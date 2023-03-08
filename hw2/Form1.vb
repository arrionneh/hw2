Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPayrollCalc.Click

    End Sub

    Private Sub lblState_Click(sender As Object, e As EventArgs) Handles lblState.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbldecState.Click

    End Sub

    Private Sub btnTaxCalc_Click(sender As Object, e As EventArgs) Handles btnTaxCalc.Click
        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal
        Const cdecFica = 0.0765D
        Const cdecFed = 0.22D
        Const cdecState = 0.04D
        strIncome = txtIncome.Text
        decIncome = Convert.ToDecimal(strIncome)
        decFica = decIncome * cdecFica
        decFederal = decIncome * cdecFed
        decState = decIncome * cdecState
        decNet = decIncome - decFica - decFederal - decState
        lbldecFICA.Text = Convert.ToString(decFica)
        lbldecFed.Text = Convert.ToString(decFederal)
        lbldecState.Text = Convert.ToString(decState)
        lbldecNet.Text = Convert.ToString(decNet)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtIncome.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
