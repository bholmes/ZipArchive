using System;
using System.Drawing;
using System.IO;
using MonoTouch.ObjCRuntime; using ObjCRuntime;
using MonoTouch.Foundation; using Foundation;
using MonoTouch.UIKit; using UIKit;

using MiniZip.ZipArchive;

namespace ZipArchiveSample
{
	public partial class TestAppViewController : UIViewController
	{
		public TestAppViewController () : base ("TestAppViewController", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string appPath = Path.Combine (documentsPath,"..","ZipArchiveSample.app");

			string zipFileName = documentsPath + "/file.zip";
			ZipArchive zip = new ZipArchive();

			zip.OnError += (sender, e) => {
				Console.WriteLine ("Something went wrong: {0}", e);
			};

			this.btnZip.TouchUpInside += (sender, e) => {
				zip.CreateZipFile(zipFileName, "passw0rd");
				zip.AddFolder (appPath,"prefix");
				zip.CloseZipFile ();
			};

			this.btnUnzip.TouchUpInside += (sender, e) => {
				zip.UnzipOpenFile(zipFileName,"passw0rd");
				zip.UnzipFileTo (documentsPath, true);
				zip.UnzipCloseFile ();
			};

		}

	}
}

