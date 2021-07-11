<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
Map custom field for C1Report
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

========================================================================
History of changes
========================================================================

27-Feb-2015  D.Yaitskov  <dima@componentone.com>
  * Google geocoder updated to work with the current Google API.
  * C1Mapper updated to work with C1.WPF.Maps.4 version 4.0.20143.448.

========================================================================
Introduction
========================================================================

This document describes the Map custom field for C1Report.

The Map custom field uses two assemblies from ComponentOne WPF studio: C1.WPF
and C1.WPF.Maps. Make sure that these assemblies are available and referenced by
your project.

To start using the Map custom field in the reports designer app:

- make sure the following line:

    <item value="C1.C1Report.CustomFields.4;C1.C1Report.CustomFields.Map" />

  is present in the <customfields> section of the C1ReportDesigner.EXE.settings
  file;

- run the report designer app;

- check that the map icon is present in the report designer toolbar;

- create new or open an existing report;

- click the map icon and drag it onto your report to add a Map field.

========================================================================
Map object model
========================================================================

Here is a description of the most important properties of the Map custom field.
Very briefly, the main poins of interest are:
- tile and data layers;
- legends;
- styles;
- expressions;
- auto zooming/centering and data tracking.

------------------------------------------------------------------------
Layers (TileSource, Layers collection)

The main parts of a map is the tile layer which provides raster graphics
representing the Earth surface or part of it, and zero or more layers
representing spatial data.

The tile layer is specified by the TileSource property. It may be set to a
VirtualEarth tile source (road, aerial or hybrid). The tile source may be set to
none in which case no tiles will be drawn on the map. This may be useful
especially when other layers such as KML provide enough data for the map
visualization. (Support for other tile sources will be added later.)

Note that unless the tile source is "none", the tiles are loaded from a network
location when the report runs, which may slow things down considerably.

Except for the tile layer, all other layers are contained in the Layers
collection. Currently, three layer types are supported:

- Points. A "points" layer allows to show spatial data as points on the map. A
  marker is drawn for each data row by the "points" layer.

- Lines. A "lines" layer draws a straight line between two points for each data
  row.

- KML Layer. KML (Keyhole Markup Language) is an XML based language that allows
  to describe various geographic information. For more info on KML see
  http://en.wikipedia.org/wiki/Keyhole_Markup_Language. A KML layer allows
  to load into the map and show a local or web-based KML file.

------------------------------------------------------------------------
Specifying layer data source

For each layer in the Layers collection, the layer's own RecordSource (an SQL
statement) may be specified. If it is omitted, data (except for KML layes) is
retrieved directly from the parent report (filtered according to the current
grouping scope). If provided, RecordSource is used on the parent report's
connection string.

------------------------------------------------------------------------
Tracking

The map shown by a Map field can automatically center and zoom in on the data
shown on the map. This behavior is determined by two factors:

- The AutoCenter and AutoZoom properties' values specified for the whole Map
  field, together with several related properties fine-tuning the automatic
  centering and zooming (AutoZoomPadLon, AutoZoomPadLat, MaxAutoZoom,
  RoundAutoZoom).

- The spatial data represented by the layers, provided that data is "tracked".
  Tracking (i.e. whether or not a particular piece of spatial data should be
  used for automatic centering and zooming) is determined by the layer's Track
  property. Additionally, for KML layers an expression may be specified which
  will determine whether a specific KML item should be tracked or not.

------------------------------------------------------------------------
Styles

Visual attributes of map elements are mostly defined by styles. There are
several types of styles (point marker styles, line styles and KML item styles),
the applicable type is determined by the context, i.e. points layers use point
marker styles, lines layers use line styles, and so on. Usually a style may be
specified as a data driven expression (so that the actual style depends on
runtime data), with a fallback style used by default. How style expressions are
specified and evaluated is described next.

The Map custom field contains 3 style collections:
- MarkerStyles
- LineStyles
- KmlItemStyles

These styles are available to all layers defined on the Map, and also to other
Map fields in the current report. The styles in each collection are addressable
either by index or - preferably - by name (using the Name property). When a
style expression evaluates to a string, that string is used to search for a
matching style, first in the current map and if that fails, in all other maps on
the current report (only matching type styles are searched; e.g. only
MarkerStyles collections are searched for a point marker style, and so on).

------------------------------------------------------------------------
Specifying spatial location (Longitude, Latitude, MapLocation)

Points and lines layers provide two different ways to specify spatial locations
for the data:

- As a pair of expressions that evaluate to a longitude/latitude pair at
  runtime. Typically these would directly reference corresponding data fields
  (longitude and latitude) stored in the data source.

- As a MapLocation, an expression (or a list of expressions) that evaluates to a
  string that can be used to retrieve the corresponding spatial location using
  an external online service (Google Maps). If the specified MapLocation
  contains semicolons, it is treated as a list of semicolon-delimited
  expressions, each of which is evaluated separately and then combined to use as
  the query. A typical MapLocation could look like this:

  "Address;City;PostalCode;Country"

  which would fetch Address, City, PostalCode and Country fields from the data
  source and then combine them to query the external service.

GeoCachePath: Using MapLocation may be very time consuming due to internet
access. Hence by default the retrieved spatial data is stored in a local disk
file. The path to that file is specified by the Map.GeoCachePath property. By
default the file's name is "geocache.xml", and it is stored in the same
directory as the report definition. Disabling geocaching is not recommended.

------------------------------------------------------------------------
Points layer (PointsLayer : LayerBase)

A points layer is used to show point location markers, one marker per each
record of the data source. A marker's location is specified either by a
Longitude/Latitude pair, or by a MapLocation, as desribed above.

Data access: when a points layer is processed at runtime, the record source
(either the layer's own RecordSource if specified, or the report's record source
filtered by the current group) is looped through, and a mark is drawn for each
data record.

Visual styles: the way point markers look is determined by the applied
marker style. A points layer provides a default MarkerStyle property that allows
to specify markers' shape, color and so on. Additionally, a MarkerStyleExpr
expression may be specified, in which case at runtime it will be evaluated for
each data record, and if a matching marker style is found in the MarkerStyles
collection of the current map, or failing that of other maps in the report, that
style will be applied instead of the default. (As described above, a style
expression should evaluate to a string matching a style name in the styles
collection.)

Clustering: when several point markers are located close to one another they may
be "clustered" together into a single marker. That marker always shows the
number of clustered point markers it represents. The visual style of the cluster
marker may differ from the style of the point markers, and may even vary
depending on the number of points it represents. Cluster styles are specified by
the points layer's ClusterStyles collection, if more than one styles are
provided the specific style is determined by the cluster size. Relevant points
layer properties are: ClusterDistance, ClusterDistribution and ClusterStyles.

Tracking: if the Track property is true, automatic centering and zooming
includes all layer's points.

------------------------------------------------------------------------
Lines layer (LinesLayer : LayerBase)

A lines layer is used to draw lines between points on the map, one line
connecting two points per each data record. Spatial location for each point may
be specified in the same manner as for points layer described above: either with
two Longitude/Latitude pairs (one for each end of the line), or with two
MapLocations used to request locations from an online service.

Data access: as with the points layer, a lines layer allows to specify its own
RecordSource, or uses the report's record source filtered by the current group.

Visual styles: styles are handled much in the same manner as with points layers,
but instead of MarkerStyles, the LineStyles collection is used.

Tracking: if the Track property is true, automatic centering and zooming
includes all layer's lines.

------------------------------------------------------------------------
KML layer (KmlLayer : LayerBase)

A KML Layer renders a KML (Keyhole Markup Language) or KMZ (compressed KML) file
on the map. The file name is specified by the KmlFileName property on the layer.
The file may be loaded from a URL, from a local disk file, or embedded in the
report. If the file is not embedded (EmbedKmlFile is false), and the directory
is not specified, the file is loaded from the directory containing the report
definition.

KML item expressions: when a KML layer is rendered, items present in the KML
file are processed in sequence. As each item is loaded, several expressions
specified on the layer are evaluated allowing to control the process - e.g. only
load certain items based on various criteria, or modify items's visual
attributes. Additionally, if a RecordSource is specified for the KML layer, the
data may be filtered for each KML item prior to evaluating the item expressions.
Following is a detailed explanation of the properties involved in evaluating KML
item expressions. Note that in all those expressions, the special variable
kmlItemName may be used, and refers to the KML item name that is currently being
processed.

- ItemFilterExpr: if (and only if) a RecordSource is specified on the KML layer,
  this filter is applied to the retrieved data prior to evaluating other
  expressions. For example, if the layer's record source contains a Country
  field, and the KML file includes country items, the following filter:

  kmlItemName=Country

  will ensure that for each KML item, other item expressions will evaluate with
  data corresponding to the current item's country.

- ItemTrackExpr: if specified, determines whether an item is used to
  automatically center/zoom the map. If left empty, true is assumed.

- ItemVisibleExpr: if specified, determines an item's visibility. If left empty,
  true is assumed.

- ItemStyleExpr: if this expression evaluates to a valid style name in the
  KmlItemStyles collection (of the current or any other Map in the report), this
  style is applied to the item. This may be used for instance to fill different
  states with different colors depending on a data value such as orders total
  for that state.

- ItemStyle.ItemNameExpr: the KML item style itself contains one calculated
  property, the item's name. This allows to suppress the name rendered on the
  map, or replace it with report data (such as orders total).

------------------------------------------------------------------------
Legends:

A map can have several associated legends, rendered within its bounds. To
facilitate placing a legend outside the map's bounds, the legend can be
associated with any map field in the report, so you can add an empty map field
just to hold a legend describing another map.

Legends are contained within the Legends collection of the Map field. To add a
legend, add an item to that collection. The location of a legend within its
map's bounds is determined by the LegendAlignment property. Orientation
determines whether items within the legend are placed vertically (default) or
horizontally. Several other properties allow to fine-tune the way the legend
looks.

Items within the legend are represented by the Items collection. That collection
may be populated automatically with data from non-KML layers of the current map,
if the Automatic property of the legend is set to true. In that case the Items
collection cannot be edited. Otherwise, the legend items must be added manually.

The following types of legend items are supported:

- LegendLayerStyleItem: represents a layer style. The designer allows to
  select an existing layer or style represented by the legend item. Depending on
  the selected layer style, the legend item may represent a point marker (for
  points layers/styles), a line (for line layers/styles) or a color swatch (for
  KML item styles).

- LegendColorSwatchItem: represents an arbitrary color swatch.

- LegendTextItem: represents arbitrary text.

------------------------------------------------------------------------
Walkthrough: Creating "Order Totals by State" report

Note: this walkthrough uses the following files:
- C1NWindMaps.mdb: C1NWind database with spatial and some other data added;
- us_states_abbr.kmz: a compressed KML file containing US states bounds with
  abbreviated state names.

In this walkthrough we will add a map to a report showing order totals for the
US states, summarized by state. The report without the map is very simple, it
just lists the total of all orders for each state. Here's the whole of it:

    OrderValue  StateName
    16325.15    Alaska
    3490.02     California
    115673.39   Idaho
    1947.24     Montana
    52245.9     New Mexico
    30393.93    Oregon
    31001.65    Washington
    12489.7     Wyoming

We will add a map to this report that will fill each state with a color ranging
from green for states with no orders to shades of yellow and red depending on
the total orders amount. Additionally, each state will have a circular mark with
the diameter proportional to the total, and a label stating that total. Finally,
we will add two smal inset maps to show Alaska and Hawaii.

So, here are the steps:

1) Creating the base report.

Add a new report in the designer, with C1NWindMaps.mdb as the data source,
with the following SQL query:

  SELECT Orders.ShipRegion, Orders.ShipCountry, StateNamesGeo.StateName,
  Sum([Order Details].UnitPrice*[Order Details].Quantity) AS OrderValue,
  (select Longitude from StateNamesGeo where StateNamesGeo.Abbr = Orders.ShipRegion) as Longitude,
  (select Latitude from StateNamesGeo where StateNamesGeo.Abbr = Orders.ShipRegion) as Latitude
  FROM ((Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID)
  INNER JOIN (Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID)
    ON Products.ProductID = [Order Details].ProductID)
  INNER JOIN StateNamesGeo on Orders.ShipRegion = StateNamesGeo.Abbr
  WHERE Orders.ShipCountry = "USA"
  GROUP BY Orders.ShipRegion, Orders.ShipCountry, StateNamesGeo.StateName
  ORDER BY Orders.ShipRegion;

Use the report wizard to add OrderValue and StateName fields to the detail
section, run the report to make sure that it prints data shown above.

2) Adding the main map.

We will add the map to the report's header, so make some room for it by dragging
the header's bottom edge down in the report designer. Now click on the Map
custom field icon (a globe) and drag it onto the header. Set the map's size to
12870 by 7620 twips or similar, arrange as needed.

3) Adjusting the map's properties.

Set the map's properties as follows (only non-defaults are shown here):
- AutoCenter: false
- AutoZoom: false
- CenterLatitude: 38
- CenterLongitude: -103
- ShowScale: false
- TileSource: None
- ZoomLevel: 3

Note that because we are showing the map of the US, we set the coordinates
manually as needed (in particular, we leave enough space on the right for the
Alaska and Hawaii insets).

4) Adding point marker style:

Open the MarkerStyles collection, add a single style to it. Set it's properties
as follows:
- CaptionExpr: StateName & ":" & vbCr & "$" & OrderValue
- FillColor: 120, 255, 128, 0
- Name: msTotalSales
- SizeExpr: sqr(OrderValue / 100)

This style will be used to draw circle markers on states with size indicating
the orders total. Note that the fill color is semi-transparent which works
better in this case. Note also that the size of the marker is proportional to
the square root of the order value (total). The style name (msTotalSales) will
be used to reference this style.

You may set other properties (font, stroke and text colors) as you like.

5) Adding KML item styles.

We will divide all states, depending on their orders total, into 6 groups:
- states with no orders at all;
- states with up to $10,000 order totals;
- states with order totals between $10,000 and $30,000;
- states with order totals between $30,000 and $50,000;
- states with order totals between $50,000 and $100,000;
- states with order totals above $100,000.

So we need to create a KML item style for each of those groups. Open the
KmlItemStyles collection, and add 6 styles with names corresponding to groups
listed above, and FillColor values to differentiate the states on the map:

- Name: ksNoOrders, FillColor: 143, 188, 139
- Name: ks0k10k, FillColor: 255, 250, 205
- Name: ks10k30k, FillColor: 255, 222, 173
- Name: ks30k50k, FillColor: 255, 160, 122
- Name: ks50k100k, FillColor: 205, 92, 92
- Name: ks100kup, FillColor: 178, 34, 34

The names are very important here as we will use them in KML item expressions to
select a style according to the state's order totals value.

6) Adding KML layer.

The most important part of our map is the KML layer showing the state bounds and
filling the states with the appropriate colors. To add it, go to the map's
Layers collection editor and add a KML layer. Set its properties as folows:

- KmlFileName: us_states_abbr.kmz (specifying the file name without the path
  will load the file from the same location as the report definition);

- RecordSource:

  SELECT Orders.ShipRegion,
  Sum([Order Details].UnitPrice*[Order Details].Quantity) AS OrderValue
  FROM (Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID)
  INNER JOIN (Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID)
    ON Products.ProductID = [Order Details].ProductID
  WHERE Orders.ShipCountry = "USA"
  GROUP BY Orders.ShipRegion
  ORDER BY Orders.ShipRegion;

- ItemFilterExpr: kmlItemName=ShipRegion (ensures that KML item expressions, in
  particular the style used to draw the KML item, is evaluated with data for the
  state corresponding to the current KML item);

- KmlVisibleExpr: kmlItemName<>"AK" (ensures that the main map does not show Alaska);

- ItemStyleExpr:

  iif (OrderValue > 100000, "ks100kup",
  iif (OrderValue > 50000, "ks50k100k",
  iif (OrderValue > 30000, "ks30k50k",
  iif (OrderValue > 10000, "ks10k30k",
  iif (OrderValue > 0, "ks0k10k",
    "ksNoOrders"
  )))))

  The above expression evaluates to one of our KML item style names (see above)
  depending on the current OrderValue which, as per our RecordSource, is the sum
  of all orders for a state, and ItemFilterExpr specified above ensures that
  this expression evaluates for the state currently being loaded from the KML
  file.

7) Adding circular markers.

To make the map even more visual, we also add a points layer with circular
markers placed on states, sized proportionally to the state's total orders. To
do it, add a PointsLayer to the Layers collection, and move above the KML layer
so that it shows on top of it when the map is rendered. Set the layer properties
as follows:

- MarkerStyleExpr: "msTotalSales" (this will use the style that we already added
  to the map's MarkerStyles collection; proportional sizing is built into that
  style so no need to do anything else here);
- Latitude: Latitude (use spatial data provided by the record source);
- Longitude: Longitude (use spatial data provided by the record source).

8) Adding legends.

We will add two legends to our map: a legend that is just a title, in the top
right corner, and a color key to our KML item styles, in the bottom right. To
add the legends, open the Legends collection editor.

To add the title, add an item, set its Caption to "Order Totals by State", and
leave LegendAlignment at its default TopRight value. Adjust other properties as
you see fit.

To add the color key, add another legend, set its alignment to BottomRight, and
open its Items collection to add the following items:

- Text item, with the text "Color key:" - this will be the legend's caption;

- 6 LayerStyle items, one for each of our KML item styles. For each item, select
  the style it describes from the LayerStyle dropdown - this will fill most of
  other properties automatically with values from the selected style. The only
  thing you will have to set manually is the item's text - set appropriately for
  each style, from "No orders", to "less than $30k", to "$10k-$30k" and so on to
  "$100k and up".

9) Addin inset maps.

We will add two inset maps, for Alaska and Hawaii. To do it:

- Click on the Map custom field icon, and draw two small maps over the upper
  left part of the main map for Alaska, and in the lower left part for Hawaii.

- Both inset maps will reuse styles defined on the main map, so no styles need
  to be added to the inset maps' style collections.

- Layers will duplicate the layers of the main map, so add two layers to the
  Layers collection of each inset map:

  - A points layer, with MarkerStyleExpr set to "msTotalSales", and
    MarkerVisibleExpr set to

    StateName = "Alaska"

    ("Hawaii" for the Hawaii inset), and all other properties as in the points
    layer of the main map;

  - A KML layer, with all properties (including RecordSource) copied from the
    corresponding properties of the KML layer of the main map, but with
    ItemVisibleExpr set to

    kmlItemName="AK"

    (kmlItemName="HI" for Hawaii). In particular note that ItemStyleExpr will
    work even though style names it evaluates to reference styles in another
    map's style collection.

  - Finally, add a legend with a single fixed text to each inset map, with the
    state's name.

That's it. Now run the report and make sure it works.


