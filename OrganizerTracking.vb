Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class OrganizerTracking

    Private Sub CloseForms()
        Dashboard.Close()
        EventCreation.Close()
        EventRecords.Close()
        Feedback_Creation.Close()
        FeedbackCollection.Close()
        Student_Registration.Close()
        StudentParticipationTracking.Close()


    End Sub

    Private Sub ConfigureListView() 'Creating Header Column for ListView
        With list_organizer
            .View = View.Details
            .Columns.Add("Organizer ID", 150, HorizontalAlignment.Left)
            .Columns.Add("Organizer Name", 150, HorizontalAlignment.Left)
            .Columns.Add("Contact Email", 150, HorizontalAlignment.Left)
        End With
    End Sub

    Private Sub LoadOrganizerData()
        Dim query As String = "SELECT * FROM organizers"
        Dim cmd As New MySqlCommand(query, conn)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim item As New ListViewItem(reader("organizer_ID").ToString())
                item.SubItems.Add(reader("organizer_name").ToString())
                item.SubItems.Add(reader("email").ToString())
                list_organizer.Items.Add(item)
            End While

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading organizer data: " & ex.ToString())
        End Try
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

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click

        Feedback_Creation.Show()
        Me.Hide()




    End Sub

    Private Sub btnOrganizer_Click(sender As Object, e As EventArgs) Handles btnOrganizer.Click


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        If (MessageBox.Show("Are you sure ?", "Logout Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then

            Login.Show()
            Me.Hide()

        Else


        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Hide()


    End Sub

    Private Sub OrganizerTracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
        ConfigureListView()
        LoadOrganizerData()
        CloseForms()
    End Sub

    Private Sub list_organizer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_organizer.SelectedIndexChanged

    End Sub
End Class