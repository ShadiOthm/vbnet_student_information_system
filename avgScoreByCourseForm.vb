Public Class avgScoreByCourseForm

    Dim score As New SCORE()

    Private Sub avgScoreByCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridViewAvgScore.DataSource = score.getAvgScoreByCourse()

    End Sub
End Class