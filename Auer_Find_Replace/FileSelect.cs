using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Auer_Find_Replace
{
    static class FileSelect
    {
        public static Auer_Find_Replace _AFR;
        public static int MaxDepth;

        private static bool CheckIfFileHasExtension(String s, String[] extn) { return extn.Any(i => s.ToLower().EndsWith(i)); }

        public static void WalkDirectoryTree(DirectoryInfo root , int depth)
        {
            FileInfo[] files = null;
            DirectoryInfo[] SubDirs;

            try{files = root.GetFiles("*.*");}

            catch (UnauthorizedAccessException e){ Console.WriteLine(e.Message);}

            catch (DirectoryNotFoundException e){Console.WriteLine(e.Message);}

            if (files != null){
                foreach (FileInfo fi in files)
                {
                    if (CheckIfFileHasExtension(fi.Extension, Auer_Find_Replace.allExtensions)) 
                    { 
                        Console.WriteLine(fi.FullName);
                        Auer_Find_Replace.allFiles.Add(fi.FullName);
                    }
                }
                if (depth < 1) { return; }
                
                SubDirs = root.GetDirectories();

                if (depth == MaxDepth) { _AFR.progressBar_FileGet.Maximum = SubDirs.Length; }

                foreach (DirectoryInfo dirInfo in SubDirs)
                {
                    if (depth == MaxDepth) { _AFR.progressBar_FileGet.PerformStep(); }
                    WalkDirectoryTree(dirInfo, depth-1);
                }
            }
        }

    }
}
