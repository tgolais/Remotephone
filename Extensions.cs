using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remotephone
{
    public static class Extensions
    {
        public static string Execute(this string cmd, bool wait = true, string executable = "cmd.exe", bool visible = false)
        {
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = executable,
                    Arguments = cmd,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = !visible,
                    WindowStyle = visible ? ProcessWindowStyle.Normal : ProcessWindowStyle.Hidden
                }
            };

            process.Start();

            if (wait)
            {
                string result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                return result;
            }

            return String.Empty;
        }

        public static string StringJoin<T>(this IEnumerable<T> collection, string separator = " ")
            => String.Join(separator, collection);

        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var elem in collection)
                action(elem);
        }

        public static void EasyInvoke(this Control _control, Action action)
        {
            if (_control.InvokeRequired)
            {
                _control.Invoke((MethodInvoker)delegate { action(); });
            }
            else
            {
                action();
            }
        }
    }
}
