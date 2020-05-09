# >> Steam Auto Shutdown <<
This program shutdowns your PC when your steam downloads finish. Actually, it shutdowns your computer if it doesn't detect any network usage for some time, so you can use it with any programs, not only with steam.

![Print](https://i.imgur.com/3sfdydY.png)

# Instructions
- Start your steam download.
- Open the program.
- Click on <b>Toggle Auto Shutdown</b>.
- The program will shutdown your PC when the downloads finish. There is a delay of 2 minutes to ensure the download really ended.

# Disk Activity Detection
Nowadays, steam supports compressed downloads. Most of the cases, Steam will download and decompress at the same time. In others, it will not. So, there will be times when your network is doing nothing but your computer is still decompressing the game files. This technically doesn't count as "download", but I added a feature to detect this and only shutdown the computer when the game is ready to play (downloaded & decompressed). **The disk detection will only work with steam, not with other programs.**

# More information
It works with every download that you are doing.
It uses network usage to measure if you are downloading or not. This will only be accurate if you are not using your computer and if there are no background applications using your network.

# Changelog

### v2.0 - 09/05/2020
- Code remake
- Redesign
- Made changes to address bugs of shutting down the PC while the download was going on
- Added Disk Monitor feature
- Improved accuracy

### v1.1 - 25/04/2017
- Fixed a bug where some network cards were not detected correctly
- Improved program stability
- Minor optimizations
