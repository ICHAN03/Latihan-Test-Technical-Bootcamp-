Module Module1

    Sub Main()
        test3()

    End Sub

    Sub test()
        Dim hari As Double = 0
        Dim temphari As Double = 0
        Dim iguana As Double = 2169
        Dim tempiguana As Double = 0
        Dim i As Integer = 0
        For i = 0 To 276
            If (i - temphari = 92) Then
                tempiguana = Math.Round(iguana * (11.1 / 100))
                iguana = Math.Round(iguana - tempiguana)
                iguana *= 2
                temphari = i
                Console.WriteLine(iguana)
            End If
        Next
        Console.ReadKey()
    End Sub
    Sub test2()
        Dim name() As String = {"D", "U", "M", "B", "W", "A", "Y", "S", "I", "D"}
        Dim tem(name.Length) As String
        Dim output As String = ""
        For f As Integer = 0 To name.Length - 1
            output = ""
            For n As Integer = 0 To name.Length - 1
                tem(n) = "="
            Next
            tem(f) = name(f)
            tem(name.Length - 1 - f) = name(f)
            For n As Integer = 0 To name.Length - 1
                output += tem(n)
            Next
            Console.WriteLine(output)
        Next

        Console.ReadKey()
    End Sub
    Sub test3()
        Dim uang As Integer
        Dim total As Integer
        Dim stock() As Integer = {0, 0, 0, 0, 0, 0, 0}
        Dim name() As String = {"50000", "20000", "10000", "5000", "2000", "1000", "500"}
        Dim ttl_kembalian As Integer = 0
        Dim te_kembalian As Integer = 0
        ttl_kembalian = uang - total
        te_kembalian = ttl_kembalian
            Dim te_kembalian While != 0
        If (te_kembalian >= 50000) Then
            te_kembalian = te_kembalian - 50000
            stock(0) += 1
        ElseIf (te_kembalian >= 20000) Then
            te_kembalian = te_kembalian - 20000
            stock(1) += 1
        ElseIf (te_kembalian >= 10000) Then
            te_kembalian = te_kembalian - 10000
            stock(2) += 1
        ElseIf (te_kembalian >= 5000) Then
            te_kembalian = te_kembalian - 5000
            stock(3) += 1
        ElseIf (te_kembalian >= 2000) Then
            te_kembalian = te_kembalian - 2000
            stock(4) += 1
        ElseIf (te_kembalian >= 1000) Then
            te_kembalian = te_kembalian - 1000
            stock(5) += 1
        ElseIf (te_kembalian >= 500) Then
            te_kembalian = te_kembalian - 500
            stock(6) += 1
            For n As Integer = 0 To name.Length - 1

                If (stock(i) > 0) Then
                End If
                    Console.WriteLine(stock(i) + " a " + name(i)
            Next
            Console.ReadKey()
    End Sub

End Module
