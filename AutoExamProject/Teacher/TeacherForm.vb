Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Mail
Imports System
Imports System.Security
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Security.Cryptography


Public Class TeacherForm
    Public Sub clear_txt()
        txt_class.Text = ""
        txt_name.Text = ""
        txt_mail.Text = ""
    End Sub
    Public Sub clear_question_txt()
        txt_question.Text = ""
        txt_a.Text = ""
        txt_b.Text = ""
        txt_c.Text = ""
        txt_d.Text = ""
        cmb_answer.Text = ""
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        clear_txt()

    End Sub

    Private Sub TeacherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = getallstudent().Tables("students")
        DataGridView2.DataSource = getallquestion().Tables("questions")
        cmb_student.DataSource = DataGridView1.DataSource
        cmb_student.DisplayMember = "s_name"
        cmb_student.ValueMember = "email"
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_class.Text = "" Then
            lbl_class_valid.Visible = True
            Exit Sub
        End If
        If txt_name.Text = "" Then
            lbl_name_valid.Visible = True
            Exit Sub
        End If
        If txt_mail.Text = "" Then
            lbl_mail_valid.Visible = True
            Exit Sub
        End If
        If insertstudent(txt_name.Text, txt_class.Text, txt_mail.Text) = True Then
            MessageBox.Show("Done", "insert student", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        clear_txt()
        DataGridView1.DataSource = getallstudent().Tables("students")
    End Sub

    Private Sub btn_find_Click(sender As Object, e As EventArgs) Handles btn_find.Click
        If txt_name.Text = "" Then
            lbl_name_valid.Visible = True
            Exit Sub
        Else
            lbl_name_valid.Visible = False
        End If
        If findstudent(txt_name.Text) = True Then
            txt_class.Text = sclass
            txt_mail.Text = semail
        Else
            MessageBox.Show("student data not found", "find student", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If updatestudent(txt_name.Text, txt_class.Text, txt_mail.Text) = True Then
            MessageBox.Show("Done", "update student", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ds.Tables("students").Clear()
            DataGridView1.DataSource = getallstudent().Tables("students")
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If deletestudent() = True Then
            MessageBox.Show("Done", "delete student", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear_txt()
            ds.Clear()
            DataGridView1.DataSource = getallstudent().Tables("students")
        End If
    End Sub

    Private Sub btn_new2_Click(sender As Object, e As EventArgs) Handles btn_new2.Click
        clear_question_txt()
    End Sub

    Private Sub btn_save2_Click(sender As Object, e As EventArgs) Handles btn_save2.Click
        If txt_question.Text = "" Then
            lbl_q_valid.Visible = True
            Exit Sub
        End If
        If txt_a.Text = "" Then
            lbl_a_valid.Visible = True
            Exit Sub
        End If
        If txt_b.Text = "" Then
            lbl_b_valid.Visible = True
            Exit Sub
        End If
        If txt_c.Text = "" Then
            lbl_c_valid.Visible = True
            Exit Sub
        End If
        If txt_d.Text = "" Then
            lbl_d_valid.Visible = True
            Exit Sub
        End If
        If insertquestion(txt_question.Text, txt_a.Text, txt_b.Text, txt_c.Text, txt_d.Text, cmb_answer.SelectedItem) = True Then
            MessageBox.Show("Done", "insert question", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ds.Tables("questions").Clear()
            clear_question_txt()
            DataGridView2.DataSource = getallquestion().Tables("questions")
        End If
    End Sub

    Private Sub btn_update2_Click(sender As Object, e As EventArgs) Handles btn_update2.Click
        If updatequestion(txt_question.Text, txt_a.Text, txt_b.Text, txt_c.Text, txt_d.Text, cmb_answer.Text) = True Then
            MessageBox.Show("Done", "update question", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ds.Tables("questions").Clear()
            DataGridView2.DataSource = getallquestion().Tables("questions")
        End If
    End Sub

    Private Sub btn_delete2_Click(sender As Object, e As EventArgs) Handles btn_delete2.Click
        If deletequestion() = True Then
            MessageBox.Show("Done", "delete question", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ds.Tables("questions").Clear()
            DataGridView2.DataSource = getallquestion().Tables("questions")
            clear_question_txt()
        End If
    End Sub

    Private Sub btn_find2_Click(sender As Object, e As EventArgs) Handles btn_find2.Click
        If txt_question.Text = "" Then
            lbl_q_valid.Visible = True
            Exit Sub
        Else
            lbl_q_valid.Visible = False
        End If
        If findquestion(txt_question.Text) = True Then
            txt_a.Text = a
            txt_b.Text = b
            txt_c.Text = c
            txt_d.Text = d
            cmb_answer.Text = ""
            cmb_answer.SelectedText = ans
        Else
            MessageBox.Show("question not found", "find question", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_finish_Click(sender As Object, e As EventArgs) Handles btn_finish.Click
        If tcn.State = ConnectionState.Open Then
            'tcn.ConnectionString = tconstring
            tcn.Close()
            'cmd.Connection = tcn
        End If
        FileCopy(Application.StartupPath & "\test_db.accdb", Application.StartupPath & "\test.accdb")
        Dim fs As New FileStream(Application.StartupPath & "\test_db.accdb", FileMode.Open, FileAccess.Read)
        Dim ofs As New FileStream(Application.StartupPath & "\test2.accdb", FileMode.Create, FileAccess.Write)
        Dim r(fs.Length + 1) As Byte
        fs.Read(r, 1, fs.Length)
        r(0) = Byte.Parse("5")
        ofs.Write(r, 0, fs.Length)
        fs.Close()
        ofs.Close()
    End Sub

    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        Dim smtp_server As New SmtpClient
        Dim e_mail As New MailMessage()

        smtp_server.UseDefaultCredentials = False
        smtp_server.Credentials = New Net.NetworkCredential("from@yahoo.com", "")
        smtp_server.Port = 587
        smtp_server.EnableSsl = True
        smtp_server.Host = "smtp.mail.yahoo.com"

        e_mail.From = New MailAddress("from@yahoo.com")
        e_mail.To.Add(txt_to.Text)
        e_mail.Subject = txt_title.Text
        e_mail.IsBodyHtml = False
        e_mail.Body = txt_body.Text

        Dim i As New Attachment(Application.StartupPath & "\test.accdb")
        e_mail.Attachments.Add(i)
        smtp_server.Send(e_mail)
        MsgBox("mail sent")
    End Sub

    Private Sub cmb_student_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_student.SelectedIndexChanged
        If cmb_student.SelectedValue.ToString = "System.Data.DataRowView" Then
            Exit Sub
        End If
        txt_to.Text = cmb_student.SelectedValue.ToString()
    End Sub
End Class