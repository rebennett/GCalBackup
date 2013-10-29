using System;
using System.Net;

namespace GCalBackup
{
	class MainClass
	{
		public static void Main (string[] args) {
		
		// datestamp for "to" filename, ex. filename: 20131027backupCalendar.ics
		String todaysDate = DateTime.Now.ToString ("yyyyMMdd");
        // grabs "from" filepath from calendarPath.txt in same directory
        String fileName = System.IO.File.ReadAllText(@"calendarPath.txt");
		WebClient myWebClient = new WebClient();
			// AUTOMATICALLY ACCEPTS CERTIFICATE
			ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
		// ensures correct encoding of file as ical
		myWebClient.Headers["Accept-Encoding"] = "text/calendar";
			// console feedback
			Console.WriteLine("Downloading backup");

		// actual file download, downloads file and saves in same directory as date + "backupCalendar.ics"
        // takes 
		try {
		myWebClient.DownloadFile(fileName, todaysDate+"backupCalendar.ics");
		Console.WriteLine ("Successful backup to "+todaysDate+"backupCalendar.ics");
			}
        // if download was unsuccessful
		catch {
				Console.WriteLine ("Backup unsuccessful.  Check your privacy settings and network connection.");
			}		
		}
	}
}