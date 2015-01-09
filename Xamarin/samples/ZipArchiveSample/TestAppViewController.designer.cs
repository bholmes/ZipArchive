// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation; using Foundation;
using MonoTouch.UIKit; using UIKit;

namespace ZipArchiveSample
{
	[Register ("TestAppViewController")]
	partial class TestAppViewController
	{
		[Outlet]
		UIButton btnUnzip { get; set; }

		[Outlet]
		UIButton btnZip { get; set; }

		[Outlet]
		UIButton btnSelectDate { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnUnzip != null) {
				btnUnzip.Dispose ();
				btnUnzip = null;
			}

			if (btnZip != null) {
				btnZip.Dispose ();
				btnZip = null;
			}

			if (btnSelectDate != null) {
				btnSelectDate.Dispose ();
				btnSelectDate = null;
			}
		}
	}
}
