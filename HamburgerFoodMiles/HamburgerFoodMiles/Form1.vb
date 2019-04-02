Public Class Form1
    Public bun As String
    Public bunMiles As Integer
    Public sauce As String
    Public sauceMiles As Integer
    Public totalfoodmiles As Integer

    Public patty As String
    Public pattyMiles As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboBun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBun.SelectedIndexChanged
        bun = cboBun.Text
        Select Case bun
            Case "White"
                bunMiles = 486
            Case "Wholemeal"
                bunMiles = 486
            Case "Grain"
                bunMiles = 486
            Case Else
                bunMiles = 0
        End Select
        lblBunMiles.Text = bunMiles
        totalfoodmiles = bunMiles + pattyMiles + sauceMiles
        lblTotalMiles.Text = totalfoodmiles
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub cboPatty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPatty.SelectedIndexChanged
        patty = cboPatty.Text
        Select Case patty
            Case "Beef"
                pattyMiles = 298
            Case "Chicken"
                pattyMiles = 93
            Case "Falafel"
                pattyMiles = 886
            Case Else
                pattyMiles = 0
        End Select
        lblPattyMiles.Text = pattyMiles
        totalfoodmiles = pattyMiles + bunMiles + sauceMiles
        lblTotalMiles.Text = totalfoodmiles
    End Sub

    Private Sub cboSauce_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSauce.SelectedIndexChanged
        sauce = cboSauce.Text
        Select Case sauce
            Case "Tomato Sauce"
                sauceMiles = 1618
            Case "BBQ Sauce"
                sauceMiles = 1618
            Case "Mayo"
                sauceMiles = 1312
            Case Else
                sauceMiles = 0
        End Select
        lblSauceMiles.Text = sauceMiles
        totalfoodmiles = pattyMiles + bunMiles + sauceMiles
        lblTotalMiles.Text = totalfoodmiles
    End Sub
End Class
