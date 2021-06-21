Public Class Application
    'Member variables
    Private strFullName As String
    Private strGender As String
    Private strDoB As String
    Private strICNum As String
    Private strEmail As String
    Private intAge As String
    Private strNational As String
    Private dblCGPA As Double
    Private strCategory As String
    Private strEducation As String
    Private strEligibility As String


    'Constructor
    Public Sub Constructor()
        Debug.WriteLine("Application object being created.")
        strFullName = "(Unknown)"
        strGender = "(Unknown)"
        strDoB = "(Unknown)"
        strICNum = "(Unknown)"
        strEmail = "(Unknown)"
        strNational = "(Unknown)"
        strEducation = "(Unknown)"
        strCategory = "(Unknown)"

        intAge = 0.0
        dblCGPA = 0.0
        strEligibility = "(Unknown)"
    End Sub
    'Full Name property procedure
    Public Property FullName() As String
        Get
            Return strFullName
        End Get
        Set(ByVal value As String)
            strFullName = value
        End Set
    End Property


    'Gender property procedure
    Public Property Gender() As String
        Get
            Return strGender
        End Get
        Set(ByVal value As String)
            strGender = value
        End Set
    End Property

    'Date of Birth property procedure
    Public Property DoB() As String
        Get
            Return strDoB
        End Get
        Set(ByVal value As String)
            strDoB = value
        End Set
    End Property
    'IC Number property procedure
    Public Property ICNumber() As String
        Get
            Return strICNum
        End Get
        Set(ByVal value As String)
            strICNum = value
        End Set
    End Property
    'Email property procedure
    Public Property Email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property
    'Nationality property procedure
    Public Property Nationality() As String
        Get
            Return strNational
        End Get
        Set(ByVal value As String)
            strNational = value
        End Set
    End Property
    'Education property procedure
    Public Property Education() As String
        Get
            Return strEducation
        End Get
        Set(ByVal value As String)
            strEducation = value
        End Set
    End Property
    'Category property procedure
    Public Property Category() As String
        Get
            Return strCategory
        End Get
        Set(ByVal value As String)
            strCategory = value
        End Set
    End Property
    'Age property procedure
    Public Property Age() As Double
        Get
            Return intAge
        End Get
        Set(ByVal value As Double)
            intAge = value
        End Set
    End Property

    'CGPA property procedure
    Public Property CGPA() As Double
        Get
            Return dblCGPA
        End Get
        Set(ByVal value As Double)
            dblCGPA = value
        End Set
    End Property
    'Eligibility property procedure
    Public Property Eligibility() As String
        Get
            Return strEligibility
        End Get
        Set(ByVal value As String)
            strEligibility = value
        End Set
    End Property

End Class
