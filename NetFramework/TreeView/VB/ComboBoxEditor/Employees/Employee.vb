
Public Class Employee

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, chiefID As Integer, firstName As String, lastName As String, post As String, countryId As Integer)
        Me.ID = id
        Me.ChiefID = chiefID
        Me.FirstName = firstName
        Me.LastName = lastName
        Me.Post = post
        Me.CountryId = countryId
    End Sub

    Public Property ID() As Integer
    Public Property ChiefID() As Integer
    Public Property Post() As String
    Public Property LastName() As String
    Public Property FirstName() As String
    Public Property CountryId() As Integer

    Public Overrides Function ToString() As String
        Return String.Format("{0} {1}", FirstName, LastName)
    End Function

    Public Shared Function GetData() As List(Of Employee)
        Dim tlist = New List(Of Employee)()
        tlist.Add(New Employee(1, -1, "John", "Doe", "Director of sales", 0))
        tlist.Add(New Employee(10, 1, "Alex", "Red", "Manager", 0))
        tlist.Add(New Employee(100, 10, "Alfred", "Bon", "Manager's assistant", 0))
        tlist.Add(New Employee(11, 1, "Elena", "White", "Manager", 0))
        tlist.Add(New Employee(12, 1, "Eric", "Green", "Manager", 0))
        tlist.Add(New Employee(13, 1, "Sara", "Blue", "Manager", 0))
        tlist.Add(New Employee(130, 12, "Mila", "Vong", "Manager's assistant", 0))
        tlist.Add(New Employee(131, 12, "Alex", "Li", "Manager's assistant", 0))
        tlist.Add(New Employee(14, 1, "Gloria", "Black", "Manager", 0))

        tlist.Add(New Employee(2, -1, "Mary", "Sue", "Marketing director", 1))
        tlist.Add(New Employee(20, 2, "Natalie", "Ming", "Manager", 1))
        tlist.Add(New Employee(201, 20, "Ivan", "Romanov", "Manager's assistant", 1))
        tlist.Add(New Employee(202, 20, "Stan", "Heck", "Manager's assistant", 1))
        tlist.Add(New Employee(203, 20, "Don", "Milman", "Manager's assistant", 1))
        tlist.Add(New Employee(21, 2, "Joseph", "Anderson", "Manager", 1))
        tlist.Add(New Employee(210, 21, "Jack", "Gun", "Manager's assistant", 1))
        tlist.Add(New Employee(22, 2, "Olivia", "Helt", "Manager", 1))
        tlist.Add(New Employee(220, 22, "Caleb", "Iron", "Manager's assistant", 1))
        tlist.Add(New Employee(221, 22, "Dylan", "Gold", "Manager's assistant", 1))
        tlist.Add(New Employee(23, 2, "Samantha", "Silver", "Manager", 1))
        tlist.Add(New Employee(24, 2, "Tyler", "Steel", "Manager", 1))

        tlist.Add(New Employee(3, -1, "Victor", "Smith", "Security director", 2))
        tlist.Add(New Employee(31, 3, "James", "Bond", "Guard", 2))
        tlist.Add(New Employee(32, 3, "Jason", "Bourne", "Guard", 2))
        tlist.Add(New Employee(33, 3, "John", "McClane", "Guard", 2))
        tlist.Add(New Employee(34, 3, "Peter", "Parker", "Guard", 2))
        tlist.Add(New Employee(35, 3, "Tony", "Stark", "Guard", 2))

        Return tlist
    End Function
End Class