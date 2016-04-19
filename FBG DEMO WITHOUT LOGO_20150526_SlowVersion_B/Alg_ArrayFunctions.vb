Namespace Opring.Algorithms
    Public NotInheritable Class Alg_ArrayFunctions
        Private Sub New()

        End Sub

        Public Shared Function ExtractSubArray(ByVal inputArray() As Double, ByVal fromIndex As Integer, ByVal toIndex As Integer) As Double()
            If fromIndex < 0 Or fromIndex >= inputArray.Length Then
                Throw New Exception("Alg_ArrayFunctions.extractSubArray: fromIndex is out of bounds. Array has " + inputArray.Length.ToString() + " elements, fromIndex is " + fromIndex.ToString())
            End If
            If toIndex < 0 Or toIndex >= inputArray.Length Then
                Throw New Exception("Alg_ArrayFunctions.extractSubArray: toIndex is out of bounds. Array has " + inputArray.Length.ToString() + " elements, toIndex is " + fromIndex.ToString())
            End If
            If fromIndex > toIndex Then
                Throw New Exception("Alg_ArrayFunctions.extractSubArray:  fromIndex (" + fromIndex.ToString() + ") is greater then toIndex (" + toIndex.ToString() + ")")
            End If
            If inputArray.Length = 0 Then
                Throw New Exception("Alg_ArrayFunctions.extractSubArray : inputArray is empty")
            End If

            Dim subsetArray() As Double
            ReDim subsetArray(toIndex - fromIndex + 1)
            For i As Integer = fromIndex To toIndex
                subsetArray(i - fromIndex) = inputArray(i)
            Next
            Return subsetArray
        End Function

        Public Shared Function FindIndexOfNearestElement(ByVal inputArray() As Double, ByVal valueToFind As Double) As Integer
            If inputArray Is Nothing Then
                Throw New Exception("Alg_ArrayFunctions.findIndexOfNearestElement: input array is null")
            End If
            If inputArray.Length = 0 Then
                Throw New Exception("Alg_ArrayFunctions.findIndexOfNearestElement: input array is empty")
            End If

            Dim smallestDifference As Double = Double.MaxValue
            Dim nearestElement As Integer = 0
            Dim difference As Double

            For i As Integer = 0 To inputArray.Length
                difference = Math.Abs(inputArray(i) - valueToFind)
                If difference < smallestDifference Then
                    smallestDifference = difference
                    nearestElement = i
                End If
            Next
            Return nearestElement
        End Function

        Public Shared Function FindIndexOfNearestElement(ByVal inputArray() As Double, ByVal valueToFind As Double, ByVal fromIndex As Integer, ByVal toIndex As Integer) As Integer
            If inputArray Is Nothing Then
                Throw New Exception("Alg_ArrayFunctions.findIndexOfNearestElement: input array is null")
            End If
            If inputArray.Length = 0 Then
                Throw New Exception("Alg_ArrayFunctions.findIndexOfNearestElement: input array is empty")
            End If

            Dim smallestDifference As Double = Double.MaxValue
            Dim nearestElement As Integer = 0
            Dim difference As Double

            For i As Integer = fromIndex To toIndex Step 1
                difference = Math.Abs(inputArray(i) - valueToFind)
                If difference < smallestDifference Then
                    smallestDifference = difference
                    nearestElement = i
                End If
            Next
            Return nearestElement
        End Function

        Public Shared Function FindIndexOfNearestElementLess(ByVal inputArray() As Double, ByVal valueToFind As Double, ByVal fromIndex As Integer, ByVal toIndex As Integer, _
                                                             ByRef indexOfLess As Integer, ByRef indexOfBigger As Integer) As Boolean
            If inputArray Is Nothing Then
                Throw New Exception("Alg_ArrayFunctions.findIndexOfNearestElement: input array is null")
            End If
            If inputArray.Length = 0 Then
                Throw New Exception("Alg_ArrayFunctions.findIndexOfNearestElement: input array is empty")
            End If

            For i As Integer = fromIndex To toIndex Step 1 * Math.Sign(toIndex - fromIndex)
                If (inputArray(i) - valueToFind) * (inputArray(i + 1) - valueToFind) < 0 Then
                    If inputArray(i) < valueToFind Then
                        indexOfLess = i
                        indexOfBigger = i + 1
                    Else
                        indexOfLess = i + 1
                        indexOfBigger = i
                    End If
                    Return True
                End If
            Next

            If inputArray(toIndex) > valueToFind Then
                indexOfBigger = toIndex
                indexOfLess = Integer.MinValue
            Else
                indexOfBigger = Integer.MinValue
                indexOfLess = toIndex
            End If
            Return False
        End Function

        Public Shared Function FindIndexOfNearestElementBigger(ByVal inputArray() As Double, ByVal valueToFind As Double, ByVal fromIndex As Integer, ByVal toIndex As Integer) As Integer
            If inputArray Is Nothing Then
                Throw New Exception("Alg_ArrayFunctions.findIndexOfNearestElement: input array is null")
            End If
            If inputArray.Length = 0 Then
                Throw New Exception("Alg_ArrayFunctions.findIndexOfNearestElement: input array is empty")
            End If

            Dim smallestDifference As Double = Double.MaxValue
            Dim nearestElement As Integer = 0
            Dim difference As Double

            For i As Integer = fromIndex To toIndex
                difference = Math.Abs(inputArray(i) - valueToFind)
                If difference < smallestDifference And inputArray(i) > valueToFind Then
                    smallestDifference = difference
                    nearestElement = i
                End If
            Next
            Return nearestElement
        End Function

    End Class
End Namespace

