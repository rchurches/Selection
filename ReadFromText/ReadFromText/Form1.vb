Public Class Form1
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        'step 1 Open the file
        'step 2 Do the stuff
        'Close the file
        Dim filenum As Integer
        filenum = FreeFile()
        If IO.File.Exists("hello.txt") Then


            FileOpen(filenum, "hello.txt", OpenMode.Input)
            'reading from the file
            While Not EOF(filenum)
                txtDisplay.Text += LineInput(filenum) & vbCrLf
            End While

            FileClose(filenum)
        Else
            MsgBox("The file does not exist!!!")
        End If


    End Sub
End Class
