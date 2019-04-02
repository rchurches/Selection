Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Please")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim MyNumbers(4) As Integer
        MyNumbers(0) = 1
        MyNumbers(1) = 2
        MyNumbers(2) = 3
        MyNumbers(3) = 4
        MyNumbers(4) = 5
        MessageBox.Show("First Number is: " & MyNumbers(0))
        MessageBox.Show("Second Number is: " & MyNumbers(1))
        MessageBox.Show("Third Number is: " & MyNumbers(2))
        MessageBox.Show("Fourth Number is: " & MyNumbers(3))
        MessageBox.Show("Fifth Number is: " & MyNumbers(4))

    End Sub
End Class
