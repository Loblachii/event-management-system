Imports MySql.Data.MySqlClient

Public Class Signup

    Public Sub ClearSelection()

        txtInput.Clear()
        txtPass.Clear()


    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click


        If (MessageBox.Show("Are you sure ?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then

            Me.Close()
            Dashboard.Close()

        Else


        End If

    End Sub

    Private Sub lblSignup_Click(sender As Object, e As EventArgs) Handles lblSignup.Click

        Call ClearSelection()
        Login.Show()
        Me.Hide()







    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        txtPass.UseSystemPasswordChar = Not CheckBox1.Checked

    End Sub

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPass.UseSystemPasswordChar = Not CheckBox1.Checked
        Call ClearSelection()
        Call OpenConnection()



    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        If (txtInput.Text = "" Or txtPass.Text = "") Then

            MessageBox.Show("Please Fill out all required fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Try
                ' Query for inserting data
                Dim query As String = "INSERT INTO accounts (user_name, user_password) 
                           VALUES (@uName, @uPass)"

                Dim cmd As New MySqlCommand(query, conn)
                ' Assign parameters
                cmd.Parameters.AddWithValue("@uName", txtInput.Text.Trim())
                cmd.Parameters.AddWithValue("@uPass", txtPass.Text.Trim())


                ' Execute query
                cmd.ExecuteNonQuery()

                MessageBox.Show("Account Added Successfully", "Add Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call ClearSelection()



            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try


        End If
    End Sub
End Class