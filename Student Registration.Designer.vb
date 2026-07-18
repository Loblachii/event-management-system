<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Registration))
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        btnOrganizer = New Button()
        btnFeedback = New Button()
        btnStudent = New Button()
        btnEvent = New Button()
        Panel3 = New Panel()
        Label2 = New Label()
        btnDashboard = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        btnExit = New Button()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        btnRecord = New Button()
        btnSave = New Button()
        btnCancel = New Button()
        txtLastName = New TextBox()
        Label11 = New Label()
        txtFirstName = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        txtContactNumber = New TextBox()
        Label9 = New Label()
        txtProgram = New TextBox()
        Label10 = New Label()
        txtEmail = New TextBox()
        Label12 = New Label()
        txtStudentID = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(3), CByte(92), CByte(19))
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnOrganizer)
        Panel1.Controls.Add(btnFeedback)
        Panel1.Controls.Add(btnStudent)
        Panel1.Controls.Add(btnEvent)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(327, 750)
        Panel1.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        Label4.Location = New Point(26, 222)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 27)
        Label4.TabIndex = 11
        Label4.Text = "SYSTEM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        Label3.Location = New Point(26, 195)
        Label3.Name = "Label3"
        Label3.Size = New Size(252, 27)
        Label3.TabIndex = 10
        Label3.Text = "EVENT MANAGEMENT"
        ' 
        ' btnOrganizer
        ' 
        btnOrganizer.BackColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        btnOrganizer.Cursor = Cursors.Hand
        btnOrganizer.FlatStyle = FlatStyle.Popup
        btnOrganizer.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOrganizer.ForeColor = Color.FromArgb(CByte(3), CByte(92), CByte(19))
        btnOrganizer.Location = New Point(26, 529)
        btnOrganizer.Margin = New Padding(3, 2, 3, 2)
        btnOrganizer.Name = "btnOrganizer"
        btnOrganizer.Padding = New Padding(12, 0, 0, 0)
        btnOrganizer.Size = New Size(271, 30)
        btnOrganizer.TabIndex = 9
        btnOrganizer.Text = "Organizer Tracking"
        btnOrganizer.TextAlign = ContentAlignment.MiddleLeft
        btnOrganizer.UseVisualStyleBackColor = False
        ' 
        ' btnFeedback
        ' 
        btnFeedback.BackColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        btnFeedback.Cursor = Cursors.Hand
        btnFeedback.FlatStyle = FlatStyle.Popup
        btnFeedback.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFeedback.ForeColor = Color.FromArgb(CByte(3), CByte(92), CByte(19))
        btnFeedback.Location = New Point(26, 486)
        btnFeedback.Margin = New Padding(3, 2, 3, 2)
        btnFeedback.Name = "btnFeedback"
        btnFeedback.Padding = New Padding(12, 0, 0, 0)
        btnFeedback.Size = New Size(271, 30)
        btnFeedback.TabIndex = 9
        btnFeedback.Text = "Feedback Creation"
        btnFeedback.TextAlign = ContentAlignment.MiddleLeft
        btnFeedback.UseVisualStyleBackColor = False
        ' 
        ' btnStudent
        ' 
        btnStudent.BackColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        btnStudent.Cursor = Cursors.Hand
        btnStudent.FlatStyle = FlatStyle.Popup
        btnStudent.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStudent.ForeColor = Color.FromArgb(CByte(3), CByte(92), CByte(19))
        btnStudent.Location = New Point(26, 443)
        btnStudent.Margin = New Padding(3, 2, 3, 2)
        btnStudent.Name = "btnStudent"
        btnStudent.Padding = New Padding(12, 0, 0, 0)
        btnStudent.Size = New Size(271, 30)
        btnStudent.TabIndex = 8
        btnStudent.Text = "Student Registration"
        btnStudent.TextAlign = ContentAlignment.MiddleLeft
        btnStudent.UseVisualStyleBackColor = False
        ' 
        ' btnEvent
        ' 
        btnEvent.BackColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        btnEvent.Cursor = Cursors.Hand
        btnEvent.FlatStyle = FlatStyle.Popup
        btnEvent.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEvent.ForeColor = Color.FromArgb(CByte(3), CByte(92), CByte(19))
        btnEvent.Location = New Point(26, 400)
        btnEvent.Margin = New Padding(3, 2, 3, 2)
        btnEvent.Name = "btnEvent"
        btnEvent.Padding = New Padding(12, 0, 0, 0)
        btnEvent.Size = New Size(271, 30)
        btnEvent.TabIndex = 7
        btnEvent.Text = "Event Creation"
        btnEvent.TextAlign = ContentAlignment.MiddleLeft
        btnEvent.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        Panel3.Location = New Point(26, 292)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(271, 2)
        Panel3.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        Label2.Location = New Point(26, 318)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 18)
        Label2.TabIndex = 5
        Label2.Text = "GENERAL"
        ' 
        ' btnDashboard
        ' 
        btnDashboard.AllowDrop = True
        btnDashboard.BackColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        btnDashboard.Cursor = Cursors.Hand
        btnDashboard.FlatStyle = FlatStyle.Popup
        btnDashboard.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.FromArgb(CByte(3), CByte(92), CByte(19))
        btnDashboard.Location = New Point(26, 358)
        btnDashboard.Margin = New Padding(3, 2, 3, 2)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(12, 0, 0, 0)
        btnDashboard.Size = New Size(271, 30)
        btnDashboard.TabIndex = 4
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        Panel2.Location = New Point(26, 612)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(271, 2)
        Panel2.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        Label1.Location = New Point(26, 638)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 18)
        Label1.TabIndex = 2
        Label1.Text = "GENERAL"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        btnExit.Cursor = Cursors.Hand
        btnExit.FlatStyle = FlatStyle.Popup
        btnExit.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.FromArgb(CByte(3), CByte(92), CByte(19))
        btnExit.Location = New Point(26, 677)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Padding = New Padding(12, 0, 0, 0)
        btnExit.Size = New Size(271, 30)
        btnExit.TabIndex = 1
        btnExit.Text = "Logout"
        btnExit.TextAlign = ContentAlignment.MiddleLeft
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(74, 33)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(158, 135)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label5.Location = New Point(356, 53)
        Label5.Name = "Label5"
        Label5.Size = New Size(327, 36)
        Label5.TabIndex = 13
        Label5.Text = "Student Registration"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label6.Location = New Point(360, 89)
        Label6.Name = "Label6"
        Label6.Size = New Size(135, 19)
        Label6.TabIndex = 14
        Label6.Text = "Welcome, User!"
        ' 
        ' btnRecord
        ' 
        btnRecord.BackColor = Color.FromArgb(CByte(3), CByte(92), CByte(19))
        btnRecord.Cursor = Cursors.Hand
        btnRecord.FlatStyle = FlatStyle.Popup
        btnRecord.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRecord.ForeColor = Color.FromArgb(CByte(230), CByte(252), CByte(235))
        btnRecord.Location = New Point(1200, 71)
        btnRecord.Margin = New Padding(3, 2, 3, 2)
        btnRecord.Name = "btnRecord"
        btnRecord.Size = New Size(278, 28)
        btnRecord.TabIndex = 29
        btnRecord.Text = "Student Record"
        btnRecord.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(3), CByte(92), CByte(19))
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        btnSave.Location = New Point(1200, 651)
        btnSave.Margin = New Padding(3, 2, 3, 2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(278, 28)
        btnSave.TabIndex = 32
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatStyle = FlatStyle.Popup
        btnCancel.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.FromArgb(CByte(3), CByte(92), CByte(19))
        btnCancel.Location = New Point(907, 651)
        btnCancel.Margin = New Padding(3, 2, 3, 2)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(278, 28)
        btnCancel.TabIndex = 31
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLastName.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        txtLastName.Location = New Point(550, 344)
        txtLastName.Margin = New Padding(3, 2, 3, 2)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(330, 27)
        txtLastName.TabIndex = 42
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label11.Location = New Point(550, 321)
        Label11.Name = "Label11"
        Label11.Size = New Size(74, 16)
        Label11.TabIndex = 41
        Label11.Text = "Last Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFirstName.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        txtFirstName.Location = New Point(550, 284)
        txtFirstName.Margin = New Padding(3, 2, 3, 2)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(330, 27)
        txtFirstName.TabIndex = 37
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label8.Location = New Point(550, 261)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 16)
        Label8.TabIndex = 36
        Label8.Text = "First Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label7.Location = New Point(550, 201)
        Label7.Name = "Label7"
        Label7.Size = New Size(77, 16)
        Label7.TabIndex = 34
        Label7.Text = "Student ID"
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContactNumber.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        txtContactNumber.Location = New Point(1017, 344)
        txtContactNumber.Margin = New Padding(3, 2, 3, 2)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(330, 27)
        txtContactNumber.TabIndex = 48
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label9.Location = New Point(1020, 321)
        Label9.Name = "Label9"
        Label9.Size = New Size(111, 16)
        Label9.TabIndex = 47
        Label9.Text = "Contact Number"
        ' 
        ' txtProgram
        ' 
        txtProgram.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtProgram.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        txtProgram.Location = New Point(1017, 284)
        txtProgram.Margin = New Padding(3, 2, 3, 2)
        txtProgram.Name = "txtProgram"
        txtProgram.Size = New Size(330, 27)
        txtProgram.TabIndex = 46
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label10.Location = New Point(1020, 261)
        Label10.Name = "Label10"
        Label10.Size = New Size(62, 16)
        Label10.TabIndex = 45
        Label10.Text = "Program"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        txtEmail.Location = New Point(1017, 224)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(330, 27)
        txtEmail.TabIndex = 44
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label12.Location = New Point(1020, 202)
        Label12.Name = "Label12"
        Label12.Size = New Size(39, 16)
        Label12.TabIndex = 43
        Label12.Text = "Email"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.AutoSize = True
        txtStudentID.BackColor = SystemColors.Window
        txtStudentID.BorderStyle = BorderStyle.FixedSingle
        txtStudentID.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStudentID.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        txtStudentID.Location = New Point(550, 224)
        txtStudentID.MaximumSize = New Size(330, 27)
        txtStudentID.MinimumSize = New Size(330, 27)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(330, 27)
        txtStudentID.TabIndex = 49
        ' 
        ' Student_Registration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        ClientSize = New Size(1512, 750)
        Controls.Add(txtStudentID)
        Controls.Add(txtContactNumber)
        Controls.Add(Label9)
        Controls.Add(txtProgram)
        Controls.Add(Label10)
        Controls.Add(txtEmail)
        Controls.Add(Label12)
        Controls.Add(txtLastName)
        Controls.Add(Label11)
        Controls.Add(txtFirstName)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(btnSave)
        Controls.Add(btnCancel)
        Controls.Add(btnRecord)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Student_Registration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "/"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOrganizer As Button
    Friend WithEvents btnFeedback As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnEvent As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnRecord As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProgram As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtStudentID As Label
End Class
