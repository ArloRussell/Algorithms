Imports System.Globalization

Module Module1

    Sub Main()
        Dim mean, mode, count As Integer
        Dim input As String
        Dim valid As Boolean
        count = 0


        Console.Write("How many numbers are in the string? >> ")
        input = Console.ReadLine
        Dim arr As Integer
        Integer.TryParse(input, arr)
        Dim nums(arr - 1) As Integer

        For i As Integer = 0 To nums.Length - 1
            Console.Write("Please enter a number >> ")
            input = Console.ReadLine.Trim.ToLower
            Integer.TryParse(input, nums(i))
            valid = ValidNum(nums(i))
            If Not valid Then
                i -= 1
            End If
        Next
        mean = FindMean(nums)
        Console.WriteLine($"The mean is: {mean}")
    End Sub

    Function FindMean(nums() As Integer)
        Dim tot, count As Integer
        Dim mean As Double
        For i As Integer = 0 To nums.Length - 1
            tot += nums(i)
            count += 1
        Next
        mean = tot / count
        Return mean
    End Function
    Function FindMode()

    End Function
    Function ValidNum(num As Integer)
        Dim valid As Boolean = True
        If num < 0 Then
            valid = False
        End If
        Return valid
    End Function

End Module
