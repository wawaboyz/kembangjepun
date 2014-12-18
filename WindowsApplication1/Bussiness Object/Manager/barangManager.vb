Imports WindowsApplication1.Manager
Imports WindowsApplication1.BussinessObject.Common

Namespace BussinessObject.Manager
    Public Class barangManager
        Inherits genericORM(Of Barang, Int32)

        Function cariBarang(ByVal nmbarang As String) As List(Of Barang)

            openSession()
            setTransaction()
            Dim listbarang As New List(Of Barang)
            listbarang = getSession.CreateQuery("FROM Barang WHERE namabarang LIKE :nmbarang").SetParameter("nmbarang", nmbarang).List.Cast(Of Barang)().ToList
            getSession.Close()
            Return listbarang

        End Function

    End Class
End Namespace

