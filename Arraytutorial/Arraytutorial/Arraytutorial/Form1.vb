Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        lstResult.Items.Clear()
        rangenum = InputBox("Enter how many numbers you want generated maximum is 255")
        ReDim MyNumbers(rangenum), Number(rangenum)
        For count = 1 To rangenum
            Randomize()
            Number(count) = count
            MyNumbers(count) = Int(Rnd() * 20) + 1
            lstResult.Items.Add("Number " & count & " is " & MyNumbers(count))
        Next

    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim usercheck As Integer
        usercheck = CInt(InputBox("Which number do you want to know?"))
        MsgBox(usercheck & "  is " & MyNumbers(usercheck))
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSortAsc.Click
        lstResult.Items.Add(vbCrLf)
        Array.Sort(MyNumbers, number)
        For count = 1 To rangenum
            Randomize()
            lstResult.Items.Add("Number " & number(count) & " is " & MyNumbers(count))
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSortDesc_Click(sender As Object, e As EventArgs) Handles btnSortDesc.Click
        lstResult.Items.Add(vbCrLf)
        Array.Reverse(MyNumbers)
        Array.Reverse(number)
        For count = 1 To rangenum
            Randomize()
            lstResult.Items.Add("Number " & number(count) & " is " & MyNumbers(count))
        Next
    End Sub
End Class
