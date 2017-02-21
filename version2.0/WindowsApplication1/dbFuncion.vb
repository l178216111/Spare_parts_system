Imports System.Data.OleDb
Public Class UserPermission
    Dim _type, _SN, _status, _data, _comment, _user, _tinput, _ninput, _sinput, _cinput, _uinput As String
    Public sel = False
    Public comm As String
    Dim Conn As OleDb.OleDbConnection
    Dim Rd As OleDb.OleDbDataReader
    Dim SQL As String
    Public Provider = "Provider=Microsoft.ace.OLEDB.12.0"
    Public Database = "Data source=\\10.192.130.43\Probe\Test_probe\Equipment_Engineering\6.0 Equip Staff folder\Teradyne team\LiuZX\J750-database\Database2.accdb;Jet OLEDB:Database password=123456"
    Public Property Type() As String
        Get
            Return _type
        End Get
        Set(ByVal value As String)
            _type = value
        End Set
    End Property
    Public Property comment() As String
        Get
            Return _comment
        End Get
        Set(ByVal value As String)
            _comment = value
        End Set
    End Property
    Public Property data() As String
        Get
            Return _data
        End Get
        Set(ByVal value As String)
            _data = value
        End Set
    End Property
    Public Property SN() As String
        Get
            Return _SN
        End Get
        Set(ByVal value As String)
            _SN = value
        End Set
    End Property
    Public Property status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property
    Public Property user() As String
        Get
            Return _user
        End Get
        Set(ByVal value As String)
            _user = value
        End Set
    End Property
    Public Property tinput() As String
        Get
            Return _tinput
        End Get
        Set(ByVal value As String)
            _tinput = value
        End Set
    End Property
    Public Property cinput() As String
        Get
            Return _cinput
        End Get
        Set(ByVal value As String)
            _cinput = value
        End Set
    End Property
    Public Property sinput() As String
        Get
            Return _sinput
        End Get
        Set(ByVal value As String)
            _sinput = value
        End Set
    End Property
    Public Property ninput() As String
        Get
            Return _ninput
        End Get
        Set(ByVal value As String)
            _ninput = value
        End Set
    End Property
    Public Property uinput() As String
        Get
            Return _uinput
        End Get
        Set(ByVal value As String)
            _uinput = value
        End Set
    End Property
    Public Sub Addrepair() '添加
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        Dim Sql As String = "INSERT INTO table1 (type,SN,status,data,comment) VALUES (@type,@SN,@status,@data,@comment)"
        Dim Cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, Conn)
        Dim P1 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@type", Me.Type)
        Dim P2 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@SN", Me.SN)
        Dim P3 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@status", Me.status)
        Dim P4 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@data", Me.data)
        Dim P5 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@comment", Me.comment)
        Cmd.Parameters.Add(P1)
        Cmd.Parameters.Add(P2)
        Cmd.Parameters.Add(P3)
        Cmd.Parameters.Add(P4)
        Cmd.Parameters.Add(P5)
        Cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Public Sub Add() '添加
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        Dim Sql As String = "INSERT INTO table1 (type,SN,status,data,comment) VALUES (@type,@SN,@status,@data,@comment)"
        Dim Cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, Conn)
        Dim P1 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@type", Me.Type)
        Dim P2 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@SN", Me.SN)
        Dim P3 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@status", Me.status)
        Dim P4 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@data", Me.data)
        Dim P5 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@comment", Me.comment)
        Cmd.Parameters.Add(P1)
        Cmd.Parameters.Add(P2)
        Cmd.Parameters.Add(P3)
        Cmd.Parameters.Add(P4)
        Cmd.Parameters.Add(P5)
        Cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Public Sub check() '检测有重复SN
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        Dim Sql As String = "select SN From table1"
        Dim Cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, Conn)
        Dim Rd As OleDb.OleDbDataReader = Cmd.ExecuteReader()
        While (Rd.Read())
            If Rd.GetValue(0) = ninput Then
                sel = False '有重复SN"
                Exit While
            Else
                sel = True  '没有重复SN
            End If
        End While
        Conn.Close()
    End Sub
    Public Sub AddF() '添加fail board ****************
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        Dim Sql As String = "INSERT INTO table1 (type,SN,status,data,comment,userid) VALUES (@type,@SN,'Fail',@data,@comment,@user)"
        Dim Cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, Conn)
        Dim P1 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@type", Me.Type)
        Dim P2 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@SN", Me.ninput)
        Dim P4 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@data", Me.data)
        Dim P5 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@comment", Me.comment)
        Dim P6 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@user", Me.user)
        Cmd.Parameters.Add(P1)
        Cmd.Parameters.Add(P2)
        Cmd.Parameters.Add(P4)
        Cmd.Parameters.Add(P5)
        Cmd.Parameters.Add(P6)
        Cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Public Sub changeF() '更新fail board ****************
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        Dim Sql As String = "UPDATE table1 set status='Fail',comment=@commnet,data=@data,userid=@user where type='" & Me.Type & "' and SN='" & Me.ninput & "'"
        Dim Cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, Conn)
        Dim P10 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@comment", Me.comment)
        Dim P4 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@data", Me.data)
        Dim P6 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@user", Me.user)
        Cmd.Parameters.Add(P10)
        Cmd.Parameters.Add(P4)
        Cmd.Parameters.Add(P6)
        Cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Public Sub updata() '修改
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        Dim Sql As String = "UPDATE table1 set type=@tinput,SN=@ninput,status=@sinput,comment=@cinput,data=@data where type=@type and SN=@SN and status=@status and comment=@comment"
        Dim Cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, Conn)
        Dim P7 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@tinput", Me.tinput)
        Dim P8 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@ninput", Me.ninput)
        Dim P9 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@sinput", Me.sinput)
        Dim P10 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@cinput", Me.cinput)
        Dim P5 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@data", Me.data)
        Dim P1 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@type", Me.Type)
        Dim P2 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@SN", Me.SN)
        Dim P3 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@status", Me.status)
        Dim P4 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@comment", Me.comment)

        Cmd.Parameters.Add(P7)
        Cmd.Parameters.Add(P8)
        Cmd.Parameters.Add(P9)
        Cmd.Parameters.Add(P10)
        Cmd.Parameters.Add(P5)
        Cmd.Parameters.Add(P1)
        Cmd.Parameters.Add(P2)
        Cmd.Parameters.Add(P3)
        Cmd.Parameters.Add(P4)

        Cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Public Sub use() '应用
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        Dim Sql As String = "UPDATE table1 set status='Using',comment=@cinput,userid=@user,data=@data where type=@type and SN=@SN"
        Dim Cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, Conn)
        Dim P10 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@cinput", Me.cinput)
        Dim P6 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@user", Me.user)
        Dim P3 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@data", Me.data)
        Dim P1 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@type", Me.Type)
        Dim P2 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@SN", Me.SN)
        Cmd.Parameters.Add(P10)
        Cmd.Parameters.Add(P6)
        Cmd.Parameters.Add(P3)
        Cmd.Parameters.Add(P1)
        Cmd.Parameters.Add(P2)
        Cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Public Function GetAll() As DataTable '显示
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        ' Dim Conn As OleDbConnection = GetConnection()
        Dim Sql As String = "SELECT * FROM table1 ORDER BY data DESC"
        Dim myDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(Sql, Conn)
        Dim Cmd As OleDbCommandBuilder = New OleDbCommandBuilder(myDataAdapter)
        Dim Dt As DataTable = New DataTable()
        myDataAdapter.Fill(Dt)
        Return Dt
        Conn.Close()
    End Function
    Public Sub delete() '删除
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        Dim Sql As String = "delete FROM table1 where type=@type and SN=@SN and status=@status and comment=@comment"
        Dim Cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, Conn)
        Dim P1 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@type", Me.Type)
        Dim P2 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@SN", Me.SN)
        Dim P3 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@status", Me.status)
        Dim P4 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@comment", Me.comment)
        Cmd.Parameters.Add(P1)
        Cmd.Parameters.Add(P2)
        Cmd.Parameters.Add(P3)
        Cmd.Parameters.Add(P4)
        Cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Public Sub sendrepair() '送修
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        Dim Sql As String = "UPDATE table1 set status='Repair',comment=@cinput,data=@data,userid=@user where type=@type and SN=@SN and status='Fail'"
        Dim Cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, Conn)
        Dim P10 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@cinput", Me.cinput)
        Dim P5 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@data", Me.data)
        Dim P6 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@user", Me.user)
        Dim P1 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@type", Me.Type)
        Dim P2 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@SN", Me.SN)
        Dim P4 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@comment", Me.comment)
        Cmd.Parameters.Add(P10)
        Cmd.Parameters.Add(P5)
        Cmd.Parameters.Add(P6)
        Cmd.Parameters.Add(P1)
        Cmd.Parameters.Add(P2)
        Cmd.Parameters.Add(P4)
        Cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Public Sub looppass() '检验合格
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        Dim Sql As String = "UPDATE table1 set status='Pass',comment=@cinput,data=@data,userid='" & Me.user & "' where type=@type and SN=@SN and status='Fail' and comment=@comment"
        Dim Cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, Conn)
        Dim P10 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@cinput", Me.cinput)
        Dim P5 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@data", Me.data)
        Dim P1 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@type", Me.Type)
        Dim P2 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@SN", Me.SN)
        Dim P4 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@comment", Me.comment)
        Dim P6 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@user", Me.user)
        Cmd.Parameters.Add(P10)
        Cmd.Parameters.Add(P5)
        Cmd.Parameters.Add(P1)
        Cmd.Parameters.Add(P2)
        Cmd.Parameters.Add(P4)
        Cmd.Parameters.Add(P6)
        Cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Public Function search() As DataTable '查询
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        ' Dim Conn As OleDbConnection = GetConnection()
        Dim Sql As String
        Sql = "SELECT * FROM table1  where " & Me.sinput & Me.tinput & Me.ninput & Me.cinput & Me.data & " ORDER BY data DESC"
        Dim myDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(Sql, Conn)
        Dim Cmd As OleDbCommandBuilder = New OleDbCommandBuilder(myDataAdapter)
        Dim Dt As DataTable = New DataTable()
        myDataAdapter.Fill(Dt)
        Return Dt
        Conn.Close()
    End Function
    Public Sub SDS() '添加SDS ****************
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        Dim Sql As String = "UPDATE table1 set status='Pass',comment=@commnet,data=@data where SN='" & Me.ninput & "'"
        Dim Cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, Conn)
        Dim P10 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@comment", Me.comment)
        Dim P4 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@data", Me.data)
        Cmd.Parameters.Add(P10)
        Cmd.Parameters.Add(P4)
        Cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Public Sub DOA() '添加DOA ****************
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        Dim Sql As String = "INSERT INTO table1 (type,SN,status,data,comment,userid) VALUES (@type,@SN,'Pass',@data,@comment,@user)"
        Dim Cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, Conn)
        Dim P1 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@type", Type)
        Dim P2 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@SN", Me.ninput)
        Dim P4 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@data", Me.data)
        Dim P5 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@comment", Me.comment)
        Dim P6 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@user", Me.user)
        Cmd.Parameters.Add(P1)
        Cmd.Parameters.Add(P2)
        Cmd.Parameters.Add(P4)
        Cmd.Parameters.Add(P5)
        Cmd.Parameters.Add(P6)
        Cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Sub getcomment() '获得comment
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        SQL = "Select comment From table1 where SN='" & Me.ninput & "'"
        Dim Cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(SQL, Conn)
        Dim P2 As OleDb.OleDbParameter = New OleDb.OleDbParameter("@SN", Me.ninput)
        Cmd.Parameters.Add(P2)
        Rd = Cmd.ExecuteReader()
        While (Rd.Read)
            comm = Rd.GetValue(0)
        End While
        Rd.Close()
        Conn.Close()
    End Sub
    Sub formlog() '登陆 form3
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        SQL = "Select * From table2 Where CID='" & Form3.TextBox1.Text & "' And Pword='" & Form3.TextBox2.Text & "'"
        Dim Cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(SQL, Conn)
        Rd = Cmd.ExecuteReader()
        If Rd.Read() Then
            SQL = "Select right From table2 Where CID='" & Form3.TextBox1.Text & "' And Pword='" & Form3.TextBox2.Text & "'"
            Cmd = New OleDb.OleDbCommand(SQL, Conn)
            Rd = Cmd.ExecuteReader()
            While (Rd.Read)
                Form1.rht = Rd.GetValue(0)
            End While
            Form3.Hide()
        Else
            MessageBox.Show("The Username or Password is Invaild!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Form3.TextBox2.Text = ""
            Form3.TextBox1.Focus()
        End If
        Rd.Close()
        Conn.Close()
    End Sub
    Sub change() '修改密码 form4
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Dim count As Integer = System.Text.Encoding.Default.GetByteCount(Form4.TextBox4.Text)
        Conn.Open()
        SQL = "Select * From table2 Where CID='" & Form4.TextBox1.Text & "' And Pword='" & Form4.TextBox2.Text & "'"
        Dim Cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(SQL, Conn)
        Rd = Cmd.ExecuteReader()
        If Rd.Read() Then
            If Form4.TextBox3.Text = Form4.TextBox4.Text Then
                If count < 6 Then
                    MsgBox("New Password Length Should Longer than 6 ", MsgBoxStyle.Exclamation)
                Else
                    SQL = "UPDATE table2 set Pword='" & Form4.TextBox3.Text & "' where CID='" & Form4.TextBox1.Text & "'"
                    Cmd = New OleDb.OleDbCommand(SQL, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Change Password Sucess")
                    Form4.TextBox1.Text = ""
                    Form4.TextBox2.Text = ""
                    Form4.TextBox3.Text = ""
                    Form4.TextBox4.Text = ""
                    Form4.Close()
                End If
            Else
                MessageBox.Show("The New Password is Invaild!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Username or Password Wrong", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Form4.TextBox1.Text = ""
            Form4.TextBox2.Text = ""
            Form4.TextBox3.Text = ""
            Form4.TextBox4.Text = ""
            Form4.TextBox1.Focus()
        End If
        Rd.Close()
        Conn.Close()
    End Sub
    Public Function diaplay() As DataTable '显示查询
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        ' Dim Conn As OleDbConnection = GetConnection()
        Dim Sql As String
        Sql = "SELECT * FROM table1 where type='" & Form1.DataGridView1.CurrentRow.Cells(0).Value.ToString & "' and data=#" & Now.ToShortDateString & "# ORDER BY data DESC"
        Dim myDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(Sql, Conn)
        Dim Cmd As OleDbCommandBuilder = New OleDbCommandBuilder(myDataAdapter)
        Dim Dt As DataTable = New DataTable()
        myDataAdapter.Fill(Dt)
        Return Dt
        Conn.Close()
    End Function
    Public Function diaplayy() As DataTable '显示查询
        Conn = New OleDb.OleDbConnection(Provider & ";" & Database)
        Conn.Open()
        ' Dim Conn As OleDbConnection = GetConnection()
        Dim Sql As String
        Sql = "SELECT * FROM table1 where SN='" & ninput & "' ORDER BY data DESC"
        Dim myDataAdapter As OleDbDataAdapter = New OleDbDataAdapter(Sql, Conn)
        Dim Cmd As OleDbCommandBuilder = New OleDbCommandBuilder(myDataAdapter)
        Dim Dt As DataTable = New DataTable()
        myDataAdapter.Fill(Dt)
        Return Dt
        Conn.Close()
    End Function
End Class
