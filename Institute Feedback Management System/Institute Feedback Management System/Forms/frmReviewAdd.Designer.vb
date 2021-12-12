<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReviewAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblCollegeName = New System.Windows.Forms.Label()
        Me.txtCollegeName = New System.Windows.Forms.TextBox()
        Me.txtFeesRating = New System.Windows.Forms.TextBox()
        Me.lblFees = New System.Windows.Forms.Label()
        Me.numFeesRating = New System.Windows.Forms.NumericUpDown()
        Me.numInfrastructureRating = New System.Windows.Forms.NumericUpDown()
        Me.txtInfrastructureRating = New System.Windows.Forms.TextBox()
        Me.lblInfrastructure = New System.Windows.Forms.Label()
        Me.numAcademicsRating = New System.Windows.Forms.NumericUpDown()
        Me.txtAcademicsRating = New System.Windows.Forms.TextBox()
        Me.lblAcademics = New System.Windows.Forms.Label()
        Me.numCurriculumRating = New System.Windows.Forms.NumericUpDown()
        Me.txtCurriculumRating = New System.Windows.Forms.TextBox()
        Me.lblCurriculum = New System.Windows.Forms.Label()
        Me.numPlacementsRating = New System.Windows.Forms.NumericUpDown()
        Me.txtPlacementsRating = New System.Windows.Forms.TextBox()
        Me.lblPlacements = New System.Windows.Forms.Label()
        Me.numCoursesOfferedRating = New System.Windows.Forms.NumericUpDown()
        Me.txtCoursesOfferedRating = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddReview = New System.Windows.Forms.Button()
        CType(Me.numFeesRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numInfrastructureRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAcademicsRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCurriculumRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPlacementsRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCoursesOfferedRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(611, 599)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(99, 30)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblCollegeName
        '
        Me.lblCollegeName.AutoSize = True
        Me.lblCollegeName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollegeName.Location = New System.Drawing.Point(58, 32)
        Me.lblCollegeName.Name = "lblCollegeName"
        Me.lblCollegeName.Size = New System.Drawing.Size(112, 18)
        Me.lblCollegeName.TabIndex = 1
        Me.lblCollegeName.Text = "College Name : "
        '
        'txtCollegeName
        '
        Me.txtCollegeName.Enabled = False
        Me.txtCollegeName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollegeName.Location = New System.Drawing.Point(176, 29)
        Me.txtCollegeName.Name = "txtCollegeName"
        Me.txtCollegeName.Size = New System.Drawing.Size(406, 26)
        Me.txtCollegeName.TabIndex = 2
        '
        'txtFeesRating
        '
        Me.txtFeesRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeesRating.Location = New System.Drawing.Point(176, 60)
        Me.txtFeesRating.Multiline = True
        Me.txtFeesRating.Name = "txtFeesRating"
        Me.txtFeesRating.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFeesRating.Size = New System.Drawing.Size(722, 78)
        Me.txtFeesRating.TabIndex = 4
        '
        'lblFees
        '
        Me.lblFees.AutoSize = True
        Me.lblFees.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFees.Location = New System.Drawing.Point(76, 68)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(94, 18)
        Me.lblFees.TabIndex = 3
        Me.lblFees.Text = "Fees Rating :"
        '
        'numFeesRating
        '
        Me.numFeesRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numFeesRating.Location = New System.Drawing.Point(904, 60)
        Me.numFeesRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numFeesRating.Name = "numFeesRating"
        Me.numFeesRating.Size = New System.Drawing.Size(60, 26)
        Me.numFeesRating.TabIndex = 5
        '
        'numInfrastructureRating
        '
        Me.numInfrastructureRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numInfrastructureRating.Location = New System.Drawing.Point(904, 144)
        Me.numInfrastructureRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numInfrastructureRating.Name = "numInfrastructureRating"
        Me.numInfrastructureRating.Size = New System.Drawing.Size(60, 26)
        Me.numInfrastructureRating.TabIndex = 8
        '
        'txtInfrastructureRating
        '
        Me.txtInfrastructureRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfrastructureRating.Location = New System.Drawing.Point(176, 144)
        Me.txtInfrastructureRating.Multiline = True
        Me.txtInfrastructureRating.Name = "txtInfrastructureRating"
        Me.txtInfrastructureRating.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfrastructureRating.Size = New System.Drawing.Size(722, 78)
        Me.txtInfrastructureRating.TabIndex = 7
        '
        'lblInfrastructure
        '
        Me.lblInfrastructure.AutoSize = True
        Me.lblInfrastructure.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfrastructure.Location = New System.Drawing.Point(17, 152)
        Me.lblInfrastructure.Name = "lblInfrastructure"
        Me.lblInfrastructure.Size = New System.Drawing.Size(153, 18)
        Me.lblInfrastructure.TabIndex = 6
        Me.lblInfrastructure.Text = "Infrastructure Rating :"
        '
        'numAcademicsRating
        '
        Me.numAcademicsRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAcademicsRating.Location = New System.Drawing.Point(904, 228)
        Me.numAcademicsRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numAcademicsRating.Name = "numAcademicsRating"
        Me.numAcademicsRating.Size = New System.Drawing.Size(60, 26)
        Me.numAcademicsRating.TabIndex = 11
        '
        'txtAcademicsRating
        '
        Me.txtAcademicsRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcademicsRating.Location = New System.Drawing.Point(176, 228)
        Me.txtAcademicsRating.Multiline = True
        Me.txtAcademicsRating.Name = "txtAcademicsRating"
        Me.txtAcademicsRating.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAcademicsRating.Size = New System.Drawing.Size(722, 78)
        Me.txtAcademicsRating.TabIndex = 10
        '
        'lblAcademics
        '
        Me.lblAcademics.AutoSize = True
        Me.lblAcademics.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcademics.Location = New System.Drawing.Point(38, 230)
        Me.lblAcademics.Name = "lblAcademics"
        Me.lblAcademics.Size = New System.Drawing.Size(132, 18)
        Me.lblAcademics.TabIndex = 9
        Me.lblAcademics.Text = "Academics Rating :"
        '
        'numCurriculumRating
        '
        Me.numCurriculumRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCurriculumRating.Location = New System.Drawing.Point(904, 315)
        Me.numCurriculumRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numCurriculumRating.Name = "numCurriculumRating"
        Me.numCurriculumRating.Size = New System.Drawing.Size(60, 26)
        Me.numCurriculumRating.TabIndex = 14
        '
        'txtCurriculumRating
        '
        Me.txtCurriculumRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurriculumRating.Location = New System.Drawing.Point(176, 315)
        Me.txtCurriculumRating.Multiline = True
        Me.txtCurriculumRating.Name = "txtCurriculumRating"
        Me.txtCurriculumRating.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCurriculumRating.Size = New System.Drawing.Size(722, 78)
        Me.txtCurriculumRating.TabIndex = 13
        '
        'lblCurriculum
        '
        Me.lblCurriculum.AutoSize = True
        Me.lblCurriculum.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurriculum.Location = New System.Drawing.Point(40, 318)
        Me.lblCurriculum.Name = "lblCurriculum"
        Me.lblCurriculum.Size = New System.Drawing.Size(130, 18)
        Me.lblCurriculum.TabIndex = 12
        Me.lblCurriculum.Text = "Curriculum Rating :"
        '
        'numPlacementsRating
        '
        Me.numPlacementsRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPlacementsRating.Location = New System.Drawing.Point(904, 399)
        Me.numPlacementsRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numPlacementsRating.Name = "numPlacementsRating"
        Me.numPlacementsRating.Size = New System.Drawing.Size(60, 26)
        Me.numPlacementsRating.TabIndex = 17
        '
        'txtPlacementsRating
        '
        Me.txtPlacementsRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlacementsRating.Location = New System.Drawing.Point(176, 399)
        Me.txtPlacementsRating.Multiline = True
        Me.txtPlacementsRating.Name = "txtPlacementsRating"
        Me.txtPlacementsRating.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPlacementsRating.Size = New System.Drawing.Size(722, 78)
        Me.txtPlacementsRating.TabIndex = 16
        '
        'lblPlacements
        '
        Me.lblPlacements.AutoSize = True
        Me.lblPlacements.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlacements.Location = New System.Drawing.Point(33, 402)
        Me.lblPlacements.Name = "lblPlacements"
        Me.lblPlacements.Size = New System.Drawing.Size(137, 18)
        Me.lblPlacements.TabIndex = 15
        Me.lblPlacements.Text = "Placements Rating :"
        '
        'numCoursesOfferedRating
        '
        Me.numCoursesOfferedRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCoursesOfferedRating.Location = New System.Drawing.Point(904, 483)
        Me.numCoursesOfferedRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numCoursesOfferedRating.Name = "numCoursesOfferedRating"
        Me.numCoursesOfferedRating.Size = New System.Drawing.Size(60, 26)
        Me.numCoursesOfferedRating.TabIndex = 20
        '
        'txtCoursesOfferedRating
        '
        Me.txtCoursesOfferedRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoursesOfferedRating.Location = New System.Drawing.Point(176, 483)
        Me.txtCoursesOfferedRating.Multiline = True
        Me.txtCoursesOfferedRating.Name = "txtCoursesOfferedRating"
        Me.txtCoursesOfferedRating.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCoursesOfferedRating.Size = New System.Drawing.Size(722, 78)
        Me.txtCoursesOfferedRating.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 486)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Courses Offered Rating :"
        '
        'btnAddReview
        '
        Me.btnAddReview.Location = New System.Drawing.Point(469, 599)
        Me.btnAddReview.Name = "btnAddReview"
        Me.btnAddReview.Size = New System.Drawing.Size(99, 30)
        Me.btnAddReview.TabIndex = 21
        Me.btnAddReview.Text = "Add Review"
        Me.btnAddReview.UseVisualStyleBackColor = True
        '
        'frmReviewAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 711)
        Me.Controls.Add(Me.btnAddReview)
        Me.Controls.Add(Me.numCoursesOfferedRating)
        Me.Controls.Add(Me.txtCoursesOfferedRating)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numPlacementsRating)
        Me.Controls.Add(Me.txtPlacementsRating)
        Me.Controls.Add(Me.lblPlacements)
        Me.Controls.Add(Me.numCurriculumRating)
        Me.Controls.Add(Me.txtCurriculumRating)
        Me.Controls.Add(Me.lblCurriculum)
        Me.Controls.Add(Me.numAcademicsRating)
        Me.Controls.Add(Me.txtAcademicsRating)
        Me.Controls.Add(Me.lblAcademics)
        Me.Controls.Add(Me.numInfrastructureRating)
        Me.Controls.Add(Me.txtInfrastructureRating)
        Me.Controls.Add(Me.lblInfrastructure)
        Me.Controls.Add(Me.numFeesRating)
        Me.Controls.Add(Me.txtFeesRating)
        Me.Controls.Add(Me.lblFees)
        Me.Controls.Add(Me.txtCollegeName)
        Me.Controls.Add(Me.lblCollegeName)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmReviewAdd"
        Me.Text = "Review Add / View Page"
        CType(Me.numFeesRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numInfrastructureRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAcademicsRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCurriculumRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPlacementsRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCoursesOfferedRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblCollegeName As Label
    Friend WithEvents txtCollegeName As TextBox
    Friend WithEvents txtFeesRating As TextBox
    Friend WithEvents lblFees As Label
    Friend WithEvents numFeesRating As NumericUpDown
    Friend WithEvents numInfrastructureRating As NumericUpDown
    Friend WithEvents txtInfrastructureRating As TextBox
    Friend WithEvents lblInfrastructure As Label
    Friend WithEvents numAcademicsRating As NumericUpDown
    Friend WithEvents txtAcademicsRating As TextBox
    Friend WithEvents lblAcademics As Label
    Friend WithEvents numCurriculumRating As NumericUpDown
    Friend WithEvents txtCurriculumRating As TextBox
    Friend WithEvents lblCurriculum As Label
    Friend WithEvents numPlacementsRating As NumericUpDown
    Friend WithEvents txtPlacementsRating As TextBox
    Friend WithEvents lblPlacements As Label
    Friend WithEvents numCoursesOfferedRating As NumericUpDown
    Friend WithEvents txtCoursesOfferedRating As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddReview As Button
End Class
