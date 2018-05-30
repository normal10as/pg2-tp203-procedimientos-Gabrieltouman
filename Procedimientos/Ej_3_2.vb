Module Ej_3_2

    Sub Main()

        Dim fecha As Date
        Dim sumar As UShort

        Console.WriteLine("Ingrese fecha: ")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese cantidad de dias a sumar: ")
        sumar = Console.ReadLine()

        Console.WriteLine(sumar_dias(fecha, sumar))

        Console.ReadKey()
    End Sub

    Private Function sumar_dias(valor1 As Date, valor2 As UShort) As String
        Return valor1.AddDays(valor2)
    End Function

End Module
