

Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO     'for filestream     i.e bridging

Imports System.Runtime.Serialization.Formatters.Binary      'for binary formatter  i.e. serialising and de....


Public Class frmSeq
    Private Sub frmSeq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Yeaaaaap,,,its my sequential file")
    End Sub

    Private FS As FileStream
    Private BF As BinaryFormatter
    Private Const FileName As String = "MyFile.IFM"
    Private Surname As String
    Private Number As Integer
    Private sClass As Student


    Private Sub Capture()
        sClass = New Student(Name, Surname, Number)

        sClass.Name = InputBox("Whats ur name?")
        sClass.Surname = InputBox("surname?")
        sClass.Number = CInt(InputBox("Grade?"))


    End Sub

    Private Function Display(Show As String) As String

        Show = "Name: " & sClass.Name & "   Surname: " & sClass.Surname &
               "   Number: " & sClass.Number
        Return Show
    End Function

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        FS = New FileStream(FileName, FileMode.Create, FileAccess.Write)

        FS.Close()

        MsgBox("file created")
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Capture()

    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click

        FS = New FileStream(FileName, FileMode.Open, FileAccess.Write)
        BF = New BinaryFormatter

        BF.Serialize(FS, sClass)

        FS.Close()
        FS = Nothing
        BF = Nothing

        MsgBox("Data Written to file")


    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click

        txtShowStuff.Text = CStr(sClass.Name & vbCrLf & sClass.Surname & vbCrLf & sClass.Number)

        FS = New FileStream(FileName, FileMode.Open, FileAccess.Read)
        BF = New BinaryFormatter

        While FS.Position < FS.Length
            Dim TempObj As Student
            TempObj = DirectCast(BF.Deserialize(FS), Student)
            MsgBox(TempObj.Name & vbCrLf & TempObj.Surname & vbCrLf & TempObj.Number)
        End While

        FS.Close()
        FS = Nothing
        BF = Nothing
    End Sub

End Class
