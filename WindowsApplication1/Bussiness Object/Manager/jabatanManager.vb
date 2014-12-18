Imports WindowsApplication1.Manager
Imports WindowsApplication1.BussinessObject.Common

Namespace BussinessObject.Manager
    Class jabatanManager
        Inherits genericORM(Of Jabatan, Int32)

        Function cariJabatan(ByVal nmjabatan As String) As List(Of Jabatan)

            openSession()
            setTransaction()
            Dim listjabatan As New List(Of Jabatan)
            listjabatan = getSession.CreateQuery("FROM Jabatan WHERE namajabatan LIKE :nmjabatan").SetParameter("nmjabatan", nmjabatan).List.Cast(Of Jabatan)().ToList
            getSession.Close()
            Return listjabatan

        End Function


    End Class
End Namespace