vbfiles = Form1.vb

resfiles = Form1.resx 

srcdir = $(srcroot)\testapps\CustomBrushes

substitutions = -s"/Handles Me./Handles /"\
	-s"/, Me./, /"\
	-s"/MyBase.Form1_Load/MyBase.Load/"\
	-s"/Private menu/WithEvents menu/"\
	-s"/Private propertyGrid/WithEvents propertyGrid/"\
	-s"/Private cb/WithEvents cb/"\
	-s"/Private c1Chart/WithEvents c1Chart/"

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
