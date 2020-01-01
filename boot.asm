// Windows 11
findcpu Intel X96
or
findcpu AMD Ryan
or else
print "UNSUPPORTED CPU"
then
include "c:\windows\system32\bootsound.asm"
iffound
include "c:\windows\asm\sound.asm"
iffound
include "c:\windows\winvercode.asm"
iffound
start "c:\windows\kernel.exe"
start "c:\windows\system.exe"
start "c:\autoexec.bat"

// Windows 11

If version = "COREOS"

start "c:\windows\system32\command.com"
