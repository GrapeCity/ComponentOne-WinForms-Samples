<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="ChartInReport._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>
<%@ Register Assembly="C1.Web.C1WebChart.2" Namespace="C1.Web.C1WebChart" TagPrefix="C1WebChart" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span style="font-family: Tahoma"><strong>C1Report with C1WebChart<br />
            <br />
        </strong><span style="font-size: 10pt">The report below shows a chart created by a <strong>
            C1WebChart</strong>
            control. This is accomplished by handling the <strong>StartSection </strong>event
            and applying the code below:<br />
            <br />
            <span style="font-size: 8pt; font-family: Courier New">protected void C1WebReport1_StartSection(object
                sender, C1.Win.C1Report.ReportEventArgs e)<br />
                {<br />
                &nbsp; &nbsp; if (e.Section == C1.Win.C1Report.SectionTypeEnum.Header)<br />
                &nbsp; &nbsp; {<br />
                &nbsp; &nbsp; &nbsp; &nbsp; // get picture field in Header section<br />
                &nbsp; &nbsp; &nbsp; &nbsp; C1.Win.C1Report.Field f = this.C1WebReport1.Report.Fields["PictureField"];<br />
                <br />
                &nbsp; &nbsp; &nbsp; &nbsp; // calculate image size in pixels (C1WebReport uses
                twips)<br />
                &nbsp; &nbsp; &nbsp; &nbsp; System.Drawing.Size size = new System.Drawing.Size(<br />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; (int)(f.Width * 96f / 1440f),<br />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; (int)(f.Height * 96f / 1440f));<br />
                <br />
                &nbsp; &nbsp; &nbsp; &nbsp; // get image from C1WebChart and assign it to field<br />
                &nbsp; &nbsp; &nbsp; &nbsp; f.Picture = this.C1WebChart1.GetImage(System.Drawing.Imaging.ImageFormat.Png,
                size);<br />
                &nbsp; &nbsp; }<br />
                }
                <br />
                <br />
                <span style="font-family: Tahoma"><span style="font-size: 10pt">
                <span>The <strong>C1WebReport</strong>
                    control has the <strong>ImageRenderMethod</strong> property set to <strong>HttpHandler</strong>,
                    so the image is rendered on the report without any temporary files. It also has
                    the <strong>EnableCallback</strong> property set to True, which enables Ajax callbacks
                    for smooth paging.</span></span></span><br />
            </span></span></span>
        <br />
        <cc1:C1WebReport ID="C1WebReport1" runat="server" Height="670px" OnStartSection="C1WebReport1_StartSection"
            Width="763px" EnableCallback="True" ImageRenderMethod="HttpHandler" 
            Scrollable="False">
            <ReportSource FileName="NWindEmbedPics.xml"
                ReportName="Alphabetical List of Products" />
            <NavigationBar Style-BackColor="Control" Text="Page {0}/{1}">
            </NavigationBar>
        </cc1:C1WebReport>
        <C1WebChart:C1WebChart ID="C1WebChart1" runat="server" Height="300px" Width="421px" Visible="False">
            <Serializer Value="&lt;?xml version=&quot;1.0&quot;?&gt;
&lt;Chart2DPropBag Version=&quot;2.0.20071.17023&quot;&gt;
  &lt;StyleCollection&gt;
    &lt;NamedStyle Name=&quot;Area&quot; ParentName=&quot;Area.default&quot; StyleData=&quot;Border=Solid,ControlDark,1;Rounding=10 10 10 10;&quot; /&gt;
    &lt;NamedStyle Name=&quot;LabelStyleDefault.default&quot; ParentName=&quot;Control&quot; StyleData=&quot;Border=None,Transparent,1;BackColor=Transparent;&quot; /&gt;
    &lt;NamedStyle Name=&quot;Control&quot; ParentName=&quot;Control.default&quot; StyleData=&quot;Border=Solid,ControlDark,1;BackColor=WhiteSmoke;&quot; /&gt;
    &lt;NamedStyle Name=&quot;AxisY2&quot; ParentName=&quot;Area&quot; StyleData=&quot;Rotation=Rotate90;AlignVert=Center;AlignHorz=Far;&quot; /&gt;
    &lt;NamedStyle Name=&quot;Header&quot; ParentName=&quot;Control&quot; StyleData=&quot;Border=None,Transparent,1;&quot; /&gt;
    &lt;NamedStyle Name=&quot;Footer&quot; ParentName=&quot;Control&quot; StyleData=&quot;Border=None,Transparent,1;&quot; /&gt;
    &lt;NamedStyle Name=&quot;Area.default&quot; ParentName=&quot;Control&quot; StyleData=&quot;Border=None,Transparent,1;AlignVert=Top;&quot; /&gt;
    &lt;NamedStyle Name=&quot;AxisY&quot; ParentName=&quot;Area&quot; StyleData=&quot;Rotation=Rotate270;AlignVert=Center;ForeColor=ControlDarkDark;AlignHorz=Near;&quot; /&gt;
    &lt;NamedStyle Name=&quot;AxisX&quot; ParentName=&quot;Area&quot; StyleData=&quot;Rotation=Rotate0;AlignVert=Bottom;ForeColor=ControlDarkDark;AlignHorz=Center;&quot; /&gt;
    &lt;NamedStyle Name=&quot;Legend&quot; ParentName=&quot;Legend.default&quot; /&gt;
    &lt;NamedStyle Name=&quot;LabelStyleDefault&quot; ParentName=&quot;LabelStyleDefault.default&quot; /&gt;
    &lt;NamedStyle Name=&quot;PlotArea&quot; ParentName=&quot;Area&quot; StyleData=&quot;Border=None,Transparent,1;&quot; /&gt;
    &lt;NamedStyle Name=&quot;Legend.default&quot; ParentName=&quot;Control&quot; StyleData=&quot;Wrap=False;Border=None,Transparent,1;AlignVert=Top;&quot; /&gt;
    &lt;NamedStyle Name=&quot;Control.default&quot; ParentName=&quot;&quot; StyleData=&quot;Border=None,Transparent,1;ForeColor=ControlText;BackColor=Control;&quot; /&gt;
  &lt;/StyleCollection&gt;
  &lt;ChartGroupsCollection&gt;
    &lt;ChartGroup Name=&quot;Group1&quot;&gt;
      &lt;DataSerializer DefaultSet=&quot;True&quot;&gt;
        &lt;DataSeriesCollection&gt;
          &lt;DataSeriesSerializer&gt;
            &lt;LineStyle Color=&quot;LightPink&quot; /&gt;
            &lt;SymbolStyle Color=&quot;LightPink&quot; OutlineColor=&quot;DeepPink&quot; Shape=&quot;Box&quot; /&gt;
            &lt;SeriesLabel&gt;series 0&lt;/SeriesLabel&gt;
            &lt;X&gt;1;2;3;4;5&lt;/X&gt;
            &lt;Y&gt;20;22;19;24;25&lt;/Y&gt;
            &lt;DataTypes&gt;Single;Single;Double;Double;Double&lt;/DataTypes&gt;
            &lt;FillStyle /&gt;
            &lt;Histogram /&gt;
          &lt;/DataSeriesSerializer&gt;
          &lt;DataSeriesSerializer&gt;
            &lt;LineStyle Color=&quot;LightBlue&quot; /&gt;
            &lt;SymbolStyle Color=&quot;LightBlue&quot; OutlineColor=&quot;DarkBlue&quot; Shape=&quot;Dot&quot; /&gt;
            &lt;SeriesLabel&gt;series 1&lt;/SeriesLabel&gt;
            &lt;X&gt;1;2;3;4;5&lt;/X&gt;
            &lt;Y&gt;8;12;10;12;15&lt;/Y&gt;
            &lt;DataTypes&gt;Single;Single;Double;Double;Double&lt;/DataTypes&gt;
            &lt;FillStyle /&gt;
            &lt;Histogram /&gt;
          &lt;/DataSeriesSerializer&gt;
          &lt;DataSeriesSerializer&gt;
            &lt;LineStyle Color=&quot;LightGreen&quot; /&gt;
            &lt;SymbolStyle Color=&quot;LightGreen&quot; OutlineColor=&quot;DarkGreen&quot; Shape=&quot;Tri&quot; /&gt;
            &lt;SeriesLabel&gt;series 2&lt;/SeriesLabel&gt;
            &lt;X&gt;1;2;3;4;5&lt;/X&gt;
            &lt;Y&gt;10;16;17;15;23&lt;/Y&gt;
            &lt;DataTypes&gt;Single;Single;Double;Double;Double&lt;/DataTypes&gt;
            &lt;FillStyle /&gt;
            &lt;Histogram /&gt;
          &lt;/DataSeriesSerializer&gt;
          &lt;DataSeriesSerializer&gt;
            &lt;LineStyle Color=&quot;Orchid&quot; /&gt;
            &lt;SymbolStyle Color=&quot;Orchid&quot; OutlineColor=&quot;DarkOrchid&quot; Shape=&quot;Diamond&quot; /&gt;
            &lt;SeriesLabel&gt;series 3&lt;/SeriesLabel&gt;
            &lt;X&gt;1;2;3;4;5&lt;/X&gt;
            &lt;Y&gt;16;19;15;22;18&lt;/Y&gt;
            &lt;DataTypes&gt;Single;Single;Double;Double;Double&lt;/DataTypes&gt;
            &lt;FillStyle /&gt;
            &lt;Histogram /&gt;
          &lt;/DataSeriesSerializer&gt;
        &lt;/DataSeriesCollection&gt;
        &lt;Highlight /&gt;
      &lt;/DataSerializer&gt;
    &lt;/ChartGroup&gt;
    &lt;ChartGroup Name=&quot;Group2&quot;&gt;
      &lt;DataSerializer&gt;
        &lt;Highlight /&gt;
      &lt;/DataSerializer&gt;
    &lt;/ChartGroup&gt;
  &lt;/ChartGroupsCollection&gt;
  &lt;Header Compass=&quot;North&quot; Visible=&quot;False&quot; /&gt;
  &lt;Footer Compass=&quot;South&quot; Visible=&quot;False&quot; /&gt;
  &lt;Legend Compass=&quot;East&quot; Visible=&quot;False&quot; /&gt;
  &lt;ChartArea LocationDefault=&quot;-1, -1&quot; SizeDefault=&quot;-1, -1&quot;&gt;
    &lt;Margin /&gt;
  &lt;/ChartArea&gt;
  &lt;Axes&gt;
    &lt;Axis Max=&quot;5&quot; Min=&quot;1&quot; UnitMajor=&quot;1&quot; UnitMinor=&quot;0.5&quot; AutoMajor=&quot;True&quot; AutoMinor=&quot;True&quot; AutoMax=&quot;True&quot; AutoMin=&quot;True&quot; Compass=&quot;South&quot;&gt;
      &lt;Text&gt;Axis X&lt;/Text&gt;
      &lt;GridMajor Visible=&quot;True&quot; Spacing=&quot;1&quot; /&gt;
    &lt;/Axis&gt;
    &lt;Axis Max=&quot;26&quot; Min=&quot;8&quot; UnitMajor=&quot;2&quot; UnitMinor=&quot;1&quot; AutoMajor=&quot;True&quot; AutoMinor=&quot;True&quot; AutoMax=&quot;True&quot; AutoMin=&quot;True&quot; Compass=&quot;West&quot;&gt;
      &lt;Text&gt;Axis Y&lt;/Text&gt;
      &lt;GridMajor Visible=&quot;True&quot; Spacing=&quot;2&quot; /&gt;
    &lt;/Axis&gt;
    &lt;Axis Max=&quot;0&quot; Min=&quot;0&quot; UnitMajor=&quot;0&quot; UnitMinor=&quot;0&quot; AutoMajor=&quot;True&quot; AutoMinor=&quot;True&quot; AutoMax=&quot;True&quot; AutoMin=&quot;True&quot; Compass=&quot;East&quot; /&gt;
  &lt;/Axes&gt;
  &lt;AutoLabelArrangement /&gt;
&lt;/Chart2DPropBag&gt;" />
        </C1WebChart:C1WebChart>
    
    </div>
    </form>
</body>
</html>
