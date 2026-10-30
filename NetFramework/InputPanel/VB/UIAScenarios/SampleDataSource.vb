' Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

Imports System.Data
Imports System.Windows.Forms

Namespace UIAScenarios

    ''' <summary>
    ''' Provides sample data sources for UI Automation test scenarios.
    ''' </summary>
    Public Module SampleDataSource

        ''' <summary>
        ''' Creates a sample products data source backed by a <see cref="BindingSource"/>.
        ''' </summary>
        ''' <returns>
        ''' A populated <see cref="BindingSource"/> containing sample product data.
        ''' </returns>
        Public Function CreateProductsSource() As BindingSource

            Dim bindingSource As New BindingSource()

            Dim dataSet As New DataSet()

            Dim table As New DataTable("Products")
            dataSet.Tables.Add(table)

            bindingSource.DataSource = dataSet
            bindingSource.DataMember = "Products"

            table.Columns.Add("Name", GetType(String))
            table.Columns.Add("Description", GetType(String))

            table.Rows.Add(
                "ProBook Laptop",
                "Reliable computer device for office work and studying.")

            table.Rows.Add(
                "Falcon Gaming Mouse",
                "High-precision computer accessory with RGB lighting.")

            table.Rows.Add(
                "KeyMaster Keyboard",
                "Mechanical computer keyboard for comfortable typing.")

            table.Rows.Add(
                "VisionX Monitor",
                "Wide-screen computer display with IPS technology.")

            table.Rows.Add(
                "PrintFast Printer",
                "Efficient computer printer for fast document printing.")

            table.Rows.Add(
                "StreamCam Webcam",
                "Compact computer camera for streaming and video calls.")

            table.Rows.Add(
                "SoundBeat Speakers",
                "Powerful computer speakers with surround sound.")

            table.Rows.Add(
                "DriveTurbo SSD",
                "Fast computer storage device for everyday use.")

            table.Rows.Add(
                "NetWave Router",
                "Advanced computer networking device with Wi‑Fi 6 support.")

            table.Rows.Add(
                "VoicePro Microphone",
                "Professional computer microphone for recording and meetings.")

            Return bindingSource

        End Function

    End Module

End Namespace
