Imports System.Data.OleDb
Imports System.IO
Module Module1
    Public cn As New OleDbConnection
    Public cmd As New OleDbCommand
    Public constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=test_db.accdb;Persist Security Info=False"
    Public dr As OleDbDataReader
    Public da As New OleDbDataAdapter
    Public ds As New DataSet
    Public dt As New DataTable
    Public index As Integer
    Public count As Integer
    Public starttime As DateTime
    Public endtime As DateTime
    Public Sub openconnection()
        If cn.State = ConnectionState.Closed Then
            cn.ConnectionString = constring
            cn.Open()
            cmd.Connection = cn
        End If
    End Sub
    Public Sub openfile(filepath As String)
        Dim fs As New FileStream(filepath, FileMode.Open, FileAccess.Read)
        Dim ofs As New FileStream(Application.StartupPath & "\test3.accdb", FileMode.Create, FileAccess.Write)
        ''Dim ofs As New FileStream(Application.StartupPath & "\test_db.accdb", FileMode.Create, FileAccess.Write)
        filepath = Application.StartupPath & "\test3.accdb"

        Dim r(fs.Length) As Byte
        fs.Read(r, 0, fs.Length)
        ofs.Write(r, 1, fs.Length)
        fs.Close()
        ofs.Close()
    End Sub
    Public Sub getallquestion()
        openconnection()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from questions"
        da.SelectCommand = cmd
        da.Fill(dt)
        count = dt.Rows.Count
    End Sub
    Public Sub setanswer(answer As String)
        openconnection()
        On Error Resume Next
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from answers where q_id=@id"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@id", dt.Rows(index)("id").ToString())
        dr = cmd.ExecuteReader()
        If dr.HasRows = False Then
            dr.Close()
            cmd.CommandText = "insert into answers(q_id,stu_answer) values (@id,@answer)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", dt.Rows(index)("id").ToString())
            cmd.Parameters.AddWithValue("@answer", answer)
            cmd.ExecuteNonQuery()
        Else
            dr.Close()
            cmd.CommandText = "update answers set stu_answer='" & answer & "' where q_id=@id"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", dt.Rows(index)("id").ToString())
            cmd.ExecuteNonQuery()
        End If

    End Sub
    Public Sub setresult(ans As String)
        openconnection()
        On Error Resume Next
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from questions where q_id=@id"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@id", dt.Rows(index)("id"))
        dr = cmd.ExecuteReader()
        dr.Read()
        If ans = dr("answer") Then
            dr.Close()
            cmd.CommandText = "update answers set result='true' where q_id=@id"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", dt.Rows(index)("id"))
            cmd.ExecuteNonQuery()
        Else
            dr.Close()
            cmd.CommandText = "update answers set result='false' where q_id=@id"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", dt.Rows(index)("id"))
            cmd.ExecuteNonQuery()
        End If
    End Sub
End Module
