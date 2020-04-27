# MusicMan
Created by Jason Huhtala
MusicMan is a software for music lesson teaching professionals to use to manage their lesson schedule, 
invoice, take notes and send lesson details and reminders to parents.  

### Developer Setup Instructions

There are only a couple steps required to make changes to MusicMan.  
1.	Current development was performed using Microsoft Visual Studio version 2017 and 2019.
2.	Nuget must be installed in order to install the Twilio libraries and necessary support libraries.
3.	Clone the github repository at https://github.com/jhuhtala/MusicMan/
4.	To be able to debug, you will need a MusicMan database.  Manually create the MusicMan Database by running MusicMan.sql within Microsoft SQL Server Management Studio. Note: Microsoft Visual Studio and Microsoft SQL Server Management Studio must be installed and running to be able to do so.

### Build and Release Process

The build for this solution is rather simple.  To build the application, open the solution using Visual Studio 2017 or 2019 and select Build > Rebuild Solution with the build set to Release.  

When choosing this option, the necessary application files will be placed in the \bin\Release folder.  All  of this folder’s contents are required to run the program.

### The install of this program has a few steps currently.  

1.	MusicMan has only been tested in Windows 7+ environment.  .NET must be installed on the host machine.
2.	Install MusicMan executables.  To do so, (after compiling) copy the files found in the bin release folder found in \MusicMan\bin\Release to the following location in your Program Files directory: C:\Program Files (x86)\MusicMan
3.	Manually create the MusicMan Database.  To do so, run MusicMan.sql within Microsoft SQL Server Management Studio. Note: Microsoft Visual Studio and Microsoft SQL Server Management Studio must be installed and running to be able to do so.

