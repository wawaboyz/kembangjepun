Imports WindowsApplication1.Manager
Imports WindowsApplication1.BussinessObject.Common

Namespace BussinessObject.Manager
    Public Class treatmentManager
        Inherits genericORM(Of Treatment, Int32)
        Function cariTreatment(ByVal nmtreatment As String) As List(Of Treatment)

            openSession()
            setTransaction()
            Dim listtreatment As New List(Of Treatment)
            listtreatment = getSession.CreateQuery("FROM Treatment WHERE namatreatment LIKE :nmtreatment").SetParameter("nmtreatment", nmtreatment).List.Cast(Of Treatment)().ToList
            getSession.Close()
            Return listtreatment

        End Function
    End Class
End Namespace
