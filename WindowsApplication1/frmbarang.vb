Imports MySql.Data.MySqlClient
Imports NHibernate
Imports NHibernate.Cfg
Imports NHibernate.Connection
Imports System.Configuration
Imports Iesi.Collections
Imports WindowsApplication1.BussinessObject.Common
Public Class frmbarang
    Private barangManager As New BussinessObject.Manager.barangManager
    Private barangList As List(Of barang)
    Dim barang As New BussinessObject.Common.Barang
    Dim action As String

    Public Sub textkosong()
        txtnamabarang.Text = ""
        txtstok.Text = ""
        txthargajual.Text = ""
        txthargaperkiraan.Text = ""
    End Sub

    Private Sub frmbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        barangList = barangManager.selectAll
        dglistbarang.DataSource = barangList
        dglistbarang.Columns(6).Visible = False
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        barang.enamabarang = txtnamabarang.Text
        barang.estokbarang = txtstok.Text
        barang.ehargajual = txthargajual.Text
        barang.ehargaperkiraan = txthargaperkiraan.Text

        If (rbya.Checked = True) Then
            barang.einventaris = 1
        Else
            barang.einventaris = 0
        End If
        If (action = "new") Then
            barangManager.save(barang)
        ElseIf (action = "edit") Then
            barang.eidbarang = dglistbarang.SelectedRows.Item(0).Cells(0).Value
            barangManager.update(barang)
        End If
        
        groupbarang.Enabled = False
        textkosong()
        barangList = barangManager.selectAll
        dglistbarang.DataSource = barangList
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        groupbarang.Enabled = True
        action = "new"
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        groupbarang.Enabled = True
        action = "edit"
        txtnamabarang.Text = dglistbarang.SelectedRows.Item(0).Cells(1).Value
        txtstok.Text = dglistbarang.SelectedRows.Item(0).Cells(2).Value
        txthargaperkiraan.Text = dglistbarang.SelectedRows.Item(0).Cells(4).Value
        txthargajual.Text = dglistbarang.SelectedRows.Item(0).Cells(5).Value
        If (dglistbarang.SelectedRows.Item(0).Cells(3).Value = "0") Then
            rbya.Checked = True
        Else
            rbtidak.Checked = True
        End If

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        textkosong()
        groupbarang.Enabled = False
    End Sub
End Class