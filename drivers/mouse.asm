include "C:\Drivers\joystick.asm"
if joystick connected
delete "c:\drivers\joysticknotplug.asm"
if joystick disconnected
copy "c:\drivers\joystick\joysticknotplug.asm" to "c:\drivers\joysticknotplug.asm"


mouse:
move mouse to 1,1,1
print "NO MOUSE SUPPORT USE JOYSTICK"
