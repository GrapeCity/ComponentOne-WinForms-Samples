resfiles = Form1.resx

vbfiles = Form1.vb

srcdir = $(srcroot)\testapps\TrendLines

substitutions = -s"/Handles Me./Handles /"\
	-s"/, Me./, /"\
	-s"/MyBase.Form1_Load/MyBase.Load/"\
	-s"/Private mi/WithEvents mi/"\
	-s"/Private btn/WithEvents btn/"\
	-s"/Private cb/WithEvents cb/"\
	-s"/Private ud/WithEvents ud/"\
	-s"/Private c1Chart/WithEvents c1Chart/"

{}.cs{}.vb:
	@adjustCStoVB -b $(?F)
	@cstovb /rem $(?F)
	@adjustCStoVB -a $(substitutions) $*.vb
	@del $(?F)

samples = readme.txt screenshot.png

readme.txt:	$(srcdir)\readme.txt
	@sreplace $? $(?F) C# VB

screenshot.png:	$(srcdir)\screenshot.png
	@copy $? . > nul

licxs:	$(srcdir)\licenses.licx
	@copy $? . > nul

samps:	$(samples)

all:	cp $(vbfiles)

clean:
	@xdelete -v $(vbfiles) $(vbfiles:.vb=.cs) $(resfiles)
	@xdelete -f obj bin
	@xdelete -v $(samples)

cp:
	@copy  "$(srcdir)\Form1.*" . > nul 