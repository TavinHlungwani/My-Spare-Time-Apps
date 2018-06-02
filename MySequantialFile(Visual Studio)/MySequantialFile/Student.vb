
Option Strict On
Option Explicit On
Option Infer Off

<Serializable()> Public Class Student         'converted to binary numbers

    Private _Name As String
    Private _Surname As String
    Private _Number As Integer

    Public Sub New(Name As String, Surname As String, Number As Integer)
        _Name = Name
        _Surname = Surname
        _Number = Number

    End Sub

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Number As Integer
        Get
            Return _Number
        End Get
        Set(value As Integer)
            _Number = value
        End Set
    End Property



    Public Property Surname As String
        Get
            Return _Surname
        End Get
        Set(value As String)
            _Surname = value
        End Set
    End Property
End Class
