Module Module1

    Sub Main()
        Dim UsernameArray() = {"204564 Alex", "640173 Rex", "354270 Allan", "478530 Jack", "876024 Max", "675309 Fred"}
        Dim swapped As Boolean
        Dim temp As String
        Dim maxsize As Integer
        Dim x1, x2 As String
        maxsize = 5


        swapped = True
        While swapped <> False
            swapped = False
            For count = 0 To maxsize - 1

                x1 = Mid(UsernameArray(count), 8, 1)
                x2 = Mid(UsernameArray(count + 1), 8, 1)

                If x2 < x1 Then
                    temp = UserNameArray(count)
                    UserNameArray(count) = UserNameArray(count + 1)
                    UserNameArray(count + 1) = temp
                    swapped = True
                End If

            Next
            maxsize = maxsize - 1
        End While

        For count = 0 To 5
            Console.WriteLine(count & ": " & UserNameArray(count))
        Next
        Console.ReadKey()
    End Sub

End Module
