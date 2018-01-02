' *********************************************
' Greg Pina
' <11/4/17>
' IT 101-401
' Assignment 13
' *********************************************

Option Strict On
Public Class frmExpenses
    Structure Expenses
        Dim intDays As Integer
        Dim intMeals As Integer
        Dim intAirfare As Integer
        Dim intHotel As Integer
        Dim intParking As Integer

    End Structure

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' close the program
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear out all controls
        txtDays.Clear()
        txtAirfare.Clear()
        txtMeals.Clear()
        txtParking.Clear()
        txtHotel.Clear()


        lblAR.ResetText()
        lblDR.ResetText()
        lblHR.ResetText()
        lblMR.ResetText()
        lblPR.ResetText()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' local variables
        Dim Expense As Expenses
        Dim dblMeals As Double
        Dim dblParking As Double
        Dim dblHotel As Double
        Dim dblAirfare As Double



        'If everything is validated then continue, else do not continue
        If Validation(Expense) = True Then

            ' call functions to calculate reimbursement
            dblMeals = CalcMeals(Expense)
            dblParking = CalcParking(Expense)
            dblHotel = CalcHotel(Expense)
            dblAirfare = CalcAirfare(Expense)

            ' pass answer to be displayed. Pass it as a string
            Display(dblParking.ToString("c"))
            Display(dblHotel.ToString("c"))
            Display(dblMeals.ToString("c"))
            Display(dblAirfare.ToString("c"))


        End If

    End Sub

    Private Function Validation(ByRef Expense As Expenses) As Boolean

        ' this will validate the input data for text box 1 using IsNumeric
        If IsNumeric(txtDays.Text) Then
            Expense.intDays = CInt(txtDays.Text)
        Else
            MessageBox.Show("Please enter numbers only for Number 1.")
            txtDays.Focus()
            txtDays.BackColor = Color.Yellow
            Return False ' reurn false as there is a problem
        End If

        ' this will validate the input data for text box 2 using IsNumeric
        If IsNumeric(txtAirfare.Text) Then
            Expense.intAirfare = CInt(txtAirfare.Text)
        Else
            MessageBox.Show("Please enter numbers only for Number 1.")
            txtAirfare.Focus()
            txtAirfare.BackColor = Color.Yellow
            Return False ' reurn false as there is a problem
        End If

        ' this will validate the input data for text box 3 using IsNumeric
        If IsNumeric(txtHotel.Text) Then
            Expense.intHotel = CInt(txtHotel.Text)
        Else
            MessageBox.Show("Please enter numbers only for Number 1.")
            txtHotel.Focus()
            txtHotel.BackColor = Color.Yellow
            Return False ' reurn false as there is a problem
        End If

        ' this will validate the input data for text box 4 using IsNumeric
        If IsNumeric(txtMeals.Text) Then
            Expense.intMeals = CInt(txtDays.Text)
        Else
            MessageBox.Show("Please enter numbers only for Number 1.")
            txtMeals.Focus()
            txtMeals.BackColor = Color.Yellow
            Return False ' reurn false as there is a problem
        End If

        ' this will validate the input data for text box 5 using IsNumeric
        If IsNumeric(txtParking.Text) Then
            Expense.intParking = CInt(txtParking.Text)
        Else
            MessageBox.Show("Please enter numbers only for Number 1.")
            txtParking.Focus()
            txtParking.BackColor = Color.Yellow
            Return False ' reurn false as there is a problem
        End If

        ' return True as we are good.
        Return True

    End Function

    Private Function CalcMeals(ByVal Meals As Expenses) As Double

        ' create local variable for answer
        Dim dblMeals As Double

        'calculate
        If Meals.intDays * 37 < Meals.intMeals Then
            dblMeals = Meals.intMeals
        Else
            dblMeals = Meals.intMeals - (Meals.intDays * 37)
        End If

        ' return the answer as a double
        Return dblMeals


    End Function

    Private Function CalcParking(ByVal Parking As Expenses) As Double

        ' create local variable for answer
        Dim dblParking As Double

        'calculate
        If Parking.intDays * 10 < Parking.intParking Then
            dblParking = Parking.intParking
        Else
            dblParking = Parking.intParking - (Parking.intDays * 10)
        End If

        ' return the answer as a double
        Return dblParking


    End Function

    Private Function CalcHotel(ByVal Hotel As Expenses) As Double

        ' create local variable for answer
        Dim dblHotel As Double

        'calculate
        If Hotel.intDays * 95 < Hotel.intHotel Then
            dblHotel = Hotel.intHotel
        Else
            dblHotel = Hotel.intHotel - (Hotel.intDays * 95)
        End If

        ' return the answer as a double
        Return dblHotel


    End Function

    Private Function CalcAirfare(ByVal Airfare As Expenses) As Double

        ' create local variable for answer
        Dim dblAirfare As Double

        'calculate
        dblAirfare = 0

        ' return the answer as a double
        Return dblAirfare


    End Function

    Private Sub Display(ByVal Reimbursement As String)

        ' display the output
        lblAR.Text = Reimbursement
        lblDR.Text = Reimbursement
        lblHR.Text = Reimbursement
        lblMR.Text = Reimbursement
        lblPR.Text = Reimbursement

    End Sub
End Class
