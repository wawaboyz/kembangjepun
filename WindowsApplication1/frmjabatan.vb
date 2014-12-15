Imports MySql.Data.MySqlClient
Imports NHibernate
Imports NHibernate.Cfg
Imports NHibernate.Connection
Imports System.Configuration
Imports Iesi.Collections
Imports WindowsApplication1.BussinessObject.Common
Public Class frmjabatan
    Private jabatanmanager As New BussinessObject.Manager.jabatanManager
    Dim jabatan As New BussinessObject.Common.Jabatan
    Private jabatanList As List(Of Jabatan)
    Dim action As String
    Public Sub textkosong()
        txtjabatan.Text = ""
        txtkomisi.Text = ""
        chkmaster.Checked = False
        chkpenjualan.Checked = False
        chkpembelian.Checked = False
        chklaporan.Checked = False
    End Sub
    Private Sub frmjabatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         
        jabatanList = jabatanmanager.selectAll()
        dglistjabatan.DataSource = jabatanList
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        groupjabatan.Enabled = False
        textkosong()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim strmenu As String
        jabatan.enamajabatan = txtjabatan.Text
        jabatan.ekomisijabatan = txtkomisi.Text
        strmenu = ""

        If (chkmaster.Checked = True) Then
            strmenu = String.Concat(strmenu, "1")
        End If
        If (chkpenjualan.Checked = True) Then
            strmenu = String.Concat(strmenu, "2")
        End If
        If (chkpembelian.Checked = True) Then
            strmenu = String.Concat(strmenu, "3")
        End If
        If (chklaporan.Checked = True) Then
            strmenu = String.Concat(strmenu, "4")
        End If
        jabatan.emenu = strmenu
        If (action = "new") Then
            jabatanmanager.save(jabatan)
        ElseIf (action = "edit") Then
            jabatan.eidjabatan = dglistjabatan.SelectedRows.Item(0).Cells(0).Value
            jabatanmanager.update(jabatan)
        End If

        jabatanList = jabatanmanager.selectAll()
        dglistjabatan.DataSource = jabatanList
        textkosong()
        groupjabatan.Enabled = False
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim panjangstr As Integer
        Dim i As Integer
        Dim mystring As String
        i = 0
        action = "edit"
        groupjabatan.Enabled = True
        textkosong()
        txtjabatan.Text = dglistjabatan.SelectedRows.Item(0).Cells(1).Value
        txtkomisi.Text = dglistjabatan.SelectedRows.Item(0).Cells(2).Value
        mystring = dglistjabatan.SelectedRows.Item(0).Cells(3).Value
        panjangstr = Len(mystring)
        While (i <> panjangstr)  
            If (mystring.Chars(i) = "1") Then
                chkmaster.Checked = True
            End If
            If (mystring.Chars(i) = "2") Then
                chkpenjualan.Checked = True
            End If
            If (mystring.Chars(i) = "3") Then
                chkpembelian.Checked = True
            End If
            If (mystring.Chars(i) = "4") Then
                chklaporan.Checked = True
            End If
            i = i + 1
        End While
    End Sub
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        textkosong()
        action = "new"
        groupjabatan.Enabled = True
    End Sub

    
    Private Sub txtcarijabatan_KeyUp(sender As Object, e As KeyEventArgs) Handles txtcarijabatan.KeyUp
        jabatanList = jabatanmanager.cariJabatan("%" + txtcarijabatan.Text + "%")
        dglistjabatan.DataSource = jabatanList
    End Sub
End Class