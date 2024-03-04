<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_find = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_mail_valid = New System.Windows.Forms.Label()
        Me.lbl_class_valid = New System.Windows.Forms.Label()
        Me.lbl_name_valid = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.txt_class = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_find2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btn_finish = New System.Windows.Forms.Button()
        Me.btn_delete2 = New System.Windows.Forms.Button()
        Me.btn_update2 = New System.Windows.Forms.Button()
        Me.btn_save2 = New System.Windows.Forms.Button()
        Me.btn_new2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_q_valid = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_d_valid = New System.Windows.Forms.Label()
        Me.lbl_c_valid = New System.Windows.Forms.Label()
        Me.lbl_b_valid = New System.Windows.Forms.Label()
        Me.lbl_a_valid = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_answer = New System.Windows.Forms.ComboBox()
        Me.txt_d = New System.Windows.Forms.TextBox()
        Me.txt_c = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_b = New System.Windows.Forms.TextBox()
        Me.txt_a = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_question = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_student = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_body = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.txt_to = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(7, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(699, 417)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(691, 391)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Student Data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_delete)
        Me.Panel2.Controls.Add(Me.btn_update)
        Me.Panel2.Controls.Add(Me.btn_find)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.btn_new)
        Me.Panel2.Location = New System.Drawing.Point(548, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(133, 378)
        Me.Panel2.TabIndex = 1
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_delete.Location = New System.Drawing.Point(25, 318)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(84, 30)
        Me.btn_delete.TabIndex = 4
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_update.Location = New System.Drawing.Point(25, 244)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(84, 30)
        Me.btn_update.TabIndex = 3
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_find
        '
        Me.btn_find.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_find.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_find.Location = New System.Drawing.Point(25, 169)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(84, 30)
        Me.btn_find.TabIndex = 2
        Me.btn_find.Text = "Find"
        Me.btn_find.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_save.Location = New System.Drawing.Point(25, 96)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(84, 30)
        Me.btn_save.TabIndex = 1
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_new.Location = New System.Drawing.Point(25, 15)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(84, 30)
        Me.btn_new.TabIndex = 0
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_mail_valid)
        Me.Panel1.Controls.Add(Me.lbl_class_valid)
        Me.Panel1.Controls.Add(Me.lbl_name_valid)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.txt_mail)
        Me.Panel1.Controls.Add(Me.txt_class)
        Me.Panel1.Controls.Add(Me.txt_name)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(7, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(535, 381)
        Me.Panel1.TabIndex = 0
        '
        'lbl_mail_valid
        '
        Me.lbl_mail_valid.AutoSize = True
        Me.lbl_mail_valid.ForeColor = System.Drawing.Color.Red
        Me.lbl_mail_valid.Location = New System.Drawing.Point(467, 87)
        Me.lbl_mail_valid.Name = "lbl_mail_valid"
        Me.lbl_mail_valid.Size = New System.Drawing.Size(50, 13)
        Me.lbl_mail_valid.TabIndex = 9
        Me.lbl_mail_valid.Text = "Required"
        Me.lbl_mail_valid.Visible = False
        '
        'lbl_class_valid
        '
        Me.lbl_class_valid.AutoSize = True
        Me.lbl_class_valid.ForeColor = System.Drawing.Color.Red
        Me.lbl_class_valid.Location = New System.Drawing.Point(467, 48)
        Me.lbl_class_valid.Name = "lbl_class_valid"
        Me.lbl_class_valid.Size = New System.Drawing.Size(50, 13)
        Me.lbl_class_valid.TabIndex = 8
        Me.lbl_class_valid.Text = "Required"
        Me.lbl_class_valid.Visible = False
        '
        'lbl_name_valid
        '
        Me.lbl_name_valid.AutoSize = True
        Me.lbl_name_valid.ForeColor = System.Drawing.Color.Red
        Me.lbl_name_valid.Location = New System.Drawing.Point(349, 15)
        Me.lbl_name_valid.Name = "lbl_name_valid"
        Me.lbl_name_valid.Size = New System.Drawing.Size(102, 13)
        Me.lbl_name_valid.TabIndex = 7
        Me.lbl_name_valid.Text = "Enter student name"
        Me.lbl_name_valid.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 111)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(529, 267)
        Me.DataGridView1.TabIndex = 6
        '
        'txt_mail
        '
        Me.txt_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mail.Location = New System.Drawing.Point(120, 85)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(331, 20)
        Me.txt_mail.TabIndex = 5
        '
        'txt_class
        '
        Me.txt_class.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_class.Location = New System.Drawing.Point(120, 46)
        Me.txt_class.Name = "txt_class"
        Me.txt_class.Size = New System.Drawing.Size(331, 20)
        Me.txt_class.TabIndex = 4
        '
        'txt_name
        '
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_name.Location = New System.Drawing.Point(120, 10)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(223, 20)
        Me.txt_name.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(59, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "E-mail :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(65, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Class :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Name :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_find2)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.btn_finish)
        Me.TabPage2.Controls.Add(Me.btn_delete2)
        Me.TabPage2.Controls.Add(Me.btn_update2)
        Me.TabPage2.Controls.Add(Me.btn_save2)
        Me.TabPage2.Controls.Add(Me.btn_new2)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(691, 391)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Questions"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_find2
        '
        Me.btn_find2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_find2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_find2.Location = New System.Drawing.Point(239, 347)
        Me.btn_find2.Name = "btn_find2"
        Me.btn_find2.Size = New System.Drawing.Size(84, 30)
        Me.btn_find2.TabIndex = 12
        Me.btn_find2.Text = "Find"
        Me.btn_find2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(431, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(251, 324)
        Me.DataGridView2.TabIndex = 11
        '
        'btn_finish
        '
        Me.btn_finish.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finish.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_finish.Location = New System.Drawing.Point(595, 347)
        Me.btn_finish.Name = "btn_finish"
        Me.btn_finish.Size = New System.Drawing.Size(84, 30)
        Me.btn_finish.TabIndex = 10
        Me.btn_finish.Text = "Finish"
        Me.btn_finish.UseVisualStyleBackColor = True
        '
        'btn_delete2
        '
        Me.btn_delete2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_delete2.Location = New System.Drawing.Point(474, 346)
        Me.btn_delete2.Name = "btn_delete2"
        Me.btn_delete2.Size = New System.Drawing.Size(84, 30)
        Me.btn_delete2.TabIndex = 9
        Me.btn_delete2.Text = "Delete"
        Me.btn_delete2.UseVisualStyleBackColor = True
        '
        'btn_update2
        '
        Me.btn_update2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_update2.Location = New System.Drawing.Point(359, 346)
        Me.btn_update2.Name = "btn_update2"
        Me.btn_update2.Size = New System.Drawing.Size(84, 30)
        Me.btn_update2.TabIndex = 8
        Me.btn_update2.Text = "Update"
        Me.btn_update2.UseVisualStyleBackColor = True
        '
        'btn_save2
        '
        Me.btn_save2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_save2.Location = New System.Drawing.Point(130, 348)
        Me.btn_save2.Name = "btn_save2"
        Me.btn_save2.Size = New System.Drawing.Size(84, 30)
        Me.btn_save2.TabIndex = 6
        Me.btn_save2.Text = "Save"
        Me.btn_save2.UseVisualStyleBackColor = True
        '
        'btn_new2
        '
        Me.btn_new2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_new2.Location = New System.Drawing.Point(15, 346)
        Me.btn_new2.Name = "btn_new2"
        Me.btn_new2.Size = New System.Drawing.Size(84, 30)
        Me.btn_new2.TabIndex = 5
        Me.btn_new2.Text = "New"
        Me.btn_new2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lbl_q_valid)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.txt_question)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(4, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(421, 327)
        Me.Panel3.TabIndex = 1
        '
        'lbl_q_valid
        '
        Me.lbl_q_valid.AutoSize = True
        Me.lbl_q_valid.ForeColor = System.Drawing.Color.Red
        Me.lbl_q_valid.Location = New System.Drawing.Point(104, 10)
        Me.lbl_q_valid.Name = "lbl_q_valid"
        Me.lbl_q_valid.Size = New System.Drawing.Size(106, 13)
        Me.lbl_q_valid.TabIndex = 9
        Me.lbl_q_valid.Text = "Enter question name"
        Me.lbl_q_valid.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_d_valid)
        Me.GroupBox1.Controls.Add(Me.lbl_c_valid)
        Me.GroupBox1.Controls.Add(Me.lbl_b_valid)
        Me.GroupBox1.Controls.Add(Me.lbl_a_valid)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmb_answer)
        Me.GroupBox1.Controls.Add(Me.txt_d)
        Me.GroupBox1.Controls.Add(Me.txt_c)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_b)
        Me.GroupBox1.Controls.Add(Me.txt_a)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 237)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Answers"
        '
        'lbl_d_valid
        '
        Me.lbl_d_valid.AutoSize = True
        Me.lbl_d_valid.ForeColor = System.Drawing.Color.Red
        Me.lbl_d_valid.Location = New System.Drawing.Point(349, 160)
        Me.lbl_d_valid.Name = "lbl_d_valid"
        Me.lbl_d_valid.Size = New System.Drawing.Size(50, 13)
        Me.lbl_d_valid.TabIndex = 19
        Me.lbl_d_valid.Text = "Required"
        Me.lbl_d_valid.Visible = False
        '
        'lbl_c_valid
        '
        Me.lbl_c_valid.AutoSize = True
        Me.lbl_c_valid.ForeColor = System.Drawing.Color.Red
        Me.lbl_c_valid.Location = New System.Drawing.Point(345, 120)
        Me.lbl_c_valid.Name = "lbl_c_valid"
        Me.lbl_c_valid.Size = New System.Drawing.Size(50, 13)
        Me.lbl_c_valid.TabIndex = 18
        Me.lbl_c_valid.Text = "Required"
        Me.lbl_c_valid.Visible = False
        '
        'lbl_b_valid
        '
        Me.lbl_b_valid.AutoSize = True
        Me.lbl_b_valid.ForeColor = System.Drawing.Color.Red
        Me.lbl_b_valid.Location = New System.Drawing.Point(346, 74)
        Me.lbl_b_valid.Name = "lbl_b_valid"
        Me.lbl_b_valid.Size = New System.Drawing.Size(50, 13)
        Me.lbl_b_valid.TabIndex = 17
        Me.lbl_b_valid.Text = "Required"
        Me.lbl_b_valid.Visible = False
        '
        'lbl_a_valid
        '
        Me.lbl_a_valid.AutoSize = True
        Me.lbl_a_valid.ForeColor = System.Drawing.Color.Red
        Me.lbl_a_valid.Location = New System.Drawing.Point(345, 28)
        Me.lbl_a_valid.Name = "lbl_a_valid"
        Me.lbl_a_valid.Size = New System.Drawing.Size(50, 13)
        Me.lbl_a_valid.TabIndex = 16
        Me.lbl_a_valid.Text = "Required"
        Me.lbl_a_valid.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(34, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 19)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Answer :"
        '
        'cmb_answer
        '
        Me.cmb_answer.FormattingEnabled = True
        Me.cmb_answer.Items.AddRange(New Object() {"a", "b", "c", "d"})
        Me.cmb_answer.Location = New System.Drawing.Point(99, 198)
        Me.cmb_answer.Name = "cmb_answer"
        Me.cmb_answer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmb_answer.Size = New System.Drawing.Size(235, 21)
        Me.cmb_answer.TabIndex = 14
        '
        'txt_d
        '
        Me.txt_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_d.Location = New System.Drawing.Point(37, 154)
        Me.txt_d.Name = "txt_d"
        Me.txt_d.Size = New System.Drawing.Size(306, 20)
        Me.txt_d.TabIndex = 13
        '
        'txt_c
        '
        Me.txt_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_c.Location = New System.Drawing.Point(37, 113)
        Me.txt_c.Name = "txt_c"
        Me.txt_c.Size = New System.Drawing.Size(306, 20)
        Me.txt_c.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(3, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "D :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(3, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 19)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "C :"
        '
        'txt_b
        '
        Me.txt_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_b.Location = New System.Drawing.Point(37, 67)
        Me.txt_b.Name = "txt_b"
        Me.txt_b.Size = New System.Drawing.Size(306, 20)
        Me.txt_b.TabIndex = 9
        '
        'txt_a
        '
        Me.txt_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_a.Location = New System.Drawing.Point(39, 25)
        Me.txt_a.Name = "txt_a"
        Me.txt_a.Size = New System.Drawing.Size(306, 20)
        Me.txt_a.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(4, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 19)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "B :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(5, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "A :"
        '
        'txt_question
        '
        Me.txt_question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_question.Location = New System.Drawing.Point(15, 34)
        Me.txt_question.Multiline = True
        Me.txt_question.Name = "txt_question"
        Me.txt_question.Size = New System.Drawing.Size(391, 45)
        Me.txt_question.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(11, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 19)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Question :"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btn_send)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.cmb_student)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(691, 391)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Send Test"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btn_send
        '
        Me.btn_send.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_send.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_send.Location = New System.Drawing.Point(263, 334)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(146, 39)
        Me.btn_send.TabIndex = 18
        Me.btn_send.Text = "Send"
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(115, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 19)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Student :"
        '
        'cmb_student
        '
        Me.cmb_student.FormattingEnabled = True
        Me.cmb_student.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cmb_student.Location = New System.Drawing.Point(186, 26)
        Me.cmb_student.Name = "cmb_student"
        Me.cmb_student.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmb_student.Size = New System.Drawing.Size(305, 21)
        Me.cmb_student.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_body)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt_title)
        Me.GroupBox2.Controls.Add(Me.txt_to)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(648, 264)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Answers"
        '
        'txt_body
        '
        Me.txt_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_body.Location = New System.Drawing.Point(79, 89)
        Me.txt_body.Multiline = True
        Me.txt_body.Name = "txt_body"
        Me.txt_body.Size = New System.Drawing.Size(538, 158)
        Me.txt_body.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(24, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 19)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Body :"
        '
        'txt_title
        '
        Me.txt_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_title.Location = New System.Drawing.Point(79, 57)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(538, 20)
        Me.txt_title.TabIndex = 9
        '
        'txt_to
        '
        Me.txt_to.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_to.Location = New System.Drawing.Point(79, 18)
        Me.txt_to.Name = "txt_to"
        Me.txt_to.Size = New System.Drawing.Size(538, 20)
        Me.txt_to.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(29, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 19)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Title :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(37, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 19)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "To :"
        '
        'TeacherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 423)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "TeacherForm"
        Me.Text = "TeacherForm"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_find As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_name_valid As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents txt_class As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btn_find2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_finish As System.Windows.Forms.Button
    Friend WithEvents btn_delete2 As System.Windows.Forms.Button
    Friend WithEvents btn_update2 As System.Windows.Forms.Button
    Friend WithEvents btn_save2 As System.Windows.Forms.Button
    Friend WithEvents btn_new2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_q_valid As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_answer As System.Windows.Forms.ComboBox
    Friend WithEvents txt_d As System.Windows.Forms.TextBox
    Friend WithEvents txt_c As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_b As System.Windows.Forms.TextBox
    Friend WithEvents txt_a As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_question As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btn_send As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmb_student As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_body As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_title As System.Windows.Forms.TextBox
    Friend WithEvents txt_to As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbl_class_valid As System.Windows.Forms.Label
    Friend WithEvents lbl_mail_valid As System.Windows.Forms.Label
    Friend WithEvents lbl_a_valid As System.Windows.Forms.Label
    Friend WithEvents lbl_d_valid As System.Windows.Forms.Label
    Friend WithEvents lbl_c_valid As System.Windows.Forms.Label
    Friend WithEvents lbl_b_valid As System.Windows.Forms.Label
End Class
