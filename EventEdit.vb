Imports MySql.Data.MySqlClient

Public Class EventEdit
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click


        Dashboard.Show()
        Me.Hide()

    End Sub

    Private Sub CloseForms()
        Dashboard.Close()
        EventCreation.Close()
        Feedback_Creation.Close()
        FeedbackCollection.Close()
        Student_Registration.Close()
        StudentParticipationTracking.Close()
        OrganizerTracking.Close()
        EventRecords.Close()
        StudentEdit.Show()



    End Sub

    Private Sub ClearSelection()

        txtEventID.Text = ""
        txtEventName.Text = ""
        txtLocation.Text = ""
        txtDescription.Text = ""
        cmbOrganizer.Text = ""

    End Sub



    Private Sub LoadOrganizers()
        Try

            Dim query As String = "Select * FROM organizers"
            Dim cmd = New MySqlCommand(query, conn)
            Dim reader = cmd.ExecuteReader()

            While reader.Read()
                If (reader.HasRows) Then
                    Dim event_names As String = reader.GetString("name")
                    cmbOrganizer.Items.Add(event_names)

                End If
            End While
            reader.Close()

        Catch ex As Exception

        End Try
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

        If (MessageBox.Show("Are you sure ?", "Logout Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then

            Login.Show()
            Me.Hide()

        Else


        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click


        EventRecords.Show()
        Me.Hide()


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        EventCreation.Show()
        Me.Hide()


    End Sub

    Private Sub EventEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OpenConnection()
        LoadOrganizers()
        EventRecords.LoadEventData()
        EventRecords.Close()



    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click



        If (txtEventName.Text = "" Or txtLocation.Text = "" Or txtDescription.Text = "" Or cmbOrganizer.Text = "") Then

            MessageBox.Show("You cannot remove a field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Try
                Dim query As String = "UPDATE events SET event_name=@eName, event_date=@eDate, location=@Location, description=@Description, organized_by=@Organizer WHERE event_ID = @eID"

                Dim cmd As New MySqlCommand(query, conn)
                ' Assign parameters
                cmd.Parameters.AddWithValue("@eID", txtEventID.Text.Trim())
                cmd.Parameters.AddWithValue("@eName", txtEventName.Text.Trim())
                cmd.Parameters.AddWithValue("@eDate", dtpEventDate.Value)
                cmd.Parameters.AddWithValue("@Location", txtLocation.Text.Trim())
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())
                cmd.Parameters.AddWithValue("@Organizer", cmbOrganizer.SelectedItem.ToString().Trim())


                ' Execute query
                cmd.ExecuteNonQuery()

                MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ClearSelection()

                EventRecords.Show()
                Me.Hide()



            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally

            End Try

        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If (MessageBox.Show("are you sure ?", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then

            Try
                Dim query As String = "delete from events where event_id=@eid"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@eid", Convert.ToInt32(txtEventID.Text))

                cmd.ExecuteNonQuery()

                MessageBox.Show("record deleted successfully", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ClearSelection()

                EventRecords.Show()
                Me.Hide()


            Catch ex As Exception
                MessageBox.Show("error: " & ex.Message)

            Finally



            End Try

        Else


        End If

    End Sub
End Class