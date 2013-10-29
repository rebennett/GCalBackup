Welcome to GCalBackup!

SETUP: 

To get started, open up Google Calendar and find the link to your *public* ical export.

**This link MUST be public, otherwise the calendar will not download properly.**

Go ahead and copy this link.

1.) Open the file named calendarPath.txt in this directory with any text editor.

2.) Paste this link in the file, making sure that the URL is the only text in this file.

3.) Save the file and exit the editor.

RUN BACKUP: 

On Windows:
Double-click GCalBackup.exe in this directory, and a copy of your calendar will be date-stamped and saved.

On Mac or Linux:
You will need the Mono compiler.
Once you have mono installed, open a terminal and navigate to this directory.
Then run:
> mono GCalBackup.exe
A copy of your calendar will be date-stamped and saved.
