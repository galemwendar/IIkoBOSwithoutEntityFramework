using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace iikoBOS_prealpha_API
{
    public class Authorization
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

        delegate bool EnumWindowProc(IntPtr hWnd, IntPtr parameter);

        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool EnumChildWindows(IntPtr window, EnumWindowProc callback, IntPtr i);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        static bool EnumWindow(IntPtr handle, IntPtr pointer)
        {
            GCHandle gch = GCHandle.FromIntPtr(pointer);
            List<IntPtr> list = gch.Target as List<IntPtr>;
            if (list == null)
                throw new InvalidCastException("GCHandle Target could not be cast as List<IntPtr>");

            list.Add(handle);
            return true;
        }

        static List<IntPtr> GetChildWindows(IntPtr parent)
        {
            List<IntPtr> result = new List<IntPtr>();
            GCHandle listHandle = GCHandle.Alloc(result);

            try
            {
                EnumWindowProc childProc = new EnumWindowProc(EnumWindow);
                EnumChildWindows(parent, childProc, GCHandle.ToIntPtr(listHandle));
            }
            finally
            {
                if (listHandle.IsAllocated)
                    listHandle.Free();
            }
            return result;


        }

        public void AuthorizationMetod(string passwd)
        {

            for (int i = 0; i < 1000;)
            {
                IntPtr authWindow = FindWindow(null, "Вход в систему");
                if (authWindow.ToInt32() != 0)
                {
                    List<IntPtr> all_hwnd_child_window = GetChildWindows(authWindow);
                    foreach (var hwnd_child_window in all_hwnd_child_window)
                    {
                        IntPtr editWindow = FindWindowEx(hwnd_child_window, new IntPtr(0), null, "");
                        SendMessage(editWindow, 0x000C, 0, passwd);

                        IntPtr bttnLogin = FindWindowEx(hwnd_child_window, new IntPtr(0), null, "Войти");
                        SendMessage(bttnLogin, (int)0x201, (IntPtr)1, IntPtr.Zero);
                        SendMessage(bttnLogin, (int)0x202, IntPtr.Zero, IntPtr.Zero);
                    }
                    i++;

                }
                else { Thread.Sleep(1000); i++; }
            }

        }
    }
}
