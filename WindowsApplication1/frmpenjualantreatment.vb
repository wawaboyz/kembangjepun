Imports MySql.Data.MySqlClient
Imports NHibernate
Imports NHibernate.Cfg
Imports NHibernate.Connection
Imports System.Configuration
Imports Iesi.Collections
Imports WindowsApplication1.BussinessObject.Common
Public Class frmpenjualantreatment
    Private listpenjualan As New List(Of Penjualan)
    Private penjualan As Penjualan
    Private jualManager As New BussinessObject.Manager.penjualanManager
    Private listtreatment As New List(Of Treatment)
    Private treatment As Treatment
    Private treatmentManager As New BussinessObject.Manager.treatmentManager
    Private listuser As New List(Of User)
    Private user As User
    Private usermanager As New BussinessObject.Manager.userManager
    Dim idfakturjual As Integer
    Private Sub frmpenjualantreatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim jumlahfaktur As Integer
        listpenjualan = jualManager.selectAll()
        jumlahfaktur = listpenjualan.Count()
        If (jumlahfaktur = 0) Then
            idfakturjual = 1
        Else
            idfakturjual = listpenjualan.Item(jumlahfaktur - 1).eidpenjualan + 1
        End If
        txtidjual.Text = idfakturjual


        listtreatment = treatmentManager.selectAll()
        cbtreatment.DataSource = listtreatment
        cbtreatment.ValueMember = "eidtreatment"
        cbtreatment.DisplayMember = "enamatreatment"
        cbtreatment.SelectedValue = ""
    End Sub
End Class