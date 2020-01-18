Public Class Wallpaper_app

    'Declaring global variables'
    Dim num1, num2, num3, num4, result As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'assigning data to variables'
        num1 = cmbLength.Text
        num2 = cmbWidth.Text
        num3 = cmbHeight.Text
        num4 = cmbRollCoverage.Text

        'performing a calculation to calculate the needed single rolls of wallpaper'
        result = (2 * num3 * num2 + 2 * num1 * num3) / num4

        'adding result to a textbox to be displayed'
        txtResult.Text = Math.Round(result) + 1

        'Code to validate whether the selected number is between 10 and 35 in cmbLength and prompt the user to try again if not'
        If cmbLength.Text < 10 Or cmbLength.Text > 35 Then
            MessageBox.Show("That was not a valid option, please try selecting a number between 10 and 35 in the Length drop box", "User error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Code to validate whether the selected number is between 10 and 35 in cmbWidthand prompt the user to try again if not'
        If cmbWidth.Text < 10 Or cmbWidth.Text > 35 Then
            MessageBox.Show("That was not a valid option, please try selecting a number between 10 and 35 in the Width drop box", "User error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Code to validate whether the selected number is between 10 and 35 in cmbHeight and prompt the user to try again if not'
        If cmbHeight.Text < 10 Or cmbHeight.Text > 35 Then
            MessageBox.Show("That was not a valid option, please try selecting a number between 10 and 35 in the Height drop box", "User error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Code to validate whether the selected number is between 10 and 35 cmbRollCoverage and prompt the user to try again if not'
        If cmbRollCoverage.Text < 40 Or cmbRollCoverage.Text > 50 Then
            MessageBox.Show("That was not a valid option, please try selecting a number between 40 and 50 in the roll coverage drop box", "User error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'code to close the application'
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbLength_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLength.SelectedIndexChanged

        'Code to use Enter button as click event for btnCalculate'
        AcceptButton = btnCalculate

    End Sub

    Private Sub cmbWidth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWidth.SelectedIndexChanged

        'Code to use Enter button as click event for btnCalculate'
        AcceptButton = btnCalculate

    End Sub

    Private Sub cmbHeight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHeight.SelectedIndexChanged

        'Code to use Enter button as click event for btnCalculate'
        AcceptButton = btnCalculate

    End Sub

    Private Sub cmbRollCoverage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRollCoverage.SelectedIndexChanged

        'Code to use Enter button as click event for btnCalculate'
        AcceptButton = btnCalculate

    End Sub
End Class
