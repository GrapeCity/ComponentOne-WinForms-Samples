vbfiles = Form1.vb InputValueForm.vb

resfiles = Form1.resx 

srcdir = $(srcroot)\testapps\CoordMapping3D

substitutions = -s"/Handles Me./Handles /"\
	-s"/MyBase.FormLoad/MyBase.Load/"\
	-s"/Private menu/WithEvents menu/"\
	-s"/Private chart3D/WithEvents chart3D/"\
	-s"/Private rb/WithEvents rb/"\
	-s"/Private cb/WithEvents cb/"\
	-s"/Private up/WithEvents up/"\
	-s"/Private btn/WithEvents btn/"\
	-s"/ Me.rb/ rb/"

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
