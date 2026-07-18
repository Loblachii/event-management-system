Imports System.Diagnostics.Eventing.Reader
Imports MySql.Data.MySqlClient

Public Class StudentParticipationTracking
    Private Sub CloseForms()
        Dashboard.Close()
        EventCreation.Close()
        EventRecords.Close()
        Feedback_Creation.Close()
        FeedbackCollection.Close()
        Student_Registration.Close()
        OrganizerTracking.Close()
        StudentEdit.Close()
        EventEdit.Close()


    End Sub

    Public Sub ConfigureListView() 'Creating Header Column for ListView
        With list_student
            .View = View.Details
            .Columns.Add("Student ID", 60, HorizontalAlignment.Left)
            .Columns.Add("First Name", 200, HorizontalAlignment.Left)
            .Columns.Add("Last Name", 200, HorizontalAlignment.Left)
            .Columns.Add("Email", 310, HorizontalAlignment.Left)
            .Columns.Add("Program", 190, HorizontalAlignment.Left)
            .Columns.Add("Contact Number", 160, HorizontalAlignment.Left)
        End With
    End Sub

    Public Sub LoadStudentData() 'Loading data from your database
        Dim query As String = "SELECT * FROM students"
        Dim cmd As New MySqlCommand(query, conn)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim item As New ListViewItem(reader("student_ID").ToString())
                item.SubItems.Add(reader("first_name").ToString())
                item.SubItems.Add(reader("last_name").ToString())
                item.SubItems.Add(reader("email").ToString())
                item.SubItems.Add(reader("program").ToString())
                item.SubItems.Add(reader("contact_number").ToString())
                list_student.Items.Add(item)
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading student data: " & ex.Message)
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

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        Student_Registration.Show()
        Me.Hide()

    End Sub

    Private Sub StudentParticipationTracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
        ConfigureListView()
        LoadStudentData()
        CloseForms()




    End Sub

    Private Sub StudentParticipationTracking_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown



    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub list_student_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_student.SelectedIndexChanged
        Dim SelectedItem As ListView.SelectedListViewItemCollection = CType(sender, ListView).SelectedItems

        If (SelectedItem.Count > 0) Then
            StudentEdit.txtStudentID.Text = SelectedItem(0).SubItems(0).Text
            StudentEdit.txtFirstName.Text = SelectedItem(0).SubItems(1).Text
            StudentEdit.txtLastName.Text = SelectedItem(0).SubItems(2).Text
            StudentEdit.txtEmail.Text = SelectedItem(0).SubItems(3).Text
            StudentEdit.txtProgram.Text = SelectedItem(0).SubItems(4).Text
            StudentEdit.txtContactNumber.Text = SelectedItem(0).SubItems(5).Text

        Else

            StudentEdit.txtStudentID.Text = ""
            StudentEdit.txtFirstName.Text = ""
            StudentEdit.txtLastName.Text = ""
            StudentEdit.txtEmail.Text = ""
            StudentEdit.txtProgram.Text = ""
            StudentEdit.txtContactNumber.Text = ""

        End If




    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click


        If (list_student.SelectedItems.Count = 0) Then

            MessageBox.Show("Please Select a row", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            list_student.Clear()
            StudentEdit.Show()


        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)





    End Sub
End Class