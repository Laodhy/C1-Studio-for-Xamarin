// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace C1CollectionView101
{
	[Register ("FilterViewController")]
	partial class FilterViewController
	{
		[Outlet]
		AppKit.NSSearchField SearchField { get; set; }

		[Outlet]
		AppKit.NSTableView TableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TableView != null) {
				TableView.Dispose ();
				TableView = null;
			}

			if (SearchField != null) {
				SearchField.Dispose ();
				SearchField = null;
			}
		}
	}
}
