using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Touha.Tools.Csb.Lib.Winform.Interface
{
    interface IApplicationExceptionHandler
    {
        void UIThreadExceptionHandler(object sender, ThreadExceptionEventArgs e);

        void NonUIExceptionHandler(object sender, UnhandledExceptionEventArgs e);
    }
}
