vbfiles = form1.vb
resfiles = form1.resx

srcdir = $(srcroot)\testapps\propGrid3D

substitutions = -s"/Handles Me./Handles /"\
	 -s"/MyBase.FormLoad/MyBase.Load/"\
	 -s"/Private menu/WithEvents menu/"\
	 -s"/Private C1Chart3D/WithEvents C1Chart3D/"\
	 -s"/Me.checkBox/checkBox/"\
	 -s"/Private checkBox/WithEvents checkBox/"\
	 -s"/Private numericUpDown/WithEvents numericUpDown/"\
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
