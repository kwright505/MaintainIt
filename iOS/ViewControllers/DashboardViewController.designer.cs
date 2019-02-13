// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MaintainIt.iOS
{
    [Register ("DashboardViewController")]
    partial class DashboardViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton goBT { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (goBT != null) {
                goBT.Dispose ();
                goBT = null;
            }
        }
    }
}