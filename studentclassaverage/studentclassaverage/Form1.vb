Public Class Form1
    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click

        Dim class_size As Byte
        class_size = InputBox("What is the size of the class?")
        Dim student_name(class_size) As String
        Dim test1(class_size), test2(class_size), test3(class_size), test4(class_size), assignment(class_size), student_average(class_size) As Single
        For i = 1 To class_size
            student_name(class_size) = InputBox("What is the student's name?")
            test1(class_size) = InputBox("What was " & student_name(i) & "'s  result for test 1?")
            txtClass.Text += student_name(i) & "'s  result for test 1 was " & test1(class_size) & vbCrLf
            test2(class_size) = InputBox("What was " & student_name(i) & "'s  result for test 2?")
            txtClass.Text += student_name(i) & "'s  result for test 2 was " & test2(class_size) & vbCrLf
            test3(class_size) = InputBox("What was " & student_name(i) & "'s  result for test 3?")
            txtClass.Text += student_name(i) & "'s  result for test 3 was " & test3(class_size) & vbCrLf
            test4(class_size) = InputBox("What was " & student_name(i) & "'s  result for test 4?")
            txtClass.Text += student_name(i) & "'s  result for test 4 was " & test4(class_size) & vbCrLf
            assignment(class_size) = InputBox("What was " & student_name(i) & "'s  result for their assignment?")
            txtClass.Text += student_name(i) & "'s  result for assignment was " & assignment(class_size) & vbCrLf
            student_average(class_size) = (test1(class_size) + test2(class_size) + test3(class_size) + test4(class_size) + student_average(class_size)) / 5
            txtClass.Text += student_name(i) & "'s  average level for 5 assessments was " & student_average(class_size) & vbCrLf & vbCrLf
        Next

    End Sub
End Class
