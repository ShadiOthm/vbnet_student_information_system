Imports MySql.Data.MySqlClient

Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBoxLogin.ImageLocation = "../../myImages/loginIco.png"

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click

        Close()

    End Sub

    Private Sub CheckBoxPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPass.CheckedChanged

        If TextBoxPassword.UseSystemPasswordChar Then

            ' show password
            TextBoxPassword.UseSystemPasswordChar = False

        Else

            ' hide password
            TextBoxPassword.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        Dim db As New MY_DB()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT * FROM `user` WHERE `username` = @usn AND `password` = @pass", db.getConnection)

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBoxUsername.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxPassword.Text

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then

            Dim fmain As New MainForm()
            fmain.Show()
            Me.Close()

        Else
            MsgBox("Invalid Username Or Password", MsgBoxStyle.Critical, "Login Error")

        End If

    End Sub
End Class