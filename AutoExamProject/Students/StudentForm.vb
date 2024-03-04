Imports System
Imports System.IO

Public Class StudentForm

    Private Sub btn_opentest_Click(sender As Object, e As EventArgs) Handles btn_opentest.Click
        If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            openfile(OpenFileDialog1.FileName)
            getallquestion()
            txt_q.Text = dt.Rows(index)("q").ToString()
            Radio_a.Text = dt.Rows(index)("a").ToString()
            Radio_b.Text = dt.Rows(index)("b").ToString()
            Radio_c.Text = dt.Rows(index)("c").ToString()
            Radio_d.Text = dt.Rows(index)("d").ToString()
        End If
        Timer1.Enabled = True
        starttime = Now.ToLocalTime
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        Radio_a.Checked = False
        Radio_b.Checked = False
        Radio_c.Checked = False
        Radio_d.Checked = False
        index = index + 1
        If index >= count Then
            index = 0
            MsgBox("End of Exam")
        End If
        txt_q.Text = dt.Rows(index)("q").ToString()
        Radio_a.Text = dt.Rows(index)("a").ToString()
        Radio_b.Text = dt.Rows(index)("b").ToString()
        Radio_c.Text = dt.Rows(index)("c").ToString()
        Radio_d.Text = dt.Rows(index)("d").ToString()
    End Sub

    Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click
        Radio_a.Checked = False
        Radio_b.Checked = False
        Radio_c.Checked = False
        Radio_d.Checked = False
        index = index - 1
        If index < 0 Then
            index = 0
            MsgBox("End of Exam")
        End If
        txt_q.Text = dt.Rows(index)("q").ToString()
        Radio_a.Text = dt.Rows(index)("a").ToString()
        Radio_b.Text = dt.Rows(index)("b").ToString()
        Radio_c.Text = dt.Rows(index)("c").ToString()
        Radio_d.Text = dt.Rows(index)("d").ToString()
    End Sub

    Private Sub btn_finish_Click(sender As Object, e As EventArgs) Handles btn_finish.Click
        endtime = Now.ToLocalTime
        Timer1.Enabled = False
        MsgBox(DateDiff(DateInterval.Minute, starttime, endtime).ToString() & " Minutes")
    End Sub

    Private Sub StudentForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If cn.State = ConnectionState.Open Then cn.Close()
    End Sub

    Private Sub Radio_a_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_a.CheckedChanged
        setanswer("a")
        setresult("a")
    End Sub

    Private Sub Radio_b_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_b.CheckedChanged
        setanswer("b")
        setresult("b")
    End Sub

    Private Sub Radio_c_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_c.CheckedChanged
        setanswer("c")
        setresult("c")
    End Sub

    Private Sub Radio_d_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_d.CheckedChanged
        setanswer("d")
        setresult("d")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_timer.Text = Now.ToLocalTime
    End Sub

    Private Sub btn_showresult_Click(sender As Object, e As EventArgs) Handles btn_showresult.Click
        Dim rp As New ResultReport
        Dim ds As New resultDS
        openconnection()
        cmd.CommandText = "select * from answers"
        da.SelectCommand = cmd
        da.Fill(ds, "answers")
        rp.SetDataSource(ds)
        ShowResult.CrystalReportViewer1.ReportSource = rp
        ShowResult.Show()
    End Sub
End Class
