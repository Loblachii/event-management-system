<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feedback_Creation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Feedback_Creation))
        cmbStudent = New ComboBox()
        cmbEvent = New ComboBox()
        cmbRating = New ComboBox()
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
        Button1 = New Button()
        Button2 = New Button()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label12 = New Label()
        txtFeedback = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        txtFeedbackID = New Label()
        txtEventID = New Label()
        txtStudentID = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbStudent
        ' 
        cmbStudent.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbStudent.FormattingEnabled = True
        cmbStudent.Location = New Point(598, 344)
        cmbStudent.MaximumSize = New Size(330, 0)
        cmbStudent.MinimumSize = New Size(278, 0)
        cmbStudent.Name = "cmbStudent"
        cmbStudent.Size = New Size(282, 27)
        cmbStudent.TabIndex = 47
        ' 
        ' cmbEvent
        ' 
        cmbEvent.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbEvent.FormattingEnabled = True
        cmbEvent.Location = New Point(598, 284)
        cmbEvent.MaximumSize = New Size(282, 0)
        cmbEvent.MinimumSize = New Size(282, 0)
        cmbEvent.Name = "cmbEvent"
        cmbEvent.Size = New Size(282, 27)
        cmbEvent.TabIndex = 48
        ' 
        ' cmbRating
        ' 
        cmbRating.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbRating.FormattingEnabled = True
        cmbRating.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cmbRating.Location = New Point(1017, 284)
        cmbRating.MaximumSize = New Size(330, 0)
        cmbRating.MinimumSize = New Size(330, 0)
        cmbRating.Name = "cmbRating"
        cmbRating.Size = New Size(330, 27)
        cmbRating.TabIndex = 49
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
        Label5.Size = New Size(295, 36)
        Label5.TabIndex = 13
        Label5.Text = "Feedback Creation"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label6.Location = New Point(369, 89)
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
        btnRecord.ForeColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        btnRecord.Location = New Point(1200, 71)
        btnRecord.Margin = New Padding(3, 2, 3, 2)
        btnRecord.Name = "btnRecord"
        btnRecord.Size = New Size(278, 28)
        btnRecord.TabIndex = 29
        btnRecord.Text = "Feedback Record"
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
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(3), CByte(92), CByte(19))
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        Button1.Location = New Point(1200, 651)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(278, 28)
        Button1.TabIndex = 34
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(3), CByte(92), CByte(19))
        Button2.Location = New Point(907, 651)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(278, 28)
        Button2.TabIndex = 33
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label11.Location = New Point(1020, 261)
        Label11.Name = "Label11"
        Label11.Size = New Size(49, 16)
        Label11.TabIndex = 43
        Label11.Text = "Rating"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label10.Location = New Point(1020, 202)
        Label10.Name = "Label10"
        Label10.Size = New Size(67, 16)
        Label10.TabIndex = 41
        Label10.Text = "Feedback"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label9.Location = New Point(598, 321)
        Label9.Name = "Label9"
        Label9.Size = New Size(59, 16)
        Label9.TabIndex = 40
        Label9.Text = "Student"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label8.Location = New Point(598, 261)
        Label8.Name = "Label8"
        Label8.Size = New Size(44, 16)
        Label8.TabIndex = 38
        Label8.Text = "Event"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label7.Location = New Point(550, 201)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 16)
        Label7.TabIndex = 36
        Label7.Text = "Feedback ID"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(1017, 344)
        DateTimePicker1.MaximumSize = New Size(330, 27)
        DateTimePicker1.MinimumSize = New Size(330, 27)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(330, 27)
        DateTimePicker1.TabIndex = 45
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label12.Location = New Point(1020, 321)
        Label12.Name = "Label12"
        Label12.Size = New Size(38, 16)
        Label12.TabIndex = 46
        Label12.Text = "Date"
        ' 
        ' txtFeedback
        ' 
        txtFeedback.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFeedback.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        txtFeedback.Location = New Point(1017, 224)
        txtFeedback.Margin = New Padding(3, 2, 3, 2)
        txtFeedback.MaximumSize = New Size(330, 27)
        txtFeedback.MinimumSize = New Size(330, 27)
        txtFeedback.Name = "txtFeedback"
        txtFeedback.Size = New Size(330, 27)
        txtFeedback.TabIndex = 50
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label13.Location = New Point(550, 261)
        Label13.Name = "Label13"
        Label13.Size = New Size(21, 16)
        Label13.TabIndex = 51
        Label13.Text = "ID"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label14.Location = New Point(550, 321)
        Label14.Name = "Label14"
        Label14.Size = New Size(21, 16)
        Label14.TabIndex = 54
        Label14.Text = "ID"
        ' 
        ' txtFeedbackID
        ' 
        txtFeedbackID.AutoSize = True
        txtFeedbackID.BackColor = SystemColors.Window
        txtFeedbackID.BorderStyle = BorderStyle.FixedSingle
        txtFeedbackID.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFeedbackID.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        txtFeedbackID.Location = New Point(550, 224)
        txtFeedbackID.MaximumSize = New Size(330, 27)
        txtFeedbackID.MinimumSize = New Size(330, 27)
        txtFeedbackID.Name = "txtFeedbackID"
        txtFeedbackID.Size = New Size(330, 27)
        txtFeedbackID.TabIndex = 55
        ' 
        ' txtEventID
        ' 
        txtEventID.AutoSize = True
        txtEventID.BackColor = SystemColors.Window
        txtEventID.BorderStyle = BorderStyle.FixedSingle
        txtEventID.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEventID.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        txtEventID.Location = New Point(550, 284)
        txtEventID.MaximumSize = New Size(44, 27)
        txtEventID.MinimumSize = New Size(44, 27)
        txtEventID.Name = "txtEventID"
        txtEventID.Size = New Size(44, 27)
        txtEventID.TabIndex = 56
        ' 
        ' txtStudentID
        ' 
        txtStudentID.AutoSize = True
        txtStudentID.BackColor = SystemColors.Window
        txtStudentID.BorderStyle = BorderStyle.FixedSingle
        txtStudentID.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStudentID.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        txtStudentID.Location = New Point(550, 344)
        txtStudentID.MaximumSize = New Size(44, 27)
        txtStudentID.MinimumSize = New Size(44, 27)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(44, 27)
        txtStudentID.TabIndex = 57
        ' 
        ' Feedback_Creation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        ClientSize = New Size(1512, 750)
        Controls.Add(txtStudentID)
        Controls.Add(txtEventID)
        Controls.Add(txtFeedbackID)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(txtFeedback)
        Controls.Add(cmbRating)
        Controls.Add(cmbEvent)
        Controls.Add(cmbStudent)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(btnSave)
        Controls.Add(btnCancel)
        Controls.Add(btnRecord)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Feedback_Creation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Feedback_Creation"
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents txtFeedback As TextBox
    Friend WithEvents cmbStudent As ComboBox
    Friend WithEvents cmbEvent As ComboBox
    Friend WithEvents cmbRating As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEventID1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtFeedbackID As Label
    Friend WithEvents txtEventID As Label
    Friend WithEvents txtStudentID As Label
End Class
