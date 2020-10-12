Public Class FlexPivotForm

    Public ReadOnly Property FlexPivot() As C1.Win.FlexPivot.C1FlexPivotPanel
        Get
            Return _c1FlexPivotPage.FlexPivotPanel
        End Get
    End Property

End Class