Module Ej_3_3
    Public exponente As UShort = 1

    Sub Main()

        Dim valor_numerico As UShort

        Console.WriteLine("Ingresar Valor: ")
        valor_numerico = Console.ReadLine()

        For ini = 1 To 5
            Console.WriteLine(vbCrLf & valor_numerico & " elevado a la " & exponente + 1 & " = " & potencia(valor_numerico))
        Next

        Console.ReadKey()
    End Sub

    Private Function potencia(valor) As UShort
        exponente += 1
        Return valor ^ exponente
    End Function

End Module
