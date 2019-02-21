<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterAverage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtFirstCourse = New System.Windows.Forms.TextBox()
        Me.txtSecondCourse = New System.Windows.Forms.TextBox()
        Me.txtThirdCourse = New System.Windows.Forms.TextBox()
        Me.txtFourthCourse = New System.Windows.Forms.TextBox()
        Me.txtFifthCourse = New System.Windows.Forms.TextBox()
        Me.txtSixthCourse = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFirstCourse = New System.Windows.Forms.Label()
        Me.lblSecondCourse = New System.Windows.Forms.Label()
        Me.lblThirdCourse = New System.Windows.Forms.Label()
        Me.lblFourthCourse = New System.Windows.Forms.Label()
        Me.lblFifthCourse = New System.Windows.Forms.Label()
        Me.lblSixthCourse = New System.Windows.Forms.Label()
        Me.lblSemesterAverages = New System.Windows.Forms.Label()
        Me.lblFirstCourseGrade = New System.Windows.Forms.Label()
        Me.lblSecondCourseGrade = New System.Windows.Forms.Label()
        Me.lblThirdCourseGrade = New System.Windows.Forms.Label()
        Me.lblFourthCourseGrade = New System.Windows.Forms.Label()
        Me.lblFifthCourseGrade = New System.Windows.Forms.Label()
        Me.lblSixthCourseGrade = New System.Windows.Forms.Label()
        Me.lblGradeAverage = New System.Windows.Forms.Label()
        Me.lblCourseAverage = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblErrorOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFirstCourse
        '
        Me.txtFirstCourse.Location = New System.Drawing.Point(145, 12)
        Me.txtFirstCourse.Name = "txtFirstCourse"
        Me.txtFirstCourse.Size = New System.Drawing.Size(100, 22)
        Me.txtFirstCourse.TabIndex = 1
        Me.txtFirstCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtFirstCourse, "Input first course grade")
        '
        'txtSecondCourse
        '
        Me.txtSecondCourse.Location = New System.Drawing.Point(145, 40)
        Me.txtSecondCourse.Name = "txtSecondCourse"
        Me.txtSecondCourse.Size = New System.Drawing.Size(100, 22)
        Me.txtSecondCourse.TabIndex = 4
        Me.txtSecondCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtSecondCourse, "Input second course grade")
        '
        'txtThirdCourse
        '
        Me.txtThirdCourse.Location = New System.Drawing.Point(145, 68)
        Me.txtThirdCourse.Name = "txtThirdCourse"
        Me.txtThirdCourse.Size = New System.Drawing.Size(100, 22)
        Me.txtThirdCourse.TabIndex = 6
        Me.txtThirdCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtThirdCourse, "Input third course grade")
        '
        'txtFourthCourse
        '
        Me.txtFourthCourse.Location = New System.Drawing.Point(145, 96)
        Me.txtFourthCourse.Name = "txtFourthCourse"
        Me.txtFourthCourse.Size = New System.Drawing.Size(100, 22)
        Me.txtFourthCourse.TabIndex = 8
        Me.txtFourthCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtFourthCourse, "Input fourth course grade")
        '
        'txtFifthCourse
        '
        Me.txtFifthCourse.Location = New System.Drawing.Point(145, 124)
        Me.txtFifthCourse.Name = "txtFifthCourse"
        Me.txtFifthCourse.Size = New System.Drawing.Size(100, 22)
        Me.txtFifthCourse.TabIndex = 10
        Me.txtFifthCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtFifthCourse, "Input fifth course grade")
        '
        'txtSixthCourse
        '
        Me.txtSixthCourse.Location = New System.Drawing.Point(145, 152)
        Me.txtSixthCourse.Name = "txtSixthCourse"
        Me.txtSixthCourse.Size = New System.Drawing.Size(100, 22)
        Me.txtSixthCourse.TabIndex = 12
        Me.txtSixthCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtSixthCourse, "Input sixth course grade")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(46, 381)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(93, 28)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Click this button to calgulate the grade average")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(145, 381)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(93, 28)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Click this button to reset the program")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(244, 381)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 28)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click this button to exit the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFirstCourse
        '
        Me.lblFirstCourse.AutoSize = True
        Me.lblFirstCourse.Location = New System.Drawing.Point(43, 12)
        Me.lblFirstCourse.Name = "lblFirstCourse"
        Me.lblFirstCourse.Size = New System.Drawing.Size(69, 17)
        Me.lblFirstCourse.TabIndex = 0
        Me.lblFirstCourse.Text = "Course &1:"
        '
        'lblSecondCourse
        '
        Me.lblSecondCourse.AutoSize = True
        Me.lblSecondCourse.Location = New System.Drawing.Point(43, 45)
        Me.lblSecondCourse.Name = "lblSecondCourse"
        Me.lblSecondCourse.Size = New System.Drawing.Size(69, 17)
        Me.lblSecondCourse.TabIndex = 3
        Me.lblSecondCourse.Text = "Course &2:"
        '
        'lblThirdCourse
        '
        Me.lblThirdCourse.AutoSize = True
        Me.lblThirdCourse.Location = New System.Drawing.Point(43, 73)
        Me.lblThirdCourse.Name = "lblThirdCourse"
        Me.lblThirdCourse.Size = New System.Drawing.Size(69, 17)
        Me.lblThirdCourse.TabIndex = 5
        Me.lblThirdCourse.Text = "Course &3:"
        '
        'lblFourthCourse
        '
        Me.lblFourthCourse.AutoSize = True
        Me.lblFourthCourse.Location = New System.Drawing.Point(43, 101)
        Me.lblFourthCourse.Name = "lblFourthCourse"
        Me.lblFourthCourse.Size = New System.Drawing.Size(69, 17)
        Me.lblFourthCourse.TabIndex = 7
        Me.lblFourthCourse.Text = "Course &4:"
        '
        'lblFifthCourse
        '
        Me.lblFifthCourse.AutoSize = True
        Me.lblFifthCourse.Location = New System.Drawing.Point(43, 129)
        Me.lblFifthCourse.Name = "lblFifthCourse"
        Me.lblFifthCourse.Size = New System.Drawing.Size(69, 17)
        Me.lblFifthCourse.TabIndex = 9
        Me.lblFifthCourse.Text = "Course &5:"
        '
        'lblSixthCourse
        '
        Me.lblSixthCourse.AutoSize = True
        Me.lblSixthCourse.Location = New System.Drawing.Point(43, 157)
        Me.lblSixthCourse.Name = "lblSixthCourse"
        Me.lblSixthCourse.Size = New System.Drawing.Size(69, 17)
        Me.lblSixthCourse.TabIndex = 11
        Me.lblSixthCourse.Text = "Course &6:"
        '
        'lblSemesterAverages
        '
        Me.lblSemesterAverages.AutoSize = True
        Me.lblSemesterAverages.Location = New System.Drawing.Point(43, 185)
        Me.lblSemesterAverages.Name = "lblSemesterAverages"
        Me.lblSemesterAverages.Size = New System.Drawing.Size(72, 17)
        Me.lblSemesterAverages.TabIndex = 24
        Me.lblSemesterAverages.Text = "Semester:"
        '
        'lblFirstCourseGrade
        '
        Me.lblFirstCourseGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirstCourseGrade.Location = New System.Drawing.Point(266, 12)
        Me.lblFirstCourseGrade.Name = "lblFirstCourseGrade"
        Me.lblFirstCourseGrade.Size = New System.Drawing.Size(100, 22)
        Me.lblFirstCourseGrade.TabIndex = 16
        Me.lblFirstCourseGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblFirstCourseGrade, "The letter grade for course 1")
        '
        'lblSecondCourseGrade
        '
        Me.lblSecondCourseGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecondCourseGrade.Location = New System.Drawing.Point(265, 40)
        Me.lblSecondCourseGrade.Name = "lblSecondCourseGrade"
        Me.lblSecondCourseGrade.Size = New System.Drawing.Size(100, 22)
        Me.lblSecondCourseGrade.TabIndex = 17
        Me.lblSecondCourseGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblSecondCourseGrade, "The letter grade for course 2")
        '
        'lblThirdCourseGrade
        '
        Me.lblThirdCourseGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThirdCourseGrade.Location = New System.Drawing.Point(266, 68)
        Me.lblThirdCourseGrade.Name = "lblThirdCourseGrade"
        Me.lblThirdCourseGrade.Size = New System.Drawing.Size(100, 22)
        Me.lblThirdCourseGrade.TabIndex = 18
        Me.lblThirdCourseGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblThirdCourseGrade, "The letter grade for course 3")
        '
        'lblFourthCourseGrade
        '
        Me.lblFourthCourseGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFourthCourseGrade.Location = New System.Drawing.Point(266, 96)
        Me.lblFourthCourseGrade.Name = "lblFourthCourseGrade"
        Me.lblFourthCourseGrade.Size = New System.Drawing.Size(100, 22)
        Me.lblFourthCourseGrade.TabIndex = 19
        Me.lblFourthCourseGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblFourthCourseGrade, "The letter grade for course 4")
        '
        'lblFifthCourseGrade
        '
        Me.lblFifthCourseGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFifthCourseGrade.Location = New System.Drawing.Point(266, 124)
        Me.lblFifthCourseGrade.Name = "lblFifthCourseGrade"
        Me.lblFifthCourseGrade.Size = New System.Drawing.Size(100, 22)
        Me.lblFifthCourseGrade.TabIndex = 20
        Me.lblFifthCourseGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblFifthCourseGrade, "The letter grade for course 5")
        '
        'lblSixthCourseGrade
        '
        Me.lblSixthCourseGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSixthCourseGrade.Location = New System.Drawing.Point(266, 152)
        Me.lblSixthCourseGrade.Name = "lblSixthCourseGrade"
        Me.lblSixthCourseGrade.Size = New System.Drawing.Size(100, 22)
        Me.lblSixthCourseGrade.TabIndex = 21
        Me.lblSixthCourseGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblSixthCourseGrade, "The letter grade for course 6")
        '
        'lblGradeAverage
        '
        Me.lblGradeAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGradeAverage.Location = New System.Drawing.Point(266, 180)
        Me.lblGradeAverage.Name = "lblGradeAverage"
        Me.lblGradeAverage.Size = New System.Drawing.Size(100, 22)
        Me.lblGradeAverage.TabIndex = 23
        Me.lblGradeAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblGradeAverage, "Te average letter grade for the semester")
        '
        'lblCourseAverage
        '
        Me.lblCourseAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourseAverage.Location = New System.Drawing.Point(145, 180)
        Me.lblCourseAverage.Name = "lblCourseAverage"
        Me.lblCourseAverage.Size = New System.Drawing.Size(100, 22)
        Me.lblCourseAverage.TabIndex = 22
        Me.lblCourseAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblCourseAverage, "The average grade for the semeste")
        '
        'lblErrorOutput
        '
        Me.lblErrorOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblErrorOutput.Location = New System.Drawing.Point(12, 211)
        Me.lblErrorOutput.MaximumSize = New System.Drawing.Size(369, 167)
        Me.lblErrorOutput.MinimumSize = New System.Drawing.Size(369, 167)
        Me.lblErrorOutput.Name = "lblErrorOutput"
        Me.lblErrorOutput.Size = New System.Drawing.Size(369, 167)
        Me.lblErrorOutput.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.lblErrorOutput, "Error information output")
        '
        'frmSemesterAverage
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(393, 418)
        Me.Controls.Add(Me.lblErrorOutput)
        Me.Controls.Add(Me.lblCourseAverage)
        Me.Controls.Add(Me.lblGradeAverage)
        Me.Controls.Add(Me.lblSixthCourseGrade)
        Me.Controls.Add(Me.lblFifthCourseGrade)
        Me.Controls.Add(Me.lblFourthCourseGrade)
        Me.Controls.Add(Me.lblThirdCourseGrade)
        Me.Controls.Add(Me.lblSecondCourseGrade)
        Me.Controls.Add(Me.lblFirstCourseGrade)
        Me.Controls.Add(Me.lblSemesterAverages)
        Me.Controls.Add(Me.lblSixthCourse)
        Me.Controls.Add(Me.lblFifthCourse)
        Me.Controls.Add(Me.lblFourthCourse)
        Me.Controls.Add(Me.lblThirdCourse)
        Me.Controls.Add(Me.lblSecondCourse)
        Me.Controls.Add(Me.lblFirstCourse)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSixthCourse)
        Me.Controls.Add(Me.txtFifthCourse)
        Me.Controls.Add(Me.txtFourthCourse)
        Me.Controls.Add(Me.txtThirdCourse)
        Me.Controls.Add(Me.txtSecondCourse)
        Me.Controls.Add(Me.txtFirstCourse)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(411, 465)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(411, 465)
        Me.Name = "frmSemesterAverage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstCourse As TextBox
    Friend WithEvents txtSecondCourse As TextBox
    Friend WithEvents txtThirdCourse As TextBox
    Friend WithEvents txtFourthCourse As TextBox
    Friend WithEvents txtFifthCourse As TextBox
    Friend WithEvents txtSixthCourse As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFirstCourse As Label
    Friend WithEvents lblSecondCourse As Label
    Friend WithEvents lblThirdCourse As Label
    Friend WithEvents lblFourthCourse As Label
    Friend WithEvents lblFifthCourse As Label
    Friend WithEvents lblSixthCourse As Label
    Friend WithEvents lblSemesterAverages As Label
    Friend WithEvents lblFirstCourseGrade As Label
    Friend WithEvents lblSecondCourseGrade As Label
    Friend WithEvents lblThirdCourseGrade As Label
    Friend WithEvents lblFourthCourseGrade As Label
    Friend WithEvents lblFifthCourseGrade As Label
    Friend WithEvents lblSixthCourseGrade As Label
    Friend WithEvents lblGradeAverage As Label
    Friend WithEvents lblCourseAverage As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblErrorOutput As Label
End Class
