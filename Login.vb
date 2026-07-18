Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Public Sub ClearSelection()

        txtInput.Clear()
        txtPass.Clear()


    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try

            Dim query As String = "SELECT * FROM accounts WHERE user_name =  @username AND user_password = @password"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@username", txtInput.Text)
            cmd.Parameters.AddWithValue("@password", txtPass.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()


            If reader.HasRows Then

                MessageBox.Show("Login Successfully", "Correct Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reader.Close()
                ClearSelection()
                Dashboard.Show()
                Me.Hide()

            Else
                MessageBox.Show("Login Failed!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ClearSelection()
                reader.Close()

            End If


        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conn.Close()

        End Try

        'Dim username As String
        'Dim password As String


        'username = Val(txtInput.Text)
        'password = Val(txtPass.Text)


        'If (username <> "Admin" AndAlso password <> "12345") Then


        '    MessageBox.Show("Login Failed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Call ClearSelection()


        'Else
        '    MessageBox.Show("Login Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Call ClearSelection()

        '    Dashboard.Show()
        '    Me.Hide()


        'End If





    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        If (MessageBox.Show("Are you sure ?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then

            Me.Close()
            Dashboard.Close()

        Else


        End If



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        txtPass.UseSystemPasswordChar = Not CheckBox1.Checked



    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        OpenConnection()
        txtPass.UseSystemPasswordChar = Not CheckBox1.Checked




    End Sub

    Private Sub lblSignup_Click(sender As Object, e As EventArgs) Handles lblSignup.Click

        Call ClearSelection()
        Signup.Show()
        Me.Hide()


    End Sub
End Class