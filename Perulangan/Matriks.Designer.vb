<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matriks
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
        Me.Lbl_matrik1 = New System.Windows.Forms.Label()
        Me.t_m1 = New System.Windows.Forms.TextBox()
        Me.Lbl_operasi = New System.Windows.Forms.Label()
        Me.c_operasi = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.t_m2 = New System.Windows.Forms.TextBox()
        Me.t_h = New System.Windows.Forms.TextBox()
        Me.Lbl_hasil = New System.Windows.Forms.Label()
        Me.b_proses = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.b_exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_matrik1
        '
        Me.Lbl_matrik1.AutoSize = True
        Me.Lbl_matrik1.Location = New System.Drawing.Point(13, 23)
        Me.Lbl_matrik1.Name = "Lbl_matrik1"
        Me.Lbl_matrik1.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_matrik1.TabIndex = 0
        Me.Lbl_matrik1.Text = "Matrik1"
        '
        't_m1
        '
        Me.t_m1.Location = New System.Drawing.Point(61, 20)
        Me.t_m1.Multiline = True
        Me.t_m1.Name = "t_m1"
        Me.t_m1.Size = New System.Drawing.Size(368, 76)
        Me.t_m1.TabIndex = 1
        '
        'Lbl_operasi
        '
        Me.Lbl_operasi.AutoSize = True
        Me.Lbl_operasi.Location = New System.Drawing.Point(12, 121)
        Me.Lbl_operasi.Name = "Lbl_operasi"
        Me.Lbl_operasi.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_operasi.TabIndex = 2
        Me.Lbl_operasi.Text = "Operasi"
        '
        'c_operasi
        '
        Me.c_operasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.c_operasi.FormattingEnabled = True
        Me.c_operasi.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.c_operasi.Location = New System.Drawing.Point(61, 118)
        Me.c_operasi.Name = "c_operasi"
        Me.c_operasi.Size = New System.Drawing.Size(368, 21)
        Me.c_operasi.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Matrik 2"
        '
        't_m2
        '
        Me.t_m2.Location = New System.Drawing.Point(61, 165)
        Me.t_m2.Multiline = True
        Me.t_m2.Name = "t_m2"
        Me.t_m2.Size = New System.Drawing.Size(368, 76)
        Me.t_m2.TabIndex = 5
        '
        't_h
        '
        Me.t_h.Location = New System.Drawing.Point(61, 260)
        Me.t_h.Multiline = True
        Me.t_h.Name = "t_h"
        Me.t_h.Size = New System.Drawing.Size(368, 76)
        Me.t_h.TabIndex = 6
        '
        'Lbl_hasil
        '
        Me.Lbl_hasil.AutoSize = True
        Me.Lbl_hasil.Location = New System.Drawing.Point(12, 263)
        Me.Lbl_hasil.Name = "Lbl_hasil"
        Me.Lbl_hasil.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_hasil.TabIndex = 7
        Me.Lbl_hasil.Text = "Hasil"
        '
        'b_proses
        '
        Me.b_proses.Location = New System.Drawing.Point(307, 351)
        Me.b_proses.Name = "b_proses"
        Me.b_proses.Size = New System.Drawing.Size(122, 23)
        Me.b_proses.TabIndex = 8
        Me.b_proses.Text = "Proses"
        Me.b_proses.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(186, 351)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(100, 23)
        Me.clear.TabIndex = 9
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'b_exit
        '
        Me.b_exit.Location = New System.Drawing.Point(61, 351)
        Me.b_exit.Name = "b_exit"
        Me.b_exit.Size = New System.Drawing.Size(100, 23)
        Me.b_exit.TabIndex = 10
        Me.b_exit.Text = "Exit"
        Me.b_exit.UseVisualStyleBackColor = True
        '
        'Matriks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.b_exit)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.b_proses)
        Me.Controls.Add(Me.Lbl_hasil)
        Me.Controls.Add(Me.t_h)
        Me.Controls.Add(Me.t_m2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c_operasi)
        Me.Controls.Add(Me.Lbl_operasi)
        Me.Controls.Add(Me.t_m1)
        Me.Controls.Add(Me.Lbl_matrik1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Matriks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_matrik1 As System.Windows.Forms.Label
    Friend WithEvents t_m1 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_operasi As System.Windows.Forms.Label
    Friend WithEvents c_operasi As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents t_m2 As System.Windows.Forms.TextBox
    Friend WithEvents t_h As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_hasil As System.Windows.Forms.Label
    Friend WithEvents b_proses As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents b_exit As System.Windows.Forms.Button
End Class
