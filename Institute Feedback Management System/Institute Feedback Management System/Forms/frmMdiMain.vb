Public Class frmMdiMain
    Dim cndata As New SQLControl

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
        frmLogin.Close()
    End Sub

    Private Sub mnuLogin_Click(sender As Object, e As EventArgs) Handles mnuLogin.Click
        Me.Hide()
        Dim objLogin As New frmLogin
        objLogin.Show()
    End Sub

    Private Sub frmMdiMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cndata.ExecQuery("Select CollegeId,CollegeName from MstCollege")
        If cndata.HasException = True Then Exit Sub

        If cndata.RecordCount = 0 Then
            MessageBox.Show("No colleges to display ...")
        Else
            cmbxCollegeName.ValueMember = "CollegeId"
            cmbxCollegeName.DisplayMember = "CollegeName"
            cmbxCollegeName.DataSource = cndata.DBDT
            cmbxCollegeName.SelectedIndex = -1
        End If
        'cndata.DBDT.Clear()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cmbxCollegeName.SelectedValue <> Nothing Then
            cmbxReviewId.DataSource = Nothing
            cmbxReviewId.Items.Clear()
            ClearDetails()
            cndata.AddParam("@CollegeId", cmbxCollegeName.SelectedValue)
            cndata.ExecQuery("Select ReviewId from TrnReviews where CollegeId = @CollegeId")
            If cndata.HasException = True Then Exit Sub

            If cndata.RecordCount = 0 Then
                MessageBox.Show("No reviews to display for the Selected College ...")
            Else
                cmbxReviewId.ValueMember = "ReviewId"
                cmbxReviewId.DisplayMember = "ReviewId"
                cmbxReviewId.DataSource = cndata.DBDT
                cmbxReviewId.SelectedIndex = -1
                btnDisplay.Visible = True
            End If
        End If
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If cmbxReviewId.SelectedValue <> Nothing Then
            ClearDetails()
            cndata.AddParam("@ReviewId", cmbxReviewId.SelectedValue)
            cndata.ExecQuery("Select * from TrnReviews where ReviewId = @ReviewId")
            If cndata.HasException = True Then Exit Sub

            If cndata.RecordCount = 0 Then
                MessageBox.Show("This particular review does not exist, please try again ...")
            Else
                txtAcademicsRating.Text = cndata.DBDT.Rows(0)("AcademicsDescription").ToString
                txtCollegeName.Text = cmbxCollegeName.Text
                txtCoursesOfferedRating.Text = cndata.DBDT.Rows(0)("CoursesOfferedDescription").ToString
                txtCurriculumRating.Text = cndata.DBDT.Rows(0)("CurriculumDescription").ToString
                txtFeesRating.Text = cndata.DBDT.Rows(0)("FeesDescription").ToString
                txtInfrastructureRating.Text = cndata.DBDT.Rows(0)("InfrastructureDescription").ToString
                txtPlacementsRating.Text = cndata.DBDT.Rows(0)("PlacementsDescription").ToString
                numAcademicsRating.Value = cndata.DBDT.Rows(0)("AcademicsRating").ToString
                numCoursesOfferedRating.Value = cndata.DBDT.Rows(0)("CoursesOfferedRating").ToString
                numCurriculumRating.Value = cndata.DBDT.Rows(0)("CurriculumRating").ToString
                numFeesRating.Value = cndata.DBDT.Rows(0)("FeesRating").ToString
                numInfrastructureRating.Value = cndata.DBDT.Rows(0)("InfrastructureRating").ToString
                numPlacementsRating.Value = cndata.DBDT.Rows(0)("PlacementsRating").ToString
            End If
        End If
    End Sub

    Private Sub ClearDetails()
        txtAcademicsRating.Text = ""
        txtCollegeName.Text = ""
        txtCoursesOfferedRating.Text = ""
        txtCurriculumRating.Text = ""
        txtFeesRating.Text = ""
        txtInfrastructureRating.Text = ""
        txtPlacementsRating.Text = ""
        numAcademicsRating.Value = 0
        numCoursesOfferedRating.Value = 0
        numCurriculumRating.Value = 0
        numFeesRating.Value = 0
        numInfrastructureRating.Value = 0
        numPlacementsRating.Value = 0
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearDetails()
        cmbxReviewId.DataSource = Nothing
        cmbxReviewId.Items.Clear()
        cmbxCollegeName.Refresh()
        cmbxCollegeName.SelectedIndex = -1
    End Sub
End Class
