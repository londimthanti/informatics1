Option Strict On
Option Infer Off
Option Explicit On

<Serializable()> Public Class cPlanet
    Protected _Name As String
    Protected _NumWages As Integer
    Protected _Wages() As Integer
    Protected _Average As Double

    Public Property Wages(ByVal index As Integer) As Integer
        Get
            Return _Wages(index)
        End Get
        Set(value As Integer)
            _Wages(index) = value
        End Set
    End Property

    Public Sub New(ByVal _Name As String, ByVal _NumWages As Integer)
        Me._Name = _Name
        Me._NumWages = _NumWages
        ReDim _Wages(_NumWages)
    End Sub

    Public Sub calculateAverage()
        Dim total As Integer = 0
        For i As Integer = 1 To _NumWages
            total += _Wages(i)
        Next i
        _Average = total / _NumWages
    End Sub

    Public Overridable Function calcmin() As Double
        calculateAverage()
        Return _Average
    End Function

    Public Function Output() As String
        Dim str As String = ""
        str += _Name + "  " + Format(calcmin(), "##0.00") + " / " + CStr(_Average)
        Return str
    End Function



End Class
