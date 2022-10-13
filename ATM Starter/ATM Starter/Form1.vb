Public Class Form1
   Dim balance As Double


    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        'Close the program
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load with $1000 balance
        balance = 1000
        MsgBox("Welcome, your starting balance is $" & balance)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '1 Keypad
        Textbox1.Text = Textbox1.Text & "1"

    End Sub


    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'Deposit 

        If balance + Textbox1.Text < 0 Then
            MsgBox("Cannot complete this transaction")
        Else
            Dim old As Double
            old = balance
            balance = balance + Textbox1.Text
            MsgBox("Current Balance: " & FormatCurrency(balance))
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'Withdraw 

        If balance + -Textbox1.Text < 0 Then
            MsgBox("Cannot complete this transaction")
        Else
            Dim old As Double
            old = balance
            balance = balance + -Textbox1.Text
            MsgBox("Current Balance: " & FormatCurrency(balance))
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        '$20 Fast Cash 

        If balance + -20 < 0 Then
            MsgBox("Cannot complete this transaction")
        Else
            Dim old As Double
            old = balance
            balance = balance + -20
            MsgBox("Current Balance: " & FormatCurrency(balance))
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        '$60 Fast Cash 

        If balance + -60 < 0 Then
            MsgBox("Cannot complete this transaction")
        Else
            Dim old As Double
            old = balance
            balance = balance + -60
            MsgBox("Current Balance: " & FormatCurrency(balance))
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Clear the keypad
        Textbox1.Text = ""
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'Display the current balance
        MsgBox("Current Balance: " & balance)
    End Sub
End Class
