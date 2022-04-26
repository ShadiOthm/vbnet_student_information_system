Public Class removeScoreForm

    Dim score As New SCORE()
    Private Sub removeScoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' populate the datagridview with:
        ' student id - first name - last name
        ' course id - label
        ' score value

        DataGridViewStudentsScore.DataSource = score.getStudentsScore()

    End Sub

    Private Sub ButtonRemoveScore_Click(sender As Object, e As EventArgs) Handles ButtonRemoveScore.Click

        Dim studentID As Integer = DataGridViewStudentsScore.CurrentRow.Cells(0).Value
        Dim courseID As Integer = DataGridViewStudentsScore.CurrentRow.Cells(3).Value

        If MsgBox("Do Want To Delete This Score", MsgBoxStyle.YesNo, "Delete Score") = MsgBoxResult.Yes Then

            If score.deleteScore(studentID, courseID) Then
                MsgBox("Score Deleted", MsgBoxStyle.Information, "Delete Score")
                DataGridViewStudentsScore.DataSource = score.getStudentsScore()

            Else
                MsgBox("Score Not Deleted", MsgBoxStyle.Information, "Delete Score")

            End If

        End If

    End Sub
End Class