Imports System.Drawing.Printing
Imports WindowsApplication1.BussinessObject.Manager
Imports WindowsApplication1.BussinessObject.Common

Public Class Form1

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim ps As New PaperSize("A4", 760, 550)
        Dim font1 As New Font("Arial", 20, FontStyle.Bold)
        'Dim font2 As New Font("Arial", 12)
        Dim font3 As New Font("Arial", 12)
        Dim fon4 As New Font("Courier New", 12)

        'Dim penjualanManager As New penjualanManager
        'Dim penjualan = penjualanManager.findByPrimaryKey(1)
        'Dim penjualanTreatment = penjualan.epenjualantreatment
        Dim i As Int32 = 0
        Dim point As Int32 = 135
        Dim diskon As Int32 = 0
        Dim total As Int32 = 0

        Format(point, "n")
        ps.PaperName = PaperKind.A4
        e.PageSettings.Landscape = False
        e.PageSettings.PaperSize = ps
        'e.Graphics.TranslateTransform(0, 0)
        'e.Graphics.RotateTransform(90)
        'e.Graphics.DrawString("tiitik 0,0", New Font("Arial", 10), Brushes.Black, New Point(0, 0))
        'e.Graphics.DrawString("Hello World", New Font("Arial", 10), Brushes.Black, New Point(100, 100))
        'MessageBox.Show(e.PageSettings.Landscape)
        'MessageBox.Show(e.PageSettings.PaperSize.ToString)
        'MessageBox.Show(e.PageSettings.PrinterResolution.ToString)
        'MessageBox.Show(e.Graphics.Transform.ToString)
        'MessageBox.Show(e.MarginBounds.Location.ToString)

        e.Graphics.DrawString("FAKTUR", font1, Brushes.Black, New Point(370, 0))
        e.Graphics.DrawString("Nama Toko", font3, Brushes.Black, New Point(40, 35))
        e.Graphics.DrawString("jepun bali", font3, Brushes.Black, New Point(145, 35))

        e.Graphics.DrawString("Alamat Toko", font3, Brushes.Black, New Point(40, 55))
        e.Graphics.DrawString("xxxxxxxx, Surabaya", font3, Brushes.Black, New Point(145, 55))

        e.Graphics.DrawString("No.Telp", font3, Brushes.Black, New Point(40, 75))
        e.Graphics.DrawString("031123321", font3, Brushes.Black, New Point(145, 75))

        e.Graphics.DrawString("Id Faktur", font3, Brushes.Black, New Point(380, 35))
        'e.Graphics.DrawString(penjualan.eidpenjualan, font3, Brushes.Black, New Point(500, 35))
        e.Graphics.DrawString("12345", font3, Brushes.Black, New Point(510, 35))

        'e.Graphics.DrawString("Tgl.Faktur", font3, Brushes.Black, New Point(380, 55))
        'e.Graphics.DrawString(penjualan.etglpenjualan, font3, Brushes.Black, New Point(500, 55))
        'e.Graphics.DrawString("12-Desember-2014", font3, Brushes.Black, New Point(510, 55))
        e.Graphics.DrawString("12-Desember-2014", font3, Brushes.Black, New Point(650, 55))

        e.Graphics.DrawString("Nama Customer", font3, Brushes.Black, New Point(380, 55))
        'e.Graphics.DrawString(penjualan.enamacustomer, font3, Brushes.Black, New Point(500, 55))
        e.Graphics.DrawString("coba", font3, Brushes.Black, New Point(510, 55))

        e.Graphics.DrawString("Cara Bayar", font3, Brushes.Black, New Point(380, 75))
        e.Graphics.DrawString("Cash", font3, Brushes.Black, New Point(510, 75))

        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------", font3, Brushes.Black, New Point(40, 95))
        e.Graphics.DrawString("No", font3, Brushes.Black, New Point(40, 115))
        e.Graphics.DrawString("Treatment", font3, Brushes.Black, New Point(80, 115))
        e.Graphics.DrawString("Therapist", font3, Brushes.Black, New Point(320, 115))
        e.Graphics.DrawString("Harga", font3, Brushes.Black, New Point(560, 115))
        e.Graphics.DrawString("Voucher", font3, Brushes.Black, New Point(720, 115))
        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------", font3, Brushes.Black, New Point(40, 135))

        'For Each temp As PenjualanTreatment In penjualanTreatment
        '    i = i + 1
        '    point = point + 20
        '    e.Graphics.DrawString(i, font3, Brushes.Black, New Point(40, point))
        '    e.Graphics.DrawString(temp.etreatmentset.enamatreatment, font3, Brushes.Black, New Point(80, point))
        '    e.Graphics.DrawString(temp.eiduser, font3, Brushes.Black, New Point(320, point))
        '    e.Graphics.DrawString(temp.eharga, font3, Brushes.Black, New Point(560, point))
        '    e.Graphics.DrawString("Voucher", font3, Brushes.Black, New Point(720, point))
        '    total = total + temp.eharga
        '

        e.Graphics.DrawString("1", font3, Brushes.Black, New Point(40, 155))
        e.Graphics.DrawString("Treatment 1", font3, Brushes.Black, New Point(80, 155))
        e.Graphics.DrawString("Therapist 1", font3, Brushes.Black, New Point(320, 155))
        e.Graphics.DrawString("10000", font3, Brushes.Black, New Point(560, 155))
        e.Graphics.DrawString("Voucher", font3, Brushes.Black, New Point(720, 155))

        e.Graphics.DrawString("2", font3, Brushes.Black, New Point(40, 175))
        e.Graphics.DrawString("Treatment 2", font3, Brushes.Black, New Point(80, 175))
        e.Graphics.DrawString("Therapist 2", font3, Brushes.Black, New Point(320, 175))
        e.Graphics.DrawString("20000", font3, Brushes.Black, New Point(560, 175))
        e.Graphics.DrawString("Voucher", font3, Brushes.Black, New Point(720, 175))

        e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------", font3, Brushes.Black, New Point(40, 395))
        e.Graphics.DrawString("Kasir", font3, Brushes.Black, New Point(80, 415))
        e.Graphics.DrawString("nama login", font3, Brushes.Black, New Point(80, 475))

        e.Graphics.DrawString("Total", font3, Brushes.Black, New Point(625, 415))
        'e.Graphics.DrawString(total, font3, Brushes.Black, New Point(720, 415))
        e.Graphics.DrawString("30000", font3, Brushes.Black, New Point(720, 415))

        e.Graphics.DrawString("Diskon", font3, Brushes.Black, New Point(625, 435))
        'If IsDBNull(penjualan.ediskon) Then
        '    diskon = 0
        'Else
        '    diskon = penjualan.ediskon
        'End If
        'e.Graphics.DrawString(diskon + " %", font3, Brushes.Black, New Point(720, 435))
        e.Graphics.DrawString("0 %", font3, Brushes.Black, New Point(720, 435))

        e.Graphics.DrawString("Grand Total", font3, Brushes.Black, New Point(625, 455))
        'e.Graphics.DrawString(penjualan.egrandtotal, font3, Brushes.Black, New Point(720, 455))
        e.Graphics.DrawString("30000", font3, Brushes.Black, New Point(720, 455))

        'e.Graphics.DrawString("FAKTUR", New Font("Arial Black", 32), Brushes.Black, New Point(316, 25))
        'e.Graphics.DrawString("Nama Toko", New Font("Arial", 28, FontStyle.Bold), Brushes.Black, New Point(40, 50))
        'e.Graphics.DrawString("Alamat Toko", New Font("Arial", 28, FontStyle.Bold), Brushes.Black, New Point(40, 75))
        'e.Graphics.DrawString("No.Telp", New Font("Arial", 28, FontStyle.Bold), Brushes.Black, New Point(40, 100))
        'e.Graphics.DrawString("Id Faktur", New Font("Arial", 28, FontStyle.Bold), Brushes.Black, New Point(350, 50))
        'e.Graphics.DrawString("Tgl.Faktur", New Font("Arial", 28, FontStyle.Bold), Brushes.Black, New Point(350, 75))
        'e.Graphics.DrawString("Nama Customer", New Font("Arial", 28, FontStyle.Bold), Brushes.Black, New Point(350, 100))
        'e.Graphics.DrawString("------------------------------------------------------------", New Font("Arial", 28), Brushes.Black, New Point(40, 110))
        'e.Graphics.DrawString("No", New Font("Arial", 28, FontStyle.Bold), Brushes.Black, New Point(40, 120))
        'e.Graphics.DrawString("Voucher", New Font("Arial", 28, FontStyle.Bold), Brushes.Black, New Point(700, 120))
        'e.Graphics.DrawString("Harga", New Font("Arial", 28, FontStyle.Bold), Brushes.Black, New Point(520, 120))
        'e.Graphics.DrawString("------------------------------------------------------------", New Font("Arial", 28), Brushes.Black, New Point(40, 145))
        'e.Graphics.DrawString("------------------------------------------------------------", New Font("Arial", 28), Brushes.Black, New Point(40, 330))
        'e.Graphics.DrawString("Kasir", New Font("Arial", 28), Brushes.Black, New Point(40, 350))
        'e.Graphics.DrawString("Total", New Font("Arial", 28), Brushes.Black, New Point(520, 350))
        'e.Graphics.DrawString("Diskon", New Font("Arial", 28), Brushes.Black, New Point(520, 375))
        'e.Graphics.DrawString("....", New Font("Arial", 28), Brushes.Black, New Point(520, 400))
        'e.Graphics.DrawString("Grand Total", New Font("Arial", 28), Brushes.Black, New Point(520, 425))

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrintPreviewControl1_Click(sender As Object, e As EventArgs)

    End Sub
End Class