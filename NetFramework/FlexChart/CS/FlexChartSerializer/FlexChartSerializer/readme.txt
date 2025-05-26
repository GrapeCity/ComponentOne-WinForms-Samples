FlexChartSerializer
---------------------------------------------------------------------------------------
Demonstrates and provides a library to serialize and deserializer FlexChart properties.

The sample provides source for building a library (DLL) for the purposes of serializing and deserializing FlexCharts and FlexPieCharts.
Several serialization formats are addressed including XML, JSON and Binary formats.

Starting from 2025v1 release, the XML serialization is included in the chart core package C1.Chart,
so you can use it without this library. There are two extension methods: ChartSerializer.SerializeToXml()
and ChartSerializer.DeserializeFromXml() that save and restore chart state.
  
  using C1.Chart.Serialization;
  
  // save to xml
  var xmlChart = flexChart.SerializeToXml();

  // restore from xml
  flexChart.DeserializeFromXml(xmlChart);