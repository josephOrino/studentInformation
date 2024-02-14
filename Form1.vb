Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim Connect As New MySqlConnection("server=localhost;userid=root;password='';database=cs222_db_orino")
    Dim Command As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim Query As String
    Dim courseVal As String
    Dim checker As Integer
    Public idSQL As String
    Public category As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'center form according to screen
        Me.CenterToScreen()
        cb_category.SelectedIndex = 3
        showData()
    End Sub

    'add, edit, delete, clear contents, and delete all record buttons

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Query = "INSERT INTO info_cs222_orinoo (student_id, course, first_name, last_name, age, year) 
            VALUES (
            '" & txt_studentID.Text & "', 
            '" & courseVal & "', 
            '" & txt_fname.Text & "', 
            '" & txt_lname.Text & "', 
            " & txt_age.Text & ", 
            " & txt_year.Text & "
            )"
        toSql(Query)
        showData()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If lv_info.SelectedItems.Count = 0 Then
            MsgBox("Please select the data to update.", vbInformation, "")
        Else
            Query = "UPDATE info_cs222_orinoo 
            SET 
            student_id = '" & txt_studentID.Text & "',
            course = '" & courseVal & "', 
            first_name = '" & txt_fname.Text & "', 
            last_name = '" & txt_lname.Text & "',
            age = " & txt_age.Text & ", 
            year = " & txt_year.Text & " 
            WHERE 
            id = '" & idSQL & "'
            "
            toSql(Query)
            showData()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If lv_info.SelectedItems.Count = 0 Then
            MsgBox("Please select the data to delete.", vbInformation, "")
        Else
            If MsgBox("Permanently delete this data?", vbQuestion + vbYesNo, "") = vbYes Then
                Query = "DELETE FROM `info_cs222_orinoo` WHERE `info_cs222_orinoo`.`ID` = '" & idSQL & "'"
                toSql(Query)
                clearContents()
                showData()
            End If
        End If

        ''learn to loop the attributes from a database and record it 
        ''as a string so we can utilize the use of sub/functions

    End Sub

    Private Sub btn_clearContent_Click(sender As Object, e As EventArgs) Handles btn_clearContent.Click
        clearContents()
    End Sub

    Private Sub btn_deleteAll_Click(sender As Object, e As EventArgs) Handles btn_deleteAll.Click
        If MsgBox("Permanently delete all the records?", vbQuestion + vbYesNo, "") = vbYes Then
            Query = "TRUNCATE `info_cs222_orinoo`"
            toSql(Query, "All records deleted.")
            clearContents()
            showData()
        End If
    End Sub

    'disables the other checkbox if one checkbox is already checked

    Private Sub radiobtn_bscs_CheckedChanged(sender As Object, e As EventArgs) Handles radiobtn_bscs.CheckedChanged
        courseVal = "BSCS"
    End Sub

    Private Sub radiobtn_bsit_CheckedChanged(sender As Object, e As EventArgs) Handles radiobtn_bsit.CheckedChanged
        courseVal = "BSIT"
    End Sub


    'added a feature that proceeds to the next textbox if enter is pressed

    Private Sub txt_studentID_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_studentID.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_fname.Focus()
        End If
    End Sub

    Private Sub txt_fname_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_fname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_lname.Focus()
        End If
    End Sub

    Private Sub txt_lname_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_lname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_age.Focus()
        End If
    End Sub

    Private Sub txt_age_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_age.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_year.Focus()
        End If
    End Sub

    'added a feature that lets you edit an information from clicking a row in the listview
    Private Sub lv_info_Click(sender As Object, e As EventArgs) Handles lv_info.Click
        If lv_info.SelectedItems.Count > 0 Then
            idSQL = lv_info.SelectedItems(0).SubItems(0).Text
            txt_studentID.Text = lv_info.SelectedItems(0).SubItems(1).Text
            If lv_info.SelectedItems(0).SubItems(2).Text = "BSCS" Then
                radiobtn_bscs.Checked = True
            ElseIf lv_info.SelectedItems(0).SubItems(2).Text = "BSIT" Then
                radiobtn_bsit.Checked = True
            End If
            txt_fname.Text = lv_info.SelectedItems(0).SubItems(3).Text
            txt_lname.Text = lv_info.SelectedItems(0).SubItems(4).Text
            txt_age.Text = lv_info.SelectedItems(0).SubItems(5).Text
            txt_year.Text = lv_info.SelectedItems(0).SubItems(6).Text
        End If
    End Sub

    'added a search feature which utilizes mysql wildcard

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        checkComboBox()
        Query = "SELECT * FROM `info_cs222_orinoo` WHERE " & category & " LIKE '%" & txt_search.Text & "%'"
        showData(Query)
    End Sub
    Private Sub txt_search_GotFocus(sender As Object, e As EventArgs) Handles txt_search.GotFocus
        checkComboBox()
        Query = "SELECT * FROM `info_cs222_orinoo` WHERE " & category & " LIKE '%" & txt_search.Text & "%'"
        showData(Query)
    End Sub

    Private Sub cb_category_DropDownClosed(sender As Object, e As EventArgs) Handles cb_category.DropDownClosed
        txt_search.Focus()
        checkComboBox()
        Query = "SELECT * FROM `info_cs222_orinoo` WHERE " & category & " LIKE '%" & txt_search.Text & "%'"
        showData(Query)
    End Sub

    'delete through the delete button

    Private Sub lv_info_KeyDown(sender As Object, e As KeyEventArgs) Handles lv_info.KeyDown
        If lv_info.SelectedItems.Count > 0 Then
            If e.KeyCode = Keys.Delete Then
                btn_delete.PerformClick()
            End If
        End If

    End Sub

    Private Sub lv_info_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_info.SelectedIndexChanged

    End Sub
End Class
