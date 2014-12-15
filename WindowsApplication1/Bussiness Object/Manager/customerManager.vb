Imports WindowsApplication1.Manager
Imports WindowsApplication1.BussinessObject.Common

Namespace BussinessObject.Manager
    Public Class customerManager
        Inherits genericORM(Of Customer, Int32)


        Function cariCustomer(ByVal nmcustomer As String) As List(Of Customer)

            openSession()
            setTransaction()
            Dim listcustomer As New List(Of Customer)
            listcustomer = getSession.CreateQuery("FROM Customer WHERE nama LIKE :nmcustomer").SetParameter("nmcustomer", nmcustomer).List.Cast(Of Customer)().ToList
            getSession.Close()
            Return listcustomer

        End Function
    End Class

End Namespace
