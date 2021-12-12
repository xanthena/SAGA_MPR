<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollegeDetails
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
        Me.gboxCollegeDetails = New System.Windows.Forms.GroupBox()
        Me.txtClgCourses = New System.Windows.Forms.TextBox()
        Me.lblClgCourses = New System.Windows.Forms.Label()
        Me.txtClgUniversity = New System.Windows.Forms.TextBox()
        Me.lblClgUniversity = New System.Windows.Forms.Label()
        Me.txtClgContactNo = New System.Windows.Forms.TextBox()
        Me.lblClgContactNo = New System.Windows.Forms.Label()
        Me.txtClgAddress = New System.Windows.Forms.TextBox()
        Me.lblClgAddress = New System.Windows.Forms.Label()
        Me.txtClgName = New System.Windows.Forms.TextBox()
        Me.lblClgName = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gboxCollegeDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboxCollegeDetails
        '
        Me.gboxCollegeDetails.Controls.Add(Me.txtClgCourses)
        Me.gboxCollegeDetails.Controls.Add(Me.lblClgCourses)
        Me.gboxCollegeDetails.Controls.Add(Me.txtClgUniversity)
        Me.gboxCollegeDetails.Controls.Add(Me.lblClgUniversity)
        Me.gboxCollegeDetails.Controls.Add(Me.txtClgContactNo)
        Me.gboxCollegeDetails.Controls.Add(Me.lblClgContactNo)
        Me.gboxCollegeDetails.Controls.Add(Me.txtClgAddress)
        Me.gboxCollegeDetails.Controls.Add(Me.lblClgAddress)
        Me.gboxCollegeDetails.Controls.Add(Me.txtClgName)
        Me.gboxCollegeDetails.Controls.Add(Me.lblClgName)
        Me.gboxCollegeDetails.Enabled = False
        Me.gboxCollegeDetails.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.gboxCollegeDetails.Location = New System.Drawing.Point(12, 38)
        Me.gboxCollegeDetails.Name = "gboxCollegeDetails"
        Me.gboxCollegeDetails.Size = New System.Drawing.Size(1199, 468)
        Me.gboxCollegeDetails.TabIndex = 2
        Me.gboxCollegeDetails.TabStop = False
        Me.gboxCollegeDetails.Text = "College Details"
        '
        'txtClgCourses
        '
        Me.txtClgCourses.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClgCourses.Location = New System.Drawing.Point(176, 184)
        Me.txtClgCourses.Name = "txtClgCourses"
        Me.txtClgCourses.Size = New System.Drawing.Size(443, 26)
        Me.txtClgCourses.TabIndex = 9
        '
        'lblClgCourses
        '
        Me.lblClgCourses.AutoSize = True
        Me.lblClgCourses.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClgCourses.Location = New System.Drawing.Point(34, 187)
        Me.lblClgCourses.Name = "lblClgCourses"
        Me.lblClgCourses.Size = New System.Drawing.Size(125, 18)
        Me.lblClgCourses.TabIndex = 8
        Me.lblClgCourses.Text = "College Courses : "
        '
        'txtClgUniversity
        '
        Me.txtClgUniversity.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClgUniversity.Location = New System.Drawing.Point(176, 152)
        Me.txtClgUniversity.Name = "txtClgUniversity"
        Me.txtClgUniversity.Size = New System.Drawing.Size(443, 26)
        Me.txtClgUniversity.TabIndex = 7
        '
        'lblClgUniversity
        '
        Me.lblClgUniversity.AutoSize = True
        Me.lblClgUniversity.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClgUniversity.Location = New System.Drawing.Point(34, 155)
        Me.lblClgUniversity.Name = "lblClgUniversity"
        Me.lblClgUniversity.Size = New System.Drawing.Size(136, 18)
        Me.lblClgUniversity.TabIndex = 6
        Me.lblClgUniversity.Text = "College University : "
        '
        'txtClgContactNo
        '
        Me.txtClgContactNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClgContactNo.Location = New System.Drawing.Point(176, 120)
        Me.txtClgContactNo.Name = "txtClgContactNo"
        Me.txtClgContactNo.Size = New System.Drawing.Size(443, 26)
        Me.txtClgContactNo.TabIndex = 5
        '
        'lblClgContactNo
        '
        Me.lblClgContactNo.AutoSize = True
        Me.lblClgContactNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClgContactNo.Location = New System.Drawing.Point(19, 123)
        Me.lblClgContactNo.Name = "lblClgContactNo"
        Me.lblClgContactNo.Size = New System.Drawing.Size(151, 18)
        Me.lblClgContactNo.TabIndex = 4
        Me.lblClgContactNo.Text = "College Contact No. : "
        '
        'txtClgAddress
        '
        Me.txtClgAddress.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClgAddress.Location = New System.Drawing.Point(176, 64)
        Me.txtClgAddress.Multiline = True
        Me.txtClgAddress.Name = "txtClgAddress"
        Me.txtClgAddress.Size = New System.Drawing.Size(443, 50)
        Me.txtClgAddress.TabIndex = 3
        '
        'lblClgAddress
        '
        Me.lblClgAddress.AutoSize = True
        Me.lblClgAddress.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClgAddress.Location = New System.Drawing.Point(45, 67)
        Me.lblClgAddress.Name = "lblClgAddress"
        Me.lblClgAddress.Size = New System.Drawing.Size(125, 18)
        Me.lblClgAddress.TabIndex = 2
        Me.lblClgAddress.Text = "College Address : "
        '
        'txtClgName
        '
        Me.txtClgName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClgName.Location = New System.Drawing.Point(176, 32)
        Me.txtClgName.Name = "txtClgName"
        Me.txtClgName.Size = New System.Drawing.Size(443, 26)
        Me.txtClgName.TabIndex = 1
        '
        'lblClgName
        '
        Me.lblClgName.AutoSize = True
        Me.lblClgName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClgName.Location = New System.Drawing.Point(58, 35)
        Me.lblClgName.Name = "lblClgName"
        Me.lblClgName.Size = New System.Drawing.Size(112, 18)
        Me.lblClgName.TabIndex = 0
        Me.lblClgName.Text = "College Name : "
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(97, 7)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(142, 28)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(269, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(142, 28)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(446, 7)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(142, 28)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel / Back"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmCollegeDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 711)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.gboxCollegeDetails)
        Me.Name = "frmCollegeDetails"
        Me.Text = "frmCollegeDetails"
        Me.gboxCollegeDetails.ResumeLayout(False)
        Me.gboxCollegeDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboxCollegeDetails As GroupBox
    Friend WithEvents txtClgName As TextBox
    Friend WithEvents lblClgName As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtClgContactNo As TextBox
    Friend WithEvents lblClgContactNo As Label
    Friend WithEvents txtClgAddress As TextBox
    Friend WithEvents lblClgAddress As Label
    Friend WithEvents txtClgUniversity As TextBox
    Friend WithEvents lblClgUniversity As Label
    Friend WithEvents txtClgCourses As TextBox
    Friend WithEvents lblClgCourses As Label
End Class
