# Chaaos
My attempt at creating an Android Auto application in C#

This repository basically starts with a generic Maui App, and then follows the instructions laid out by Christian Stryndom in his [MAUI for Cars](https://www.youtube.com/watch?v=nNkVxegb2oU) youtube video.

# Updates
1. 01/24/2024 - Updated for .NET 8.0

# Getting Started
```
git clone https://github.com/mikelor/chaaos
```
  1. Start Android Auto on Phone
  1. Start Head Unit Server
  1. On desktop console change directory to c:\users\<user>\AppData\Local\Android\Sdk\extras\google\auto
  1. Start desktop head unit
```
C:\Users\mikel\AppData\Local\Android\Sdk\extras\google\auto>adb forward tcp:5277 tcp:5277
C:\Users\mikel\AppData\Local\Android\Sdk\extras\google\auto>desktop-head-unit.exe
```
# Sample Screen Shots
Chaaos App Icon
![Chaaos App Icon](doc/ChaaosApp.png)

Main Screen
![Main Screen](doc/MainScreen.png)

# General Resources
  1. [Android for Cars Design Guidelines](https://developer.android.com/static/training/cars/Android%20for%20Cars%20App%20Library%20design%20guidelines.pdf) PDF
  1. [Carlos Mota's](https://twitter.com/cafonsomota) - [Going on the Road with Android Auto](https://speakerdeck.com/cmota/going-on-a-road-trip-with-android-auto) presentation.
  
# Android Auto Resources
  1. [Christian Stryndom's](https://twitter.com/cvstrydom) - [MAUI for Cars](https://www.youtube.com/watch?v=nNkVxegb2oU) YouTube Video
  1. [Carlos Mota's](https://twitter.com/cafonsomota) - [Going on the Road with Android Auto](https://speakerdeck.com/cmota/going-on-a-road-trip-with-android-auto) presentation.
  1. [John O'Reilly's](https://twitter.com/joreilly) - [Confetti App for Android Auto](https://github.com/joreilly/Confetti/tree/main/androidApp/src/main/java/dev/johnoreilly/confetti/auto) on Github

# Android Automotive Resources
  1. [Android Automotive OEM Images](https://developer.android.com/training/cars/testing#oem-images)

