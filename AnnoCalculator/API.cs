using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AnnoCalculator
{
    internal class API
    {
        public int[] populationCount { get; private set; }
        IntPtr gameHandle;
        public API(IntPtr gameHandle) 
        {
            populationCount = new int[7];
            this.gameHandle = gameHandle;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out IntPtr lpNumberOfBytesRead);
        public void ReadDataFromGame()
        {
            
        }

    }

}
