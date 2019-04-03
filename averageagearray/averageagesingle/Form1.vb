Public Class Form1
    Public totalage, maxage, studtotal As Integer
    Public averageage As Single
    Public studname(1) As String
    Public studage(1) As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        initialise()
        dataentry()
        results()

    End Sub
    Private Sub initialise()
        totalage = 0
        averageage = 0
        maxage = 0
        studtotal = 0
    End Sub

    Private Sub dataentry()
        Dim studentsname As String

        studname(0) = InputBox("What is the name of the first student ?")
        studage(0) = InputBox("What is the age of " & studname(0) & " ?")
        If studage(0) < 10 Or studage(0) > 18 Then
            MsgBox(" The age of the student must be between 10 and 18 inclusive, Please enter an appropriate age or the program will end")
            studage(0) = InputBox("What is the age of " & studname(0) & " ?")
            If studage(0) < 10 Or studage(0) > 18 Then
                MsgBox(" The age of the student must be between 10 and 18 inclusive,the program will now end")
                End
            End If
        End If
        totalage += studage(0)
  
        Do While studentsname <> "zz" And studtotal < 5
            studentsname = InputBox("What is the name of the next student ? ")
            If studentsname <> "zz" Then
                studtotal += 1
                ReDim Preserve studname(studtotal)
                ReDim Preserve studage(studtotal)
                studname(studtotal) = studentsname
                studage(studtotal) = InputBox("What is the age of " & studentsname)
                If studage(studtotal) < 10 Or studage(studtotal) > 18 Then
                    MsgBox(" The age of the student must be between 10 and 18 inclusive, Please enter an appropriate age or the program will end")
                    studage(studtotal) = InputBox("What is the age of " & studname(studtotal) & " ?")
                    If studage(studtotal) < 10 Or studage(studtotal) > 18 Then
                        MsgBox(" The age of the student must be between 10 and 18 inclusive,the program will now end")
                        End
                    End If
                End If
                totalage += studage(studtotal)
            End If
        Loop
        Array.Sort(studage, studname)
        'Array.Reverse(studage)
        'Array.Reverse(studname)
        For i = 0 To studtotal
            txtDisplay.Text += vbNewLine & " The age of " & studname(i) & " is " & studage(i) & " years old"
        Next

        txtDisplay.Text += vbNewLine & "The oldest student is " & studage(0)
        txtDisplay.Text += vbNewLine & "The youngest student is " & studage(studtotal)
    End Sub

    Private Sub results()
       
        averageage = totalage / (studtotal + 1)
        txtDisplay.Text += vbNewLine & " The average age of the group is " & averageage


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim namefind As String
        Dim nameindex As Integer
        namefind = InputBox("Who do want the age of ?")
        nameindex = Array.IndexOf(studname, namefind)
        MsgBox("The age of " & studname(nameindex) & " is " & studage(nameindex) & " years old")
    End Sub
End Class
