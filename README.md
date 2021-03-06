# Voron Scripts for Aurora

## Checkout video demonstration
[![Video Demo](https://github.com/VoronFX/Aurora/raw/voron-scripts/Project-Aurora/Scripts/VoronScripts/Resources/VideoPreview.jpg)](https://www.youtube.com/watch?v=6Ub-lh2kmKg)

The goal of this fork is to help me debug my scripts for Aurora and probably make some personal fixes. 
The actual Aurora project you can find here: [Link to Aurora project](https://github.com/antonpup/Aurora)

# About scripts
As you understand I did some scripts for my Logitech G910 Orion Spark.
All scripts were designed for my own use and by my own taste, but if you like them feel free to use and modify them.
You can even ask me to implement something on keyboard, if you can't. And if I will have time I will help you.
Right now, my profile consists of 4 scripts:

##PerformanceBars NEW!

* Allow to display value from any valid PerformanceCounter in system as bar.
* Has optional blinking effect when value reaches certain treshold.
* Highly customizible: you can have several bars with different setting (update interval, smoothing, blinking threshold, blinking speed, colors of the bar...) for any performance counter.
* You can use KeySequence or FreeForm(even with angle) for chosing area. But KeySequence animathion is smoother.
* Examples of use: Bars for each cpu core and/or total (like on the gif). Bars for disk load (Total or by letter). Bar for network usage, memory usage, anything you can find in Computer Managment->Performance->Monitoring Tools->Performance Monitor and consider as usefull.
* Samples included, look into script itself.
* [Here](https://raw.githubusercontent.com/VoronFX/Aurora/voron-scripts/Project-Aurora/Scripts/VoronScripts/Resources/PerformanceBarsGuide.jpg) is guide for this script 

![PerformanceBars](https://raw.githubusercontent.com/VoronFX/Aurora/voron-scripts/Project-Aurora/Scripts/VoronScripts/Resources/bars.gif)

##CpuCores

* Displays load of each core on separate button. I have quad-core cpu and those four G6-G9 buttons perfectly matches it.
* As core load reaches 95% it begins to blinks.
* When total load becomes 95% or higher the whole keyboard fades out.
* Also, there is a rainbow circle on numpad that becomes more visible and spins faster with cpu load.

![CpuCores](https://raw.githubusercontent.com/VoronFX/Aurora/voron-scripts/Project-Aurora/Scripts/VoronScripts/Resources/cpu.gif)

##GpuLoad

* UPDATE!: Experimental support for ATI gpus.
* Displays utilization of graphic card on desired buttons or region. I use G5-G1 buttons on the left. 
* When graphic card utilization becomes 95% or higher bar begins to blink.
* Now supports only NVidia graphic cards.
* Can use freeform region, but key based animation is smoother.
* Also, there is a rainbow on Print Screen, Scroll Lock and Pause Break buttons that becomes more visible and spins faster with gpu load.

![GpuLoad](https://raw.githubusercontent.com/VoronFX/Aurora/voron-scripts/Project-Aurora/Scripts/VoronScripts/Resources/gpu.gif)

##PingPulser

* Displays ping with animation. I use F1-F12 keys for it.
* PING IS REAL. Yeah, it's not just only nice animation. Every animation represents one real ping request. 
I've added 200ms delay between real request and animation for the case if PC get lag animation should stay correct. 
But you can adjust it if you want even more real representation.
* Different hosts can be used for active application. And default host for other apps. 
For example, you can set script to show ping to game server while that game is active window.
* Can use freeform region, but key based animation is smoother.

![PingPulser](https://raw.githubusercontent.com/VoronFX/Aurora/voron-scripts/Project-Aurora/Scripts/VoronScripts/Resources/pingpulser.gif)

# Download and install
1. Download current profile version [here](https://github.com/VoronFX/Aurora/releases/latest).
2. Just extract files in archive to your profiles folder ("%USERPROFILE%\AppData\Roaming\Aurora\Profiles\")
3. Select Voron profile in Desktop profile if you want everything with color zones
4. Or just use those scripts you want
5. Checkout script files, you can adjust some setting inside
6. Enjoy your geek illumination! ^_^

# Requirements
* Aurora itself [Link to Aurora project](https://github.com/antonpup/Aurora)
* Tested and developed for 0.5.1d and 0.6.0

# Credit
* [Aurora](https://github.com/antonpup/Aurora) - The program that made it possible
* [hwmonitor](http://openhardwaremonitor.org/) - Some code used for monitoring gpu utilization
