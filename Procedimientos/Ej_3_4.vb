Module Ej_3_4
    Private dato As Single

    Sub Main()

        Console.WriteLine(vbCrLf & "El valor de la Hipotenusa es: " & hipotenusa())

        Console.ReadKey()
    End Sub

    Private Function hipotenusa() As Single
        Dim lado_a As UShort
        Dim lado_b As UShort

        ingresar_dato("A") 'Paso un caracter para imprimir por pantalla
        lado_a = dato
        ingresar_dato("B")
        lado_b = dato

        Return Math.Sqrt(lado_a ^ 2 + lado_b ^ 2)
    End Function

    Private Sub ingresar_dato(lado As Char)
        Do
            dato = 0.0
            Console.Write("Ingrese Lado " & lado & " : ")
            dato = Console.ReadLine()
            If validar(dato) = 0 Then
                Exit Sub
            Else
                Console.WriteLine(vbCrLf & "DATO NO VALIDO!!!")
            End If
        Loop
    End Sub

    Private Function validar(valor As Single) As Single

        If valor < 1 Then   'Para evitar valores negativos o 0
            Return 1
        End If
        Return valor - Math.Truncate(valor) 'Extraigo parte entera

    End Function

End Module
