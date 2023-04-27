
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Text = ""
        If CheckBox1.Checked = True Then
            Text = Text + "(loneta azul)"
        End If
        If CheckBox2.Checked = True Then
            Text = Text + "(loneta negra)"
        End If
        If CheckBox3.Checked = True Then
            Text = Text + "(loneta roja)"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim valor3 As Integer
        Dim suma As Integer
        valor1 = TextBox1.Text
        valor2 = TextBox2.Text
        valor3 = TextBox3.Text
        suma = valor1 + valor2 + valor3
        Label7.Text = suma




        Dim piezas As Integer

        Dim costuni As Integer
        piezas = TextBox5.Text



        costuni = suma / piezas
        Label13.Text = costuni

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
