Imports MySql.Data.MySqlClient

Public Class StudentEdit
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

        Dashboard.Show()
        Me.Hide()


    End Sub

    Private Sub CloseForms()
        Dashboard.Close()
        EventCreation.Close()
        EventRecords.Close()
        Feedback_Creation.Close()
        FeedbackCollection.Close()
        Student_Registration.Close()
        OrganizerTracking.Close()
        StudentParticipationTracking.Close()
        EventEdit.Close()


    End Sub

    Private Sub ClearSelection()

        txtStudentID.Text = ""
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        txtProgram.Clear()
        txtContactNumber.Clear()


    End Sub

    Private Sub btnEvent_Click(sender As Object, e As EventArgs) Handles btnEvent.Click

        EventCreation.Show()
        Me.Hide()

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click

        Student_Registration.Show()
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

    Private Sub StudentEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OpenConnection()
        StudentParticipationTracking.LoadStudentData()
        CloseForms()


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If (txtStudentID.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Or txtEmail.Text = "" Or txtProgram.Text = "" Or
            txtContactNumber.Text = "") Then

            MessageBox.Show("You cannot remove a field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else




            Try
                Dim query As String = "update students set first_name=@fname, last_name=@lname, email=@email, program=@program, contact_number=@contact where student_id = @studentid"

                Dim cmd As New MySqlCommand(query, conn)
                ' assign parameters
                cmd.Parameters.AddWithValue("@studentid", txtStudentID.Text.Trim())
                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text.Trim())
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text.Trim())
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                cmd.Parameters.AddWithValue("@program", txtProgram.Text.Trim())
                cmd.parameters.addwithvalue("@contact", txtContactNumber.Text.Trim())


                ' execute query
                cmd.executenonquery()

                MessageBox.Show("record updated successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information)

                StudentParticipationTracking.ConfigureListView()
                ClearSelection()

                StudentParticipationTracking.Show()
                Me.Hide()



            Catch ex As Exception
                MessageBox.Show("error: " & ex.Message)
            Finally
            End Try

        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If (MessageBox.Show("Are you sure ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then

            Try
                Dim query As String = "DELETE FROM students WHERE student_ID=@StudentID"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@StudentID", Convert.ToInt32(txtStudentID.Text))

                cmd.ExecuteNonQuery()

                MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ClearSelection()

                StudentParticipationTracking.ConfigureListView()

                StudentParticipationTracking.Show()
                Me.Hide()



            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            Finally


            End Try

        Else


        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        StudentParticipationTracking.Show()
        Me.Hide()

    End Sub
End Class