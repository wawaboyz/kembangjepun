Imports WindowsApplication1.Manager
Imports WindowsApplication1.BussinessObject.Common

Namespace BussinessObject.Manager
    Public Class pembelianManager
        Inherits genericORM(Of pembelian, Int32)

        Function cari() As List(Of Pembelian)

            openSession()
            setTransaction()
            Dim listbeli As New List(Of Pembelian)
            listbeli = getSession.CreateQuery("From pembelian").List.Cast(Of Pembelian)().ToList
            getTransaction.Commit()
            getSession.Close()
            Return listbeli
        End Function

        Public Overloads Sub save(ByVal p As Pembelian, dtgridtransaksi As System.Windows.Forms.DataGridView)
            openSession()
            setTransaction()
            getSession.Save(p)
            getSession.Flush()


            Dim pembelianBarang As New PembelianBarang
            ' Dim pembelianbarangmanger As New BussinessObject.Manager.pembelianBarangManager
            For awal As Integer = 0 To dtgridtransaksi.Rows.Count() - 1 Step +1
                Dim pembelianbarangid As New PembelianBarangId
                Dim barang As New Barang
                barang.eidbarang = Int32.Parse(dtgridtransaksi.Rows.Item(awal).Cells(0).Value)
                pembelianbarangid.eidpembelian = p.eidpembelian
                pembelianbarangid.eidbarang = Int32.Parse(dtgridtransaksi.Rows.Item(awal).Cells(0).Value)
                pembelianBarang.eidpembelianbarang = pembelianbarangid
                pembelianBarang.ejumlah = dtgridtransaksi.Rows.Item(awal).Cells(2).Value
                pembelianBarang.eharga = dtgridtransaksi.Rows.Item(awal).Cells(3).Value
                pembelianBarang.esubtotal = dtgridtransaksi.Rows.Item(awal).Cells(4).Value
                'pembelianBarang.epembelianset = p
                'pembelianBarang.ebarangset = barang
                'pembelianbarangmanger.save(pembelianBarang)
                getSession.Save(pembelianBarang)
            Next

            getTransaction.Commit()
            getSession.Close()
        End Sub

    End Class
End Namespace
