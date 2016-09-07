// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace AddMethodTool
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField textCopy { get; set; }

		[Outlet]
		AppKit.NSTextField textCsproj { get; set; }

		[Outlet]
		AppKit.NSTextField textProject { get; set; }

		[Outlet]
		AppKit.NSTextField textSln { get; set; }

		[Action ("ClickLeft:")]
		partial void ClickLeft (Foundation.NSObject sender);

		[Action ("ClickRight:")]
		partial void ClickRight (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (textProject != null) {
				textProject.Dispose ();
				textProject = null;
			}

			if (textCopy != null) {
				textCopy.Dispose ();
				textCopy = null;
			}

			if (textCsproj != null) {
				textCsproj.Dispose ();
				textCsproj = null;
			}

			if (textSln != null) {
				textSln.Dispose ();
				textSln = null;
			}
		}
	}
}
