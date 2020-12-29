using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Management.Automation;
using System.Diagnostics;

namespace Auer_Find_Replace
{
    public class NetworkConnection : IDisposable
    {
        //https://stackoverflow.com/questions/295538/how-to-provide-user-name-and-password-when-connecting-to-a-network-share

        public string _networkName;

        public static NetworkCredential _networkCredential = new NetworkCredential("","");

        public static List<NetworkConnection> openConnections = new List<NetworkConnection>();

        public static void GenerateConnections()
        {
            List<string> UNCpaths = Auer_Find_Replace.allPaths.Where(p => p.StartsWith("\\\\")).ToList();
            openConnections.Clear();
            UNCpaths.ForEach(p => CreateConnection(p)); 
        }

        public static bool CreateConnection(string path)
        {
            //return is_open? status
            try
            {
                if (DataManager.PossiblePath(path)) { return true; }
                openConnections.Add( new NetworkConnection(path, _networkCredential));
                DataManager.OpenDir(path);
                return true;
            }
            catch { return false;  }
        }

        public NetworkConnection(string networkName,
            NetworkCredential credentials)
        {
            _networkName = networkName;

            var netResource = new NetResource()
            {
                Scope = ResourceScope.GlobalNetwork,
                ResourceType = ResourceType.Disk,
                DisplayType = ResourceDisplaytype.Share,
                RemoteName = networkName
            };

            var userName = string.IsNullOrEmpty(credentials.Domain)
                ? credentials.UserName
                : string.Format(@"{0}\{1}", credentials.Domain, credentials.UserName);

            var result = WNetAddConnection2(
                netResource,
                credentials.Password,
                userName,
                0);

            if (result != 0)
            {
                //From https://duanenewman.net/blog/post/running-powershell-scripts-from-csharp/

                Console.WriteLine("Login Failed: Attempting Powershell Login");

                var ps1File = "Popup.ps1";
                var startInfo = new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    Arguments = $"-NoProfile -ExecutionPolicy unrestricted -windowstyle hidden -file \"{ps1File}\" \"{networkName}\" \"{credentials.UserName}\" \"{credentials.Password}\"",
                    UseShellExecute = false,
                    
                };
                Process P = Process.Start(startInfo);
                P.WaitForExit();
            }
        }

        ~NetworkConnection()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            WNetCancelConnection2(_networkName, 0, true);
        }

        [DllImport("mpr.dll")]
        private static extern int WNetAddConnection2(NetResource netResource,
            string password, string username, int flags);

        [DllImport("mpr.dll")]
        private static extern int WNetCancelConnection2(string name, int flags,
            bool force);
    }

    [StructLayout(LayoutKind.Sequential)]
    public class NetResource
    {
        public ResourceScope Scope;
        public ResourceType ResourceType;
        public ResourceDisplaytype DisplayType;
        public int Usage;
        public string LocalName;
        public string RemoteName;
        public string Comment;
        public string Provider;
    }

    public enum ResourceScope : int
    {
        Connected = 1,
        GlobalNetwork,
        Remembered,
        Recent,
        Context
    };

    public enum ResourceType : int
    {
        Any = 0,
        Disk = 1,
        Print = 2,
        Reserved = 8,
    }

    public enum ResourceDisplaytype : int
    {
        Generic = 0x0,
        Domain = 0x01,
        Server = 0x02,
        Share = 0x03,
        File = 0x04,
        Group = 0x05,
        Network = 0x06,
        Root = 0x07,
        Shareadmin = 0x08,
        Directory = 0x09,
        Tree = 0x0a,
        Ndscontainer = 0x0b
    }
}
