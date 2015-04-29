#!/bin/bash
# scipt to install required packages for GM4D to run
# gksu - package to get super user privilleges with a GUI frontend (http://www.nongnu.org/gksu/)
# mono-complete - the Mono framework, an OpenSource implementation of the .NET framework (http://www.mono-project.com/)
# isc-dhcp-server - the DHCP server from the ISC (https://www.isc.org/downloads/dhcp/)
sudo apt-get --yes --force-yes install gksu mono-complete isc-dhcp-server
sudo cp -a -r GM4D /usr/local/bin
sudo cp GM4D/GM4D.desktop /usr/share/applications/GM4D.desktop


