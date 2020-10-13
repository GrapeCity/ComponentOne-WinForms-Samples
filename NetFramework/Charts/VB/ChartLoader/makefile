vbfiles = Form1.vb Form2.vb Form3.vb Form4.vb

resfiles = Form1.resx Form2.resx Form3.resx Form4.resx

srcdir = $(srcroot)\testapps\ChartLoader

substitutions = -s"/Handles Me./Handles /"\
	-s"/MyBase.Form1_Load/MyBase.Load/"\
	-s"/MyBase.Form1_Resize/MyBase.Resize/"\
	-s"/MyBase.frmPropGrid_Load/MyBase.Load/"\
	-s"/MyBase.frmPropGrid_Resize/MyBase.Resize/"\
	-s"/MyBase.frmClientSize_Load/MyBase.Load/"\
	-s"/MyBase.frmLoadURL_Load/MyBase.Load/"\
	-s"/Private menu/WithEvents menu/"\
	-s"/Private btn/WithEvents btn/"\
	-s"/Private c1Chart/WithEvents c1Chart/"\
	-s"/Private c1Chart3D/WithEvents c1Chart3D/"

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
