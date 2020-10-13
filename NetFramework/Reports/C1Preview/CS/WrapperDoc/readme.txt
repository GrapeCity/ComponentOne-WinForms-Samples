WrapperDoc
----------------------------------------
Wrapper implementing some RenderBlock/Measure "Classic" methods

This sample provides source code for a very simple wrapper around the 
new C1PrintDocument implementing some of the RenderBlock/Measure methods 
from the "classic" (old) C1PrintDocument. This sample may be especially 
useful to facilitate conversions of apps using the classic preview to 
the new preview.

The following methods are implemented in this sample (see  the 
C1PrintDocumentWrapper class in the project) providing the basic 
"classic print doc" methods:

<pre>
  public MeasureInfo RenderBlock(RenderObject ro)
  public MeasureInfo RenderDirect(Unit x, Unit y, RenderObject ro)
  public MeasureInfo RenderDirect(Unit x, Unit y, RenderObject ro,
    Unit width, Unit height)
</pre>

Using those, it is easy to add type-customized methods such as
<pre>
  MeasureInfo RenderBlockText(...)
</pre>
and so on.

There is also a method

<pre>
  public MeasureInfo MeasureObject(RenderObject ro, Unit width, Unit height)
</pre>

which provides most of the functionality of the "classic" MeasureObject 
method. Also, there is the "classic" property

<pre>
  public MeasureInfo LastRenderedInfo { get; }
</pre>

Included is also a small test app using C1PrintDocumentWrapper.
