using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using GalaSoft.MvvmLight.Ioc;
using Demo1.Data;

namespace Demo1.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
			SimpleIoc.Default.Register<ISqlite>(() => SQLite_iOS.SQLite);

            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
