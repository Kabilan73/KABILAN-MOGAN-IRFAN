Public Class incomeclassForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close the form.
        Me.Close()

    End Sub

    Private Sub btnClick_click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim dblNum As Double

        If IsNumeric(txtNum.Text) Then
            dblNum = txtNum.Text
            If (dblNum <= 4849) Then
                lblResult.Text = "RM" & txtNum.Text & " is under B40 category" 'B40 if the household income is less than or equal RM 4849 per month
            ElseIf (dblNum <= 10959) Then
                lblResult.Text = "RM" & txtNum.Text & " is under M40 category" 'M40 if the household income is less than or equal to RM 10959 per month
            Else
                lblResult.Text = "RM" & txtNum.Text & " is under T20 category" 'T20 if the household income is greater than 10959

            End If
        Else
            lblResult.Text = "Value must be numeric" 'If the input is not numeric, it will display "Value must be numeric"
        End If

        txtNum.Text = ""
        txtNum.Focus()


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNum.Text = String.Empty 'Clear txtNum Field
        lblResult.Text = String.Empty 'Clear lblResult 

        txtNum.Focus()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub incomeclassForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class