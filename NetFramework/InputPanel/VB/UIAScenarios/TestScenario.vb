' Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

Imports System

Namespace UIAScenarios

    ''' <summary>
    ''' Represents a single UI Automation test scenario.
    ''' Contains scenario metadata and executable action.
    ''' </summary>
    Public Class TestScenario

        ''' <summary>
        ''' Initializes a new instance of the <see cref="TestScenario"/> class.
        ''' </summary>
        ''' <param name="name">Scenario display name.</param>
        ''' <param name="description">Short scenario description.</param>
        Public Sub New(name As String, description As String)
            Me.Name = name
            Me.Description = description
        End Sub

        ''' <summary>
        ''' Gets the scenario name.
        ''' </summary>
        Public Property Name As String

        ''' <summary>
        ''' Gets the scenario description.
        ''' </summary>
        Public Property Description As String

        ''' <summary>
        ''' Gets or sets the action that executes the scenario logic.
        ''' </summary>
        Public Property Scenario As Action

    End Class

End Namespace
