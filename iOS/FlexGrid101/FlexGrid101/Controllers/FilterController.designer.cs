﻿// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace FlexGrid101
{
    [Register ("FilterController")]
    partial class FilterController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem FilterButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        C1.iOS.Grid.FlexGrid Grid { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem UndoFilterButton { get; set; }

        [Action ("UndoFilterButton_Activated:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UndoFilterButton_Activated (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (FilterButton != null) {
                FilterButton.Dispose ();
                FilterButton = null;
            }

            if (Grid != null) {
                Grid.Dispose ();
                Grid = null;
            }

            if (UndoFilterButton != null) {
                UndoFilterButton.Dispose ();
                UndoFilterButton = null;
            }
        }
    }
}