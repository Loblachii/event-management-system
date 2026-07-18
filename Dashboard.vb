Imports MySql.Data.MySqlClient

Public Class Dashboard

    Private Sub CloseForms()
        EventCreation.Close()
        EventRecords.Close()
        Feedback_Creation.Close()
        FeedbackCollection.Close()
        Student_Registration.Close()
        StudentParticipationTracking.Close()
        OrganizerTracking.Close()

    End Sub
    Private Sub CountEvents()
        Using cmd As New MySqlCommand("SELECT COUNT(event_ID) FROM events", conn)
            Dim Count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            lblEventCount.Text = String.Format("{0}", Count)
        End Using
    End Sub

    Private Sub CountStudents()
        Using cmd As New MySqlCommand("SELECT COUNT(student_ID) FROM students", conn)
            Dim Count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            lblStudentCount.Text = String.Format("{0}", Count)
        End Using
    End Sub

    Private Sub CountFeedbacks()
        Using cmd As New MySqlCommand("SELECT COUNT(feedback_ID) FROM event_feedback", conn)
            Dim Count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            lblFeedbackCount.Text = String.Format("{0}", Count)
        End Using
    End Sub

    Private Sub CountOrganizers()
        Using cmd As New MySqlCommand("SELECT COUNT(organizer_ID) FROM organizers", conn)
            Dim Count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            lblOrganizerCount.Text = String.Format("{0}", Count)
        End Using
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnection()
        CountEvents()
        CountStudents()
        CountFeedbacks()
        CountOrganizers()
        CloseForms()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click


        If (MessageBox.Show("Are you sure ?", "Logout Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then

            Login.Show()
            Me.Hide()

        Else


        End If





    End Sub

    Private Sub btnEvent_Click(sender As Object, e As EventArgs) Handles btnEvent.Click

        EventCreation.Show()
        Me.Hide()


    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click

        Student_Registration.Show()
        Me.Hide()



    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click

        Feedback_Creation.Show()
        Me.Hide()

    End Sub

    Private Sub btnOrganizer_Click(sender As Object, e As EventArgs) Handles btnOrganizer.Click

        OrganizerTracking.Show()
        Me.Hide()


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        EventRecords.Show()
        Me.Hide()


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        StudentParticipationTracking.Show()
        Me.Hide()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click


        FeedbackCollection.Show()
        Me.Hide()


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        OrganizerTracking.Show()
        Me.Hide()


    End Sub

    Private Sub lblEventCount_Click(sender As Object, e As EventArgs) Handles lblEventCount.Click

    End Sub
End Class

