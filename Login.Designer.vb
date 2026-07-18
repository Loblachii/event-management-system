<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtInput = New TextBox()
        txtPass = New TextBox()
        CheckBox1 = New CheckBox()
        btnLogin = New Button()
        btnExit = New Button()
        Label5 = New Label()
        lblSignup = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label1.Location = New Point(611, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 33)
        Label1.TabIndex = 1
        Label1.Text = "Welcome Back"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label2.Location = New Point(614, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(288, 23)
        Label2.TabIndex = 2
        Label2.Text = "Please Enter your Account details"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label3.Location = New Point(612, 195)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 16)
        Label3.TabIndex = 3
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label4.Location = New Point(613, 251)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 16)
        Label4.TabIndex = 4
        Label4.Text = "Password"
        ' 
        ' txtInput
        ' 
        txtInput.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtInput.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        txtInput.Location = New Point(614, 213)
        txtInput.Margin = New Padding(3, 2, 3, 2)
        txtInput.MaximumSize = New Size(330, 27)
        txtInput.MinimumSize = New Size(330, 27)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(330, 27)
        txtInput.TabIndex = 5
        ' 
        ' txtPass
        ' 
        txtPass.BorderStyle = BorderStyle.FixedSingle
        txtPass.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPass.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        txtPass.Location = New Point(614, 269)
        txtPass.Margin = New Padding(3, 2, 3, 2)
        txtPass.MaximumSize = New Size(278, 27)
        txtPass.MinimumSize = New Size(330, 27)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(330, 27)
        txtPass.TabIndex = 6
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Tahoma", 9.75F, FontStyle.Bold)
        CheckBox1.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        CheckBox1.Location = New Point(616, 301)
        CheckBox1.Margin = New Padding(3, 2, 3, 2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(128, 20)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(3), CByte(92), CByte(19))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        btnLogin.Location = New Point(616, 357)
        btnLogin.Margin = New Padding(3, 2, 3, 2)
        btnLogin.MinimumSize = New Size(330, 27)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(330, 28)
        btnLogin.TabIndex = 8
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(3), CByte(92), CByte(19))
        btnExit.Cursor = Cursors.Hand
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        btnExit.Location = New Point(1002, 2)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(45, 45)
        btnExit.TabIndex = 9
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(2), CByte(46), CByte(9))
        Label5.Location = New Point(668, 396)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 16)
        Label5.TabIndex = 10
        Label5.Text = "Don't have an account yet?"
        ' 
        ' lblSignup
        ' 
        lblSignup.AutoSize = True
        lblSignup.Cursor = Cursors.Hand
        lblSignup.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSignup.ForeColor = Color.FromArgb(CByte(3), CByte(92), CByte(19))
        lblSignup.Location = New Point(834, 396)
        lblSignup.Name = "lblSignup"
        lblSignup.Size = New Size(50, 16)
        lblSignup.TabIndex = 11
        lblSignup.Text = "Signup"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(20, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(525, 435)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.FromArgb(CByte(230), CByte(252), CByte(234))
        ClientSize = New Size(1049, 470)
        Controls.Add(PictureBox1)
        Controls.Add(lblSignup)
        Controls.Add(Label5)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Controls.Add(CheckBox1)
        Controls.Add(txtPass)
        Controls.Add(txtInput)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSignup As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
