Public Class Form1
    Private Sub btnOneWay_Click(sender As Object, e As EventArgs) Handles btnOneWay.Click
        Dim cartoon As String
        Dim randnum As Byte
        Randomize()
        randnum = Int(Rnd() * 2) + 1
        If randnum = 1 Then
            MsgBox("Good")
        End If

    End Sub
End Class
