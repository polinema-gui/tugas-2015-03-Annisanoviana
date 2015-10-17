Public Class Form1

    Private Sub ProblemBintangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProblemBintang.Click
        Bintang.MdiParent = Me
        Bintang.Show()
    End Sub

    Private Sub MatriksKalkulator_Click(sender As Object, e As EventArgs) Handles MatriksKalkulator.Click
        Matriks.MdiParent = Me
        Matriks.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Apakah Anda Yakin Ingin Keluar ?", "Konfirmasi",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If


    End Sub


    Private Sub AplikasiToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
