Dim vectorNum(19), promedio As Double
Dim i, higher As Integer
Dim vector As String

'Se solicita cada valor del arreglo
For i = 0 To vectorNum.Length - 1
    vector = InputBox("Valor: " & i + 1, "Ingrese un número real", "0,00")
    If vector = "" Then
        If MessageBox.Show("¿Seguro que desea cerrar el programa?", "Cerrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            End
        End If
            Else
        vectorNum(i) = vector
    End If
Next

'Ordenamos el array con esta funcion
Array.Sort(vectorNum)

'Calculamos el promedio
For i = 0 To vectorNum.Length - 1
    promedio = promedio + vectorNum(i)
Next
promedio = promedio / vectorNum.Length
'Variable que aumenta solo si existe número o números mayores al promedio

higher = 0
For i = 0 To vectorNum.Length - 1
    If (vectorNum(i) > promedio) Then
        higher = higher + 1
    End If
Next

'Se muestran los resultados
MsgBox("Valor máximo: " & vectorNum(vectorNum.Length - 1) & vbCrLf & "Valor mínimo: " & vectorNum(0) & vbCrLf & "Cantidad de números mayores al promedio: " & higher)
