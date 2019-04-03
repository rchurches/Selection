Public Class Form1
    Public averageage As Single
    Public totalage As Integer
    Public howmanypeople As Byte
    Public familymember(howmanypeople) As String
    Public birthYear(howmanypeople) As Integer
    Public age(howmanypeople) As Integer

    Private Sub stats()
        averageage = totalage / howmanypeople
        txtAge.Text += vbNewLine & "Average age is " & averageage & " years old"

    End Sub
    Private Sub whodetails()
        Dim who As String
        who = InputBox("Who do you want to find")
        Dim indnum As Integer
        'Dim answer As String = Array.Find(familymember.ToArray(), Function(m) m = who)
        'MsgBox(answer)
        indnum = Array.IndexOf(familymember, who)
        MsgBox(who & "  is " & age(indnum) & " years old")
    End Sub
    Private Sub btnAgeCalc_Click(sender As Object, e As EventArgs) Handles btnEnterdata.Click
        Dim i As Integer
        Erase familymember
        Erase age
        Erase birthYear

        howmanypeople = InputBox("How many people are you going to enter?")
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

    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        stats()
    End Sub

    Private Sub btnFindPersonData_Click(sender As Object, e As EventArgs) Handles btnFindPersonData.Click
        whodetails()

    End Sub
End Class
