Imports MySql.Data.MySqlClient
Imports MyFinal_Orino_MarkJoseph.Form1
Imports System.Data.Common

Module Module1
    Dim Connect As New MySqlConnection("server=localhost;userid=root;password='';database=cs222_db_orino")
    Dim Command As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim Query As String

    Public Sub showData()
        Try
            Connect.Open()
            Query = "SELECT * FROM info_cs222_orinoo"
            Command = New MySqlCommand
            With Command
                .Connection = Connect
                .CommandText = Query
            End With

            Form1.lv_info.Items.Clear()

            Reader = Command.ExecuteReader

            Do While Reader.Read = True
                Dim list = Form1.lv_info.Items.Add(Reader("ID"))
                list.Subitems.Add(Reader("student_id"))
                list.Subitems.Add(Reader("course"))
                list.Subitems.Add(Reader("first_name"))
                list.Subitems.Add(Reader("last_name"))
                list.Subitems.Add(Reader("age"))
                list.Subitems.Add(Reader("year"))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub

    Public Sub showData(ByRef Query As String)
        Try
            Connect.Open()
            Command = New MySqlCommand
            With Command
                .Connection = Connect
                .CommandText = Query
            End With

            Form1.lv_info.Items.Clear()

            Reader = Command.ExecuteReader

            Do While Reader.Read = True
                Dim list = Form1.lv_info.Items.Add(Reader("ID"))
                list.Subitems.Add(Reader("student_id"))
                list.Subitems.Add(Reader("course"))
                list.Subitems.Add(Reader("first_name"))
                list.Subitems.Add(Reader("last_name"))
                list.Subitems.Add(Reader("age"))
                list.Subitems.Add(Reader("year"))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub

    Public Sub toSql(ByRef query As String)
        Try
            Connect.Open()
            Command = New MySqlCommand
            With Command
                .Connection = Connect
                .CommandText = query
                Reader = Command.ExecuteReader
            End With
            MsgBox("Changes Saved", vbInformation, "Success")
            clearContents()
        Catch er As Exception
            If er.Message.Contains("syntax") Then
                MsgBox("Please make sure no textbox is empty.", vbInformation, "")
            Else
                MsgBox(er.Message)
            End If

        Finally
            Connect.Close()
        End Try
    End Sub

    Public Sub toSql(ByRef query As String, ByRef message As String)
        Try
            Connect.Open()
            Command = New MySqlCommand
            With Command
                .Connection = Connect
                .CommandText = query
                Reader = Command.ExecuteReader
            End With
            MsgBox(message, vbInformation, "Success")
        Catch er As Exception
            MsgBox(er.Message)
        Finally
            Connect.Close()
        End Try
    End Sub

    Public Sub clearContents()
        Form1.txt_age.Clear()
        Form1.txt_fname.Clear()
        Form1.txt_lname.Clear()
        Form1.txt_studentID.Clear()
        Form1.txt_year.Clear()
        Form1.txt_search.Clear()
        Form1.radiobtn_bsit.Checked = False
        Form1.radiobtn_bscs.Checked = False
        Form1.idSQL = 0

    End Sub

    Public Sub checkComboBox()
        Dim combo = Form1.cb_category
        If combo.SelectedIndex = 0 Then
            Form1.category = "id"
        ElseIf combo.SelectedIndex = 1 Then
            Form1.category = "student_id"
        ElseIf combo.SelectedIndex = 2 Then
            Form1.category = "course"
        ElseIf combo.SelectedIndex = 3 Then
            Form1.category = "first_name"
        ElseIf combo.SelectedIndex = 4 Then
            Form1.category = "last_name"
        ElseIf combo.SelectedIndex = 5 Then
            Form1.category = "age"
        ElseIf combo.SelectedIndex = 6 Then
            Form1.category = "year"
        End If
    End Sub

End Module
