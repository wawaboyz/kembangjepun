Imports MySql.Data.MySqlClient
Imports NHibernate
Imports NHibernate.Cfg
Imports NHibernate.Connection
Imports System.Configuration
Imports Iesi.Collections
Imports WindowsApplication1.BussinessObject.Common

Public Class frmpegawai
    Public Shared logger As log4net.ILog
    Private usermanager1 As New BussinessObject.Manager.userManager
    Private userList As List(Of userJabatan)
    Dim user As New BussinessObject.Common.User
    Private jabatanManager As New BussinessObject.Manager.jabatanManager
    Private jabatanList As List(Of Jabatan)
    Dim action As String
    Public Sub textkosong()
        txtnama.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        txtalamat.Text = ""
        txtkomisi.Text = ""
        txtnoktp.Text = ""
        txttelepon.Text = ""
        rdlaki.Checked = True
        cbagama.SelectedValue = ""
        cbjabatan.SelectedValue = ""

    End Sub


    Private Sub frmpegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'Get the logger as named in the configuration file.
            logger = log4net.LogManager.GetLogger("Log4NetAssembly1")
            logger.Info("Form1_Load() - Start")
            logger.Debug("Form1_Load() - Code Implementation goes here......")
        Catch ex As Exception
            logger.Error("Form1_Load() - " & ex.Message)
        Finally
            logger.Info("Form1_Load() - Finish")
        End Try


        userList = usermanager1.selectUserALL()
        dglistpegawai.DataSource = userList
        jabatanList = jabatanManager.selectAll()
        cbjabatan.DataSource = jabatanList
        cbjabatan.ValueMember = "eidjabatan"
        cbjabatan.DisplayMember = "enamajabatan"
        cbjabatan.SelectedValue = ""
        dglistpegawai.Columns(10).Visible = False
        dglistpegawai.Columns(11).Visible = False
        dglistpegawai.Columns(14).Visible = False
        dglistpegawai.Columns(15).Visible = False
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        grouppegawai.Enabled = False

        user.enama = txtnama.Text
        user.eusername = txtusername.Text
        user.epass = txtpassword.Text
        user.ealamat = txtalamat.Text
        user.ekomisi = txtkomisi.Text
        user.enoktp = txtnoktp.Text
        user.etelepon = txttelepon.Text
        If (rdlaki.Checked = True) Then
            user.ejeniskelamin = "L"
        Else
            user.ejeniskelamin = "P"
        End If
        user.eagama = cbagama.SelectedItem
        user.eidjabatan = cbjabatan.SelectedItem

        If (action = "new") Then
            usermanager1.save(user)
        ElseIf (action = "edit") Then
            user.eiduser = dglistpegawai.SelectedRows.Item(0).Cells(0).Value
            usermanager1.update(user)
        End If
        textkosong()
        grouppegawai.Enabled = False

        userList = usermanager1.selectUserALL()
        dglistpegawai.DataSource = userList
    End Sub


    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        grouppegawai.Enabled = True
        txtnama.Text = dglistpegawai.SelectedRows.Item(0).Cells(3).Value
        txtusername.Text = dglistpegawai.SelectedRows.Item(0).Cells(1).Value
        txtpassword.Text = dglistpegawai.SelectedRows.Item(0).Cells(2).Value
        txtalamat.Text = dglistpegawai.SelectedRows.Item(0).Cells(4).Value
        txtkomisi.Text = dglistpegawai.SelectedRows.Item(0).Cells(5).Value
        txtnoktp.Text = dglistpegawai.SelectedRows.Item(0).Cells(6).Value
        txttelepon.Text = dglistpegawai.SelectedRows.Item(0).Cells(8).Value

        If (dglistpegawai.SelectedRows.Item(0).Cells(7).Value = "L") Then
            rdlaki.Checked = True
        Else
            rdperempuan.Checked = True
        End If

        Dim index As Integer
        Dim indexjabatan As Integer
        index = cbagama.FindString(dglistpegawai.SelectedRows.Item(0).Cells(9).Value)
        cbagama.SelectedIndex = index

        indexjabatan = cbjabatan.FindString(dglistpegawai.SelectedRows.Item(0).Cells(12).Value)
        cbjabatan.SelectedIndex = indexjabatan
        action = "edit"

    End Sub

    Private Sub txtcaripegawai_KeyUp(sender As Object, e As KeyEventArgs) Handles txtcaripegawai.KeyUp
        userList = usermanager1.cariPegawai("%" + txtcaripegawai.Text + "%")
        dglistpegawai.DataSource = userList

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        grouppegawai.Enabled = True
        action = "new"

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If (MessageBox.Show("APAKAH ANDA YAKIN MENGHAPUS DATA INI?", "HAPUS DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            user.eiduser = dglistpegawai.SelectedRows.Item(0).Cells(0).Value
            usermanager1.delete(user)

        End If

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        textkosong()
        grouppegawai.Enabled = False
    End Sub

End Class