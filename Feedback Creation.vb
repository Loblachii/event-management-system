Imports MySql.Data.MySqlClient

Public Class Feedback_Creation

    Private Sub CloseForms()
        Dashboard.Close()
        EventCreation.Close()
        EventRecords.Close()
        FeedbackCollection.Close()
        Student_Registration.Close()
        StudentParticipationTracking.Close()
        OrganizerTracking.Close()

    End Sub


    Private Sub ClearSelection()

        cmbEvent.Text = ""
        cmbStudent.Text = ""
        txtFeedback.Text = ""
        cmbRating.Text = ""


    End Sub
    Private Sub LoadEvents()

        Try

            Dim query As String = "Select * FROM events"
            Dim cmd = New MySqlCommand(query, conn)
            Dim reader = cmd.ExecuteReader()

            While reader.Read()
                If (reader.HasRows) Then
                    Dim event_names As String = reader.GetString("event_name")
                    cmbEvent.Items.Add(event_names)

                End If
            End While
            reader.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub LoadStudents()

        Try

            Dim query As String = "Select * FROM students"
            Dim cmd = New MySqlCommand(query, conn)
            Dim reader = cmd.ExecuteReader()

            While reader.Read()
                If (reader.HasRows) Then
                    Dim event_names As String = reader.GetString("first_name")
                    cmbStudent.Items.Add(event_names)

                End If

            End While
            reader.Close()

        Catch ex As Exception

        End Try


    End Sub
    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click

        FeedbackCollection.Show()
        Me.Hide()

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

        Dashboard.Show()
        Me.Hide()


    End Sub

    Private Sub btnEvent_Click(sender As Object, e As EventArgs) Handles btnEvent.Click

        EventCreation.Show()
        Me.Hide()


    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click

        Student_Registration.Show()
        Me.Hide()


    End Sub

    Private Sub btnOrganizer_Click(sender As Object, e As EventArgs) Handles btnOrganizer.Click

        OrganizerTracking.Show()
        Me.Hide()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        If (MessageBox.Show("Are you sure ?", "Logout Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then

            Login.Show()
            Me.Hide()

        Else


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dashboard.Show()
        Me.Hide()

    End Sub

    Private Sub Feedback_Creation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OpenConnection()
            LoadEvents()
            LoadStudents()
            CloseForms()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Feedback_Creation_Load error: " & ex.ToString())
            MessageBox.Show("An error occurred while initializing the feedback screen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click







        If (cmbEvent.Text = "" Or cmbStudent.Text = "" Or txtFeedback.Text = "" Or cmbRating.Text = "") Then

            MessageBox.Show("Please Fill out all required fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Try
            ' Query for inserting data
            Dim query As String = "INSERT INTO event_feedback (event_ID, student_ID, feedback_text, rating, feedback_date) 
                           VALUES (@eID, @sID, @Feedback, @Rate, @Date)"

            Dim cmd As New MySqlCommand(query, conn)
                ' Assign parameters
                cmd.Parameters.AddWithValue("@eID", txtEventID.Text.Trim())
                cmd.Parameters.AddWithValue("@sID", txtStudentID.Text.Trim())
                cmd.Parameters.AddWithValue("@Feedback", txtFeedback.Text.Trim())
                cmd.Parameters.AddWithValue("@Rate", cmbRating.SelectedItem.ToString().Trim())
                cmd.Parameters.AddWithValue("@Date", DateTimePicker1.Value)


                ' Execute query
                cmd.ExecuteNonQuery()

                MessageBox.Show("Record Added Successfully", "Add Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call ClearSelection()



            Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try


        End If








    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub cmbEvent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEvent.SelectedIndexChanged
        Try
            Dim query = "SELECT * FROM events WHERE event_name = @eventname"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@eventname", cmbEvent.SelectedItem.ToString())

            Dim reader = cmd.ExecuteReader

            If reader.HasRows Then
                reader.Read()

                txtEventID.Text = reader("event_ID").ToString()
                reader.Close()
            Else
                MessageBox.Show("Error :(")
                reader.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try


    End Sub

    Private Sub cmbStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudent.SelectedIndexChanged
        Try
            Dim query = "SELECT * FROM students WHERE first_name = @studentname"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@studentname", cmbStudent.SelectedItem.ToString())

            Dim reader = cmd.ExecuteReader

            If reader.HasRows Then
                reader.Read()

                txtStudentID.Text = reader("student_ID").ToString()
                reader.Close()
            Else
                MessageBox.Show("Error :(")
                reader.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try
    End Sub
End Class