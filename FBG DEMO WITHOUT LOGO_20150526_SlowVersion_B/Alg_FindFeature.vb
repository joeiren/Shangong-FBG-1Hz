Namespace Opring.Algorithms
    Public NotInheritable Class Alg_FindFeature
        Private Sub New()

        End Sub

        Public Shared Function FindIndexesForAllPeaks(ByVal dataSet() As Double, ByVal numberOfPointsToUse As Integer) As Integer()

            Return findIndexesForAllExtrema(dataSet, numberOfPointsToUse, PeakOrValley.Peak)
        End Function

        Public Shared Function FindIndexesForMaxPeak(ByVal dataSet() As Double, ByVal numberOfPointsToUse As Integer) As Integer
            Dim pointsOfInterst() As Integer = findIndexesForAllExtrema(dataSet, numberOfPointsToUse, PeakOrValley.Peak)

            Dim maxPeakIndex As Integer = pointsOfInterst(0)
            Dim maxValue As Double = Double.MinValue

            For Each index As Integer In pointsOfInterst
                If dataSet(index) > maxValue Then
                    maxValue = dataSet(index)
                    maxPeakIndex = index
                End If
            Next
            Return maxPeakIndex
        End Function

        Public Shared Function FindIndexForMinValley(ByVal dataSet() As Double, ByVal numberOfPointsToUse As Integer) As Integer
            Dim pointsOfInterest() As Double = findIndexesForAllExtrema(dataSet, numberOfPointsToUse, PeakOrValley.Valley)

            Dim minValleyIndex As Integer = pointsOfInterest(0)
            Dim minValue As Double = Double.MaxValue

            For Each index As Integer In pointsOfInterest
                If dataSet(index) < minValue Then
                    minValue = dataSet(index)
                    minValleyIndex = index
                End If
            Next
            Return minValleyIndex
        End Function

        Public Shared Function FindIndexesForAllValleys(ByVal dataSet() As Double, ByVal numberOfPointsToUse As Integer) As Integer()
            Return findIndexesForAllExtrema(dataSet, numberOfPointsToUse, PeakOrValley.Valley)
        End Function

        Private Shared Function IsPeak(ByVal indexToCheck As Integer, ByVal pointsToUse As Integer, ByVal dataSet() As Double) As Boolean
            Dim peak As Boolean = True
            For i As Integer = indexToCheck - pointsToUse To indexToCheck + pointsToUse
                If i >= 0 And i <= dataSet.Length Then
                    If dataSet(i) > dataSet(indexToCheck) Then
                        peak = False
                    End If
                End If
            Next
            Return peak
        End Function

        Private Shared Function IsValley(ByVal indexToCheck As Integer, ByVal pointToUse As Integer, ByVal dataSet() As Double)
            Dim valley As Boolean = True
            For i As Integer = indexToCheck - pointToUse To indexToCheck + pointToUse
                If i >= 0 And i <= dataSet.Length Then
                    If dataSet(i) < dataSet(indexToCheck) Then
                        valley = False
                    End If
                End If
            Next
            Return valley
        End Function

        Private Shared Function findIndexesForAllExtrema(ByVal dataSet() As Double, ByVal pointsToUse As Integer, ByVal mode As PeakOrValley)
            If dataSet.Length = 0 Then
                Throw New Exception("Alg_FindFeature: Empty array")
            End If

            Dim pointsOfInterest As ArrayList = New ArrayList()
            For i As Integer = pointsToUse To dataSet.Length - pointsToUse - 2
                If mode = PeakOrValley.Peak Then
                    If IsPeak(i, pointsToUse, dataSet) Then
                        pointsOfInterest.Add(i)
                    End If
                Else
                    If IsValley(i, pointsToUse, dataSet) Then
                        pointsOfInterest.Add(i)
                    End If
                End If
            Next
            Dim indexList() As Integer = pointsOfInterest.ToArray(GetType(Integer))
            Return indexList
        End Function


    End Class

    Enum PeakOrValley
        Peak
        Valley
    End Enum
End Namespace

