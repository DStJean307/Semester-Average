Option Strict On
'Darcy St Jean 100722175
'This program takes grades from 6 courses and determines the average
Public Class frmSemesterAverage
    Dim enteredGrade As Integer
    Dim inputDouble As Double
    Dim gradeInputsLength As Integer = 6
    Dim gradeInputs(gradeInputsLength) As Integer
    Dim letterGrade As Integer
    Dim determinedLetterdGrade() As String = {"F", "D-", "D", "D+", "C-", "C", "C+", "B-", "B", "B+", "A-", "A", "A+"}
    Const NON_NUMERIC_ERROR As String = "Grades entered must be a numeric whole number"
    Const OUT_OF_RANGE_ERROR As String = "Grades entered must be between 0 and 100 inclusive"
    Const WHOLE_NUMBER_ERROR As String = "Grades entered must be a whole number"
    Const ERROR_TITLE As String = "ERROR(s)"
    Dim firstError As Boolean = False




    Public Function DetermineGrade(enteredGrade As Integer, letterGrade As Integer) As Integer
        If (enteredGrade < 50) Then
            letterGrade = 0
        ElseIf (enteredGrade <= 52) Then
            letterGrade = 1
        ElseIf (enteredGrade <= 56) Then
            letterGrade = 2
        ElseIf (enteredGrade <= 59) Then
            letterGrade = 3
        ElseIf (enteredGrade <= 62) Then
            letterGrade = 4
        ElseIf (enteredGrade <= 66) Then
            letterGrade = 5
        ElseIf (enteredGrade <= 69) Then
            letterGrade = 6
        ElseIf (enteredGrade <= 72) Then
            letterGrade = 7
        ElseIf (enteredGrade <= 76) Then
            letterGrade = 8
        ElseIf (enteredGrade <= 79) Then
            letterGrade = 9
        ElseIf (enteredGrade <= 84) Then
            letterGrade = 10
        ElseIf (enteredGrade <= 89) Then
            letterGrade = 11
        ElseIf (enteredGrade <= 100) Then
            letterGrade = 12
        End If
        Return letterGrade
    End Function
    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtFirstCourse_TextChanged(sender As Object, e As EventArgs) Handles txtFirstCourse.TextChanged
        If txtFirstCourse.Text.Trim.Length > 0 Then
            'Check for numeric value
            If (Double.TryParse(txtFirstCourse.Text, inputDouble)) Then
                'Check if input is numeric
                If (Integer.TryParse(txtFirstCourse.Text, enteredGrade)) Then
                    'Check user input and display the apropriate error or grade output
                    If (enteredGrade < 0 OrElse enteredGrade > 100) Then
                        'If the error list is empty add ERROR(s) to the beginning of the list
                        If (firstError = False) Then
                            lblErrorOutput.Text += ERROR_TITLE.ToString + vbCrLf
                            firstError = True
                        End If
                        lblErrorOutput.Text += OUT_OF_RANGE_ERROR + vbCrLf
                        txtFirstCourse.Clear()
                    Else
                        'Determines the letter grade, clears the error box and adds the grade value to the array
                        letterGrade = DetermineGrade(enteredGrade, letterGrade)
                        lblErrorOutput.Text = ""
                        firstError = False
                        lblFirstCourseGrade.Text = determinedLetterdGrade(letterGrade)
                        gradeInputs(0) = enteredGrade
                    End If

                Else
                    If (firstError = False) Then
                        lblErrorOutput.Text += ERROR_TITLE.ToString + vbCrLf
                        firstError = True
                    End If
                    lblErrorOutput.Text += WHOLE_NUMBER_ERROR + vbCrLf
                    txtFirstCourse.Clear()

                End If
            Else
                If (firstError = False) Then
                    lblErrorOutput.Text += ERROR_TITLE.ToString + vbCrLf
                    firstError = True
                End If
                lblErrorOutput.Text += NON_NUMERIC_ERROR.ToString + vbCrLf
                txtFirstCourse.Clear()
            End If
        Else
            lblFirstCourseGrade.Text = ""
        End If

    End Sub

    Private Sub txtSecondCourse_TextChanged(sender As Object, e As EventArgs) Handles txtSecondCourse.TextChanged
        If txtSecondCourse.Text.Trim.Length > 0 Then
            'Check for numeric value
            If (Double.TryParse(txtSecondCourse.Text, inputDouble)) Then
                'Check if input is numeric
                If (Integer.TryParse(txtSecondCourse.Text, enteredGrade)) Then
                    'Check user input and display the apropriate error or grade output
                    If (enteredGrade < 0 OrElse enteredGrade > 100) Then
                        'If the error list is empty add ERROR(s) to the beginning of the list
                        If (firstError = False) Then
                            lblErrorOutput.Text += ERROR_TITLE + vbCrLf
                            firstError = True
                        End If
                        lblErrorOutput.Text += OUT_OF_RANGE_ERROR + vbCrLf
                        txtSecondCourse.Clear()
                    Else
                        'Determines the letter grade, clears the error box and adds the grade value to the array
                        letterGrade = DetermineGrade(enteredGrade, letterGrade)
                        lblErrorOutput.Text = ""
                        firstError = False
                        lblSecondCourseGrade.Text = determinedLetterdGrade(letterGrade)
                        gradeInputs(1) = enteredGrade
                    End If

                Else
                    If (firstError = False) Then
                        lblErrorOutput.Text += ERROR_TITLE + vbCrLf
                        firstError = True
                    End If
                    lblErrorOutput.Text += WHOLE_NUMBER_ERROR + vbCrLf
                    txtSecondCourse.Clear()


                End If
            Else
                If (firstError = False) Then
                    lblErrorOutput.Text += ERROR_TITLE + vbCrLf
                    firstError = True
                End If
                lblErrorOutput.Text += NON_NUMERIC_ERROR.ToString + vbCrLf
                txtSecondCourse.Clear()
            End If
        Else
            lblSecondCourseGrade.Text = ""
        End If

    End Sub

    Private Sub txtThirdCourse_TextChanged(sender As Object, e As EventArgs) Handles txtThirdCourse.TextChanged
        If txtThirdCourse.Text.Trim.Length > 0 Then
            'Check for numeric value
            If (Double.TryParse(txtThirdCourse.Text, inputDouble)) Then
                'Check if input is numeric
                If (Integer.TryParse(txtThirdCourse.Text, enteredGrade)) Then
                    'Check user input and display the apropriate error or grade output
                    If (enteredGrade < 0 OrElse enteredGrade > 100) Then
                        'If the error list is empty add ERROR(s) to the beginning of the list
                        If (firstError = False) Then
                            lblErrorOutput.Text += ERROR_TITLE + vbCrLf
                            firstError = True
                        End If
                        lblErrorOutput.Text += OUT_OF_RANGE_ERROR + vbCrLf
                        txtThirdCourse.Clear()
                    Else
                        'Determines the letter grade, clears the error box and adds the grade value to the array
                        letterGrade = DetermineGrade(enteredGrade, letterGrade)
                        lblErrorOutput.Text = ""
                        firstError = False
                        lblThirdCourseGrade.Text = determinedLetterdGrade(letterGrade)
                        gradeInputs(2) = enteredGrade
                    End If

                Else
                    If (firstError = False) Then
                        lblErrorOutput.Text += ERROR_TITLE + vbCrLf
                        firstError = True
                    End If
                    lblErrorOutput.Text += WHOLE_NUMBER_ERROR + vbCrLf
                    txtThirdCourse.Clear()
                End If
            Else
                If (firstError = False) Then
                    lblErrorOutput.Text += ERROR_TITLE.ToString + vbCrLf
                    firstError = True
                End If
                lblErrorOutput.Text += NON_NUMERIC_ERROR.ToString + vbCrLf
                txtThirdCourse.Clear()
            End If
        End If
    End Sub

    Private Sub txtFourthCourse_TextChanged(sender As Object, e As EventArgs) Handles txtFourthCourse.TextChanged
        If txtFourthCourse.Text.Trim.Length > 0 Then
            'Check for numeric value
            If (Double.TryParse(txtFourthCourse.Text, inputDouble)) Then
                'Check if input is numeric
                If (Integer.TryParse(txtFourthCourse.Text, enteredGrade)) Then
                    'Check user input and display the apropriate error or grade output
                    If (enteredGrade < 0 OrElse enteredGrade > 100) Then
                        'If the error list is empty add ERROR(s) to the beginning of the list
                        If (firstError = False) Then
                            lblErrorOutput.Text += ERROR_TITLE + vbCrLf
                            firstError = True
                        End If
                        lblErrorOutput.Text += OUT_OF_RANGE_ERROR + vbCrLf
                        txtFourthCourse.Clear()
                    Else
                        'Determines the letter grade, clears the error box and adds the grade value to the array
                        letterGrade = DetermineGrade(enteredGrade, letterGrade)
                        lblErrorOutput.Text = ""
                        firstError = False
                        lblFourthCourseGrade.Text = determinedLetterdGrade(letterGrade)
                        gradeInputs(3) = enteredGrade
                    End If

                Else
                    If (firstError = False) Then
                        lblErrorOutput.Text += ERROR_TITLE + vbCrLf
                        firstError = True
                    End If
                    lblErrorOutput.Text += WHOLE_NUMBER_ERROR + vbCrLf
                    txtFourthCourse.Clear()
                End If
            Else
                If (firstError = False) Then
                    lblErrorOutput.Text += ERROR_TITLE + vbCrLf
                    firstError = True
                End If
                lblErrorOutput.Text += NON_NUMERIC_ERROR.ToString + vbCrLf
                txtFourthCourse.Clear()
            End If
        Else
            lblFourthCourseGrade.Text = ""
        End If
    End Sub

    Private Sub txtFifthCourse_TextChanged(sender As Object, e As EventArgs) Handles txtFifthCourse.TextChanged
        If txtFifthCourse.Text.Trim.Length > 0 Then
            'Check for numeric value
            If (Double.TryParse(txtFifthCourse.Text, inputDouble)) Then
                'Check if input is numeric
                If (Integer.TryParse(txtFifthCourse.Text, enteredGrade)) Then
                    'Check user input and display the apropriate error or grade output
                    If (enteredGrade < 0 OrElse enteredGrade > 100) Then
                        'If the error list is empty add ERROR(s) to the beginning of the list
                        If (firstError = False) Then
                            lblErrorOutput.Text += ERROR_TITLE + vbCrLf
                            firstError = True
                        End If
                        lblErrorOutput.Text += OUT_OF_RANGE_ERROR + vbCrLf
                        txtFifthCourse.Clear()
                    Else
                        'Determines the letter grade, clears the error box and adds the grade value to the array
                        letterGrade = DetermineGrade(enteredGrade, letterGrade)
                        lblErrorOutput.Text = ""
                        firstError = False
                        lblFifthCourseGrade.Text = determinedLetterdGrade(letterGrade)
                        gradeInputs(4) = enteredGrade
                    End If

                Else
                    If (firstError = False) Then
                        lblErrorOutput.Text += ERROR_TITLE + vbCrLf
                        firstError = True
                    End If
                    lblErrorOutput.Text += WHOLE_NUMBER_ERROR + vbCrLf
                    txtFifthCourse.Clear()
                End If
            Else
                If (firstError = False) Then
                    lblErrorOutput.Text += ERROR_TITLE + vbCrLf
                    firstError = True
                End If
                lblErrorOutput.Text += NON_NUMERIC_ERROR.ToString + vbCrLf
                txtFifthCourse.Clear()
            End If
        Else
            lblFifthCourseGrade.Text = ""
        End If
    End Sub

    Private Sub txtSixthCourse_TextChanged(sender As Object, e As EventArgs) Handles txtSixthCourse.TextChanged
        If txtSixthCourse.Text.Trim.Length > 0 Then
            'Check for numeric value
            If (Double.TryParse(txtSixthCourse.Text, inputDouble)) Then
                'Check if input is numeric
                If (Integer.TryParse(txtSixthCourse.Text, enteredGrade)) Then
                    'Check user input and display the apropriate error or grade output
                    If (enteredGrade < 0 OrElse enteredGrade > 100) Then
                        'If the error list is empty add ERROR(s) to the beginning of the list
                        If (firstError = False) Then
                            lblErrorOutput.Text += ERROR_TITLE + vbCrLf
                            firstError = True
                        End If
                        lblErrorOutput.Text += OUT_OF_RANGE_ERROR + vbCrLf
                        txtSixthCourse.Clear()
                    Else
                        'Determines the letter grade, clears the error box and adds the grade value to the array
                        letterGrade = DetermineGrade(enteredGrade, letterGrade)
                        lblErrorOutput.Text = ""
                        firstError = False
                        lblSixthCourseGrade.Text = determinedLetterdGrade(letterGrade)
                        gradeInputs(5) = enteredGrade
                    End If
                Else
                    If (firstError = False) Then
                        lblErrorOutput.Text += ERROR_TITLE + vbCrLf
                        firstError = True
                    End If
                    lblErrorOutput.Text += WHOLE_NUMBER_ERROR + vbCrLf
                    txtSixthCourse.Clear()
                End If
            Else
                If (firstError = False) Then
                    lblErrorOutput.Text += ERROR_TITLE + vbCrLf
                    firstError = True
                End If
                lblErrorOutput.Text += NON_NUMERIC_ERROR.ToString + vbCrLf
                txtSixthCourse.Clear()
            End If
        Else
            lblSixthCourseGrade.Text = ""
        End If
    End Sub

    'Calculates the average number and letter grade, sets the text boxes to read only
    'and disables the calculate button
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim gradeTotal As Integer
        Dim gradeAverage As Integer
        For gradeCounter = 0 To gradeInputsLength - 1
            gradeTotal += gradeInputs(gradeCounter)
        Next
        gradeAverage = CInt(gradeTotal / gradeInputsLength)
        letterGrade = DetermineGrade(gradeAverage, letterGrade)
        lblCourseAverage.Text = gradeAverage.ToString
        lblGradeAverage.Text = determinedLetterdGrade(letterGrade)
        btnCalculate.Enabled = False
        txtFirstCourse.ReadOnly = True
        txtSecondCourse.ReadOnly = True
        txtThirdCourse.ReadOnly = True
        txtFourthCourse.ReadOnly = True
        txtFifthCourse.ReadOnly = True
        txtSixthCourse.ReadOnly = True
    End Sub

    'Clears the form and reenables the text boxes and calculate button
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtFirstCourse.Clear()
        txtSecondCourse.Clear()
        txtThirdCourse.Clear()
        txtFourthCourse.Clear()
        txtFifthCourse.Clear()
        txtSixthCourse.Clear()
        lblCourseAverage.Text = ""
        lblGradeAverage.Text = ""
        lblFirstCourseGrade.Text = ""
        lblSecondCourseGrade.Text = ""
        lblThirdCourseGrade.Text = ""
        lblFourthCourseGrade.Text = ""
        lblFifthCourseGrade.Text = ""
        lblSixthCourseGrade.Text = ""
        lblErrorOutput.Text = ""
        txtFirstCourse.Select()
        btnCalculate.Enabled = True
        firstError = False
        txtFirstCourse.ReadOnly = False
        txtSecondCourse.ReadOnly = False
        txtThirdCourse.ReadOnly = False
        txtFourthCourse.ReadOnly = False
        txtFifthCourse.ReadOnly = False
        txtSixthCourse.ReadOnly = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
