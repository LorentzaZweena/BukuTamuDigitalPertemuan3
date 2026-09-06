<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        TextBoxNama = New TextBox()
        Label3 = New Label()
        TextBoxInstansi = New TextBox()
        MaskedTextBox1 = New MaskedTextBox()
        Label4 = New Label()
        NumericUpDown1 = New NumericUpDown()
        Label5 = New Label()
        ListView1 = New ListView()
        Label6 = New Label()
        TreeView1 = New TreeView()
        Label7 = New Label()
        RichTextBox1 = New RichTextBox()
        Label8 = New Label()
        LinkLabel1 = New LinkLabel()
        ButtonSimpan = New Button()
        TextBox1 = New TextBox()
        Label9 = New Label()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(45, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(330, 36)
        Label1.TabIndex = 0
        Label1.Text = "BUKU TAMU DIGITAL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Location = New Point(140, 89)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.Size = New Size(306, 31)
        TextBoxNama.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(45, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 25)
        Label3.TabIndex = 3
        Label3.Text = "Instansi"
        ' 
        ' TextBoxInstansi
        ' 
        TextBoxInstansi.Location = New Point(140, 157)
        TextBoxInstansi.Name = "TextBoxInstansi"
        TextBoxInstansi.Size = New Size(306, 31)
        TextBoxInstansi.TabIndex = 4
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(213, 222)
        MaskedTextBox1.Mask = "00/00/0000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(233, 31)
        MaskedTextBox1.TabIndex = 5
        MaskedTextBox1.ValidatingType = GetType(Date)
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(45, 222)
        Label4.Name = "Label4"
        Label4.Size = New Size(162, 25)
        Label4.TabIndex = 6
        Label4.Text = "Tanggal Kunjungan"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(170, 276)
        NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(276, 31)
        NumericUpDown1.TabIndex = 7
        NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(45, 278)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 25)
        Label5.TabIndex = 8
        Label5.Text = "Jumlah orang"
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(168, 337)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(278, 146)
        ListView1.TabIndex = 9
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(45, 337)
        Label6.Name = "Label6"
        Label6.Size = New Size(95, 25)
        Label6.TabIndex = 10
        Label6.Text = "Jenis tamu"
        ' 
        ' TreeView1
        ' 
        TreeView1.Location = New Point(655, 89)
        TreeView1.Name = "TreeView1"
        TreeView1.Size = New Size(243, 146)
        TreeView1.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(485, 89)
        Label7.Name = "Label7"
        Label7.Size = New Size(152, 25)
        Label7.TabIndex = 12
        Label7.Text = "Tujuan kunjungan"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(655, 259)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(243, 144)
        RichTextBox1.TabIndex = 13
        RichTextBox1.Text = ""
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(485, 262)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 25)
        Label8.TabIndex = 14
        Label8.Text = "Pesan"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(485, 433)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(94, 25)
        LinkLabel1.TabIndex = 15
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "LinkLabel1"
        ' 
        ' ButtonSimpan
        ' 
        ButtonSimpan.Location = New Point(655, 433)
        ButtonSimpan.Name = "ButtonSimpan"
        ButtonSimpan.Size = New Size(153, 34)
        ButtonSimpan.TabIndex = 16
        ButtonSimpan.Text = "Simpan data"
        ButtonSimpan.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(213, 538)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(685, 77)
        TextBox1.TabIndex = 17
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(45, 538)
        Label9.Name = "Label9"
        Label9.Size = New Size(161, 25)
        Label9.TabIndex = 18
        Label9.Text = "Riwayat kunjungan"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1077, 654)
        Controls.Add(Label9)
        Controls.Add(TextBox1)
        Controls.Add(ButtonSimpan)
        Controls.Add(LinkLabel1)
        Controls.Add(Label8)
        Controls.Add(RichTextBox1)
        Controls.Add(Label7)
        Controls.Add(TreeView1)
        Controls.Add(Label6)
        Controls.Add(ListView1)
        Controls.Add(Label5)
        Controls.Add(NumericUpDown1)
        Controls.Add(Label4)
        Controls.Add(MaskedTextBox1)
        Controls.Add(TextBoxInstansi)
        Controls.Add(Label3)
        Controls.Add(TextBoxNama)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxInstansi As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label6 As Label
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Label7 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ButtonSimpan As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label

End Class
