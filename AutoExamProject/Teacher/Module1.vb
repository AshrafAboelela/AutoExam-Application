Imports System.Data.OleDb
Module Module1
    Public cn As New OleDbConnection
    Public cmd As New OleDbCommand
    Public constring As String = "Provider=Microsoft.ACE.OLEDB.15.0;Data Source=user_db.accdb;Persist Security Info=False"
    Public dr As OleDbDataReader
    Public da As New OleDbDataAdapter
    Public sclass As String
    Public semail As String
    Public a As String
    Public b As String
    Public c As String
    Public d As String
    Public ans As String
    Public id As Integer
    Public q_id As Integer
    Public ds As New DataSet
    Public tcn As New OleDbConnection
    Public tconstring As String = "Provider=Microsoft.ACE.OLEDB.15.0;Data Source=test_db.accdb;Persist Security Info=False"

    Public Sub openconnection()
        If cn.State = ConnectionState.Closed Then
            cn.ConnectionString = constring
            cn.Open()
            cmd.Connection = cn
        End If
    End Sub

    Public Sub opentestconnection()
        If tcn.State = ConnectionState.Closed Then
            tcn.ConnectionString = tconstring
            tcn.Open()
            cmd.Connection = tcn
        End If
    End Sub

    Public Function login(username As String, pwd As String) As Boolean
        openconnection()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from users where user_name='" & username & "' and pwd='" & pwd & "'"
        dr = cmd.ExecuteReader()
        If dr.HasRows = True Then
            dr.Close()
            Return True
        Else
            dr.Close()
            Return False
        End If
    End Function

    Public Function insertstudent(name As String, _class As String, email As String) As Boolean
        openconnection()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into students(s_name,class,email) values (@sname,@class,@email)"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@sname", name)
        cmd.Parameters.AddWithValue("@class", _class)
        cmd.Parameters.AddWithValue("@email", email)
        Dim i As Integer
        i = cmd.ExecuteNonQuery()
        'If i = 1 Then Return True
        'If i <> 1 Then Return False
        If i = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getallstudent() As DataSet
        openconnection()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from students"
        da.SelectCommand = cmd
        da.Fill(ds, "students")
        Return ds
    End Function

    Public Function findstudent(name As String) As Boolean
        openconnection()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from students where s_name='" & name & "'"
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows = True Then
            sclass = dr("class")
            semail = dr("email")
            id = dr("id")
            dr.Close()
            Return True
        Else
            dr.Close()
            Return False
        End If
    End Function

    Public Function updatestudent(name As String, _class As String, email As String) As Boolean
        openconnection()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update students set s_name=@sname,class=@class,email=@email where id=@id"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@sname", name)
        cmd.Parameters.AddWithValue("@class", _class)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@id", id)
        Dim i As Integer
        i = cmd.ExecuteNonQuery()
        'If i = 1 Then Return True
        'If i <> 1 Then Return False
        If i = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function deletestudent() As Boolean
        openconnection()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from students where id=@id"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@id", id)
        Dim i As Integer
        i = cmd.ExecuteNonQuery()
        'If i = 1 Then Return True
        'If i <> 1 Then Return False
        If i = 1 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function insertquestion(Q As String, A As String, B As String, C As String, D As String, answer As String) As Boolean
        opentestconnection()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into questions(q,a,b,c,d,answer) values (@q,@a,@b,@c,@d,@answer)"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@q", Q)
        cmd.Parameters.AddWithValue("@a", A)
        cmd.Parameters.AddWithValue("@b", B)
        cmd.Parameters.AddWithValue("@c", C)
        cmd.Parameters.AddWithValue("@d", D)
        cmd.Parameters.AddWithValue("@answer", answer)
        Dim i As Integer
        i = cmd.ExecuteNonQuery()
        'If i = 1 Then Return True
        'If i <> 1 Then Return False
        If i = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function getallquestion() As DataSet
        opentestconnection()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from questions"
        da.SelectCommand = cmd
        da.Fill(ds, "questions")
        Return ds
    End Function
    Public Function updatequestion(Q As String, A As String, B As String, C As String, D As String, answer As String) As Boolean
        opentestconnection()
        cmd.CommandText = "update questions set q=@q,A=@a,B=@b,C=@c,D=@d,answer=@answer where id=@id"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@q", Q)
        cmd.Parameters.AddWithValue("@a", A)
        cmd.Parameters.AddWithValue("@b", B)
        cmd.Parameters.AddWithValue("@c", C)
        cmd.Parameters.AddWithValue("@d", D)
        cmd.Parameters.AddWithValue("@answer", answer)
        cmd.Parameters.AddWithValue("@id", q_id)
        Dim i As Integer
        i = cmd.ExecuteNonQuery()
        'If i = 1 Then Return True
        'If i <> 1 Then Return False
        If i = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function deletequestion() As Boolean
        opentestconnection()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from questions where id=@id"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@id", q_id)
        Dim i As Integer
        i = cmd.ExecuteNonQuery()
        'If i = 1 Then Return True
        'If i <> 1 Then Return False
        If i = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function findquestion(question As String) As Boolean
        opentestconnection()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from questions where q='" & question & "'"
        dr = cmd.ExecuteReader()
        dr.Read()

        If dr.HasRows = True Then
            a = dr("a")
            b = dr("b")
            c = dr("c")
            d = dr("d")
            ans = dr("answer")
            q_id = dr("id")
            dr.Close()
            Return True
        Else
            dr.Close()
            Return False
        End If
    End Function

End Module
