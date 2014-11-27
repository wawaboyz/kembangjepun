Public Class frmmenu

    Private Sub BARANGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BARANGToolStripMenuItem.Click
        Dim masterbarang As New frmbarang
        masterbarang.MdiParent = Me
        masterbarang.Show()
    End Sub

    Private Sub PEGAWAIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PEGAWAIToolStripMenuItem.Click
        Dim masterpegawai As New frmpegawai
        masterpegawai.MdiParent = Me
        masterpegawai.Show()
    End Sub

    Private Sub JABATANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JABATANToolStripMenuItem.Click
        Dim masterjabatan As New frmjabatan
        masterjabatan.MdiParent = Me
        masterjabatan.Show()
    End Sub

    Private Sub TREATMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TREATMENTToolStripMenuItem.Click
        Dim mastertreatment As New frmtreatment
        mastertreatment.MdiParent = Me
        mastertreatment.Show()
    End Sub

    Private Sub CUSTOMERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERToolStripMenuItem.Click
        Dim mastercustomer As New frmcustomer
        mastercustomer.MdiParent = Me
        mastercustomer.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        If (MessageBox.Show("ANDA YAKIN MAU KELUAR?", "KELUAR SISTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Close()


        End If
    End Sub

    Private Sub frmmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PEMBELIANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PEMBELIANToolStripMenuItem.Click
        Dim masterpembelian As New frmpembelian
        masterpembelian.MdiParent = Me
        masterpembelian.Show()
    End Sub

    Private Sub TREATMENTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TREATMENTToolStripMenuItem1.Click
        Dim masterpenjualantreatment As New frmpenjualantreatment
        masterpenjualantreatment.MdiParent = Me
        masterpenjualantreatment.Show()
    End Sub
End Class