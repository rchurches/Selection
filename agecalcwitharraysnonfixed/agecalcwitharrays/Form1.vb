Public Class Form1
    Dim averageage As Single
    Dim totalage As Integer
    Dim howmanypeople As Byte
    Dim familymember(howmanypeople) As String
    Dim birthYear(howmanypeople) As Integer
    Dim age(howmanypeople) As Integer

    Private Sub stats()
        averageage = totalage / howmanypeople
        txtAge.Text += vbNewLine & "Average age is " & averageage & " years old"

    End Sub
    Private Sub btnAgeCalc_Click(sender As Object, e As EventArgs) Handles btnEnterdata.Click
        Dim i As Integer

        '  howmanypeople = InputBox("How many people are you going to enter?")
        While familymember()
            ReDim familymember(howmanypeople)
        ReDim birthYear(howmanypeople)
        ReDim age(howmanypeople)

        For count = 1 To howmanypeople
            familymember(count) = InputBox("Type family member's name")
            birthYear(count) = InputBox(" What year was " & familymember(count) & " born in?")
            txtAge.Text += vbNewLine & familymember(count) & " was born in " & birthYear(count)
        Next
        For i = 1 To howmanypeople
            age(i) = Year(Now()) - birthYear(i)
            txtAge.Text += vbNewLine & familymember(i) & " age is " & age(i) & " years old"
            totalage += age(i)
        Next

        Array.Sort(age, familymember)
        txtAge.Text += vbNewLine & " Family on order of youngest to oldest"
        For i = 1 To howmanypeople

            txtAge.Text += vbNewLine & familymember(i) & " age is " & age(i) & " years old"

        Next

        Array.Reverse(age)
        Array.Reverse(familymember)
        txtAge.Text += vbNewLine & " Family on order of oldest to youngest"
        For i = 0 To howmanypeople - 1
            txtAge.Text += vbNewLine & familymember(i) & " age is " & age(i) & " years old"
        Next


        'MsgBox("Average age of group is " & averageage)
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        stats()

    End Sub
End Class
