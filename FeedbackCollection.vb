Imports MySql.Data.MySqlClient

Public Class FeedbackCollection

    Private Sub CloseForms()
        Dashboard.Close()
        EventCreation.Close()
        EventRecords.Close()
        Feedback_Creation.Close()
        Student_Registration.Close()
        StudentParticipationTracking.Close()
        OrganizerTracking.Close()

    End Sub
    Private Sub ConfigureListView() 'Creating Header Column for ListView
        With list_Feedback
            .View = View.Details
            .Columns.Add("Feedback ID", 100, HorizontalAlignment.Left)
            .Columns.Add("Event ID", 100, HorizontalAlignment.Left)
            .Columns.Add("Student ID", 100, HorizontalAlignment.Left)
            .Columns.Add("Feedback", 300, HorizontalAlignment.Left)
            .Columns.Add("Rating", 70, HorizontalAlignment.Left)
            .Columns.Add("Date", 300, HorizontalAlignment.Left)
        End With
    End Sub

    Private Sub LoadFeedbackData() 'Loading data from your database
        Dim query As String = "SELECT * FROM event_feedback"
        Dim cmd As New MySqlCommand(query, conn)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim item As New ListViewItem(reader("feedback_ID").ToString())
                item.SubItems.Add(reader("event_ID").ToString())
                item.SubItems.Add(reader("student_ID").ToString())
                item.SubItems.Add(reader("feedback_text").ToString())
                item.SubItems.Add(reader("rating").ToString())
                item.SubItems.Add(reader("feedback_date").ToString())
                list_Feedback.Items.Add(item)
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading event data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs)

        Dashboard.Show()
        Hide()

    End Sub

    Private Sub btnEvent_Click(sender As Object, e As EventArgs)

        EventCreation.Show()
        Hide()

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs)

        StudentParticipationTracking.Show()
        Hide()

    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnOrganizer_Click(sender As Object, e As EventArgs)

        OrganizerTracking.Show()
        Hide()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        If (MessageBox.Show("Are you sure ?", "Logout Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then

            Login.Show()
            Me.Hide()

        Else


        End If

    End Sub

    Private Sub btnDashboard_Click_1(sender As Object, e As EventArgs) Handles btnDashboard.Click

        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnEvent_Click_1(sender As Object, e As EventArgs) Handles btnEvent.Click

        EventCreation.Show()
        Me.Hide()

    End Sub

    Private Sub btnStudent_Click_1(sender As Object, e As EventArgs) Handles btnStudent.Click

        Student_Registration.Show()
        Me.Hide()

    End Sub

    Private Sub btnOrganizer_Click_1(sender As Object, e As EventArgs) Handles btnOrganizer.Click

        OrganizerTracking.Show()
        Me.Hide()

    End Sub

    Private Sub btnFeedback_Click_1(sender As Object, e As EventArgs) Handles btnFeedback.Click

        Feedback_Creation.Show()
        Me.Hide()

    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        Feedback_Creation.Show()
        Me.Hide()

    End Sub

    Private Sub FeedbackCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
        ConfigureListView()
        LoadFeedbackData()
        CloseForms()
    End Sub

    Private Sub list_Feedback_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_Feedback.SelectedIndexChanged

    End Sub
End Class