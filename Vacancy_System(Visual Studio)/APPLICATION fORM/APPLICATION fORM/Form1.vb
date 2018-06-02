'<<<<<<<<<<<<<<<<<<<<<<<<< VISION BOY APPLICATION FORM VERSION >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmApplicationForm

    Private Sub frmApplicationForm_Load(sender As Object, E As EventArgs) Handles MyBase.Load
        MsgBox("You must be between the age of 22 and 50 to apply for these department vacancies")
    End Sub

    Private Structure BackgroundRec
        Public Name As String
        Public Surname As String
        Public Age As Integer
        Public Day As Integer
        Public Month As String
        Public Year As Integer
        Public Gender As String
        Public Tittle As String
        Public Telephone As Integer
        Public Email As String

        Public Country As String
        Public Province As String
        Public Town_City As String
        Public Surburb_Village As String
        Public Destrict As String
        Public Religion As String
    End Structure

    Private Structure AcademicRec
        Public School As String
        Public Grade As Integer
        Public Results As Integer

        Public University_College As String
        Public Name As String
        Public Qualifiction As String
        Public Rate As String
        Public CourseName As String
    End Structure

    Private Structure VacancyRec
        Public Advert As String
        Public Department As String
        Public Permanent_Temporal As String
        Public SelfQuestion As String
    End Structure

    Private Background(1) As BackgroundRec
    Private Academic(1) As AcademicRec
    Private Vacancy(1) As VacancyRec

    Private Sub BackgroundDetails()

        Background(1).Name = InputBox("Kindly type in your name")
        txtName.Text = Background(1).Name

        Background(1).Surname = InputBox("Now enter your surname")
        txtSurname.Text = Background(1).Surname

        Background(1).Age = CInt(InputBox("Enter your age"))
        While Background(1).Age < 22
            MsgBox("You are too young to apply for these vacancies, grow a bit older and try again")
            Background(1).Age = CInt(InputBox("Enter the age that is equal to or greater than 22"))
        End While
        While Background(1).Age > 50
            MsgBox("You are too old to apply for these vacancies, try another age")
            Background(1).Age = CInt(InputBox("Enter the age that is less than or equal to 50"))
        End While
        txtAge.Text = CStr(Background(1).Age)

        Background(1).Day = CInt(InputBox("Enter the date of your birth"))
        While Background(1).Day > 31
            MsgBox("There is no birth date such as " & Background(1).Day & " try another date")
            Background(1).Day = CInt(InputBox("A month contains 31 days so enter a valid date of a month"))
        End While
        txtDay.Text = CStr(Background(1).Day)

        Background(1).Month = InputBox("On which month were you born")
        'Dim January, February, March, April, May, June, July, August, September, October, November, December As String
        'If Background(1).Month = CStr(1) Then
        '    txtMonth.Text = January
        'End If
        txtMonth.Text = Background(1).Month

        Background(1).Year = CInt(InputBox("Enter the year in which you were born"))
        txtYear.Text = CStr(Background(1).Year)

        Background(1).Tittle = InputBox("Are you Mr,Mrs or Miss?")
        txtTitle.Text = Background(1).Tittle

        Background(1).Gender = InputBox("Type in your gender")
        txtGender.Text = Background(1).Gender

        Background(1).Telephone = CInt(InputBox("Enter your telephone number in which we can contact you directly"))
        txtTelephone.Text = CStr("0" & Background(1).Telephone)

        Background(1).Email = InputBox("Type in your email to which we can send any newsletter")
        txtEmail.Text = Background(1).Email

        Background(1).Country = InputBox("Type in the name of your country")
        txtCountry.Text = Background(1).Country

        Background(1).Province = InputBox("Type in the name of your province")
        txtProvince.Text = Background(1).Province

        Background(1).Town_City = InputBox("Type in the name of town or city in which you reside")
        txtTownorCity.Text = Background(1).Town_City

        Background(1).Destrict = InputBox("Type in the name of your destrict")
        txtDestrict.Text = Background(1).Destrict

        Background(1).Surburb_Village = InputBox("Is your home a surburb or village")
        txtSurburborVillage.Text = Background(1).Surburb_Village

        Background(1).Religion = InputBox("What is the name of your religion? , eg Christianity, ZCC, Dutch, etc")
        txtReligion.Text = Background(1).Religion

    End Sub

    Private Sub btnBackGround_Click(sender As Object, e As EventArgs) Handles btnBackGround.Click
        BackgroundDetails()
    End Sub
    Private Sub btnSave1_Click(sender As Object, e As EventArgs) Handles btnSave1.Click
        MsgBox("Your background details have been saved!!, please proceed with your application")
    End Sub


    Private Sub AcademicDetails()

        Academic(1).School = InputBox("Type in the name of the secondary school you've completed")
        txtSchool.Text = Academic(1).School

        Academic(1).Grade = CInt(InputBox("Enter the highest grade passed"))
        txtGrade.Text = CStr(Academic(1).Grade)

        Academic(1).Results = CInt(InputBox("Enter the level of your final results"))
        txtResults.Text = CStr(Academic(1).Results)

        Academic(1).University_College = InputBox("Did you attend a university or College?")
        txtUniversityorCollege.Text = Academic(1).University_College

        Academic(1).Name = InputBox("Enter the name of the institution you've attended in full")
        txtName2.Text = Academic(1).Name

        Academic(1).Qualifiction = InputBox("What is the qualification you attained in this institution?, eg Honours, Degree, Diploma")
        txtQualification.Text = Academic(1).Qualifiction

        Academic(1).Rate = InputBox("Type in the rate of this qualification, eg Outstanding, Meritoriuos, etc")
        txtRate.Text = Academic(1).Rate

        Academic(1).CourseName = InputBox("Type in the name of this " & Academic(1).Qualifiction)
        txtCourseName.Text = Academic(1).CourseName

    End Sub

    Private Sub btnAcademic_Click(sender As Object, e As EventArgs) Handles btnAcademic.Click
        AcademicDetails()
    End Sub

    Private Sub btnSave2_Click(sender As Object, e As EventArgs) Handles btnSave2.Click
        MsgBox("Your academic details have been saved!!, please proceed with your application")
    End Sub


    Private Sub VacancyDetails()
        Vacancy(1).Advert = InputBox("Please tell us where you saw this advertisement, eg Newspaper, Internet, Megazine, etc")
        txtAdvert.Text = Vacancy(1).Advert

        Vacancy(1).Department = InputBox("In which department are you applying for in this vacancy?")
        txtDepartment.Text = Vacancy(1).Department

        Vacancy(1).Permanent_Temporal = InputBox("Is the job you are applying for a permanent or temporal?")
        txtPermanentorTemporal.Text = Vacancy(1).Permanent_Temporal

        Vacancy(1).SelfQuestion = InputBox("Please tell us in less than 100 words why we should hire you in this vacancy")
        txtSelfQuestion.Text = Vacancy(1).SelfQuestion

    End Sub

    Private Sub btnVacancy_Click(sender As Object, e As EventArgs) Handles btnVacancy.Click
        VacancyDetails()
    End Sub

    Private Sub btnSave3_Click(sender As Object, e As EventArgs) Handles btnSave3.Click
        MsgBox("Your vacancy information have been saved!!, please check any mistakes in your form then click submit when you are certain that all the details entered are correct")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MsgBox("Thanks for your application, you will be contacted once your application has been reviewed. GOOD BYE!!!!")
        End
    End Sub
End Class
