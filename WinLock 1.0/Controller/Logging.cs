using System;
using System.Diagnostics;
using System.IO;

namespace com.codeBlack.winLock.Controller
{
    public class Logging
    {
        const string logsFolder = @"c:\WinLockFiles\Logs\";

        string authLogs = Path.Combine(logsFolder, "authLogs.txt");
        string cryptLogs = Path.Combine(logsFolder, "cryptLogs.txt");
        string actLogs = Path.Combine(logsFolder, "processLogs.txt");
        string sessionLogs = Path.Combine(logsFolder, "sessionLogs.txt");

        string username = "";
        string role = "";
        string line = "";

        public string authLogsContainerText = "";
        public string encryptionLogsContainerText = "";
        public string processLogsContainerText = "";

        int procCount;

        public Logging(string username, string role)
        {
            this.username = username;
            this.role = role;

            // ================= ENSURE FOLDER + FILES EXIST =================
            if (!Directory.Exists(logsFolder))
                Directory.CreateDirectory(logsFolder);

            CreateFileIfMissing(authLogs);
            CreateFileIfMissing(cryptLogs);
            CreateFileIfMissing(actLogs);
            CreateFileIfMissing(sessionLogs);
        }

        // ================= FILE CREATION SAFETY =================
        private void CreateFileIfMissing(string path)
        {
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) { }
            }
        }

        // ================= ENCRYPT / DECRYPT LOG =================
        public void logCryptActivity(string activity)
        {
            CreateFileIfMissing(cryptLogs);

            using (StreamWriter writer = new StreamWriter(cryptLogs, true))
            {
                writer.WriteLine(
                    $"ACTION: {activity} | USER: {username} | ROLE: {role} | TIME: {DateTime.Now}"
                );
            }
        }

        // ================= PROCESS LOG =================
        public void logProcessActivity()
        {
            CreateFileIfMissing(actLogs);

            Process[] processes = Process.GetProcesses();

            foreach (Process proc in processes)
            {
                using (StreamWriter writer = new StreamWriter(actLogs, true))
                {
                    procCount++;
                    writer.WriteLine($"[{procCount}] {DateTime.Now} | USER: {username} opened {proc.ProcessName}");
                }
            }
        }

        // ================= SESSION LOG =================
        public void logSessionActivity(DateTime start, DateTime end, TimeSpan duration)
        {
            CreateFileIfMissing(sessionLogs);

            using (StreamWriter writer = new StreamWriter(sessionLogs, true))
            {
                writer.WriteLine(
                    $"USER: {username} | ROLE: {role} | START: {start} | END: {end} | DURATION: {duration:hh\\:mm\\:ss}"
                );
            }
        }

        // ================= READ AUTH =================
        public void readAuthActivity()
        {
            CreateFileIfMissing(authLogs);

            authLogsContainerText = "";

            using (StreamReader reader = new StreamReader(authLogs))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (role == "administrator" || line.Contains(username))
                        authLogsContainerText += line + Environment.NewLine;
                }
            }
        }

        // ================= READ CRYPTO =================
        public void readCryptActivity()
        {
            CreateFileIfMissing(cryptLogs);

            encryptionLogsContainerText = "";

            using (StreamReader reader = new StreamReader(cryptLogs))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (role == "administrator" || line.Contains(username))
                        encryptionLogsContainerText += line + Environment.NewLine;
                }
            }
        }

        // ================= READ PROCESS =================
        public void readActivity()
        {
            CreateFileIfMissing(actLogs);

            processLogsContainerText = "";

            using (StreamReader reader = new StreamReader(actLogs))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (role == "administrator" || line.Contains(username))
                        processLogsContainerText += line + Environment.NewLine;
                }
            }
        }
    }
}