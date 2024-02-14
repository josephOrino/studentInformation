<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        Label8 = New Label()
        cb_category = New ComboBox()
        Label7 = New Label()
        txt_search = New TextBox()
        btn_clearContent = New Button()
        btn_deleteAll = New Button()
        radiobtn_bsit = New RadioButton()
        radiobtn_bscs = New RadioButton()
        lv_info = New ListView()
        id = New ColumnHeader()
        studentID = New ColumnHeader()
        course = New ColumnHeader()
        fname = New ColumnHeader()
        lname = New ColumnHeader()
        age = New ColumnHeader()
        year = New ColumnHeader()
        txt_year = New TextBox()
        Label6 = New Label()
        txt_age = New TextBox()
        Label5 = New Label()
        btn_delete = New Button()
        btn_edit = New Button()
        btn_add = New Button()
        txt_lname = New TextBox()
        txt_fname = New TextBox()
        txt_studentID = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(cb_category)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txt_search)
        GroupBox1.Controls.Add(btn_clearContent)
        GroupBox1.Controls.Add(btn_deleteAll)
        GroupBox1.Controls.Add(radiobtn_bsit)
        GroupBox1.Controls.Add(radiobtn_bscs)
        GroupBox1.Controls.Add(lv_info)
        GroupBox1.Controls.Add(txt_year)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txt_age)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(btn_delete)
        GroupBox1.Controls.Add(btn_edit)
        GroupBox1.Controls.Add(btn_add)
        GroupBox1.Controls.Add(txt_lname)
        GroupBox1.Controls.Add(txt_fname)
        GroupBox1.Controls.Add(txt_studentID)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 7)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 671)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(562, 620)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 25)
        Label8.TabIndex = 31
        Label8.Text = "by: "
        ' 
        ' cb_category
        ' 
        cb_category.FormattingEnabled = True
        cb_category.Items.AddRange(New Object() {"ID", "Student ID", "Course", "First Name", "Last Name", "Age", "Year"})
        cb_category.Location = New Point(609, 617)
        cb_category.Name = "cb_category"
        cb_category.Size = New Size(134, 33)
        cb_category.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(220, 620)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 25)
        Label7.TabIndex = 29
        Label7.Text = "Search:"
        ' 
        ' txt_search
        ' 
        txt_search.Location = New Point(294, 619)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(262, 31)
        txt_search.TabIndex = 28
        ' 
        ' btn_clearContent
        ' 
        btn_clearContent.Location = New Point(277, 183)
        btn_clearContent.Name = "btn_clearContent"
        btn_clearContent.Size = New Size(111, 34)
        btn_clearContent.TabIndex = 27
        btn_clearContent.Text = "Clear"
        btn_clearContent.UseVisualStyleBackColor = True
        ' 
        ' btn_deleteAll
        ' 
        btn_deleteAll.Location = New Point(579, 223)
        btn_deleteAll.Name = "btn_deleteAll"
        btn_deleteAll.Size = New Size(163, 34)
        btn_deleteAll.TabIndex = 26
        btn_deleteAll.Text = "Delete All Records"
        btn_deleteAll.UseVisualStyleBackColor = True
        ' 
        ' radiobtn_bsit
        ' 
        radiobtn_bsit.AutoSize = True
        radiobtn_bsit.Location = New Point(630, 40)
        radiobtn_bsit.Name = "radiobtn_bsit"
        radiobtn_bsit.Size = New Size(71, 29)
        radiobtn_bsit.TabIndex = 25
        radiobtn_bsit.Text = "BSIT"
        radiobtn_bsit.UseVisualStyleBackColor = True
        ' 
        ' radiobtn_bscs
        ' 
        radiobtn_bscs.AutoSize = True
        radiobtn_bscs.Location = New Point(518, 43)
        radiobtn_bscs.Name = "radiobtn_bscs"
        radiobtn_bscs.Size = New Size(78, 29)
        radiobtn_bscs.TabIndex = 24
        radiobtn_bscs.Text = "BSCS"
        radiobtn_bscs.UseVisualStyleBackColor = True
        ' 
        ' lv_info
        ' 
        lv_info.Columns.AddRange(New ColumnHeader() {id, studentID, course, fname, lname, age, year})
        lv_info.FullRowSelect = True
        lv_info.GridLines = True
        lv_info.Location = New Point(38, 275)
        lv_info.Name = "lv_info"
        lv_info.Size = New Size(705, 324)
        lv_info.TabIndex = 16
        lv_info.UseCompatibleStateImageBehavior = False
        lv_info.View = View.Details
        ' 
        ' id
        ' 
        id.Text = "ID"
        id.Width = 40
        ' 
        ' studentID
        ' 
        studentID.Text = "Student ID"
        studentID.Width = 100
        ' 
        ' course
        ' 
        course.Text = "Course"
        course.Width = 100
        ' 
        ' fname
        ' 
        fname.Text = "First Name"
        fname.Width = 150
        ' 
        ' lname
        ' 
        lname.Text = "Last Name"
        lname.Width = 150
        ' 
        ' age
        ' 
        age.Text = "Age"
        age.Width = 80
        ' 
        ' year
        ' 
        year.Text = "Year"
        year.Width = 100
        ' 
        ' txt_year
        ' 
        txt_year.Location = New Point(518, 134)
        txt_year.Name = "txt_year"
        txt_year.Size = New Size(225, 31)
        txt_year.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(457, 134)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 25)
        Label6.TabIndex = 14
        Label6.Text = "Year:"
        ' 
        ' txt_age
        ' 
        txt_age.Location = New Point(136, 131)
        txt_age.Name = "txt_age"
        txt_age.Size = New Size(225, 31)
        txt_age.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(82, 134)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 25)
        Label5.TabIndex = 12
        Label5.Text = "Age:"
        ' 
        ' btn_delete
        ' 
        btn_delete.Location = New Point(630, 183)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(112, 34)
        btn_delete.TabIndex = 10
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' btn_edit
        ' 
        btn_edit.Location = New Point(512, 183)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(112, 34)
        btn_edit.TabIndex = 9
        btn_edit.Text = "Update"
        btn_edit.UseVisualStyleBackColor = True
        ' 
        ' btn_add
        ' 
        btn_add.Location = New Point(394, 183)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(112, 34)
        btn_add.TabIndex = 8
        btn_add.Text = "Add"
        btn_add.UseVisualStyleBackColor = True
        ' 
        ' txt_lname
        ' 
        txt_lname.Location = New Point(518, 84)
        txt_lname.Name = "txt_lname"
        txt_lname.Size = New Size(225, 31)
        txt_lname.TabIndex = 6
        ' 
        ' txt_fname
        ' 
        txt_fname.Location = New Point(136, 81)
        txt_fname.Name = "txt_fname"
        txt_fname.Size = New Size(225, 31)
        txt_fname.TabIndex = 5
        ' 
        ' txt_studentID
        ' 
        txt_studentID.Location = New Point(136, 37)
        txt_studentID.Name = "txt_studentID"
        txt_studentID.Size = New Size(225, 31)
        txt_studentID.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(435, 43)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 25)
        Label4.TabIndex = 3
        Label4.Text = "Course:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(407, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 25)
        Label3.TabIndex = 2
        Label3.Text = "Last Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 25)
        Label2.TabIndex = 1
        Label2.Text = "First Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 25)
        Label1.TabIndex = 0
        Label1.Text = "Student ID:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 702)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        Text = "Student Information"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents txt_studentID As TextBox
    Friend WithEvents txt_year As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_age As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents lv_info As ListView
    Friend WithEvents studentID As ColumnHeader
    Friend WithEvents fname As ColumnHeader
    Friend WithEvents lname As ColumnHeader
    Friend WithEvents age As ColumnHeader
    Friend WithEvents year As ColumnHeader
    Friend WithEvents course As ColumnHeader
    Friend WithEvents radiobtn_bscs As RadioButton
    Friend WithEvents radiobtn_bsit As RadioButton
    Friend WithEvents btn_clearContent As Button
    Friend WithEvents btn_deleteAll As Button
    Friend WithEvents id As ColumnHeader
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cb_category As ComboBox
    Friend WithEvents Label8 As Label
End Class
