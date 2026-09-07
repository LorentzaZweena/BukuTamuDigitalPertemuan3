Public Class Form1
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListView1.View = View.Details
        ListView1.Columns.Add("Jenis Tamu", 150)

        ListView1.Items.Add("Orang Tua")
        ListView1.Items.Add("Tamu Dinas")
        ListView1.Items.Add("Alumni")


        TreeView1.Nodes.Add("Sekolah")
        TreeView1.Nodes(0).Nodes.Add("Kepala Sekolah")
        TreeView1.Nodes(0).Nodes.Add("Tata Usaha")


        MaskedTextBox1.Mask = "00/00/0000"

        NumericUpDown1.Minimum = 1
        NumericUpDown1.Maximum = 10

        LinkLabel1.Text = "Website Kampus"
        LinkLabel1.Links.Add(0, 14, "https://tik.pnj.ac.id/")

        TextBox1.Multiline = True
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Text = "Riwayat kunjungan:"
    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        Dim nama = TextBoxNama.Text
        Dim instansi = TextBoxInstansi.Text
        Dim tanggal = MaskedTextBox1.Text
        Dim jumlah = NumericUpDown1.Value
        Dim pesan = RichTextBox1.Text

        Dim jenisTamu = If(ListView1.SelectedItems.Count > 0,
                           ListView1.SelectedItems(0).Text, "")

        Dim tujuan = If(TreeView1.SelectedNode IsNot Nothing,
                        TreeView1.SelectedNode.Text, "")

        Dim ringkasan = $"Nama: {nama}" & vbCrLf &
                        $"Instansi: {instansi}" & vbCrLf &
                        $"Tanggal: {tanggal}" & vbCrLf &
                        $"Jenis Tamu: {jenisTamu}" & vbCrLf &
                        $"Tujuan: {tujuan}" & vbCrLf &
                        $"Jumlah Orang: {jumlah}" & vbCrLf &
                        $"Pesan: {pesan}"

        TextBox1.AppendText(vbCrLf & "---" & vbCrLf & ringkasan)

        MessageBox.Show("Data buku tamu telah disimpan.")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim psi As New System.Diagnostics.ProcessStartInfo With {
        .FileName = e.Link.LinkData.ToString(),
        .UseShellExecute = True
    }

        System.Diagnostics.Process.Start(psi)
    End Sub
End Class
