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

            if (!Directory.Exists(logsFolder))
                Directory.CreateDirectory(logsFolder);

            CreateFileIfMissing(authLogs);
            CreateFileIfMissing(cryptLogs);
            CreateFileIfMissing(actLogs);
        }

        // ================= FILE CREATION =================
        private void CreateFileIfMissing(string path)
        {
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) { }
            }
        }

        // ================= GENERIC READ =================
        private string ReadLog(string path)
        {
            CreateFileIfMissing(path);
            string result = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string l;
                while ((l = reader.ReadLine()) != null)
                {
                    if (role == "administrator" || l.Contains($"USER: {username}"))
                        result += l + Environment.NewLine;
                }
            }

            return result;
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

        // ================= SESSION LOG (NOW INTO AUTH LOGS) =================
        public void logSessionActivity(DateTime start, DateTime end, TimeSpan duration)
        {
            CreateFileIfMissing(authLogs);

            using (StreamWriter writer = new StreamWriter(authLogs, true))
            {
                writer.WriteLine(
                    $"[SESSION] USER: {username} | ROLE: {role} | START: {start} | END: {end} | DURATION: {duration:hh\\:mm\\:ss}"
                );
            }
        }

        // ================= READ METHODS =================
        public void readAuthActivity()
        {
            authLogsContainerText = ReadLog(authLogs);
        }

        public void readCryptActivity()
        {
            encryptionLogsContainerText = ReadLog(cryptLogs);
        }

        public void readActivity()
        {
            processLogsContainerText = ReadLog(actLogs);
        }
    }
}