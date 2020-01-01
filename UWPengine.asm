run edge://%apphtml%
if debug build
create log.log
endif
when edge://%apphtml% closed
if debug build
del log.log
endif
exit
