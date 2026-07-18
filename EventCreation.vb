Imports MySql.Data.MySqlClient

Public Class EventCreation

    Private Sub CloseForms()
        Dashboard.Close()
        EventRecords.Close()
        Feedback_Creation.Close()
        FeedbackCollection.Close()
        Student_Registration.Close()
        StudentParticipationTracking.Close()
        OrganizerTracking.Close()

    End Sub



    Private Sub ClearSelection()

        txtCategoryID.Text = ""
        txtDescription.Clear()
        txtLocation.Clear()
        txtName.Clear()
        txtID.Text = ""
        cmbOrganizer.Text = ""
        cmbCategory.Text = ""



    End Sub
    Private Sub LoadOrganizer()
        Try
            Dim query As String = "SELECT * FROM organizers"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim event_names As String = reader.GetString("organizer_name")
                            cmbOrganizer.Items.Add(event_names)
                        End While
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub LoadCategory()
        Try
            Dim query As String = "Select * FROM event_categories"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim event_names As String = reader.GetString("category_name")
                            cmbCategory.Items.Add(event_names)
                        End While
                    End If
                End Using
            End Using
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("LoadCategory error: " & ex.ToString())
            MessageBox.Show("Failed to load categories. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnEvent_Click(sender As Object, e As EventArgs) Handles btnEvent.Click

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click


        Dashboard.Show()
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


    Private Sub EventCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OpenConnection()
        LoadOrganizer()
        LoadCategory()
        CloseForms()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Call ClearSelection()

        Dashboard.Show()
        Me.Hide()






    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click

        EventRecords.Show()
        Me.Hide()


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click



        If txtName.Text = "" Or cmbCategory.Text = "" Or txtLocation.Text = "" Or txtDescription.Text = "" Or cmbOrganizer.Text = "" Then

            MessageBox.Show("Please Fill out all required fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        Else
            Try
                ' Query for inserting data
                Dim query As String = "INSERT INTO events (event_name, event_date, location, description, organized_by) 
                           VALUES (@eName, @eDate, @Location, @Description, @Organizers)"

                Dim cmd As New MySqlCommand(query, conn)
                ' Assign parameters
                cmd.Parameters.AddWithValue("@eName", txtName.Text.Trim())
                cmd.Parameters.AddWithValue("@eDate", txtDate.Value)
                cmd.Parameters.AddWithValue("@Location", txtLocation.Text.Trim())
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim())
                cmd.Parameters.AddWithValue("@Organizers", cmbOrganizer.SelectedItem.ToString().Trim())


                ' Execute query
                cmd.ExecuteNonQuery()

                MessageBox.Show("Record Added Successfully", "Add Records", MessageBoxButtons.OK, MessageBoxIcon.Information)

                EventRecords.LoadEventData()
                EventRecords.list_events.Clear()
                Call ClearSelection()





            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine("cmbCategory_SelectedIndexChanged error: " & ex.ToString())
                MessageBox.Show("Failed to load category details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try


        End If


    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        Try
            Dim query = "SELECT * FROM event_categories WHERE category_name = @CategoryName"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CategoryName", cmbCategory.SelectedItem.ToString())
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows AndAlso reader.Read() Then
                        txtCategoryID.Text = reader("category_ID").ToString()
                    Else
                        MessageBox.Show("Error :(")
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try
    End Sub
End Class