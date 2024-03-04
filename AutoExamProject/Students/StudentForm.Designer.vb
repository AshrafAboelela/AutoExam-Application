<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Me.components = New System.ComponentModel.Container()
        Me.btn_finish = New System.Windows.Forms.Button()
        Me.lbl_timer = New System.Windows.Forms.Label()
        Me.btn_previous = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.Radio_d = New System.Windows.Forms.RadioButton()
        Me.Radio_c = New System.Windows.Forms.RadioButton()
        Me.Radio_b = New System.Windows.Forms.RadioButton()
        Me.Radio_a = New System.Windows.Forms.RadioButton()
        Me.txt_q = New System.Windows.Forms.TextBox()
        Me.btn_opentest = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_showresult = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_finish
        '
        Me.btn_finish.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finish.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_finish.Location = New System.Drawing.Point(231, 207)
        Me.btn_finish.Name = "btn_finish"
        Me.btn_finish.Size = New System.Drawing.Size(88, 30)
        Me.btn_finish.TabIndex = 26
        Me.btn_finish.Text = "Finish"
        Me.btn_finish.UseVisualStyleBackColor = True
        '
        'lbl_timer
        '
        Me.lbl_timer.AutoSize = True
        Me.lbl_timer.Location = New System.Drawing.Point(245, 102)
        Me.lbl_timer.Name = "lbl_timer"
        Me.lbl_timer.Size = New System.Drawing.Size(31, 13)
        Me.lbl_timer.TabIndex = 25
        Me.lbl_timer.Text = "0000"
        '
        'btn_previous
        '
        Me.btn_previous.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_previous.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_previous.Location = New System.Drawing.Point(23, 207)
        Me.btn_previous.Name = "btn_previous"
        Me.btn_previous.Size = New System.Drawing.Size(88, 30)
        Me.btn_previous.TabIndex = 24
        Me.btn_previous.Text = "Previous"
        Me.btn_previous.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_next.Location = New System.Drawing.Point(127, 207)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(88, 30)
        Me.btn_next.TabIndex = 23
        Me.btn_next.Text = "Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'Radio_d
        '
        Me.Radio_d.AutoSize = True
        Me.Radio_d.Location = New System.Drawing.Point(21, 171)
        Me.Radio_d.Name = "Radio_d"
        Me.Radio_d.Size = New System.Drawing.Size(90, 17)
        Me.Radio_d.TabIndex = 22
        Me.Radio_d.TabStop = True
        Me.Radio_d.Text = "RadioButton1"
        Me.Radio_d.UseVisualStyleBackColor = True
        '
        'Radio_c
        '
        Me.Radio_c.AutoSize = True
        Me.Radio_c.Location = New System.Drawing.Point(21, 148)
        Me.Radio_c.Name = "Radio_c"
        Me.Radio_c.Size = New System.Drawing.Size(90, 17)
        Me.Radio_c.TabIndex = 21
        Me.Radio_c.TabStop = True
        Me.Radio_c.Text = "RadioButton1"
        Me.Radio_c.UseVisualStyleBackColor = True
        '
        'Radio_b
        '
        Me.Radio_b.AutoSize = True
        Me.Radio_b.Location = New System.Drawing.Point(21, 125)
        Me.Radio_b.Name = "Radio_b"
        Me.Radio_b.Size = New System.Drawing.Size(90, 17)
        Me.Radio_b.TabIndex = 20
        Me.Radio_b.TabStop = True
        Me.Radio_b.Text = "RadioButton1"
        Me.Radio_b.UseVisualStyleBackColor = True
        '
        'Radio_a
        '
        Me.Radio_a.AutoSize = True
        Me.Radio_a.Location = New System.Drawing.Point(21, 102)
        Me.Radio_a.Name = "Radio_a"
        Me.Radio_a.Size = New System.Drawing.Size(90, 17)
        Me.Radio_a.TabIndex = 19
        Me.Radio_a.TabStop = True
        Me.Radio_a.Text = "RadioButton1"
        Me.Radio_a.UseVisualStyleBackColor = True
        '
        'txt_q
        '
        Me.txt_q.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_q.Location = New System.Drawing.Point(8, 58)
        Me.txt_q.Multiline = True
        Me.txt_q.Name = "txt_q"
        Me.txt_q.Size = New System.Drawing.Size(430, 38)
        Me.txt_q.TabIndex = 18
        '
        'btn_opentest
        '
        Me.btn_opentest.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_opentest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_opentest.Location = New System.Drawing.Point(173, 12)
        Me.btn_opentest.Name = "btn_opentest"
        Me.btn_opentest.Size = New System.Drawing.Size(103, 30)
        Me.btn_opentest.TabIndex = 17
        Me.btn_opentest.Text = "Open Test"
        Me.btn_opentest.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_showresult
        '
        Me.btn_showresult.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_showresult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_showresult.Location = New System.Drawing.Point(335, 206)
        Me.btn_showresult.Name = "btn_showresult"
        Me.btn_showresult.Size = New System.Drawing.Size(113, 30)
        Me.btn_showresult.TabIndex = 27
        Me.btn_showresult.Text = "Show Result"
        Me.btn_showresult.UseVisualStyleBackColor = True
        '
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 245)
        Me.Controls.Add(Me.btn_showresult)
        Me.Controls.Add(Me.btn_finish)
        Me.Controls.Add(Me.lbl_timer)
        Me.Controls.Add(Me.btn_previous)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.Radio_d)
        Me.Controls.Add(Me.Radio_c)
        Me.Controls.Add(Me.Radio_b)
        Me.Controls.Add(Me.Radio_a)
        Me.Controls.Add(Me.txt_q)
        Me.Controls.Add(Me.btn_opentest)
        Me.Name = "StudentForm"
        Me.Text = "StudentForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_finish As System.Windows.Forms.Button
    Friend WithEvents lbl_timer As System.Windows.Forms.Label
    Friend WithEvents btn_previous As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents Radio_d As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_c As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_b As System.Windows.Forms.RadioButton
    Friend WithEvents Radio_a As System.Windows.Forms.RadioButton
    Friend WithEvents txt_q As System.Windows.Forms.TextBox
    Friend WithEvents btn_opentest As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_showresult As System.Windows.Forms.Button

End Class
