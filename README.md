# Remotephone
![Remotephone logo](https://github.com/EquablePanic4/Remotephone/blob/main/Resources/Remotephone.png?raw=true)
### Description
This app was made for Android Developers to replace standard and slow Android Emulator (even if it's emulated via
Hyper-V engine). This app is based on scrcpy and Android Debug Bridge - it's GUI to those applications.

### Requirements
App is developed under Microsoft .NET 5.0, but you don't need to install any runtime, it's enough to have Microsoft
Windows OS.


### Features
* Possibility to stream and interact with Android Device over USB and network connection
* Realtime Android screen mirroring
* Interacting with host OS
* Recording screen
* Flexible framerate and bandwith
* Connecting multiple Android devices
* Screen mirroring even if device's screen is off
* Easy network connection (no root required)

### Screenshots
![Remotephone GUI](https://i.imgur.com/7337J0z.jpg)
![Remotephone streaming](https://i.imgur.com/bnCzNPO.jpg)

### Downloads
* [Remotephone win-x64](https://repo.it.dynamicevent.pl/Remotephone/1.0/Remotephone_%20x64.exe)
* [Remotephone win-x86](https://repo.it.dynamicevent.pl/Remotephone/1.0/Remotephone_%20x86.exe)

### Troubleshooting
* **My device isn't availble** - This trouble may be caused by missing specific device drivers. At the beginning
please try download correct drivers from manufacturer website. If it won't help, you will need to switch driver
in Windows Device Manager to something like "Adb composite interface"
* **I cannot find recorded screen files** - screen recordings automaticly are stored in current user "My Videos" directory.
* **FPS manipulation doesn't work** - Try to use this feature when device is connected via USB cord - it should increase
connection performance and reduce latency. This feature is only availble for devices with Android 10+.
* **I cannot connect via IP Address** - you should look for "Debugging over wifi" in device's developer settings, if there's no setting like this
you must download app like 'Adb over wifi' from Google Play Store - but you must be rooted, if you aren't, you must connect your phone via USB cord, then
use option "Enable TCP Connection" in Remotephone.

### Credits
@rom1v [scrcpy](https://github.com/Genymobile/scrcpy)