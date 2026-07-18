Imports MySql.Data.MySqlClient

Public Class EventRecords
    Private Sub CloseForms()
        Dashboard.Close()
        EventCreation.Close()
        Feedback_Creation.Close()
        FeedbackCollection.Close()
        Student_Registration.Close()
        StudentParticipationTracking.Close()
        OrganizerTracking.Close()
        EventEdit.Close()
        StudentEdit.Close()



    End Sub

    Public Sub ConfigureListView() 'Creating Header Column for ListView
        With list_events
            .View = View.Details
            .Columns.Add("Event ID", 60, HorizontalAlignment.Left)
            .Columns.Add("Event Name", 200, HorizontalAlignment.Left)
            .Columns.Add("Event Date", 200, HorizontalAlignment.Left)
            .Columns.Add("Location", 190, HorizontalAlignment.Left)
            .Columns.Add("Description", 310, HorizontalAlignment.Left)
            .Columns.Add("Organizer", 160, HorizontalAlignment.Left)
        End With
    End Sub




    Public Sub LoadEventData() 'Loading data from your database
        Dim query As String = "SELECT * FROM events"
        Using cmd As New MySqlCommand(query, conn)
            Try
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New ListViewItem(reader("event_ID").ToString())
                        item.SubItems.Add(reader("event_name").ToString())
                        item.SubItems.Add(reader("event_date").ToString())
                        item.SubItems.Add(reader("location").ToString())
                        item.SubItems.Add(reader("description").ToString())
                        item.SubItems.Add(reader("organized_by").ToString())
                        list_events.Items.Add(item)
                    End While
                End Using
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine("LoadEventData error: " & ex.ToString())
                MessageBox.Show("Failed to load event records. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        EventCreation.Show()
        Me.Hide()


    End Sub

    Private Sub EventRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
        ConfigureListView()
        LoadEventData()
        CloseForms()


    End Sub

    Public Sub list_events_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_events.SelectedIndexChanged

        Dim SelectedItem As ListView.SelectedListViewItemCollection = CType(sender, ListView).SelectedItems

        If (SelectedItem.Count > 0) Then
            EventEdit.txtEventID.Text = SelectedItem(0).SubItems(0).Text
            EventEdit.txtEventName.Text = SelectedItem(0).SubItems(1).Text
            EventEdit.dtpEventDate.Value = SelectedItem(0).SubItems(2).Text
            EventEdit.txtLocation.Text = SelectedItem(0).SubItems(3).Text
            EventEdit.txtDescription.Text = SelectedItem(0).SubItems(4).Text
            EventEdit.cmbOrganizer.Text = SelectedItem(0).SubItems(5).Text

        Else
            EventEdit.txtEventID.Text = ""
            EventEdit.txtEventName.Clear()
            EventEdit.txtLocation.Clear()
            EventEdit.txtDescription.Clear()
            EventEdit.cmbOrganizer.Text = ""



        End If




    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If (list_events.SelectedItems.Count = 0) Then

            MessageBox.Show("please select a row", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            list_events.Clear()
            EventEdit.Show()


        End If




    End Sub

End Class