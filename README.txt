Welcome to GCalBackup!

SETUP: 

To get started, open up Google Calendar and find the link to your *public* ical export.

**This link MUST be public, otherwise the calendar will not download properly.**

Go ahead and copy this link.

1.) Find and open the file named calendarPath.txt with any text editor.

2.) There is currently a sample URL in calendarPath.txt.  Paste your link in its place, making sure that your URL is the only text in this file.

3.) Save the file and exit the editor.

RUN BACKUP: 

On Windows:
Double-click GCalBackup.exe in this directory, and a copy of your calendar will be date-stamped and saved.

On Mac or Linux:
You will need the Mono compiler.
Once you have mono installed, open a terminal and navigate to the directory containing GCalBackup.exe.
Then run:
> mono GCalBackup.exe
A copy of your calendar will be date-stamped and saved.
