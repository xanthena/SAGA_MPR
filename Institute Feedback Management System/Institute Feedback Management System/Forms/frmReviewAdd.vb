Public Class frmReviewAdd
    Dim cnData As New SQLControl

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmMdiMain.Show()
    End Sub

    Private Sub frmReviewAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cnData.AddParam("@CollegeId", GlobalVariables.UserCollegeId)
        cnData.ExecQuery("Select CollegeName from MstCollege where CollegeId = @CollegeId")
        If cnData.HasException = True Then Exit Sub

        If cnData.RecordCount = 0 Then
            MessageBox.Show("Student does not belong to any College, check data ...")
        Else
            txtCollegeName.Text = cnData.DBDT.Rows(0)("CollegeName").ToString
        End If
        cnData.DBDT.Clear()
    End Sub

    Private Sub btnAddReview_Click(sender As Object, e As EventArgs) Handles btnAddReview.Click
        cnData.AddParam("@CollegeId", GlobalVariables.UserCollegeId)
        cnData.AddParam("@StudentId", GlobalVariables.UserId)
        cnData.AddParam("@FeesRating", numFeesRating.Value)
        cnData.AddParam("@FeesDescription", txtFeesRating.Text)
        cnData.AddParam("@InfrastructureRating", numInfrastructureRating.Value)
        cnData.AddParam("@InfrastructureDescription", txtInfrastructureRating.Text)
        cnData.AddParam("@AcademicsRating", numAcademicsRating.Value)
        cnData.AddParam("@AcademicsDescription", txtAcademicsRating.Text)
        cnData.AddParam("@CurriculumRating", numCurriculumRating.Value)
        cnData.AddParam("@CurriculumDescription", txtCurriculumRating.Text)
        cnData.AddParam("@PlacementsRating", numPlacementsRating.Value)
        cnData.AddParam("@PlacementsDescription", txtPlacementsRating.Text)
        cnData.AddParam("@CoursesOfferedRating", numCoursesOfferedRating.Value)
        cnData.AddParam("@CoursesOfferedDescription", txtCoursesOfferedRating.Text)

        cnData.ExecQuery("INSERT INTO TrnReviews(CollegeId,StudentId,FeesRating,FeesDescription,InfrastructureRating,InfrastructureDescription,
            AcademicsRating,AcademicsDescription,CurriculumRating,CurriculumDescription,PlacementsRating,PlacementsDescription,CoursesOfferedRating,
            CoursesOfferedDescription,AddDtTm)
        VALUES(@CollegeId,@StudentId,@FeesRating,@FeesDescription,@InfrastructureRating,@InfrastructureDescription,
            @AcademicsRating,@AcademicsDescription,@CurriculumRating,@CurriculumDescription,@PlacementsRating,@PlacementsDescription,@CoursesOfferedRating,
            @CoursesOfferedDescription,GETDATE())")

        If cnData.HasException = True Then
            Exit Sub
        Else
            MessageBox.Show("Review Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearData()
        End If

    End Sub

    Private Sub ClearData()
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
End Class