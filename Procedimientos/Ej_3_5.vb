Module Ej_3_5
    Private dato As Single
    'Global para usar en la Funcion y pasar el resultado a la variable.
    Sub Main()

        Console.WriteLine(vbCrLf & "El Volumen es: " & volumen_cilindro())

        Console.ReadKey()
    End Sub

    Private Function volumen_cilindro() As Single
        Dim radio As UShort
        Dim altura As UShort

        ingresar_dato("Radio") 'Paso una cadena para imprimir por pantalla
        radio = dato
        ingresar_dato("Altura")
        altura = dato

        Return Math.PI * altura * radio ^ 2
    End Function

    Private Sub ingresar_dato(cadena As String)
        Do
            dato = 0.0
            Console.WriteLine(vbCrLf & "Ingrese " & cadena & " : ")
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
