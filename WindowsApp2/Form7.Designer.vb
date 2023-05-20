<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Advisers
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HeadName = New System.Windows.Forms.TextBox()
        Me.HeadID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Adviser"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Adviser ID"
        '
        'HeadName
        '
        Me.HeadName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeadName.Location = New System.Drawing.Point(62, 230)
        Me.HeadName.Multiline = True
        Me.HeadName.Name = "HeadName"
        Me.HeadName.Size = New System.Drawing.Size(256, 38)
        Me.HeadName.TabIndex = 36
        '
        'HeadID
        '
        Me.HeadID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeadID.Location = New System.Drawing.Point(45, 138)
        Me.HeadID.Multiline = True
        Me.HeadID.Name = "HeadID"
        Me.HeadID.Size = New System.Drawing.Size(86, 38)
        Me.HeadID.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.SeaShell
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(147, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 26)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "ADVISER"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.PictureBox1.Location = New System.Drawing.Point(381, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(426, 516)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SeaShell
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(486, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 26)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "LIST OF ADVISERS"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(408, 182)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(367, 261)
        Me.DataGridView1.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(517, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Load Advisers"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Orange
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(250, 336)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 54)
        Me.Button4.TabIndex = 65
        Me.Button4.Text = "Delete Adviser"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Orange
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(128, 336)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 54)
        Me.Button2.TabIndex = 64
        Me.Button2.Text = "Update Adviser"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Orange
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(7, 336)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(115, 54)
        Me.Button5.TabIndex = 63
        Me.Button5.Text = "Add Adviser"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Button6.ForeColor = System.Drawing.Color.Peru
        Me.Button6.Location = New System.Drawing.Point(592, 122)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(115, 54)
        Me.Button6.TabIndex = 62
        Me.Button6.Text = "Search Adviser"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(481, 132)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(105, 28)
        Me.search.TabIndex = 61
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Button3.ForeColor = System.Drawing.Color.Peru
        Me.Button3.Location = New System.Drawing.Point(471, 449)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 54)
        Me.Button3.TabIndex = 66
        Me.Button3.Text = "Upload Data"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Button7.ForeColor = System.Drawing.Color.Peru
        Me.Button7.Location = New System.Drawing.Point(605, 449)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(115, 54)
        Me.Button7.TabIndex = 68
        Me.Button7.Text = "Print"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SeaShell
        Me.Label5.Location = New System.Drawing.Point(42, 412)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(291, 68)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Note: For the Update Button enter the ID you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " want to update and provide the upd" &
    "ated" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Adviser.  For Delete just enter the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Adviser ID in the text box above and" &
    " execute." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(504, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Enter ID"
        '
        'Advisers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(800, 513)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HeadName)
        Me.Controls.Add(Me.HeadID)
        Me.Controls.Add(Me.Label12)
        Me.Name = "Advisers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HeadName As TextBox
    Friend WithEvents HeadID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents search As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
