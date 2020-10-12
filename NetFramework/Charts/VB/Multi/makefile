vbfiles = Form1.vb

resfiles = Form1.resx 

srcdir = $(srcroot)\testapps\Multi

substitutions = -s"/Handles Me./Handles /"\
	-s"/MyBase.Form1_Load/MyBase.Load/"\
	-s"/MyBase.Form1_Size/MyBase.Size/"\
	-s"/Private menu/WithEvents menu/"\
	-s"/Private chart/WithEvents chart/"\
	-s"/Private printDocument/WithEvents printDocument/"\
	-s"/Private toolBar/WithEvents toolBar/"\
	-s"/Private timer/WithEvents timer/"

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
