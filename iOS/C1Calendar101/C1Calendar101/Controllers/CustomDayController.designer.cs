﻿// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace C1Calendar101
{
    [Register ("CustomDayController")]
    partial class CustomDayController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        C1.iOS.Calendar.C1Calendar Calendar { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Calendar != null) {
                Calendar.Dispose ();
                Calendar = null;
            }
        }
    }
}