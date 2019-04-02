Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim function_date As Date
        Dim criterion, year_input As Integer
        criterion = 2000
        function_date = InputBox("Please enter date")
        year_input = Year(function_date)
        ' MsgBox(year_input)
        MsgBox(Int((year_input - criterion) / 10))
        If year_input > criterion Then
            MsgBox("This Millenium")

            If Int((year_input - criterion)) < 1 Then
                MsgBox("This Decade")
            Else
                MsgBox("Yet to occur")
            End If
        Else
            MsgBox("Not This Millenium")


        End If
    End Sub
End Class
