using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Auer_Find_Replace
{
    class Logger
    {
        List<List<string>> allchangelog;
        List<string> filechangelog;
        int currentfilechangecount = 0;
        string content;
        string descriptor;

        public enum LogType { Find, Replace, Delete}

        private LogType _myLogType;

        DataManager.actionData myActionData;

        public class LogDataSet
        {
            public Match match { get; set; }
            public string extract { get; set; }
            public string insert { get; set; }
        }

        public Logger( DataManager.actionData actionData) {
            myActionData = actionData;
            allchangelog = new List<List<string>>() { new List<string>() { myActionData.actionName + " ==== " +myActionData.actionType } };
            filechangelog = new List<string>();

            switch (actionData.actionType)
            {
                case "Find": _myLogType = LogType.Find; return;
                case "Nested Replace": _myLogType = LogType.Replace; return;
                case "Delete Scope": _myLogType = LogType.Delete; return;
            }
            descriptor = Descriptor();
        }
        public void NewFile(string filecontents) {
            filechangelog = new List<string>();
            content = filecontents;
        }
        public void AddLine(Match match = null, string extract = null, string insert = null) 
        {
            currentfilechangecount++;
            switch (_myLogType)
            {
                case LogType.Find: filechangelog.Add("    Line__" + LineFromPos(content, match.Index).ToString() + "__Found|  " + extract); return;
                case LogType.Replace: filechangelog.Add("    Line__" + LineFromPos(content, match.Index).ToString() + "__Replaced|  " + extract + "  |with|  " + insert); return;
                case LogType.Delete: filechangelog.Add("    Deleted content matched by regex: " + myActionData.scopeLimitingREGEX.ToString()); return;
                default: return;
            }
            
        }
        public void CompleteFile(string file) 
        {
            Auer_Find_Replace.changecount += currentfilechangecount;
            if (currentfilechangecount > 0)
            {
                filechangelog.Insert(0, currentfilechangecount + descriptor + file);
                currentfilechangecount = 0;
                allchangelog.Add(filechangelog);
            }
        }

        int LineFromPos(string input, int indexPosition)
        {
            int lineNumber = 1;
            for (int i = 0; i < indexPosition; i++){if (input[i] == '\n') lineNumber++;}
            return lineNumber;
        }

        //------Log Changes---------
        public void WriteLog()
        {
            try
            {
                Directory.CreateDirectory("logs/");
                string dt = DateTime.Now.ToString("s");
                foreach (char c in Path.GetInvalidFileNameChars()) { dt = dt.Replace(c, '-'); }

                string path = "logs/" + dt + "_" + _myLogType.ToString() + ".txt";

                

                Console.WriteLine(path);


                if (!File.Exists(path))
                {
                    LogFooter();
                    File.WriteAllLines(path, allchangelog.SelectMany(l => l).ToList(), Encoding.UTF8);
                }
            }
            catch
            {
                Console.WriteLine("Failed to generate log");
            }
            
        }

        void LogFooter() 
        {
            allchangelog.Add(new List<string>() { "\n" + myActionData.actionDescription});
        }

        string Descriptor()
        {
            switch (_myLogType)
            {
                case LogType.Find: return " - items found in: ";
                case LogType.Replace: return " - changes made in: ";
                case LogType.Delete: return " - deletes made in: ";
                default: return "";
            }
        }

    }
}
