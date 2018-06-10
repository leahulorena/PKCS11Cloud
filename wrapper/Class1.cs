using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using RGiesecke.DllExport;

namespace wrapper
{
    public class Class1
    {


        

        [DllExport]
        static public string test() {
            return "test";

        }
        
        [DllExport]
        static public string init()
        {
            localhost.DSWS ws = new localhost.DSWS();
           // String str = Marshal.PtrToStringAnsi(getUsername());
            string str = "client1@client.com";
            string file = ws.GetUserCertificate(str);
            return file;
        }

        //[DllImport("softhsm.dll", CallingConvention = CallingConvention.Cdecl)]
        //static extern IntPtr getUsername();

        //[DllImport("softhsm.dll", CallingConvention = CallingConvention.Cdecl)]
        //static extern IntPtr setUsername([MarshalAs(UnmanagedType.LPTStr)]string issuer);
    }
}
