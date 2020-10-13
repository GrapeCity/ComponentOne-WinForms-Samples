Public Class EmployeesTypedList
    Inherits TypedList(Of Employee)
    Public Shared Function GetData() As TypedList(Of Employee)
        Dim tlist = New TypedList(Of Employee)()
        tlist.Add(New Employee(1, -1, "John", "Doe", "Director of sales"))
        tlist.Add(New Employee(10, 1, "Alex", "Red", "Manager"))
        tlist.Add(New Employee(100, 10, "Alfred", "Bon", "Manager's assistant"))
        tlist.Add(New Employee(11, 1, "Elena", "White", "Manager"))
        tlist.Add(New Employee(12, 1, "Eric", "Green", "Manager"))
        tlist.Add(New Employee(13, 1, "Sara", "Blue", "Manager"))
        tlist.Add(New Employee(130, 12, "Mila", "Vong", "Manager's assistant"))
        tlist.Add(New Employee(131, 12, "Alex", "Li", "Manager's assistant"))
        tlist.Add(New Employee(14, 1, "Gloria", "Black", "Manager"))

        tlist.Add(New Employee(2, -1, "Mary", "Sue", "Marketing director"))
        tlist.Add(New Employee(20, 2, "Natalie", "Ming", "Manager"))
        tlist.Add(New Employee(201, 20, "Ivan", "Romanov", "Manager's assistant"))
        tlist.Add(New Employee(202, 20, "Stan", "Heck", "Manager's assistant"))
        tlist.Add(New Employee(203, 20, "Don", "Milman", "Manager's assistant"))
        tlist.Add(New Employee(21, 2, "Joseph", "Anderson", "Manager"))
        tlist.Add(New Employee(210, 21, "Jack", "Gun", "Manager's assistant"))
        tlist.Add(New Employee(22, 2, "Olivia", "Helt", "Manager"))
        tlist.Add(New Employee(220, 22, "Caleb", "Iron", "Manager's assistant"))
        tlist.Add(New Employee(221, 22, "Dylan", "Gold", "Manager's assistant"))
        tlist.Add(New Employee(23, 2, "Samantha", "Silver", "Manager"))
        tlist.Add(New Employee(24, 2, "Tyler", "Steel", "Manager"))

        tlist.Add(New Employee(3, -1, "Victor", "Smith", "Security director"))
        tlist.Add(New Employee(31, 3, "James", "Bond", "Guard"))
        tlist.Add(New Employee(32, 3, "Jason", "Bourne", "Guard"))
        tlist.Add(New Employee(33, 3, "John", "McClane", "Guard"))
        tlist.Add(New Employee(34, 3, "Peter", "Parker", "Guard"))
        tlist.Add(New Employee(35, 3, "Tony", "Stark", "Guard"))

        Return tlist
    End Function
End Class