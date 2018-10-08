# wslx
A launcher application for running wsl with an xserver.

Currently Supported and Tested Distros:
* Ubuntu 18.04
<<<<<<< Updated upstream
* Ubuntu 16.04
* Debian GNU\Linux

Currently "Supported" Distros but Not Fully Tested:
=======
<<<<<<< HEAD

Currently "Supported" Distros but Not Fully Tested:
=======
* Ubuntu 16.04
>>>>>>> install_script
* Debian GNU\Linux

Currently "Supported" Distros but Not Fully Tested:
>>>>>>> Stashed changes
* OpenSUSE Leap 42
* Kali
* WLinux

Currently Supported XServer Clients:
* X410
* VcXsrv (In default install location only)

Currently Supported Window Managers:
* i3

Prerequisite steps before using WSLX and WSLX Setup:
0. Install a WSL Disrto from the Windows store.
1. Install either X410 or VcXsrv
2. Install and set up i3 on your WSL (now can be automated by WSLXSetup on select distros)
3. Put WSLX.exe, WSLXSetup.exe, and Defaults folder in a folder together somewhere on your computer.

First time use of WSLX with no existing config for window manager
0. Select options for installation
1. Click Install WM
2. Enter sudo password in the terminal window that popped up
3. Wait
4. Click "Generate Config"
5. Click "Exit and Run WSLX"

First time use of WSLXSetup and WSLX with i3 already installed and configured:
0. Run WSLXSetup.exe and select your options.
1. Click "Generate Config"
2. Click "Exit and Run WSLX"

<<<<<<< Updated upstream
Any other time use of WSLX:
* Run WSLX.exe
=======
<<<<<<< HEAD
Any other time use of WSLX
0. Run WSLX.exe
=======
Any other time use of WSLX:
* Run WSLX.exe
>>>>>>> install_script
>>>>>>> Stashed changes
