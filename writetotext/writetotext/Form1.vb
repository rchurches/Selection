Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileOpen(1, "Please.txt", OpenMode.Output)
        'PrintLine(1, "Csokolom Roberrr")
        Dim input As String
        input = ""
        Do While input.ToUpper <> "STOP"
            input = InputBox(“Enter a sentence. Type STOP to stop”, ”Sentence”, ”STOP”)
            If input.ToUpper <> "STOP" Then
                PrintLine(1, input)
            End If
        Loop
        FileClose(1)
    End Sub
End Class
