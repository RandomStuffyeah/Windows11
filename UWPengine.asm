run edge://%apphtml%
create log.log
when edge://%apphtml% closed
del log.log
exit
