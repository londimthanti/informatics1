Option Strict On
Option Infer Off
Option Explicit On

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Form1

    Private Planets() As cPlanet
    Private nP As Integer
    Private FS As FileStream
    Private BF As BinaryFormatter
    Private Const FILELOCATION As String = "practical09.IFM "

    Private Sub BtnInst_Click(sender As Object, e As EventArgs) Handles BtnInst.Click
        nP = CInt(InputBox("enter number of planets"))
        ReDim Planets(nP)
    End Sub

    Private Sub btnInputs_Click(sender As Object, e As EventArgs) Handles btnInputs.Click
        For i As Integer = 1 To nP
            Dim choice As Integer = CInt(InputBox("1 = cDeveloped, 2 = developing"))
            Dim name As String = InputBox("enter planets name ")

            Select Case choice
                Case 1 'Developed
                    Dim numwages As Integer
                    numwages = CInt(InputBox("hoew many wages" & CStr(i) & "?"))
                    Dim GDP As Double
                    GDP = CDbl(InputBox("GDP of planets"))
                    Dim devel As cDeveloped = New cDeveloped(name, numwages)

                    For w As Integer = 1 To numwages
                        devel.Wages(w) = CInt(InputBox("what is the wage for" & CStr(w) & " ?"))
                    Next w
                    Planets(i) = devel

                Case 2  'developing
                    Dim delopng As cDeveloping = New cDeveloping(name)
                    For w As Integer = 1 To 3
                        delopng.Wages(w) = CInt(InputBox("what the wage for" & CStr(w) & "?"))
                    Next w
                    Planets(i) = delopng
            End Select
        Next i
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        For i As Integer = 1 To nP
            txtDisplay.Text += Planets(i).Output
        Next i
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        FS = New FileStream(FILELOCATION, FileMode.Create, FileAccess.Write)
        BF = New BinaryFormatter()

        For p As Integer = 1 To nP
            If TypeOf Planets(p) Is cDeveloped Then
                Dim developed As cDeveloped
                developed = DirectCast(Planets(p), cDeveloped)
                BF.Serialize(FS, developed)
            End If
        Next p
        FS.Close()
        FS = Nothing
        BF = Nothing
        MsgBox("saved all developed files ")
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        FS = New FileStream(FILELOCATION, FileMode.Open, FileAccess.Read)
        BF = New BinaryFormatter()
        Dim dev() As cDeveloped
        Dim count As Integer = 1

        While FS.Position < FS.Length
            'Dim temp As cDeveloped
            'If max = 1 Then
            '    max = temp.GDP
            '    best = temp
            'Else
            '    If max < temp.GDP Then
            '        max = temp.GDP
            '        best = temp
            '    End If
            'End If
            count += 1
            ReDim Preserve dev(count)
            dev(count) = DirectCast(BF.Deserialize(FS), cDeveloped)
        End While
        txtdisplay2.Text = dev().Output & "     GDP       " + CStr(dev().GDP)
    End Sub
End Class
