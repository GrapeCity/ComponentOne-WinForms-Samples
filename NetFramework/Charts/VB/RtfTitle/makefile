vbfiles = Form1.vb RtfForm.vb

resfiles = Form1.resx RtfForm.resx

srcdir = $(srcroot)\testapps\RtfTitle

substitutions = -s"/Handles Me./Handles /"\
	-s"/MyBase.Form1_Load/MyBase.Load/"\
	-s"/MyBase.RtfForm_Load/MyBase.Load/"\
	-s"/Private menu/WithEvents menu/"\
	-s"/Private c1Chart/WithEvents c1Chart/"\
	-s"/Private btnHeader/WithEvents btnHeader/"\
	-s"/Private btnFooter/WithEvents btnFooter/"\
	-s"/Private printDocument1/WithEvents printDocument1/"\
	-s"/Private cbHeaderAlign/WithEvents cbHeaderAlign/"\
	-s"/Private cbFooterAlign/WithEvents cbFooterAlign/"\
	-s"/Private btnFont/WithEvents btnFont/"\
	-s"/Private comboBox1/WithEvents comboBox1/"\
	-s"/Private richTextBox1/WithEvents richTextBox1/"\
	-s"/Private btnPrintPreview/WithEvents btnPrintPreview/"

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
