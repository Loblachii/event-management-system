Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Student_Registration

    Private Sub CloseForms()
        Dashboard.Close()
        EventCreation.Close()
        EventRecords.Close()
        Feedback_Creation.Close()
        FeedbackCollection.Close()
        StudentParticipationTracking.Close()
        OrganizerTracking.Close()

    End Sub

    Private Sub ClearSelection()

        txtFirstName.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        txtProgram.Clear()
        txtContactNumber.Clear()


    End Sub
    Private Sub Student_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
        CloseForms()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

        Dashboard.Show()
        Me.Hide()

    End Sub

    Private Sub btnEvent_Click(sender As Object, e As EventArgs) Handles btnEvent.Click

        EventCreation.Show()
        Me.Hide()

    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click

        Feedback_Creation.Show()
        Me.Hide()


    End Sub

    Private Sub btnOrganizer_Click(sender As Object, e As EventArgs) Handles btnOrganizer.Click

        OrganizerTracking.Show()
        Me.Hide()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        If (MessageBox.Show("Are you sure ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then

            Login.Show()
            Me.Hide()

        Else


        End If

    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click


        StudentParticipationTracking.Show()
        Me.Hide()

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click


        Dashboard.Show()
        Me.Hide()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click



        If (txtFirstName.Text = "" Or txtLastName.Text = "" Or txtEmail.Text = "" Or txtProgram.Text = "" Or txtContactNumber.Text = "") Then

            MessageBox.Show("Please Fill out all required fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Try
                ' Query for inserting data
                Dim query As String = "INSERT INTO students (first_name, last_name, email, program, contact_number) 
                           VALUES (@Fname, @Lname, @Email, @Program, @ContactNumber)"

                Dim cmd As New MySqlCommand(query, conn)
                ' Assign parameters
                cmd.Parameters.AddWithValue("@Fname", txtFirstName.Text.Trim())
                cmd.Parameters.AddWithValue("@Lname", txtLastName.Text.Trim())
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                cmd.Parameters.AddWithValue("@Program", txtProgram.Text.Trim())
                cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text.Trim())


                ' Execute query
                cmd.ExecuteNonQuery()

                MessageBox.Show("Record Added Successfully", "Add Records", MessageBoxButtons.OK, MessageBoxIcon.Information)


                StudentParticipationTracking.LoadStudentData()
                StudentParticipationTracking.list_student.Clear()
                ClearSelection()


            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try

        End If

    End Sub
End Class