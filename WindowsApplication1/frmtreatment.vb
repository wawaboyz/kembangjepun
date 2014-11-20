Imports MySql.Data.MySqlClient
Imports NHibernate
Imports NHibernate.Cfg
Imports NHibernate.Connection
Imports System.Configuration
Imports Iesi.Collections
Imports WindowsApplication1.BussinessObject.Common
Public Class frmtreatment
    Private treatmentManager As New BussinessObject.Manager.treatmentManager
    Private treatmentList As List(Of Treatment)
    Dim treatment As New BussinessObject.Common.Treatment
    Dim action As String
    Public Sub textkosong()
        txttreatment.Text = ""
        txtharga.Text = ""
        txtwaktu.Text = ""

    End Sub
    Private Sub frmtreatment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        treatmentList = treatmentManager.selectAll()
        dglisttreatment.DataSource = treatmentList
        If (dglisttreatment.Rows.Count = 0) Then
            btnedit.Enabled = False
            btndelete.Enabled = False
        Else
            btnedit.Enabled = True
            btndelete.Enabled = True
        End If

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        treatment.enamatreatment = txttreatment.Text
        treatment.eharga = txtharga.Text
        treatment.ejam = txtwaktu.Text
        If (action = "new") Then
            treatmentManager.save(treatment)
        ElseIf (action = "edit") Then
            treatment.eidtreatment = dglisttreatment.SelectedRows.Item(0).Cells(0).Value
            treatmentManager.update(treatment)
        End If
        textkosong()
        grouptreatment.Enabled = False
        treatmentList = treatmentManager.selectAll()
        dglisttreatment.DataSource = treatmentList
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        grouptreatment.Enabled = True
        action = "new"

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        action = "edit"
        grouptreatment.Enabled = True
        txttreatment.Text = dglisttreatment.SelectedRows.Item(0).Cells(1).Value
        txtharga.Text = dglisttreatment.SelectedRows.Item(0).Cells(2).Value
        txtwaktu.Text = dglisttreatment.SelectedRows.Item(0).Cells(3).Value
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        textkosong()
        grouptreatment.Enabled = False
    End Sub
End Class