using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace videoClipExtractor
{
    /// <summary>
    /// An Async wrapper for <see cref="Process"/>.
    /// </summary>
    public class ProcessAsync
    {

        private string _fileName;
        private string _arguments;

        public ProcessAsync(string fileName, string arguments)
        {
            _fileName = fileName;
            _arguments = arguments;
        }

        // public async Task<string> Run(char stdin = null)
        public async Task<string> Run()
        {

            // Initialise
            var cmd = new Process();
            cmd.StartInfo.FileName = _fileName;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.Arguments = _arguments;

            // Create a task that waits for the Process to finish
            var cmdExited = new CmdExitedTaskWrapper();
            cmd.EnableRaisingEvents = true;
            cmd.Exited += cmdExited.EventHandler;

            // Start process
            cmd.Start();

            // Pass any stdin if necessary
            //if (stdin != null)
            //{
            //    await cmd.StandardInput.WriteAsync(stdin);
            //    await cmd.StandardInput.FlushAsync();
            //    cmd.StandardInput.Close();
            //}

            cmd.StandardInput.WriteLine("echo Jeremy");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            // cmd.WaitForExit();

            // Wait for process to end and return stdout
            await cmdExited.Task;
            return cmd.StandardOutput.ReadToEnd();

        }

        /// <remarks>
        /// We can't wait on a Process directly, so create a wrapper for a
        /// task that waits for the <see cref="Process.Exited"/> Event to be
        /// raised.
        /// </remarks>
        private class CmdExitedTaskWrapper
        {

            private TaskCompletionSource<bool> _tcs = new TaskCompletionSource<bool>();

            public void EventHandler(object sender, EventArgs e)
            {
                _tcs.SetResult(true);
            }

            public Task Task => _tcs.Task;

        }

    }
}
