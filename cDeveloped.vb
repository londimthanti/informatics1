Option Strict On
Option Explicit On
Option Infer Off

<Serializable()> Public Class cDeveloped
    Inherits cPlanet
    Public GDP As Double
    Private Shared Number As Integer

    Public Sub New(ByVal Name As String, ByVal NumWages As Integer)
        MyBase.New(Name, NumWages)
        Me.GDP = GDP
        Number += 1
    End Sub

    Public Overrides Function calcmin() As Double
        Return GDP / Number
    End Function

End Class
