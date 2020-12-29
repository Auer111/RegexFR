using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Auer_Find_Replace
{
    public static class DataManager
    {
        //Store the user settings
        private const string AFR_settings_fileName = "FA_Setup.xml";
        //Store the actions
        private const string ActionConfig_fileName = "FA_Data.xml";
        //Store the file paths
        private const string FilePathConfig_fileName = "File_Paths.xml";
        //Store the extensions
        private const string ExtensionsConfig_fileName = "File_Extensions.xml";
        //Our json data file path
        private const string JsonData_filePath = "data/";

        //Json Format
        public class jsonObject
        {
            public string extract { get; set; }
            public string insert { get; set; }
        }
        //XML format
        public class AFR_Settings
        {
            public string Filepath { get; set; }
            public string FilepathSuffix { get; set; }
            public string RecursionDepth { get; set; }
            public List<string> SelectedExtensions { get; set; }
            public bool RemoveExisting { get; set; }
            public bool PathSuffixCheckbox { get; set; }
        }
        public class actionData
        {
            public string actionType { get; set; }
            public string actionName { get; set; }
            public string actionDescription { get; set; }
            public string fileName { get; set; }
            public string scopeLimitingREGEX { get; set; }
        }

        //all possible regex will be stored here
        public static Dictionary<string, Regex> regExpressions = new Dictionary<string, Regex>()
        {
            {"All", new Regex(@".*") },
            {"Class", new Regex(@"(?<=class="")[^""]+(?="")") },
            {"Empty Space", new Regex(@"\s\s+") }

        };
        //all possible actions will be stored here
        public static Dictionary<string, string> allActions = new Dictionary<string, string>()
        {
             {"Find", "Use the Extract field to locate string instances to log" },
             {"Nested Replace", "Extract and Insert strings within the selected scope" },
             {"Delete Scope", "Delete any file content matched by the selected scope" }
        };

        //Validate file
        public static bool ValidateNewFileName(string fileName) {return !string.IsNullOrEmpty(fileName) && fileName.IndexOfAny(Path.GetInvalidFileNameChars()) < 0 && !File.Exists(Path.Combine(JsonData_filePath, fileName));}
        public static bool ValidateRenamedFile(string fileName) { return !string.IsNullOrEmpty(fileName) && fileName.IndexOfAny(Path.GetInvalidFileNameChars()) < 0; }
        public static void OpenDataDir() {
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\data"); 
        }
        public static void OpenLogDir()
        {
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\logs");
        }

        public static void OpenDir(string path) {
            System.Diagnostics.Process.Start(path);
        }

        //--------------------------------PERSIST JSON USER CONTENT-------------------------
        public static List<string> GetJsonDataFiles() {return Directory.EnumerateFiles(JsonData_filePath).Where(file => file.EndsWith("json")).ToList();}

        public static List<jsonObject> getJsonData(string file)
        {
            using (StreamReader r = new StreamReader(file))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<jsonObject>>(json);
            }
        }

        public static bool CreateJsonDataFile(string file)
        {
            try
            {
                File.Create(file);
                File.WriteAllText(JsonData_filePath + file, JsonConvert.SerializeObject(new List<jsonObject>() { new jsonObject { extract = "example_extract", insert = "example_insert" } }));
                return true;
            }
            catch (SystemException e) { Console.Write(e.Message); return false; }
        }
        public static bool OverwriteJsonDataFile(string file, List<jsonObject> content)
        {
            try
            {
                File.WriteAllText(JsonData_filePath + file, JsonConvert.SerializeObject(content));
                return true;
            }
            catch (SystemException e) { Console.Write(e.Message); return false; }
        }

        public static bool DeleteJsonDataFile(string file)
        {
            try
            {
                File.Delete(JsonData_filePath + file);
                return true;
            }
            catch(SystemException e) { Console.Write(e.Message); return false; }
        }
        //--------------------------PERSIST AFR Main Properties-------------------------
        public static void SerializeAFR(AFR_Settings settings)
        {
            File.WriteAllText(AFR_settings_fileName, string.Empty);
            var serializer = new XmlSerializer(typeof(AFR_Settings));
            using (var stream = File.OpenWrite(AFR_settings_fileName)) { serializer.Serialize(stream, settings); }
        }

        public static AFR_Settings DeserializeAFR()
        {
            try
            {
                AFR_Settings settings;
                var serializer = new XmlSerializer(typeof(AFR_Settings));
                using (var stream = File.OpenRead(AFR_settings_fileName)) { settings = (AFR_Settings)(serializer.Deserialize(stream)); }
                return settings;
            }
            catch
            {
                return new AFR_Settings
                {
                    Filepath = "",
                    FilepathSuffix = "",
                    RecursionDepth = "2",
                    SelectedExtensions = new List<string>(),
                    RemoveExisting = true,
                    PathSuffixCheckbox = false
                };
            }
        }
        //--------------------------PERSIST XML USER ACTION INPUT DATA SAVE-------------------------
        public static void SerializeActions()
        {
            List<actionData>  list = Auer_Find_Replace.allFormattingActions.Select(fa => fa.myActionData).ToList();

            File.WriteAllText(ActionConfig_fileName, string.Empty);
            var serializer = new XmlSerializer(typeof(List<actionData>));
            using (var stream = File.OpenWrite(ActionConfig_fileName)){serializer.Serialize(stream, list);}
        }

        public static List<actionData> DeserializeActions()
        {
            List<actionData> saved_actions;
            var serializer = new XmlSerializer(typeof(List<actionData>));
            using (var stream = File.OpenRead(ActionConfig_fileName)){saved_actions = (List<actionData>)(serializer.Deserialize(stream));}
            return saved_actions;
        }
        //--------------------------PERSIST XML FILE PATH INPUT DATA SAVE-------------------------
        public static bool SerializeFilePaths(List<string> list)
        {
            try
            {
                File.WriteAllText(FilePathConfig_fileName, string.Empty);
                var serializer = new XmlSerializer(typeof(List<string>));
                using (var stream = File.OpenWrite(FilePathConfig_fileName)) { serializer.Serialize(stream, list); }
                return true;
            }
            catch {return false;}
        }

        public static List<string> DeserializeFilePaths()
        {
            List<string> saved_list;
            var serializer = new XmlSerializer(typeof(List<string>));
            using (var stream = File.OpenRead(FilePathConfig_fileName)) { saved_list = (List<string>)(serializer.Deserialize(stream)); }
            return saved_list;
        }

        //--------------------------PERSIST EXTENSIONS INPUT DATA SAVE-------------------------
        public static bool SerializeExtensions(List<string> list)
        {
            try
            {
                File.WriteAllText(ExtensionsConfig_fileName, string.Empty);
                var serializer = new XmlSerializer(typeof(List<string>));
                using (var stream = File.OpenWrite(ExtensionsConfig_fileName)) { serializer.Serialize(stream, list); }
                return true;
            }
            catch { return false; }
        }

        public static List<string> DeserializeExtensions()
        {
            List<string> saved_list;
            var serializer = new XmlSerializer(typeof(List<string>));
            using (var stream = File.OpenRead(ExtensionsConfig_fileName)) { saved_list = (List<string>)(serializer.Deserialize(stream)); }
            return saved_list;
        }

        public static bool PossiblePath(string path) 
        {
            var task = Task.Run(() => { return SearchForDirectory(path); });
            bool sucessful = task.Wait(TimeSpan.FromMilliseconds(200));
            if (sucessful) { return task.Result; }
            else { return false; }
            
        }

        //Called via a task to limit amount of time retrieving directory
        public static bool SearchForDirectory(string path)
        {
            try
            {
                FileAttributes attr = File.GetAttributes(path);
                if (!attr.HasFlag(FileAttributes.Directory)) { return false; }
                return true;
            }
            catch { return false; }
        }



    }
}
