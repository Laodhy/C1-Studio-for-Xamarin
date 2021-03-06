﻿using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using C1.CollectionView;
using C1.Mac.CollectionView;
using System.Collections.ObjectModel;

namespace C1CollectionView101
{
	public partial class SampleViewController : NSViewController
	{
		public SampleViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			SourceList.Initialize();

			var samples = new SourceListItem("Samples");
            var storyboard = NSStoryboard.FromName("Main", null);

			samples.AddItem(Resources.gettingstarted, "collectionview.png", () => 
            {
                var viewController = storyboard.InstantiateControllerWithIdentifier("gettingstarted") as GettingStartedViewController;
				var item = NSSplitViewItem.FromViewController(viewController);
				var splitViewController = ParentViewController as NSSplitViewController;
				splitViewController.RemoveSplitViewItem(splitViewController.SplitViewItems[1]);
				splitViewController.AddSplitViewItem(item);
			});
			samples.AddItem(Resources.columndefinition, "collectionview.png", () =>
			{
				var viewController = storyboard.InstantiateControllerWithIdentifier("columndefinition") as ColumnDefinitionViewController;
				var item = NSSplitViewItem.FromViewController(viewController);
				var splitViewController = ParentViewController as NSSplitViewController;
				splitViewController.RemoveSplitViewItem(splitViewController.SplitViewItems[1]);
				splitViewController.AddSplitViewItem(item);
			});
			samples.AddItem(Resources.filtering, "filter.png", () =>
            {
				var viewController = storyboard.InstantiateControllerWithIdentifier("filtering") as FilterViewController;
				var item = NSSplitViewItem.FromViewController(viewController);
                var splitViewController = ParentViewController as NSSplitViewController;
				splitViewController.RemoveSplitViewItem(splitViewController.SplitViewItems[1]);
				splitViewController.AddSplitViewItem(item);
            });
            samples.AddItem(Resources.grouping, "flexgrid_grouping.png", () =>
			{
				var viewController = storyboard.InstantiateControllerWithIdentifier("grouping") as GroupingViewController;
				var item = NSSplitViewItem.FromViewController(viewController);
				var splitViewController = ParentViewController as NSSplitViewController;
				splitViewController.RemoveSplitViewItem(splitViewController.SplitViewItems[1]);
				splitViewController.AddSplitViewItem(item);
			});
			samples.AddItem(Resources.ondemand, "flexgrid_loading.png", () =>
			{
				var viewController = storyboard.InstantiateControllerWithIdentifier("ondemand") as OnDemandViewController;
				var item = NSSplitViewItem.FromViewController(viewController);
				var splitViewController = ParentViewController as NSSplitViewController;
				splitViewController.RemoveSplitViewItem(splitViewController.SplitViewItems[1]);
				splitViewController.AddSplitViewItem(item);
			});
			samples.AddItem(Resources.customcells, "collectionview.png", () =>
			{
                var viewController = storyboard.InstantiateControllerWithIdentifier("customcells") as CustomCellsViewController;
				var item = NSSplitViewItem.FromViewController(viewController);
				var splitViewController = ParentViewController as NSSplitViewController;
				splitViewController.RemoveSplitViewItem(splitViewController.SplitViewItems[1]);
				splitViewController.AddSplitViewItem(item);
			});

			SourceList.AddItem(samples);

			// Display side list
			SourceList.ReloadData();
			SourceList.ExpandItem(null, true);
		}

	}

}
