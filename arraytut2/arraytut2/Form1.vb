Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numbers() As Integer
        Dim startAt, endAt, times, StoreAnswer, i As Integer
        times = Val(TextBox1.Text)
        startAt = Val(TextBox2.Text)
        endAt = Val(TextBox3.Text)
        ReDim numbers(endAt)
        For i = startAt To endAt
            StoreAnswer = i * times
            numbers(i) = StoreAnswer
            ListBox1.Items.Add(times & " X " & i & " = " & numbers(i))
        Next
    End Sub
End Class
