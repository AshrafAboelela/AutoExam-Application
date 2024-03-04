Public Class LoginForm

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_pass.Text = "" Or txt_pass.Text = "" Then
            lbl_error.Visible = True
            Exit Sub
        Else
            lbl_error.Visible = False
        End If

        If login(txt_name.Text, txt_pass.Text) = True Then
            TeacherForm.Show()
            Me.Hide()
        Else
            MsgBox("user name or password not found")
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class
