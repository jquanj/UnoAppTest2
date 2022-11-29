using Microsoft.UI.Xaml;
using System;

namespace UnoAppTest2.Wasm
{
    public class Program
    {
        private static App _app;

        static int Main(string[] args)
        {
            // This statement triggers the issue
            //SQLitePCL.Batteries.Init();

            // This statement also triggers the same issue
            SQLitePCL.Batteries_V2.Init();

            // Triggers a System.Exception: Failed to run emscripten
            //SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_sqlite3());

            Microsoft.UI.Xaml.Application.Start(_ => _app = new App());

            return 0;
        }
    }
}
