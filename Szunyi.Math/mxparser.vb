Imports org.mariuszgromada.math.mxparser
Public Class mxparser
    Public Shared Function Get_Blast_Arguments(s() As String) As Dictionary(Of String, Own_Argument)
        Dim args As New Dictionary(Of String, Own_Argument)
        Dim UdedItems As New List(Of String)
        For i1 = 0 To s.Count - 1
            If s(i1).StartsWith("Hsp") Then
                If args.ContainsKey(s(i1)) = False Then
                    args.Add(s(i1), New Own_Argument(s(i1)))
                End If
            ElseIf s(i1).StartsWith("Hit") Then
                If args.ContainsKey(s(i1)) = False Then
                    args.Add(s(i1), New Own_Argument(s(i1)))
                End If
            ElseIf s(i1).StartsWith("Record") Then
                If args.ContainsKey(s(i1)) = False Then
                    args.Add(s(i1), New Own_Argument(s(i1)))
                End If

            End If

        Next
        Return args

    End Function
End Class
Public Class Own_Argument
    Public Property Name As String
    Public Property Arg As Argument
    Public Property Value As List(Of Double)
    Public Property Values As List(Of Double)()
    Public Sub New(Name As String)
        Me.Name = Name
        Arg = New Argument(Me.Name, 1)
        Arg.setArgumentName(Me.Name)
        If Arg.getArgumentName = "" Then
            Dim jj As Int16 = 54
        End If
        Dim jk As Int16 = 54
    End Sub

End Class
