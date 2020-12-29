using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace Auer_Find_Replace
{
    public class FormattingAction
    {
        Auer_Find_Replace AFR;

        //data for this action saved from the json file
        public DataManager.actionData myActionData;

        Logger Logger;

        string content;

        public bool enabled = false;

        //Start - save json data to this action
        public FormattingAction(DataManager.actionData jsa) { myActionData = jsa; }

        public void RunAction(Auer_Find_Replace afr) {
            AFR = afr;
            if (!enabled) { return; }
            Logger = new Logger(myActionData);
            if (myActionData.actionType == "Delete Scope") { DeleteScope(); return; }
            
            CORE();
        }

        private void CORE()
        {
            //the data file we are using for this action
            List<DataManager.jsonObject> items = DataManager.getJsonData(myActionData.fileName);

            foreach (var file in Auer_Find_Replace.allFiles)
            {
                using (StreamReader r = new StreamReader(file)) { content = r.ReadToEnd(); }
                Logger.NewFile(content);
                foreach (DataManager.jsonObject jso in items)
                {
                    switch (myActionData.actionType)
                    {
                        case "Find": Find(jso); break;
                        case "Nested Replace": NestedReplace(jso); break;
                        default: return; 
                    }
                }
                if(myActionData.actionType != "Find") { File.WriteAllText(file, content); }

                Logger.CompleteFile(file);
                AFR.progressBar1.PerformStep();
            }
            Logger.WriteLog();

        }

        private void Find(DataManager.jsonObject jso)
        {
            string lookingFor = Regex.Escape(jso.extract);
            try
            {
                MatchCollection rm = Regex.Matches(content, lookingFor);
                foreach (Match match in rm) { Logger.AddLine(match, jso.extract); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }



        private void NestedReplace(DataManager.jsonObject jso) {

            try { content = Regex.Replace(content, DataManager.regExpressions[myActionData.scopeLimitingREGEX].ToString(), delegate (Match match) { return parseEachClass(match, jso.extract, jso.insert); }); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            //Inner replace of Nested Regex, where the magic happens to switch out the values
            string parseEachClass(Match match,string extract, string insert)
            {
                if (match.Value.Contains(extract)) 
                {
                    Logger.AddLine(match, extract,insert);
                    return Regex.Replace(match.Value, Regex.Escape(extract), insert); 
                }
                else { return match.Value; }
            }
        }

        private void DeleteScope()
        {
            //Logger Logger = new Logger("===Delete Scope Action===");
            foreach (var file in Auer_Find_Replace.allFiles)
            {
                string content;
                using (StreamReader r = new StreamReader(file)) { content = r.ReadToEnd(); }
                Logger.NewFile(content);

                try { content = Regex.Replace(content, DataManager.regExpressions[myActionData.scopeLimitingREGEX].ToString(), ""); }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                Logger.AddLine();
                Logger.CompleteFile(file);

                File.WriteAllText(file, content);
                AFR.progressBar1.PerformStep();
            }
            Logger.WriteLog();
        }
    }
}
