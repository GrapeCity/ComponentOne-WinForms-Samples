vbfiles = Form1.vb

resfiles = Form1.resx 

srcdir = $(srcroot)\testapps\CustomDraw

substitutions = -s"/Handles Me./Handles /"\
	-s"/MyBase.Form1_Load/MyBase.Load/"\
	-s"/Private menu/WithEvents menu/"\
	-s"/Private c1Chart/WithEvents c1Chart/"\
	-s"/Private trackBar1/WithEvents trackBar1/"\
	-s"/Me.trackBar1.Scroll/trackBar1.Scroll/"\
	-s"/Dim pa(np) As PointF/Dim pa(np-1) As PointF/"\
	-s"/Dim pa2(np) As PointF/Dim pa2(np-1) As PointF/"

{$(srcdir)}.cs{}.vb:
	@copy $? . > nul 
	@adjustCStoVB -b $(?F)
	@cstovb /rem $(?F)
	@adjustCStoVB -a $(substitutions) $*.vb
	@del $(?F)

{$(srcdir)}.resx{}.resx:
	@copy $? . > nul 

samples = readme.txt screenshot.png

readme.txt:	$(srcdir)\readme.txt
	@sreplace $? $(?F) C# VB

screenshot.png:	$(srcdir)\screenshot.png
	@copy $? . > nul

licxs:	$(srcdir)\licenses.licx
	@copy $? . > nul

samps:	$(samples)

all:	$(vbfiles) $(resfiles)

clean:
	@xdelete -v $(vbfiles) $(vbfiles:.vb=.cs) $(resfiles)
	@xdelete -f obj bin
	@xdelete -v $(samples)
