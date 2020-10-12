Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Public Class Employee
    Private Shared s_rnd As Random = New Random()
    Private Shared s_names As String() = New String() {"John", "Alex", "Alfred", "Elena", "Eric", "Sara", "Mila", "Gloria", "Mary", "Natalie", "Ivan", "Stan", "Don", "Joseph", "Jack", "Olivia", "Caleb", "Dylan", "Samantha", "Tyler", "Victor", "James", "Jason", "Peter", "Tony"}
    Private Shared s_lastNames As String() = New String() {"Doe", "Red", "Bon", "White", "Green", "Blue", "Vong", "Li", "Black", "Sue", "Ming", "Romanov", "Heck", "Milman", "Anderson", "Gun", "Helt", "Iron", "Gold", "Silver", "Steel", "Smith", "Bond", "Bourne", "McClane", "Parker", "Stark"}
    Public Shared ReadOnly Property Posts As Post() = New Post() {New Post() With {
        .Id = 0,
        .Title = "Engineer"
    }, New Post() With {
        .Id = 1,
        .Title = "Manager"
    }, New Post() With {
        .Id = 2,
        .Title = "Manager's assistant"
    }, New Post() With {
        .Id = 3,
        .Title = "Security"
    }, New Post() With {
        .Id = 4,
        .Title = "Secretary"
    }, New Post() With {
        .Id = 5,
        .Title = "Accountant"
    }, New Post() With {
        .Id = 6,
        .Title = "HR"
    }, New Post() With {
        .Id = 7,
        .Title = "Courier"
    }, New Post() With {
        .Id = 8,
        .Title = "Cleaner"
    }}
    Public Shared ReadOnly Property Countries As Country() = New Country() {New Country() With {
        .Id = 0,
        .Name = "Canada"
    }, New Country() With {
        .Id = 1,
        .Name = "China"
    }, New Country() With {
        .Id = 2,
        .Name = "Germany"
    }, New Country() With {
        .Id = 3,
        .Name = "Ireland"
    }, New Country() With {
        .Id = 4,
        .Name = "Japan"
    }, New Country() With {
        .Id = 5,
        .Name = "New Zealand"
    }, New Country() With {
        .Id = 6,
        .Name = "Poland"
    }, New Country() With {
        .Id = 7,
        .Name = "United Kingdom"
    }, New Country() With {
        .Id = 8,
        .Name = "United States"
    }}
    <Browsable(False)>
    Public Property Id As Integer
    <DisplayName("Post")>
    Public Property PostId As Integer
    Public Property Name As String
    <DisplayName("Last name")>
    Public Property LastName As String
    <DisplayName("Employment date")>
    Public Property EmploymentDate As DateTime
    <DisplayName("Country")>
    <Range(0, 8)>
    Public Property CountryId As Integer

    Public Shared Function GenerateData() As List(Of Employee)
        Dim list = New List(Of Employee)()
        Dim today = DateTime.Today
        For i As Integer = 0 To 10000000 - 1
            list.Add(New Employee() With {
                .Name = s_names(s_rnd.[Next](0, s_names.Length)),
                .LastName = s_lastNames(s_rnd.[Next](0, s_lastNames.Length)),
                .PostId = s_rnd.[Next](0, Posts.Max(Function(x) x.Id) + 1),
                .Id = i,
                .EmploymentDate = today.AddYears(-s_rnd.[Next](2, 25)),
                .CountryId = s_rnd.[Next](0, 9)
            })
        Next

        Return list
    End Function
End Class

Public Class Post
    Public Property Id As Integer
    Public Property Title As String
End Class

Public Class Country
    Public Property Id As Integer
    Public Property Name As String
End Class