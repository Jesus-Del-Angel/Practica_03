Public Class Form1
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Resultado.Click

    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim mat1, mat2, mat3, mat4, mat5 As Double
        Dim promedio As Double

        mat1 = Val(Materia1.Text)
        mat2 = Val(Materia2.Text)
        mat3 = Val(Materia3.Text)
        mat4 = Val(Materia4.Text)
        mat5 = Val(Materia5.Text)

        promedio = (mat1 + mat2 + mat3 + mat4 + mat5) / 5

        Resultado.Text = promedio.ToString()
    End Sub
End Class
