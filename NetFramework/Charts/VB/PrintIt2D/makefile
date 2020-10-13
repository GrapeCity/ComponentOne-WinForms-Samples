vbfiles = Form1.vb frmCanvas.vb

resfiles = Form1.resx frmCanvas.resx

srcdir = $(srcroot)\testapps\PrintIt2D

substitutions = -s"/Handles Me./Handles /"\
	-s"/MyBase.Form1_Load/MyBase.Load/"\
	-s"/Private menu/WithEvents menu/"\
	-s"/Private rb/WithEvents rb/"\
	-s"/Private btn/WithEvents btn/"\
	-s"/ Me.rb/ rb/"\
	-s"/Private chart/WithEvents chart/"

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
