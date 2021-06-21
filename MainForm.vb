Public Class MainForm

    Private Sub Data(ByVal s As Application)
        'Data procedure gets data from Application Object parameter
        s.FullName = txtFullName.Text 'Assign s.FullName to txtFullName.Text
        s.Gender = cbGender.Text  'Assign s.Gender to cbGender.Text
        s.DoB = txtDOB.Text  'Assign s.DOB to txtDOB.Text
        s.Email = txtEmail.Text  'Assign s.Email to txtEmail.Text
        s.ICNumber = txtICNum.Text  'Assign s.ICNumber to txtICNum.Text
        s.Age = txtAge.Text  'Assign s.Age to txtAge.Text
        s.Nationality = CBNation.Text  'Assign s.Nationality to CBNation.Text
        s.CGPA = txtCGPA.Text  'Assign s.CGPA to txtCGPA.Text
        s.Category = CBCategory.Text  'Assign s.Category to CBCategory.Text
        s.Education = CBEducation.Text  'Assign s.Education to CBEducation.Text
    End Sub

    Private Function Condition() 'Condition Function to display the eligibility status
        Dim result As String
        Dim frmDisplay As New DisplayForm

        result = ""
        If txtAge.Text < 20 Then 'Ineligible if the user is below than 20
            result = "Ineligible"
        End If
        If CBNation.Text = "Non-Malaysian" Then 'Ineligible if the user is Non-Malaysian
            result = "Ineligible"
        End If
        If txtCGPA.Text <= 3.5 Then 'Ineligible if the user's CGPA is below than 3.60
            result = "Ineligible"
        End If
        If CBCategory.Text = "M40" Or CBCategory.Text = "T20" Then 'Ineligible if the user is from M40 and T20 category
            result = "Ineligible"
        End If
        If CBEducation.Text = "Others" Then 'Ineligible if the user is not diploma or degree student in local institution
            result = "Ineligible"
        End If
        If result = "" Then
            result = "Eligible" 'Eligible if the user pass all the requirements and conditions
        End If

        Return result

    End Function

    Private Function Eligibility() 'Eligibility Function to display the reason of eligibility status
        Dim result As String
        Dim frmDisplay As New DisplayForm

        result = ""
        If txtAge.Text < 20 Then 'If the user is younger than 20 , the result will be  "You need to be older than 20 years old."
            result += "You need to be older than 18 years old." + vbNewLine
        End If
        If CBNation.Text = "Non-Malaysian" Then 'If the user is Non-Malaysiam, the result will be "Applicant must be Malaysian."
            result += "Applicant must be Malaysian." + vbNewLine
        End If
        If txtCGPA.Text <= 3.5 Then 'If the user does not meet CGPA requirement, the result will be "You dont meet CGPA requirement. "
            result += "You dont meet CGPA requirement. " + vbNewLine
        End If
        If CBCategory.Text = "M40" Or CBCategory.Text = "T20" Then 'If the user is not from B40, the result will be "You are not from B40 category. "
            result += "You are not from B40 category. " + vbNewLine
        End If
        If CBEducation.Text = "Others" Then 'If the user is not diploma or degree student, the result will be "You must be pursuing Diploma or Degree in local Institution. "
            result += "You must be pursuing Diploma or Degree in local Institution. " + vbNewLine
        End If
        If result = "" Then 'Congratulation text if the user pass all the conditions
            result = "Congratulations!" + vbNewLine + "You have passed all the requirements" + vbNewLine + "Please wait until we contact you."
        End If

        Return result

    End Function

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click 'Sub Procedure for button Result
        Dim frmDisplay As New DisplayForm

        'If Else Condition is use to display any empty input field
        If txtFullName.Text = "" Then
            MsgBox("Please enter your Full Name. This is mandatory field.") 'Display message box for Full Name
            txtFullName.Focus() 'Focus on empty input

        ElseIf cbGender.Text = "" Then
            MsgBox("Please select your gender. This is mandatory field.") 'Display message box for Gender


        ElseIf txtDOB.Text = "" Then
            MsgBox("Please enter your Date of Birth.This is mandatory field.") 'Display message box for Date of Birth
            txtDOB.Focus() 'Focus on empty input

        ElseIf txtICNum.Text = "" Then
            MsgBox("Please enter your Identification Number.This is mandatory field.") 'Display message box for IC Number
            txtICNum.Focus() 'Focus on empty input

        ElseIf txtEmail.Text = "" Then
            MsgBox("Please enter your Email.This is mandatory field.") 'Display message box for Email
            txtEmail.Focus() 'Focus on empty input

        ElseIf txtAge.Text = "" Then
            MsgBox("Please enter your Age.This is mandatory field.") 'Display message box for Age
            txtAge.Focus() 'Focus on empty input

        ElseIf CBNation.Text = "" Then
            MsgBox("Please choose a nationality.This is mandatory field.") 'Display message box for Nationality

        ElseIf CBCategory.Text = "" Then
            MsgBox("Please choose your income classification.This is mandatory field.") 'Display message box for income classification

        ElseIf CBEducation.Text = "" Then
            MsgBox("Please select your education.This is mandatory field.") 'Display message box for Education

        ElseIf txtCGPA.Text = "" Then
            MsgBox("Please state your CGPA from previous education.This is mandatory field.") 'Display message box for CGPA
            txtCGPA.Focus() 'Focus on empty input

        Else
            MsgBox("You have successfully submitted your information.") 'Display message box for sucessfull submission of details

            frmDisplay.lblReason.Text = Eligibility() 'Display reason of eligibility status in lblReason
            frmDisplay.lblStatus.Text = Condition() 'Display  eligibility status in lblStatus
            frmDisplay.ShowDialog() 'Display frmDisplay
        End If

    End Sub

    Private Sub txtDOB_LostFOcus(sender As Object, e As EventArgs) Handles txtDOB.LostFocus 'Sub Procedure Date of Birth Lost Focus
        If Len(txtDOB.Text) = 0 Then
            Exit Sub
        ElseIf Len(txtDOB.Text) < 10 Then
            MsgBox("You have entered an invalid or incorrectly formated date.") 'Display message box for incorrect date format
            txtDOB.Focus() 'Focus on the Date of Birth input field
        ElseIf IsDate(txtDOB.Text) = False Or txtDOB.Text(2) <> "/" Or txtDOB.Text(5) <> "/" Then 'Date must contain "/"
            MsgBox("You have entered an invalid or incorrectly formatted date.") 'Display message box for incorrect date format
            txtDOB.Focus() 'Focus on the Date of Birth input field
        ElseIf DateTime.Parse(txtDOB.Text) > Now.Date Or DateTime.Parse(txtDOB.Text) < DateTime.Parse("01/01/1900") Then 'Date beginning in the 1900
            MsgBox("The date you have entered is outside the acceptable range.") 'Display message box for incorrect date RANGE
            txtDOB.Focus() 'Focus on the Date of Birth input field
        End If
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus 'Sub procedure Email Lost Focus
        Dim intAt, intDot As Integer
        If Len(txtEmail.Text) = 0 Then
            Exit Sub
        Else
            intAt = InStr(1, txtEmail.Text, "@") 'Email should contain @
            intDot = InStr(intAt + 1, txtEmail.Text, ".") 'Email should have .com
            If (intAt = 0) Or (intDot = 0) Or (intDot = (intAt + 1)) _
                Or (InStr(intAt + 1, txtEmail.Text, "@") < 0) _
                 Or (Len(txtEmail.Text) < intDot + 1) _
                  Or (InStr(intDot + 1, txtEmail.Text, ".") < 0) Then
                MsgBox("You have entered invalid email address.") 'Display message box for invalid email 
                txtEmail.Focus() ' Focus on the Email input field
            End If
        End If
    End Sub
    'Sub procedure ApplicationProceduresToolStripMenuItem
    Private Sub ApplicationProceduresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicationProceduresToolStripMenuItem.Click
        AppProcedureForm.ShowDialog() 'Display AppProcedureForm
    End Sub
    'Sub procedure  EligibilityRequirementsToolStripMenuItem
    Private Sub EligibilityRequirementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EligibilityRequirementsToolStripMenuItem.Click
        ConditionForm.ShowDialog() 'Display EligibilityForm
    End Sub

    'Sub procedure IncomeToolStripMenuItem
    Private Sub IncomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncomeToolStripMenuItem.Click
        incomeclassForm.ShowDialog() 'Display  incomeclassForm
    End Sub

    'Sub procedure  ExitToolStripMenuItem
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim exitMsg As DialogResult
        'Display a message box as a confirmation to user if the user want to exit or not
        exitMsg = MsgBox("Are you sure you want to exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "B40 Laptop Aid")
        'If the user click Yes,Exit A pplication
        If exitMsg = Windows.Forms.DialogResult.Yes Then
            Windows.Forms.Application.Exit()

        Else
            'If the user click No, Return to the Application
            Return

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFullName.Text = String.Empty 'Clear Full Name input field
        cbGender.Text = String.Empty 'Clear Gender field
        txtDOB.Text = String.Empty 'Clear Date of birth input field
        txtICNum.Text = String.Empty 'Clear IC Number input field
        txtEmail.Text = String.Empty 'Clear Full Name input field
        txtAge.Text = String.Empty 'Clear Age input field
        CBNation.Text = String.Empty 'Clear Nationality field
        CBCategory.Text = String.Empty 'Clear Income classification field
        CBEducation.Text = String.Empty 'Clear Education field
        txtCGPA.Text = String.Empty 'Clear CGPA input field

        txtFullName.Focus() 'Reset the focus to Full Name input field
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
