Imports MySql.Data.MySqlClient
Imports NHibernate
Imports NHibernate.Cfg
Imports NHibernate.Connection
Imports System.Configuration
Imports Iesi.Collections
Imports WindowsApplication1.BussinessObject.Common

Public Class frmcustomer
    Private customerManager As New BussinessObject.Manager.customerManager
    Private customerList As List(Of Customer)
    Dim customer As New BussinessObject.Common.Customer
    Dim action As String
    Public Sub textkosong()
        txtnama.Text = ""
        txtalamat.Text = ""
        txtnomorkartu.Text = ""
        txttelepon.Text = ""
        rdlaki.Checked = True
        rdaktif.Checked = True
        dttgllahir.Value = Today
    End Sub
    Private Sub frmcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customerList = customerManager.selectAll
        dglistpelanggan.DataSource = customerList


    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        customer.enama = txtnama.Text
        customer.ealamat = txtalamat.Text
        customer.enomorkartu = txtnomorkartu.Text
        customer.etelp = txttelepon.Text
        customer.etgllahir = dttgllahir.Value

        If (rdlaki.Checked = True) Then
            customer.ejeniskelamin = "L"
        ElseIf (rdperempuan.Checked = True) Then
            customer.ejeniskelamin = "P"
        End If

        If (rdaktif.Checked = True) Then
            customer.eaktif = True
        ElseIf (rdnonaktif.Checked = True) Then
            customer.eaktif = False
        End If

        If (action = "new") Then
            customerManager.save(customer)
        ElseIf (action = "edit") Then
            customer.eidcustomer = dglistpelanggan.SelectedRows.Item(0).Cells(0).Value
            customerManager.update(customer)
        End If

        textkosong()
        grouppelanggan.Enabled = False
        customerList = customerManager.selectAll
        dglistpelanggan.DataSource = customerList
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        action = "new"
        grouppelanggan.Enabled = True
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        action = "edit"
        txtnama.Text = dglistpelanggan.SelectedRows.Item(0).Cells(1).Value
        txtalamat.Text = dglistpelanggan.SelectedRows.Item(0).Cells(2).Value
        txttelepon.Text = dglistpelanggan.SelectedRows.Item(0).Cells(3).Value
        txtnomorkartu.Text = dglistpelanggan.SelectedRows.Item(0).Cells(4).Value
        If (dglistpelanggan.SelectedRows.Item(0).Cells(5).Value = "L") Then
            rdlaki.Checked = True
        ElseIf (dglistpelanggan.SelectedRows.Item(0).Cells(5).Value = "P") Then
            rdperempuan.Checked = True
        End If
        dttgllahir.Value = dglistpelanggan.SelectedRows.Item(0).Cells(6).Value
        If (dglistpelanggan.SelectedRows.Item(0).Cells(7).Value = True) Then
            rdaktif.Checked = True
        ElseIf (dglistpelanggan.SelectedRows.Item(0).Cells(7).Value = False) Then
            rdnonaktif.Checked = True
        End If
        grouppelanggan.Enabled = True
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        textkosong()
        grouppelanggan.Enabled = False

    End Sub

    
End Class