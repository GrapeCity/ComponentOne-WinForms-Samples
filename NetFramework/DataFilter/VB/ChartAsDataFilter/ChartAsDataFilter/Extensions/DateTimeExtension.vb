Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Runtime.CompilerServices

Namespace ChartAsDataFilter
    Module DateTimeExtensions
        Dim _gc As GregorianCalendar = New GregorianCalendar()

        <Extension()>
        Function GetQuarterNumber(ByVal day As DateTime) As Integer
            Return (day.Date.Month - 1) / 3 + 1
        End Function

        <Extension()>
        Function GetFirstDateOfQuarter(ByVal day As DateTime) As DateTime
            Return New DateTime(day.Date.Year, (day.GetQuarterNumber() - 1) * 3 + 1, 1)
        End Function

        <Extension()>
        Function GetLastDateOfQuarter(ByVal day As DateTime) As DateTime
            Return day.GetFirstDateOfQuarter().AddMonths(3).AddDays(-1)
        End Function

        <Extension()>
        Function GetWeekOfMonth(ByVal day As DateTime) As Integer
            Dim first = New DateTime(day.Year, day.Month, 1)
            Return day.GetWeekOfYear() - first.GetWeekOfYear() + 1
        End Function

        <Extension()>
        Function GetFirstDateOfWeek(ByVal day As DateTime) As DateTime
            Dim monthFirst = New DateTime(day.Year, day.Month, 1)
            Dim offset = CInt(CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek) - CInt(monthFirst.DayOfWeek)
            Dim weekNum = day.GetWeekOfMonth()
            Return If(weekNum = 1, monthFirst, monthFirst.AddDays((weekNum - 1) * 7 + offset))
        End Function

        <Extension()>
        Function GetLastDateOfWeek(ByVal day As DateTime) As DateTime
            Dim firstDate = day.GetFirstDateOfWeek()
            Dim lastDate = firstDate.AddDays(6 - CInt(firstDate.DayOfWeek))
            Return If(lastDate.Month <> day.Month, New DateTime(day.Year, day.Month, DateTime.DaysInMonth(day.Year, day.Month)), lastDate)
        End Function

        <Extension()>
        Function GetWeekOfYear(ByVal day As DateTime) As Integer
            Return _gc.GetWeekOfYear(day, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
        End Function
    End Module
End Namespace