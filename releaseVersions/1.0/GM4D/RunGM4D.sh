#!/bin/bash
# This is the startup script for the GM4D mono application. 
# It uses gksu and mono to start the application with superuser privilleges.
cd /usr/local/bin/GM4D
gksudo mono GM4D.exe
