Public Class frmLogin
    Dim MyConn As New SQLControl

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmMdiMain.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MyConn.AddParam("@Login", txtLogin.Text)
        MyConn.AddParam("@Pswd", txtPassword.Text)
        MyConn.ExecQuery("Select * from SysUser Where UserName = @Login And UserPassword = @Pswd;")
        If MyConn.HasException = True Then Exit Sub

        If MyConn.RecordCount = 0 Then
            MessageBox.Show("Login Name / Password does not match, try again ...")
        Else
            GlobalVariables.UserCollegeId = MyConn.DBDT.Rows(0)("UserCollegeId").ToString
            GlobalVariables.UserId = MyConn.DBDT.Rows(0)("SysUserId").ToString
            GlobalVariables.UsrName = MyConn.DBDT.Rows(0)("UserName").ToString
            GlobalVariables.UserLevel = MyConn.DBDT.Rows(0)("UserLevel").ToString
            MyConn.DBDT.Clear()
            Me.Hide()

            If GlobalVariables.UserLevel = "Student" Then
                frmReviewAdd.Show()
            ElseIf GlobalVariables.UserLevel = "Admin" Then
                frmCollegeDetails.Show()
            End If
        End If
    End Sub
End Class