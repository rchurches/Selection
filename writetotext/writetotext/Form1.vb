Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        FileOpen(1, "Please.txt", OpenMode.Output)
        'set up to ope a file 1 is just giving the file a value .
        'Openmode.Output simply says to overwrite whatever iscurrently in Please.txt with what is to follow
        'This will write to the please.txt file within the Bin\Debug Folder where the run time program is
        'If please.txt does not exist here it will make it


        Dim input As String
        input = "" 'this is to ensure there are no errors in handling string at the begininning
        Do While input.ToUpper <> "STOP" 'this sets a pre test loop with a sentinel value of STOP
            input = InputBox(“Enter a sentence. Type STOP to stop”, ”Sentence”, ”STOP”)
            If input.ToUpper <> "STOP" Then
                PrintLine(1, input)
            End If
        Loop
        FileClose(1) 'This closes the file if we do notr do this we can hang the computer as it still is open in the background
    End Sub
End Class
