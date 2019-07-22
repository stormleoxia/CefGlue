using System;
using Xilium.CefGlue.Common;
using Xilium.CefGlue.WPF;

namespace Xilium.CefGlue.Demo.WPF
{
    internal static class Program
    {
        [STAThread]
        private static int Main(string[] args)
        {
            CefRuntimeLoader.Initialize(args);

            var app = new Xilium.CefGlue.Demo.WPF.App();
            app.InitializeComponent();
            app.Run();

            return 0;
        }
    }
}
