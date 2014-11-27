Imports MySql.Data.MySqlClient
Imports NHibernate
Imports NHibernate.Cfg
Imports NHibernate.Connection
Imports System.Configuration
Imports Iesi.Collections
Imports WindowsApplication1.BussinessObject.Common

Public Class frmlogin
    Public Shared logger As log4net.ILog
    Private usermanager As New BussinessObject.Manager.userManager
    Private jabatanManager As New BussinessObject.Manager.jabatanManager
    Private jabatanList As List(Of Jabatan)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CATATAN :
        '1. MENU DELETE VOUCHER DAN MENGHANGUSKAN VOUCHER PERLU / TIDAK -- KARENA USER SALAH INPUT JUMLAH, ITEM DAN NO VOUCHER



        'MessageBox.Show(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name())

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


        'For Each temp As Jabatan In jabatanList
        'cbJabatan.Items.Add(temp)
        'Next
        jabatanList = jabatanManager.selectAll()
        cbJabatan.DataSource = jabatanList
        cbJabatan.ValueMember = "eidjabatan"
        cbJabatan.DisplayMember = "enamajabatan"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ''Dim myConfig As New Configuration
        ''myConfig.Configure()
        ''myConfig.AddAssembly(GetType(User).Assembly)

        'myConfig.Configure("hibernate.cfg.xml")
        'myConfig.AddFile("hibernate.cfg.xml")
        'myConfig.Configure("hibernate.cfg.xml")
        'myConfig.AddAssembly("WindowsApplication1")
        'myConfig.SetProperty("hibernate.dialect", _
        '            "NHibernate.Dialect.MySQLDialect")

        ''Dim myFactory As ISessionFactory = myConfig.BuildSessionFactory
        ''Dim mySession As ISession = myFactory.OpenSession
        ''Dim myTransaction As ITransaction = mySession.BeginTransaction

        'Dim user As New BussinessObject.Common.User
        'user.eusername = txtUser.Text
        'user.epass = txtPass.Text
        'user.ejeniskelamin = "P"
        'user.ejabatan = cbJabatan.SelectedItem

        'Dim userManager As New BussinessObject.Manager.userManager
        'usermanager.save(User)

        'mySession.Save(User)
        'myTransaction.Commit()
        'mySession.Close()

        Dim menu As New frmmenu
        Dim strmenu As String
        Dim userlist As userJabatan
        userlist = usermanager.login(txtUser.Text, txtPass.Text)
        strmenu = userlist.emenu.ToString
        Dim pjgstr As Integer
        Dim i As Integer
        i = 0
        pjgstr = strmenu.Length
        If userlist.emenu <> "" Then

            While (i <> pjgstr)
                If (strmenu.Chars(i) = "1") Then
                    menu.MASTERToolStripMenuItem.Visible = True
                End If
                If (strmenu.Chars(i) = "2") Then
                    menu.PENJUALANToolStripMenuItem.Visible = True

                End If
                If (strmenu.Chars(i) = "3") Then
                    menu.PEMBELIANToolStripMenuItem.Visible = True

                End If
                If (strmenu.Chars(i) = "4") Then
                    menu.LAPORANToolStripMenuItem.Visible = True
                End If
                i = i + 1



            End While

            menu.ShowDialog()

        Else
            MessageBox.Show("USERNAME/PASSWORD TIDAK VALID")

        End If



        'MessageBox.Show("success")

    End Sub
End Class
