using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Auer_Find_Replace
{
    class CMD
    {
        Process p;

        public enum Commands { OpenConnections, Close}

        public string Run(Commands command, string conn ="") 
        {
            p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            switch (command)
            {
                case Commands.OpenConnections: return GetAllOpen();
                case Commands.Close: return Close(conn);
                default: return "";
            }
           
        }

        private string GetAllOpen() 
        {
            p.StartInfo.Arguments = "/C net use";
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            Console.WriteLine(output);
            return output;
        }
        private string Close(string conn)
        {
            p.StartInfo.Arguments = "/C net use " + conn + " /delete";
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return output;
        }
        
        public List<string> GetPathsFromOutput(string output) 
        {
            List<string> paths = new List<string>();
            string pattern = @"\\.+[^$]";
            MatchCollection matchlist = Regex.Matches(output, pattern);
            paths = matchlist.Cast<Match>().Select(match => match.Value).ToList();
            return paths;
        }

    }
}
