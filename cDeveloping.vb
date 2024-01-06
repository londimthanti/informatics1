Option Strict On
Option Infer Off
Option Explicit On

Public Class cDeveloping
    Inherits cPlanet

    Public Sub New(ByVal Name As String)
        MyBase.New(Name, 3)
    End Sub

    Public Overrides Function calcmin() As Double
        Return MyBase.calcmin() * 0.3
    End Function

End Class
