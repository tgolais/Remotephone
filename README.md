# Remotephone
<p align="center">
  <img width="300" height="300" src="https://i.imgur.com/fxtGyIq.png">
</p>

## Description
This app was made for Android Developers to replace standard and slow Android Emulator (even if it's emulated via
Hyper-V engine). This app is based on scrcpy and Android Debug Bridge - it's GUI to those applications.

## Requirements
To run this app you need Microsoft .NET 5.0 Runtime installed on your Windows machine. To check if runtime is installed please enter this command in CMD or PowerShell:
```powershell
dotnet --info
```
```text
Host (useful for support):
  Version: 5.0.3
  Commit:  c636bbdc8a

.NET SDKs installed:
  No SDKs were found.

.NET runtimes installed:
  Microsoft.NETCore.App 5.0.3 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.WindowsDesktop.App 5.0.3 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
```

If you have .NET SDK installed, you can also try command as below:
```powershell
dotnet --version
```
```text
6.0.100-preview.1.21103.13
```
#### Installing .NET Runtime
* [Microsoft .NET Runtime 5.0](https://dotnet.microsoft.com/download/dotnet/5.0/runtime/?utm_source=getdotnetcore&utm_medium=referral)
* [Microsoft .NET SDK 5.0](https://dotnet.microsoft.com/download) (for developers)

## Features
* Possibility to stream and interact with Android Device over USB and network connection
* Realtime Android screen mirroring
* Interacting with host OS
* Recording screen
* Flexible framerate and bandwith
* Connecting multiple Android devices
* Screen mirroring even if device's screen is off
* Easy network connection (no root required)

## Screenshots
![Remotephone GUI](https://i.imgur.com/7337J0z.jpg)
![Remotephone streaming](https://i.imgur.com/bnCzNPO.jpg)

## Downloads

#### Application
* [Remotephone 1.0 win-x64](https://repo.it.dynamicevent.pl/Remotephone/1.0/x64/Remotephone.exe)
* [Remotephone 1.0 win-x86](https://repo.it.dynamicevent.pl/Remotephone/1.0/x86/Remotephone.exe)

#### .NET Runtime
* [.NET Runtime 5.0](https://dotnet.microsoft.com/download/dotnet/5.0/runtime/?utm_source=getdotnetcore&utm_medium=referral)

#### Building from sources
Building this app from sources is very simple. It's enough to download sources and run CMD or Powershell in project root directory (where solution (.sln) file is stored),
and run propper command. **.NET 5.0 SDK Required**

**Run application in debug mode:**
```powershell
dotnet run
```

or if you want compile app for specific CPU architecture [win-x86, win-x64, win-arm]

**Windows x64**
```powershell
dotnet publish -r win-x64 -p:PublishSingleFile=true --self-contained false
```

**Windows x86**
```powershell
dotnet publish -r win-x86 -p:PublishSingleFile=true --self-contained false
```

**Windows ARM64**
```powershell
dotnet publish -r win-arm -p:PublishSingleFile=true --self-contained false
```

## Troubleshooting
* **My device isn't availble** - This trouble may be caused by missing specific device drivers. At the beginning
please try download correct drivers from manufacturer website. If it won't help, you will need to switch driver
in Windows Device Manager to something like "Adb composite interface"
* **I cannot find recorded screen files** - screen recordings automaticly are stored in current user "My Videos" directory.
* **FPS manipulation doesn't work** - Try to use this feature when device is connected via USB cord - it should increase
connection performance and reduce latency. This feature is only availble for devices with Android 10+.
* **I cannot connect via IP Address** - you should look for "Debugging over wifi" in device's developer settings, if there's no setting like this
you must download app like 'Adb over wifi' from Google Play Store - but you must be rooted, if you aren't, you must connect your phone via USB cord, then
use option "Enable TCP Connection" in Remotephone.
* **When I'm trying to run app, I receive message that .NET Runtime is missing** - To solve this trouble, it's enough to install propper .NET Runtime on your computer. [.NET Runtime Downloads](https://dotnet.microsoft.com/download/dotnet/5.0/runtime/?utm_source=getdotnetcore&utm_medium=referral)

## Credits
* @dotnet [.NET Platform](https://github.com/dotnet)
* @rom1v [scrcpy](https://github.com/Genymobile/scrcpy)