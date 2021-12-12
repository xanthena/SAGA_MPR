<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMdiMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbxCollegeName = New System.Windows.Forms.ComboBox()
        Me.lblCollegeName = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblReviewId = New System.Windows.Forms.Label()
        Me.cmbxReviewId = New System.Windows.Forms.ComboBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.numCoursesOfferedRating = New System.Windows.Forms.NumericUpDown()
        Me.txtCoursesOfferedRating = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numPlacementsRating = New System.Windows.Forms.NumericUpDown()
        Me.txtPlacementsRating = New System.Windows.Forms.TextBox()
        Me.lblPlacements = New System.Windows.Forms.Label()
        Me.numCurriculumRating = New System.Windows.Forms.NumericUpDown()
        Me.txtCurriculumRating = New System.Windows.Forms.TextBox()
        Me.lblCurriculum = New System.Windows.Forms.Label()
        Me.numAcademicsRating = New System.Windows.Forms.NumericUpDown()
        Me.txtAcademicsRating = New System.Windows.Forms.TextBox()
        Me.lblAcademics = New System.Windows.Forms.Label()
        Me.numInfrastructureRating = New System.Windows.Forms.NumericUpDown()
        Me.txtInfrastructureRating = New System.Windows.Forms.TextBox()
        Me.lblInfrastructure = New System.Windows.Forms.Label()
        Me.numFeesRating = New System.Windows.Forms.NumericUpDown()
        Me.txtFeesRating = New System.Windows.Forms.TextBox()
        Me.lblFees = New System.Windows.Forms.Label()
        Me.txtCollegeName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.numCoursesOfferedRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPlacementsRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCurriculumRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAcademicsRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numInfrastructureRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFeesRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogin, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuLogin
        '
        Me.mnuLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuLogin.Name = "mnuLogin"
        Me.mnuLogin.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.mnuLogin.Size = New System.Drawing.Size(49, 20)
        Me.mnuLogin.Text = "Login"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(38, 20)
        Me.mnuExit.Text = "Exit"
        '
        'cmbxCollegeName
        '
        Me.cmbxCollegeName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxCollegeName.FormattingEnabled = True
        Me.cmbxCollegeName.Location = New System.Drawing.Point(172, 27)
        Me.cmbxCollegeName.Name = "cmbxCollegeName"
        Me.cmbxCollegeName.Size = New System.Drawing.Size(263, 26)
        Me.cmbxCollegeName.TabIndex = 1
        '
        'lblCollegeName
        '
        Me.lblCollegeName.AutoSize = True
        Me.lblCollegeName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollegeName.Location = New System.Drawing.Point(54, 30)
        Me.lblCollegeName.Name = "lblCollegeName"
        Me.lblCollegeName.Size = New System.Drawing.Size(112, 18)
        Me.lblCollegeName.TabIndex = 3
        Me.lblCollegeName.Text = "College Name : "
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(494, 27)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(84, 26)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblReviewId
        '
        Me.lblReviewId.AutoSize = True
        Me.lblReviewId.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReviewId.Location = New System.Drawing.Point(79, 62)
        Me.lblReviewId.Name = "lblReviewId"
        Me.lblReviewId.Size = New System.Drawing.Size(87, 18)
        Me.lblReviewId.TabIndex = 6
        Me.lblReviewId.Text = "Review Id : "
        '
        'cmbxReviewId
        '
        Me.cmbxReviewId.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxReviewId.FormattingEnabled = True
        Me.cmbxReviewId.Location = New System.Drawing.Point(172, 59)
        Me.cmbxReviewId.Name = "cmbxReviewId"
        Me.cmbxReviewId.Size = New System.Drawing.Size(263, 26)
        Me.cmbxReviewId.TabIndex = 5
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(494, 59)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(84, 26)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        Me.btnDisplay.Visible = False
        '
        'numCoursesOfferedRating
        '
        Me.numCoursesOfferedRating.Enabled = False
        Me.numCoursesOfferedRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCoursesOfferedRating.Location = New System.Drawing.Point(900, 558)
        Me.numCoursesOfferedRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numCoursesOfferedRating.Name = "numCoursesOfferedRating"
        Me.numCoursesOfferedRating.Size = New System.Drawing.Size(60, 26)
        Me.numCoursesOfferedRating.TabIndex = 40
        '
        'txtCoursesOfferedRating
        '
        Me.txtCoursesOfferedRating.Enabled = False
        Me.txtCoursesOfferedRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoursesOfferedRating.Location = New System.Drawing.Point(172, 558)
        Me.txtCoursesOfferedRating.Multiline = True
        Me.txtCoursesOfferedRating.Name = "txtCoursesOfferedRating"
        Me.txtCoursesOfferedRating.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCoursesOfferedRating.Size = New System.Drawing.Size(722, 78)
        Me.txtCoursesOfferedRating.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-4, 561)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Courses Offered Rating :"
        '
        'numPlacementsRating
        '
        Me.numPlacementsRating.Enabled = False
        Me.numPlacementsRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPlacementsRating.Location = New System.Drawing.Point(900, 474)
        Me.numPlacementsRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numPlacementsRating.Name = "numPlacementsRating"
        Me.numPlacementsRating.Size = New System.Drawing.Size(60, 26)
        Me.numPlacementsRating.TabIndex = 37
        '
        'txtPlacementsRating
        '
        Me.txtPlacementsRating.Enabled = False
        Me.txtPlacementsRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlacementsRating.Location = New System.Drawing.Point(172, 474)
        Me.txtPlacementsRating.Multiline = True
        Me.txtPlacementsRating.Name = "txtPlacementsRating"
        Me.txtPlacementsRating.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPlacementsRating.Size = New System.Drawing.Size(722, 78)
        Me.txtPlacementsRating.TabIndex = 36
        '
        'lblPlacements
        '
        Me.lblPlacements.AutoSize = True
        Me.lblPlacements.Enabled = False
        Me.lblPlacements.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlacements.Location = New System.Drawing.Point(29, 477)
        Me.lblPlacements.Name = "lblPlacements"
        Me.lblPlacements.Size = New System.Drawing.Size(137, 18)
        Me.lblPlacements.TabIndex = 35
        Me.lblPlacements.Text = "Placements Rating :"
        '
        'numCurriculumRating
        '
        Me.numCurriculumRating.Enabled = False
        Me.numCurriculumRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCurriculumRating.Location = New System.Drawing.Point(900, 390)
        Me.numCurriculumRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numCurriculumRating.Name = "numCurriculumRating"
        Me.numCurriculumRating.Size = New System.Drawing.Size(60, 26)
        Me.numCurriculumRating.TabIndex = 34
        '
        'txtCurriculumRating
        '
        Me.txtCurriculumRating.Enabled = False
        Me.txtCurriculumRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurriculumRating.Location = New System.Drawing.Point(172, 390)
        Me.txtCurriculumRating.Multiline = True
        Me.txtCurriculumRating.Name = "txtCurriculumRating"
        Me.txtCurriculumRating.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCurriculumRating.Size = New System.Drawing.Size(722, 78)
        Me.txtCurriculumRating.TabIndex = 33
        '
        'lblCurriculum
        '
        Me.lblCurriculum.AutoSize = True
        Me.lblCurriculum.Enabled = False
        Me.lblCurriculum.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurriculum.Location = New System.Drawing.Point(36, 393)
        Me.lblCurriculum.Name = "lblCurriculum"
        Me.lblCurriculum.Size = New System.Drawing.Size(130, 18)
        Me.lblCurriculum.TabIndex = 32
        Me.lblCurriculum.Text = "Curriculum Rating :"
        '
        'numAcademicsRating
        '
        Me.numAcademicsRating.Enabled = False
        Me.numAcademicsRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAcademicsRating.Location = New System.Drawing.Point(900, 303)
        Me.numAcademicsRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numAcademicsRating.Name = "numAcademicsRating"
        Me.numAcademicsRating.Size = New System.Drawing.Size(60, 26)
        Me.numAcademicsRating.TabIndex = 31
        '
        'txtAcademicsRating
        '
        Me.txtAcademicsRating.Enabled = False
        Me.txtAcademicsRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcademicsRating.Location = New System.Drawing.Point(172, 303)
        Me.txtAcademicsRating.Multiline = True
        Me.txtAcademicsRating.Name = "txtAcademicsRating"
        Me.txtAcademicsRating.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAcademicsRating.Size = New System.Drawing.Size(722, 78)
        Me.txtAcademicsRating.TabIndex = 30
        '
        'lblAcademics
        '
        Me.lblAcademics.AutoSize = True
        Me.lblAcademics.Enabled = False
        Me.lblAcademics.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcademics.Location = New System.Drawing.Point(34, 305)
        Me.lblAcademics.Name = "lblAcademics"
        Me.lblAcademics.Size = New System.Drawing.Size(132, 18)
        Me.lblAcademics.TabIndex = 29
        Me.lblAcademics.Text = "Academics Rating :"
        '
        'numInfrastructureRating
        '
        Me.numInfrastructureRating.Enabled = False
        Me.numInfrastructureRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numInfrastructureRating.Location = New System.Drawing.Point(900, 219)
        Me.numInfrastructureRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numInfrastructureRating.Name = "numInfrastructureRating"
        Me.numInfrastructureRating.Size = New System.Drawing.Size(60, 26)
        Me.numInfrastructureRating.TabIndex = 28
        '
        'txtInfrastructureRating
        '
        Me.txtInfrastructureRating.Enabled = False
        Me.txtInfrastructureRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfrastructureRating.Location = New System.Drawing.Point(172, 219)
        Me.txtInfrastructureRating.Multiline = True
        Me.txtInfrastructureRating.Name = "txtInfrastructureRating"
        Me.txtInfrastructureRating.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfrastructureRating.Size = New System.Drawing.Size(722, 78)
        Me.txtInfrastructureRating.TabIndex = 27
        '
        'lblInfrastructure
        '
        Me.lblInfrastructure.AutoSize = True
        Me.lblInfrastructure.Enabled = False
        Me.lblInfrastructure.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfrastructure.Location = New System.Drawing.Point(13, 227)
        Me.lblInfrastructure.Name = "lblInfrastructure"
        Me.lblInfrastructure.Size = New System.Drawing.Size(153, 18)
        Me.lblInfrastructure.TabIndex = 26
        Me.lblInfrastructure.Text = "Infrastructure Rating :"
        '
        'numFeesRating
        '
        Me.numFeesRating.Enabled = False
        Me.numFeesRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numFeesRating.Location = New System.Drawing.Point(900, 135)
        Me.numFeesRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numFeesRating.Name = "numFeesRating"
        Me.numFeesRating.Size = New System.Drawing.Size(60, 26)
        Me.numFeesRating.TabIndex = 25
        '
        'txtFeesRating
        '
        Me.txtFeesRating.Enabled = False
        Me.txtFeesRating.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeesRating.Location = New System.Drawing.Point(172, 135)
        Me.txtFeesRating.Multiline = True
        Me.txtFeesRating.Name = "txtFeesRating"
        Me.txtFeesRating.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFeesRating.Size = New System.Drawing.Size(722, 78)
        Me.txtFeesRating.TabIndex = 24
        '
        'lblFees
        '
        Me.lblFees.AutoSize = True
        Me.lblFees.Enabled = False
        Me.lblFees.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFees.Location = New System.Drawing.Point(72, 143)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(94, 18)
        Me.lblFees.TabIndex = 23
        Me.lblFees.Text = "Fees Rating :"
        '
        'txtCollegeName
        '
        Me.txtCollegeName.Enabled = False
        Me.txtCollegeName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollegeName.Location = New System.Drawing.Point(172, 104)
        Me.txtCollegeName.Name = "txtCollegeName"
        Me.txtCollegeName.Size = New System.Drawing.Size(406, 26)
        Me.txtCollegeName.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "College Name : "
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(584, 27)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 26)
        Me.btnClear.TabIndex = 41
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 711)
        Me.Controls.Add(Me.btnClear)
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblReviewId)
        Me.Controls.Add(Me.cmbxReviewId)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblCollegeName)
        Me.Controls.Add(Me.cmbxCollegeName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMdiMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Institute Feedback Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.numCoursesOfferedRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPlacementsRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCurriculumRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAcademicsRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numInfrastructureRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFeesRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuLogin As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents cmbxCollegeName As ComboBox
    Friend WithEvents lblCollegeName As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblReviewId As Label
    Friend WithEvents cmbxReviewId As ComboBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents numCoursesOfferedRating As NumericUpDown
    Friend WithEvents txtCoursesOfferedRating As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents numPlacementsRating As NumericUpDown
    Friend WithEvents txtPlacementsRating As TextBox
    Friend WithEvents lblPlacements As Label
    Friend WithEvents numCurriculumRating As NumericUpDown
    Friend WithEvents txtCurriculumRating As TextBox
    Friend WithEvents lblCurriculum As Label
    Friend WithEvents numAcademicsRating As NumericUpDown
    Friend WithEvents txtAcademicsRating As TextBox
    Friend WithEvents lblAcademics As Label
    Friend WithEvents numInfrastructureRating As NumericUpDown
    Friend WithEvents txtInfrastructureRating As TextBox
    Friend WithEvents lblInfrastructure As Label
    Friend WithEvents numFeesRating As NumericUpDown
    Friend WithEvents txtFeesRating As TextBox
    Friend WithEvents lblFees As Label
    Friend WithEvents txtCollegeName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Button
End Class
