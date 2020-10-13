vbfiles = Form1.vb Function.vb Engine.vb FuncForm.vb

resfiles = Form1.resx FuncForm.resx

srcdir = $(srcroot)\testapps\Function2D

substitutions = -s"/Handles Me./Handles /"\
	-s"/MyBase.Form1_Load/MyBase.Load/"\
	-s"/Private menu/WithEvents menu/"\
	-s"/Private chart3D/WithEvents chart3D/"\
	-s"/Private rb/WithEvents rb/"\
	-s"/Private cb/WithEvents cb/"\
	-s"/Private up/WithEvents up/"\
	-s"/Private btn/WithEvents btn/"\
	-s"/Private tb/WithEvents tb/"\
	-s"/Private lb/WithEvents lb/"\
	-s"/ Me.tb/ tb/"\
	-s"/ Me.menuItem/ menuItem/"

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
