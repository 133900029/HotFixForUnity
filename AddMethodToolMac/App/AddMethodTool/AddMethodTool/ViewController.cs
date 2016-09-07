using System;

using AppKit;
using Foundation;
 
namespace AddMethodTool
{
	public partial class ViewController : NSViewController
	{
 
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Do any additional setup after loading the view.
			 
			textProject.StringValue = "/Users/luozhuocheng/Desktop/Project1/Assets/script";
		 	textCopy.StringValue = "/Users/luozhuocheng/Desktop/CopyProject/Assets/script";
			textSln.StringValue = "/Users/luozhuocheng/Desktop/Project1/UnityVS.Project1.sln";
			textCsproj.StringValue = "/UnityVS.Project1.CSharp.csproj"; 

		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}
		 
		partial void ClickLeft(Foundation.NSObject sender)
		{
			CSharpProject.textCsproj = textCsproj.StringValue;
			Program.textCopy = textCopy.StringValue;
			Program.textSln = textSln.StringValue;
			Program.textProject = textProject.StringValue;
			Program.Left();

 		}
		partial void ClickRight(Foundation.NSObject sender)
		{
			CSharpProject.textCsproj = textCsproj.StringValue;
			Program.textCopy = textCopy.StringValue;
			Program.textSln = textSln.StringValue;
			Program.textProject = textProject.StringValue;
			Program.Right();

		}
	}
}
