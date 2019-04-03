Imports System.Management
Imports System.IO
Imports System.Diagnostics
Public Class Form1

    Private Sub BtnSales_Click(sender As Object, e As EventArgs) Handles BtnSales.Click
        Dim TotalCount As Single
        Label2.Text = ("Process: Working... Data Input Mode...")
        TotalCount = 0
        TxtWadges.Text = ""
        countemployee = InputBox("Please enter number of employees")
        ReDim workersname(countemployee)
        ReDim sales(countemployee)
        ReDim commission(countemployee)
        For i = 1 To countemployee
            workersname(i) = InputBox("Enter Worker " & i)
            sales(i) = InputBox("Please Enter The Sales of " & workersname(i))
            Try
                commission(i) = sales(i) * commissionrate
            Catch ex As Exception
                commission(i) = 0
            End Try
            TxtWadges.Text = TxtWadges.Text & workersname(i) & " Made $" & sales(i) & " of Sales, And has a committion of $" & commission(i) & vbCrLf & vbCrLf
            TotalCount = TotalCount + commission(i)

            Label2.Text = ("Process: Working... Data Input Mode...")

        Next

        TxtWadges.Text = TxtWadges.Text & "The Total Commition is: $" & Math.Round(TotalCount, 2) & vbCrLf
        Label2.Text = ("Process: Completed!")


    End Sub
End Class
