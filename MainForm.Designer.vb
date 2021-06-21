<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtICNum = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtCGPA = New System.Windows.Forms.TextBox()
        Me.CBEducation = New System.Windows.Forms.ComboBox()
        Me.CBCategory = New System.Windows.Forms.ComboBox()
        Me.CBNation = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationProceduresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EligibilityRequirementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtDOB)
        Me.GroupBox1.Controls.Add(Me.cbGender)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtICNum)
        Me.GroupBox1.Controls.Add(Me.txtFullName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(157, 130)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(640, 373)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Applicant's Info"
        '
        'txtDOB
        '
        Me.txtDOB.BackColor = System.Drawing.SystemColors.Window
        Me.txtDOB.Location = New System.Drawing.Point(307, 178)
        Me.txtDOB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDOB.Multiline = True
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(189, 34)
        Me.txtDOB.TabIndex = 17
        '
        'cbGender
        '
        Me.cbGender.BackColor = System.Drawing.SystemColors.Window
        Me.cbGender.DropDownWidth = 303
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.IntegralHeight = False
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(307, 127)
        Me.cbGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(189, 33)
        Me.cbGender.TabIndex = 16
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Location = New System.Drawing.Point(307, 281)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(303, 34)
        Me.txtEmail.TabIndex = 15
        '
        'txtICNum
        '
        Me.txtICNum.BackColor = System.Drawing.SystemColors.Window
        Me.txtICNum.Location = New System.Drawing.Point(307, 228)
        Me.txtICNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtICNum.Multiline = True
        Me.txtICNum.Name = "txtICNum"
        Me.txtICNum.Size = New System.Drawing.Size(303, 34)
        Me.txtICNum.TabIndex = 14
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.SystemColors.Window
        Me.txtFullName.Location = New System.Drawing.Point(307, 78)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFullName.Multiline = True
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(303, 34)
        Me.txtFullName.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(213, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(164, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "IC Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(274, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date of birth (dd/mm/yyyy):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(196, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Gender:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Full Name:"
        '
        'btnResult
        '
        Me.btnResult.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResult.Location = New System.Drawing.Point(307, 894)
        Me.btnResult.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(125, 50)
        Me.btnResult.TabIndex = 3
        Me.btnResult.Text = "Result"
        Me.btnResult.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAge)
        Me.GroupBox2.Controls.Add(Me.txtCGPA)
        Me.GroupBox2.Controls.Add(Me.CBEducation)
        Me.GroupBox2.Controls.Add(Me.CBCategory)
        Me.GroupBox2.Controls.Add(Me.CBNation)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(157, 521)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(640, 351)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Eligibility check"
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.SystemColors.Window
        Me.txtAge.Location = New System.Drawing.Point(307, 41)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 30)
        Me.txtAge.TabIndex = 10
        '
        'txtCGPA
        '
        Me.txtCGPA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCGPA.Location = New System.Drawing.Point(307, 265)
        Me.txtCGPA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCGPA.Name = "txtCGPA"
        Me.txtCGPA.Size = New System.Drawing.Size(100, 30)
        Me.txtCGPA.TabIndex = 9
        '
        'CBEducation
        '
        Me.CBEducation.BackColor = System.Drawing.SystemColors.Window
        Me.CBEducation.FormattingEnabled = True
        Me.CBEducation.Items.AddRange(New Object() {"Diploma in Local Institution", "Degree in Local Institution", "Others"})
        Me.CBEducation.Location = New System.Drawing.Point(307, 209)
        Me.CBEducation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBEducation.Name = "CBEducation"
        Me.CBEducation.Size = New System.Drawing.Size(303, 33)
        Me.CBEducation.TabIndex = 8
        '
        'CBCategory
        '
        Me.CBCategory.BackColor = System.Drawing.SystemColors.Window
        Me.CBCategory.FormattingEnabled = True
        Me.CBCategory.Items.AddRange(New Object() {"B40", "M40", "T20"})
        Me.CBCategory.Location = New System.Drawing.Point(307, 148)
        Me.CBCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBCategory.Name = "CBCategory"
        Me.CBCategory.Size = New System.Drawing.Size(100, 33)
        Me.CBCategory.TabIndex = 7
        '
        'CBNation
        '
        Me.CBNation.BackColor = System.Drawing.SystemColors.Window
        Me.CBNation.FormattingEnabled = True
        Me.CBNation.Items.AddRange(New Object() {"Malaysian", "Non-Malaysian"})
        Me.CBNation.Location = New System.Drawing.Point(307, 91)
        Me.CBNation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBNation.Name = "CBNation"
        Me.CBNation.Size = New System.Drawing.Size(223, 33)
        Me.CBNation.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(172, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 25)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Education:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(60, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(219, 25)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Income classification:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(207, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 25)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "CGPA:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(167, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nationality:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(228, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Age:"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.GrayText
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(959, 40)
        Me.MenuStrip2.TabIndex = 7
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationProceduresToolStripMenuItem, Me.EligibilityRequirementsToolStripMenuItem, Me.IncomeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(95, 36)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ApplicationProceduresToolStripMenuItem
        '
        Me.ApplicationProceduresToolStripMenuItem.Name = "ApplicationProceduresToolStripMenuItem"
        Me.ApplicationProceduresToolStripMenuItem.Size = New System.Drawing.Size(376, 36)
        Me.ApplicationProceduresToolStripMenuItem.Text = "Application Procedures"
        '
        'EligibilityRequirementsToolStripMenuItem
        '
        Me.EligibilityRequirementsToolStripMenuItem.Name = "EligibilityRequirementsToolStripMenuItem"
        Me.EligibilityRequirementsToolStripMenuItem.Size = New System.Drawing.Size(376, 36)
        Me.EligibilityRequirementsToolStripMenuItem.Text = "Eligibility Requirements"
        '
        'IncomeToolStripMenuItem
        '
        Me.IncomeToolStripMenuItem.Name = "IncomeToolStripMenuItem"
        Me.IncomeToolStripMenuItem.Size = New System.Drawing.Size(376, 36)
        Me.IncomeToolStripMenuItem.Text = "Income Classification "
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(376, 36)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(499, 894)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 50)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(379, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(245, 32)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Application Form"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(159, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(703, 32)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Politeknik Tuanku Syed Sirajuddin ""Bantuan Khas"""
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.project.My.Resources.Resources._32
        Me.ClientSize = New System.Drawing.Size(959, 1003)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MainForm"
        Me.Text = "Bantuan Khas PTSS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnResult As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtICNum As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCGPA As TextBox
    Friend WithEvents CBEducation As ComboBox
    Friend WithEvents CBCategory As ComboBox
    Friend WithEvents CBNation As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplicationProceduresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EligibilityRequirementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClear As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
