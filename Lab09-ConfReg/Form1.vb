Public Class Form1

    Public dblTotalCost As Double

    Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click

        Dim conferenceOptions As New Form2()

        'Display a form that allow the user to select Conference Options. 
        Form2.ShowDialog()
        Dim cost As Double = Form2.TotalCost(dblTotalCost)
        'show the total cost 
        lblTotal.Text = dblTotalCost.ToString("c")
    End Sub


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'clear everything.
        lblTotal.Text = "$0.00"
        dblTotalCost = 0
        txtName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZip.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtCompany.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'exit the application
        Me.Close()
    End Sub

End Class