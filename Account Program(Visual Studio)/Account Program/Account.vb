'Option Strict On
'Option Explicit On
'Option Infer Off

Public Class Account

    Private balanceValue As Double

    Public Sub New(Optional initialBalance As Double = 0)

        If initialBalance < 1 Then
            Throw New ArgumentOutOfRangeException("initialbalance must be greater than 0")
        End If

        balanceValue = initialBalance

    End Sub

    Public Sub Deposit(depositAmount As Double)
        If depositAmount <= 0 Then
            Throw New ArgumentOutOfRangeException("Deposit cannot be a negative value")
        End If

        balanceValue += depositAmount

    End Sub

    Public Sub Withdraw(WithdrawalAmount As Double)

        If WithdrawalAmount > balanceValue Then
            Throw New ArgumentOutOfRangeException("Withdrawal amount cannot be greater than balance")

        ElseIf WithdrawalAmount <= 0 Then
            Throw New ArgumentOutOfRangeException("Withdrawal must be a positive number")
        End If

        balanceValue -= WithdrawalAmount

    End Sub

    Public ReadOnly Property Balance As Double

        Get
            Return balanceValue
        End Get
    End Property
End Class
