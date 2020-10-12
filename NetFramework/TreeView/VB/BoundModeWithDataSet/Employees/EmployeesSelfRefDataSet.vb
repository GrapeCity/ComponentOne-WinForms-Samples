Public Class EmployeesSelfRefDataSet
    Public Shared Function GetData() As DataSet

        Dim dataSet = New DataSet
        Dim employees = New DataTable("Employees")

        employees.Columns.Add("ID", Type.GetType("System.Int32"))
        employees.Columns.Add("ChiefID", Type.GetType("System.Int32"))
        employees.Columns.Add("FirstName", Type.GetType("System.String"))
        employees.Columns.Add("LastName", Type.GetType("System.String"))
        employees.Columns.Add("Post", Type.GetType("System.String"))

        employees.Rows.Add(New Object() {1, -1, "John", "Doe", "Director of sales"})
        employees.Rows.Add(New Object() {10, 1, "Alex", "Red", "Manager"})
        employees.Rows.Add(New Object() {100, 10, "Alfred", "Bon", "Manager's assistant"})
        employees.Rows.Add(New Object() {11, 1, "Elena", "White", "Manager"})
        employees.Rows.Add(New Object() {12, 1, "Eric", "Green", "Manager"})
        employees.Rows.Add(New Object() {13, 1, "Sara", "Blue", "Manager"})
        employees.Rows.Add(New Object() {130, 12, "Mila", "Vong", "Manager's assistant"})
        employees.Rows.Add(New Object() {131, 12, "Alex", "Li", "Manager's assistant"})
        employees.Rows.Add(New Object() {14, 1, "Gloria", "Black", "Manager"})

        employees.Rows.Add(New Object() {2, -1, "Mary", "Sue", "Marketing director"})
        employees.Rows.Add(New Object() {20, 2, "Natalie", "Ming", "Manager"})
        employees.Rows.Add(New Object() {201, 20, "Ivan", "Romanov", "Manager's assistant"})
        employees.Rows.Add(New Object() {202, 20, "Stan", "Heck", "Manager's assistant"})
        employees.Rows.Add(New Object() {203, 20, "Don", "Milman", "Manager's assistant"})
        employees.Rows.Add(New Object() {21, 2, "Joseph", "Anderson", "Manager"})
        employees.Rows.Add(New Object() {210, 21, "Jack", "Gun", "Manager's assistant"})
        employees.Rows.Add(New Object() {22, 2, "Olivia", "Helt", "Manager"})
        employees.Rows.Add(New Object() {220, 22, "Caleb", "Iron", "Manager's assistant"})
        employees.Rows.Add(New Object() {221, 22, "Dylan", "Gold", "Manager's assistant"})
        employees.Rows.Add(New Object() {23, 2, "Samantha", "Silver", "Manager"})
        employees.Rows.Add(New Object() {24, 2, "Tyler", "Steel", "Manager"})
        employees.Rows.Add(New Object() {3, -1, "Victor", "Smith", "Security director"})
        employees.Rows.Add(New Object() {31, 3, "James", "Bond", "Guard"})
        employees.Rows.Add(New Object() {32, 3, "Jason", "Bourne", "Guard"})
        employees.Rows.Add(New Object() {33, 3, "John", "McClane", "Guard"})
        employees.Rows.Add(New Object() {34, 3, "Peter", "Parker", "Guard"})
        employees.Rows.Add(New Object() {35, 3, "Tony", "Stark", "Guard"})

        dataSet.Tables.Add(employees)

        Return dataSet
    End Function
End Class
