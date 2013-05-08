using System;
using System.Threading;
using System.Windows.Forms;
using dokas.EncodingConverter.Exceptions;

namespace dokas.EncodingConverter
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;

            Application.Run(new MainForm());
        }

        #region Exceptions Handling

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            if (e.Exception is RecoverableException)
            {
                // this is expected behaviour occured due to user activity
                // show warning message with description how to fix it
                HandleRecoverableException(e.Exception.Message);
            }
            else if (e.Exception.InnerException is RecoverableException)
            {
                // this is expected behaviour occured due to user activity
                // show warning message with description how to fix it
                HandleRecoverableException(e.Exception.InnerException.Message);
            }
            else if (e.Exception is UnrecoverableException)
            {
                // we know about the possibility of such errors,
                // just show the message and restart application
                HandleUnrecoverableException(e.Exception.Message);
            }
            else if (e.Exception.InnerException is UnrecoverableException)
            {
                // we know about the possibility of such errors,
                // just show the message and restart application
                HandleUnrecoverableException(e.Exception.InnerException.Message);
            }
            else
            {
                // fail totally with message for developers
                // TODO: Add logging and 'Send this error to developer' feature
                throw e.Exception;
            }
        }

        private static void HandleRecoverableException(string message)
        {
            MessageBox.Show(
                message + Environment.NewLine + Environment.NewLine + "Please correct the issue and retry.",
                "Something is wrong...",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private static void HandleUnrecoverableException(string message)
        {
            MessageBox.Show(
                "Application failed with the error and will be restarted." + Environment.NewLine + message,
                "Unrecoverable Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            Application.Restart();
        }

        #endregion
    }
}
