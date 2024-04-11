//using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Configuration;
using System.IO;


namespace AFSApp.Helpers
{
    public class AFSLogger
    {
        private static readonly Encoding Utf8Encoder = Encoding.GetEncoding(
            "UTF-8",
            new EncoderReplacementFallback(string.Empty),
            new DecoderExceptionFallback()
        );

        ///The max size a log file can be in Kilobytes. Default is 1024 (1 MB)
        public static ulong maxFileSize = 4096;

        ///The max number of log file that will be stored. Once this point is reached, the oldest file is deleted.
        public static int maxFileCount = 4;

        ///The directory in which the log files will be written
        public static string directory = defaultDirectory();

        //The name of the log files.
        public static string name = "logfile";


        public static string currentLogFile = "logfile-0.log";

        public static string dateFormat = "y-MM-dd H:m:ss.FFF";
        ///logging singleton

        ///write content to the current log file.
        public static void write(string text)
        {
            var path = $"{directory}/{logName(num: 0)}";
            currentLogFile = logName(num: 0);
            Console.WriteLine($"LogPath: {path}");

            //       using StreamWriter file = new("WriteLines2.txt", append: true);       using StreamWriter file = new("WriteLines2.txt", append: true);
            string dateStr = DateTime.Now.ToString(dateFormat);
            string newText = text.Replace(@"\u", "u");
            string writeText = $"[{dateStr}]: {newText}\n";

            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path))
                {
                    try
                    {
                        //                        Byte[] logLine = new UTF8Encoding(true,true).GetBytes(writeText);
                        Byte[] logLine = Utf8Encoder.GetBytes(writeText);
                        fs.Write(logLine, 0, logLine.Length);
                    }
                    catch (EncoderFallbackException e) {
                        Console.WriteLine("{0} exception\nMessage:\n{1}",
                                          e.GetType().Name, e.Message);
                    }
                    

                }
            }
            else
            {
                string logString = Utf8Encoder.GetString(Utf8Encoder.GetBytes(writeText));
                File.AppendAllText(path, logString);
            }
            cleanup();

        }

        ///do the checks and cleanup
        public static void cleanup()
        {
            var path = $"{directory}/{logName(num: 0)}";
            var size = fileSize(path);
            long maxSize = (long)(maxFileSize * 1024);
            if (size > 0 && size >= maxSize && maxSize > 0 && maxFileCount > 0)
            {
                rename(0);
                //delete the oldest file
                var deletePath = $"{directory}/{logName(num: maxFileCount)}";
                try
                {
                    File.Delete(deletePath);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        ///check the size of a file
        public static long fileSize(string path)
        {
            FileInfo fi = new FileInfo(path);
            if (fi.Exists)
            {
                return fi.Length;
            }
            return 0;
        }

        ///Recursive method call to rename log files
        public static void rename(int index)
        {
            //       let fileManager = FileManager.default
            var path = $"{directory}/{logName(num: index)}";
            var newPath = $"{directory}/{logName(num: index + 1)}";
            if (File.Exists(newPath))
            {
                rename(index + 1);
            }
            try
            {
                File.Move(path, newPath);
            }
            catch (Exception)
            {

                return;
            }


        }

        ///gets the log name
        public static string logName(int num)
        {
            return $"{name}-{num}.log";
        }

        ///get the default log directory
        static string defaultDirectory()
        {
            var path = "";
            //  if (File.Exists(path))
            //        Settings appsettings = configHelper.Config.GetRequiredSection("Settings").Get<Settings>();
            path = ConfigurationManager.AppSettings["LogFilePath"];
            if (string.IsNullOrEmpty(path))
            {
                path = "Logs";
            }

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        static string getCurrentLogFile()
        {
            //       print("getCurrentLogFile: \(currentLogFile)")
            return "logfile-0.log";
        }


    }

    public class LogData
    {
        public static void LogInfo(string info)
        {
            AFSLogger.write("INFO: " + info);
        }

        public static void LogTrace(string info)
        {
            AFSLogger.write("TRACE: " + info);
        }

        public static void LogError(string error)
        {
            AFSLogger.write("Error: " + error);
        }

        private static string FlattenException(Exception exception)
        {
            var stringBuilder = new StringBuilder();

            while (exception != null)
            {
                stringBuilder.AppendLine(exception.Message);
                stringBuilder.AppendLine(exception.StackTrace);

                exception = exception.InnerException;
            }

            return stringBuilder.ToString();
        }

        public static void LogException(Exception ex)
        {
            AFSLogger.write("Exception: " + FlattenException(ex));
        }
    }
    public static class StringExtensions
    {
        public static string ReplaceAll(this string original, string toBeReplaced, string newValue)
        {
            if (string.IsNullOrEmpty(original) || string.IsNullOrEmpty(toBeReplaced)) return original;
            if (newValue == null) newValue = string.Empty;
            StringBuilder sb = new StringBuilder();
            foreach (char ch in original)
            {
                if (toBeReplaced.IndexOf(ch) < 0) sb.Append(ch);
                else sb.Append(newValue);
            }
            return sb.ToString();
        }

        public static string ReplaceAll(this string original, string[] toBeReplaced, string newValue)
        {
            if (string.IsNullOrEmpty(original) || toBeReplaced == null || toBeReplaced.Length <= 0) return original;
            if (newValue == null) newValue = string.Empty;
            foreach (string str in toBeReplaced)
                if (!string.IsNullOrEmpty(str))
                    original = original.Replace(str, newValue);
            return original;
        }



    }

}
