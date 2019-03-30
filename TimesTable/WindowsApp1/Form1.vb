Public Class Form1
    Private Sub btnTimesTable_Click(sender As Object, e As EventArgs) Handles btnTimesTable.Click
        Dim product As Integer
        Dim table, num1, maxnum As Byte
        Dim buggalugs As String
        buggalugs = InputBox("Hey dude, what is your name?")

        table = InputBox(buggalugs & ", What times table do you want")
        maxnum = InputBox("How big Double you want the table?")
        txtTimesTable.Text = "Csokolom " & buggalugs & vbCrLf
        For num1 = 1 To maxnum
            product = num1 * table

            txtTimesTable.Text = txtTimesTable.Text & num1 & " X " & table & " = " & product & vbCrLf
        Next
    End Sub
End Class
