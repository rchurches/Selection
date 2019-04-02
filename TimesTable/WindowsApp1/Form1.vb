Public Class Form1
    Private Sub btnTimesTable_Click(sender As Object, e As EventArgs) Handles btnTimesTable.Click
        Dim product As Integer
        Dim table As Byte
        Dim buggalugs As String
        buggalugs = InputBox("Hey dude, what is your name?")

        table = InputBox(buggalugs & ", What times table do you want")
        txtTimesTable.Text = "Csokolom " & buggalugs
        For count = 1 To 12
            product = count * table
            txtTimesTable.Text = txtTimesTable.Text & product & vbCrLf
        Next
    End Sub
End Class
