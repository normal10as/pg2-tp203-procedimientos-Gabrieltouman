Module Ej_3_1

    Sub Main()
        fecha_actual()
        Console.WriteLine("Hora Actual: " & hora_actual())

        Console.ReadKey()
    End Sub

    Private Sub fecha_actual()
        Console.WriteLine("Fecha Actual: " & Date.Today)
    End Sub

    Private Function hora_actual() As String
        Return TimeOfDay
    End Function


End Module
