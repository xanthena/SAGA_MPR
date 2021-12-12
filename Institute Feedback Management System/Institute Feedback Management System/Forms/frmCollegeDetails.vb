Public Class frmCollegeDetails
    Dim cnData As New SQLControl

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmMdiMain.Show()
    End Sub

    Private Sub frmCollegeDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEdit.Enabled = True
        btnCancel.Enabled = True
        Me.WindowState = FormWindowState.Maximized
        LoadData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEdit.Enabled = False
        btnCancel.Enabled = False
        btnSave.Enabled = True
        gboxCollegeDetails.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intErrCode As Integer
        Dim strErrMsg As String = ""
        Dim strSaveType As String = "U"

        cnData.DBDT.Clear()
        cnData.AddParam("@in_SaveType", strSaveType)
        cnData.AddParam("@in_CollegeId", GlobalVariables.UserCollegeId)
        cnData.AddParam("@in_CollegeName", txtClgName.Text)
        cnData.AddParam("@in_CollegeAddress", txtClgAddress.Text)
        cnData.AddParam("@in_CollegeContactNumber", txtClgContactNo.Text)
        cnData.AddParam("@in_CollegeUniversity", txtClgUniversity.Text)
        cnData.AddParam("@in_CollegeCourses", txtClgCourses.Text)
        cnData.ExecProcedure("IFMSCollegeAddUpdate")
        If cnData.HasException = True Then
            MessageBox.Show("Entry did Not Save ...")
            Exit Sub
        End If
        intErrCode = cnData.intCtrlErrCode
        strErrMsg = cnData.strCtrlErrMsg
        If intErrCode < 0 Then
            MessageBox.Show("SQL Exception: " & vbCrLf & strErrMsg)
            Exit Sub
        Else
            btnEdit.Enabled = True
            btnCancel.Enabled = True
            btnSave.Enabled = False
            gboxCollegeDetails.Enabled = False
            LoadData()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If btnSave.Enabled = True Then
            MessageBox.Show("Please save the current entry to go to the previous page", "Earning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Me.Hide()
        frmMdiMain.Show()
    End Sub

    Private Sub LoadData()
        cnData.AddParam("@CollegeId", GlobalVariables.UserCollegeId)
        cnData.ExecQuery("Select * from MstCollege where CollegeId = @CollegeId")
        If cnData.HasException = True Then Exit Sub

        If cnData.RecordCount = 0 Then
            MessageBox.Show("User not linked to any college, please check data ...")
        Else
            txtClgName.Text = cnData.DBDT.Rows(0)("CollegeName").ToString
            txtClgAddress.Text = cnData.DBDT.Rows(0)("ClgAddress").ToString
            txtClgContactNo.Text = cnData.DBDT.Rows(0)("ClgContactNumber").ToString
            txtClgCourses.Text = cnData.DBDT.Rows(0)("ClgCourses").ToString
            txtClgUniversity.Text = cnData.DBDT.Rows(0)("ClgUniversity").ToString
        End If
        cnData.DBDT.Clear()
    End Sub
End Class