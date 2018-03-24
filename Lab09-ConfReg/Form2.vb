Public Class Form2

    Function TotalCost(ByRef dblTotalCost)
        Dim dblRegistration As Double
        Dim dblDinnerandReg As Double
        Dim dblPreCon As Double

        'conference registration
        If chkRegistration.Checked = True Then
            dblRegistration = 895
        Else
            dblRegistration = 0
        End If

        'dinner and keynote speech
        If chkDinnerKeynote.Checked = True Then
            dblDinnerandReg = 30
        Else
            dblDinnerandReg = 0
        End If

        'optional preconference workshop
        If lstWorkshops.SelectedIndex = 0 Then
            dblPreCon = 295
        ElseIf lstWorkshops.SelectedIndex = 1 Then
            dblPreCon = 295
        ElseIf lstWorkshops.SelectedIndex = 2 Then
            dblPreCon = 395
        ElseIf lstWorkshops.SelectedIndex = 3 Then
            dblPreCon = 395
        ElseIf lstWorkshops.SelectedIndex = -1 Then
            dblPreCon = 0
        End If

        dblTotalCost = dblRegistration + dblDinnerandReg + dblPreCon
        Return dblTotalCost

    End Function

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'clear checkboxes and deselect items on the listbox.
        chkRegistration.Checked = False
        chkDinnerKeynote.Checked = False
        lstWorkshops.SelectedIndex = -1
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'close the form and return to "main"
        Me.Close()
    End Sub

End Class