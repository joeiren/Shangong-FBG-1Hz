
Namespace Opring.Algorithms

    Public Structure BoundingIndices
        Public Sub New(ByVal indexOfArrayValueLessThan As Integer, ByVal indexOfArrayValueGreaterThan As Integer)
            If indexOfArrayValueLessThan < 0 Or indexOfArrayValueGreaterThan < 0 Then
                Throw New Exception("Array indices cannot be less than 0")
            End If

            If Math.Abs(indexOfArrayValueGreaterThan - indexOfArrayValueLessThan) > 1 Then
                Throw New Exception("Bounding indices must be equal or adjacent")
            End If

            Me.indexOfArrayValueLessThan = indexOfArrayValueLessThan
            Me.indexOfArrayValueGreaterThan = indexOfArrayValueGreaterThan
        End Sub

        ''' <summary>
        ''' index of closet array element, less than the search value
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly IndexOfArrayValueLessThan As Integer

        ''' <summary>
        ''' index of closet array element, greater than the search value
        ''' </summary>
        ''' <remarks></remarks>
        Public ReadOnly IndexOfArrayValueGreaterThan As Integer
    End Structure

    Public NotInheritable Class Alg_BoundingIndices
        Private Sub New()

        End Sub

        Public Shared Function Calculate(ByVal array() As Double, ByVal val As Double) As BoundingIndices
            If array Is Nothing Then
                Throw New Exception("Null input array")
            End If
            If array.Length < 2 Then
                Throw New Exception("Input array must have 2 or more elements")
            End If

            Dim found As Boolean = False
            Dim indexOfArrayValueLessThan As Integer = 0
            Dim indexOfArrayValueGreaterThan As Integer = 0

            For i As Integer = 0 To array.Length - 2
                If array(i) = val Then
                    indexOfArrayValueLessThan = i
                    indexOfArrayValueGreaterThan = i
                    found = True
                    Exit For
                End If

                If array(i) < val And val < array(i + 1) Then
                    indexOfArrayValueLessThan = i
                    indexOfArrayValueGreaterThan = i + 1
                    found = True
                    Exit For
                ElseIf array(i) > val And val > array(i + 1) Then
                    indexOfArrayValueLessThan = i + 1
                    indexOfArrayValueGreaterThan = i
                    found = True
                    Exit For

                End If

                If (i = array.Length - 2) Then
                    If array(i + 1) = val Then
                        indexOfArrayValueLessThan = i + 1
                        indexOfArrayValueGreaterThan = i + 1
                        found = True
                        Exit For
                    End If
                End If
            Next

            If Not found Then
                Throw New Exception("Value not found within specified array")
            End If
            If indexOfArrayValueLessThan > array.Length - 1 Or indexOfArrayValueGreaterThan > array.Length - 1 Then
                Throw New Exception("Internal error - output indices out of bounds")
            End If

            Return New BoundingIndices(indexOfArrayValueLessThan, indexOfArrayValueGreaterThan)

        End Function

    End Class

End Namespace

