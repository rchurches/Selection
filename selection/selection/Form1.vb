Public Class Form1
    Public units, username, shape As String
    Public area As Single

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        username = InputBox("What is your name", "User's Name")
        shape = InputBox("What shape do you want for the Area Calculator", "Shape", "Circle, Rectangle or Triangle")
        If shape = "Circle" Then
            circle()
        End If
        If shape = "Rectangle" Then
            rectangle()
        End If
        If shape = "Triangle" Then
            triangle()
        End If

    End Sub
    Private Sub triangle()
        Dim base, height As Integer
        units = InputBox("What unit is the lenght measured in", "Units", "cm")
        height = InputBox("Please enter height", "Height")
        base = InputBox("Please enter base", "Base")
        area = Math.Round(0.5 * base * height)
        MsgBox("The area of a triangle with base of " & base & " and height of " & height & " is " & area & " " & units & " squared")
    End Sub

    Private Sub rectangle()
        Dim length, width As Integer
        units = InputBox("What unit is the length measured in", "Units", "cm")
        length = InputBox("Please enter Length", "Length")
        width = InputBox("Please enter Width", "Width")
        area = Math.Round(length * width, 2)
        MsgBox("The area of a rectangle with width of " & width & " and length of " & length & " is " & area & " " & units & " squared")
    End Sub
    Private Sub circle()
        Dim radius As Integer
        units = InputBox("What unit is the lenght measured in", "Units", "cm")
        radius = InputBox("Please enter Radius", "Radius", 5)
        area = Math.Round(Math.PI * radius ^ 2, 2)
        MsgBox("The area of a circle with radius of " & radius & " is " & area & " " & units & " squared")
    End Sub

End Class
