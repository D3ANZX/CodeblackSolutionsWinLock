using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace com.codeBlack.winLock.Controller
{
    
    public class Logging
    {
        const string logsFolder = @"c:\WinLockFiles\Logs\";
        string authLogs = Path.Combine(logsFolder, "authLogs.txt");
        string cryptLogs = Path.Combine(logsFolder, "cryptLogs.txt");
        string actLogs = Path.Combine(logsFolder, "processLogs.txt");
        string username = "";
        string role = "";
        string line = "";
        public string authLogsContainerText = "";
        public string encryptionLogsContainerText = "";
        public string processLogsContainerText = "";


        int procCount;

        public Logging(string username, string role) { 
        if (!Directory.Exists(logsFolder))
            {
                Directory.CreateDirectory(logsFolder);
                using (FileStream cryptLogFile = new FileStream(cryptLogs, FileMode.Create)) ;
                using (FileStream authLogFile = new FileStream(authLogs, FileMode.Create)) ;
                using (FileStream actLogFile = new FileStream(actLogs, FileMode.Create)) ;

            }

        }


        public void logCryptActivity(string activity)
        {
            using (StreamWriter encryptWriter = new StreamWriter(cryptLogs, true))
            {
                encryptWriter.WriteLine($"{activity}: {username} : {role} at {DateTime.Now}");
            }
        }


        public void logProcessActivity()
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process proc in processes)
            {
                using (StreamWriter activityWriter = new StreamWriter(actLogs, true))
                {
                    procCount++;
                    activityWriter.WriteLine($"[{procCount}] {DateTime.Now} - {username} opened {proc.ProcessName}");
                }

            }

        }


        public void readAuthActivity()
        {
            using (StreamReader readAuthActivity = new StreamReader(authLogs))
            {
                if (role == "administrator")
                {
                    authLogsContainerText = readAuthActivity.ReadToEnd();
                }
                else
                {
                    while ((line = readAuthActivity.ReadLine()) != null)
                    {
                        if (line.Contains(username))
                            authLogsContainerText += line;
                    }
                }
            }
        }



        public void readCryptActivity()
        {
            using (StreamReader readCryptActivity = new StreamReader(cryptLogs))
            {

                if (role == "administrator")
                {
                    encryptionLogsContainerText = "[Session start]";
                    encryptionLogsContainerText = readCryptActivity.ReadToEnd();
                }
                else
                {
                    while ((line = readCryptActivity.ReadLine()) != null)
                    {
                        if (line.Contains(username))
                        {
                            encryptionLogsContainerText += line + Environment.NewLine;
                        }
                    }
                }
            }
        }

        public void readActivity()
        {
            using (StreamReader readActivity = new StreamReader(actLogs))
            {
                if (role == "administrator")
                {
                    processLogsContainerText = readActivity.ReadToEnd();
                }
                else
                {
                    while ((line = readActivity.ReadLine()) != null)
                    {
                        if (line.Contains(username))
                        {
                            processLogsContainerText += line;
                        }
                    }
                }
            }
        }
    }
}
