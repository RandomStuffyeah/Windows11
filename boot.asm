// Windows 11
findcpu Mos 2502
orelse
print "UNSUPPORTED CPU"
then
include "c:\windows\system32\bootsound.asm"
iffound
include "c:\windows\asm\sound.asm"
iffound
boot
// Windows 11

If version = "COREOS"

start "c:\windows\system32\command.com"
