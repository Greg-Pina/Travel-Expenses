<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenses
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblMeals = New System.Windows.Forms.Label()
        Me.lblAirfare = New System.Windows.Forms.Label()
        Me.lblHotel = New System.Windows.Forms.Label()
        Me.lblParking = New System.Windows.Forms.Label()
        Me.lblPR = New System.Windows.Forms.Label()
        Me.lblHR = New System.Windows.Forms.Label()
        Me.lblAR = New System.Windows.Forms.Label()
        Me.lblMR = New System.Windows.Forms.Label()
        Me.lblDR = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtMeals = New System.Windows.Forms.TextBox()
        Me.txtAirfare = New System.Windows.Forms.TextBox()
        Me.txtHotel = New System.Windows.Forms.TextBox()
        Me.txtParking = New System.Windows.Forms.TextBox()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(107, 452)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 25)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(307, 452)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 25)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(526, 452)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 25)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDays
        '
        Me.lblDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDays.Location = New System.Drawing.Point(56, 34)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(100, 25)
        Me.lblDays.TabIndex = 3
        Me.lblDays.Text = "Days"
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMeals
        '
        Me.lblMeals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMeals.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeals.Location = New System.Drawing.Point(56, 80)
        Me.lblMeals.Name = "lblMeals"
        Me.lblMeals.Size = New System.Drawing.Size(100, 25)
        Me.lblMeals.TabIndex = 4
        Me.lblMeals.Text = "Meals"
        Me.lblMeals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAirfare
        '
        Me.lblAirfare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAirfare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAirfare.Location = New System.Drawing.Point(56, 133)
        Me.lblAirfare.Name = "lblAirfare"
        Me.lblAirfare.Size = New System.Drawing.Size(100, 25)
        Me.lblAirfare.TabIndex = 5
        Me.lblAirfare.Text = "Airfare"
        Me.lblAirfare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHotel
        '
        Me.lblHotel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHotel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHotel.Location = New System.Drawing.Point(56, 198)
        Me.lblHotel.Name = "lblHotel"
        Me.lblHotel.Size = New System.Drawing.Size(100, 25)
        Me.lblHotel.TabIndex = 6
        Me.lblHotel.Text = "Hotel"
        Me.lblHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblParking
        '
        Me.lblParking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblParking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParking.Location = New System.Drawing.Point(56, 265)
        Me.lblParking.Name = "lblParking"
        Me.lblParking.Size = New System.Drawing.Size(100, 25)
        Me.lblParking.TabIndex = 7
        Me.lblParking.Text = "Parking"
        Me.lblParking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPR
        '
        Me.lblPR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPR.Location = New System.Drawing.Point(49, 262)
        Me.lblPR.Name = "lblPR"
        Me.lblPR.Size = New System.Drawing.Size(100, 25)
        Me.lblPR.TabIndex = 12
        Me.lblPR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHR
        '
        Me.lblHR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHR.Location = New System.Drawing.Point(49, 195)
        Me.lblHR.Name = "lblHR"
        Me.lblHR.Size = New System.Drawing.Size(100, 25)
        Me.lblHR.TabIndex = 11
        Me.lblHR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAR
        '
        Me.lblAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAR.Location = New System.Drawing.Point(49, 130)
        Me.lblAR.Name = "lblAR"
        Me.lblAR.Size = New System.Drawing.Size(100, 25)
        Me.lblAR.TabIndex = 10
        Me.lblAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMR
        '
        Me.lblMR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMR.Location = New System.Drawing.Point(49, 77)
        Me.lblMR.Name = "lblMR"
        Me.lblMR.Size = New System.Drawing.Size(100, 25)
        Me.lblMR.TabIndex = 9
        Me.lblMR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDR
        '
        Me.lblDR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDR.Location = New System.Drawing.Point(49, 31)
        Me.lblDR.Name = "lblDR"
        Me.lblDR.Size = New System.Drawing.Size(100, 25)
        Me.lblDR.TabIndex = 8
        Me.lblDR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(296, -23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 13
        '
        'txtMeals
        '
        Me.txtMeals.Location = New System.Drawing.Point(256, 80)
        Me.txtMeals.Name = "txtMeals"
        Me.txtMeals.Size = New System.Drawing.Size(100, 20)
        Me.txtMeals.TabIndex = 14
        '
        'txtAirfare
        '
        Me.txtAirfare.Location = New System.Drawing.Point(256, 133)
        Me.txtAirfare.Name = "txtAirfare"
        Me.txtAirfare.Size = New System.Drawing.Size(100, 20)
        Me.txtAirfare.TabIndex = 15
        '
        'txtHotel
        '
        Me.txtHotel.Location = New System.Drawing.Point(256, 198)
        Me.txtHotel.Name = "txtHotel"
        Me.txtHotel.Size = New System.Drawing.Size(100, 20)
        Me.txtHotel.TabIndex = 16
        '
        'txtParking
        '
        Me.txtParking.Location = New System.Drawing.Point(256, 265)
        Me.txtParking.Name = "txtParking"
        Me.txtParking.Size = New System.Drawing.Size(100, 20)
        Me.txtParking.TabIndex = 17
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(256, 34)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(100, 20)
        Me.txtDays.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDays)
        Me.GroupBox1.Controls.Add(Me.txtParking)
        Me.GroupBox1.Controls.Add(Me.txtHotel)
        Me.GroupBox1.Controls.Add(Me.txtAirfare)
        Me.GroupBox1.Controls.Add(Me.txtMeals)
        Me.GroupBox1.Controls.Add(Me.lblParking)
        Me.GroupBox1.Controls.Add(Me.lblHotel)
        Me.GroupBox1.Controls.Add(Me.lblAirfare)
        Me.GroupBox1.Controls.Add(Me.lblMeals)
        Me.GroupBox1.Controls.Add(Me.lblDays)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 360)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Expenses"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPR)
        Me.GroupBox2.Controls.Add(Me.lblHR)
        Me.GroupBox2.Controls.Add(Me.lblAR)
        Me.GroupBox2.Controls.Add(Me.lblMR)
        Me.GroupBox2.Controls.Add(Me.lblDR)
        Me.GroupBox2.Location = New System.Drawing.Point(474, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 359)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Company Reimbursals"
        '
        'frmExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 540)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmExpenses"
        Me.Text = "Travel Expenses"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDays As Label
    Friend WithEvents lblMeals As Label
    Friend WithEvents lblAirfare As Label
    Friend WithEvents lblHotel As Label
    Friend WithEvents lblParking As Label
    Friend WithEvents lblPR As Label
    Friend WithEvents lblHR As Label
    Friend WithEvents lblAR As Label
    Friend WithEvents lblMR As Label
    Friend WithEvents lblDR As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtMeals As TextBox
    Friend WithEvents txtAirfare As TextBox
    Friend WithEvents txtHotel As TextBox
    Friend WithEvents txtParking As TextBox
    Friend WithEvents txtDays As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
