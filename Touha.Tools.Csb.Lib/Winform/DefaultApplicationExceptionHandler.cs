using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Touha.Tools.Csb.Lib.Winform.Interface;

namespace Touha.Tools.Csb.Lib.Winform
{
    public class DefaultApplicationExceptionHandler : IApplicationExceptionHandler
    {
        public void NonUIExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = e.ExceptionObject as Exception;
                Debug.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UIThreadExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                Exception ex = e.Exception;
                Debug.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}