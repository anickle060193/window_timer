using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowTimer
{
    class Native
    {
        [DllImport( "user32.dll" )]
        static extern IntPtr GetForegroundWindow();

        [DllImport( "user32.dll" )]
        static extern int GetWindowText( IntPtr hWnd, StringBuilder text, int count );

        public static string GetForegroundWindowTitle()
        {
            const int nChars = 512;
            StringBuilder buffer = new StringBuilder( nChars );
            IntPtr handle = GetForegroundWindow();

            if( GetWindowText( handle, buffer, nChars ) > 0 )
            {
                return buffer.ToString();
            }
            return null;
        }
    }
}
