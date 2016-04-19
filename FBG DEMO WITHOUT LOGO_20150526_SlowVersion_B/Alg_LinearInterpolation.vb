
Namespace Opring.Algorithms

    Public NotInheritable Class Alg_LinearInterpolation

        Private Sub New()

        End Sub

        ''' <summary>
        ''' Perform linear interpolation on the specified values
        ''' </summary>
        ''' <param name="x1"></param>
        ''' <param name="y1"></param>
        ''' <param name="x2"></param>
        ''' <param name="y2"></param>
        ''' <param name="xValue">x value to interpolate for</param>
        ''' <returns>Interpolated y value</returns>
        ''' <remarks></remarks>
        Public Shared Function CalculateYbyX(ByVal x1 As Double, ByVal y1 As Double, ByVal x2 As Double, ByVal y2 As Double, _
                                             ByVal xValue As Double) As Double
            If x1 = x2 Then
                Throw New Exception("x1 = x2 is not allowed!")
            End If

            Dim gradient, interpolatedYvalue As Double
            gradient = (y2 - y1) / (x2 - x1)
            interpolatedYvalue = gradient * (xValue - x1) + y1

            Return interpolatedYvalue
        End Function

        ''' <summary>
        ''' Calculate x for yValue, given a Euclid line and a yValue
        ''' </summary>
        ''' <param name="x1">x1</param>
        ''' <param name="y1">y1</param>
        ''' <param name="x2">x2</param>
        ''' <param name="y2">y2</param>
        ''' <param name="yValue">Target y value on slope</param>
        ''' <returns>Estimated x value for target Y</returns>
        ''' <remarks></remarks>
        Public Shared Function CalculateXbyY(ByVal x1 As Double, ByVal y1 As Double, ByVal x2 As Double, ByVal y2 As Double, _
                                             ByVal yValue As Double) As Double
            If x1 = x2 Then
                Throw New Exception("x1 = x2 is not allowed!")
            End If

            Dim gradient, interpolatedXvalue As Double
            gradient = (y2 - y1) / (x2 - x1)
            interpolatedXvalue = x1 + ((yValue - y1) / gradient)

            Return interpolatedXvalue

        End Function

        Public Shared Function CalculateXbyY(ByVal xArray() As Double, ByVal yArray() As Double, ByVal y As Double) As Double
            If xArray Is Nothing Or yArray Is Nothing Then
                Throw New Exception("Null input array")
            End If

            If xArray.Length <> yArray.Length Then
                Throw New Exception("Input arrays must be Same Size")
            End If

            If xArray.Length < 2 Then
                Throw New Exception("Input array must have 2 or more elements")
            End If

            Dim yBoundingIndices As BoundingIndices
            yBoundingIndices = Alg_BoundingIndices.Calculate(yArray, y)
            Dim x As Double = -999
            If yBoundingIndices.IndexOfArrayValueLessThan = yBoundingIndices.IndexOfArrayValueGreaterThan Then
                x = xArray(yBoundingIndices.IndexOfArrayValueGreaterThan)
            Else
                Dim xArrayValueLessThanY = xArray(yBoundingIndices.IndexOfArrayValueLessThan)
                Dim xArrayValueGreaterThanY = xArray(yBoundingIndices.IndexOfArrayValueGreaterThan)
                Dim yArrayValueLessThanY = yArray(yBoundingIndices.IndexOfArrayValueLessThan)
                Dim yArrayValueGreaterThanY = yArray(yBoundingIndices.IndexOfArrayValueGreaterThan)

                x = Alg_LinearInterpolation.CalculateXbyY(xArrayValueLessThanY, yArrayValueLessThanY, xArrayValueGreaterThanY, yArrayValueGreaterThanY, y)
            End If

            Return x

        End Function

    End Class

End Namespace

