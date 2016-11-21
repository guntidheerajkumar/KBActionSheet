using System;
using KBCustomActionSheet;
using CoreGraphics;
using UIKit;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();


			BtnLight.TouchUpInside += (sender, e) => {
				KBActionSheet actionSheet = new KBActionSheet();
				actionSheet.Title = "A thing needs to be done.\nAre you sure you want to do it?";
				actionSheet.AddButtonWithTitle("Do Something", () => { });
				actionSheet.AddDestructiveButtonWithTitle("Do Nothing", () => {
					actionSheet.Dispose();
				});
				actionSheet.Style = KBActionSheetStyle.Light;
				actionSheet.ShowFromView(BtnLight, this.View);
			};

			BtnDark.TouchUpInside += (sender, e) => {
				KBActionSheet actionSheet = new KBActionSheet();
				actionSheet.Title = "A thing needs to be done.\nAre you sure you want to do it?";
				actionSheet.AddButtonWithTitle("Do Something", () => { });
				actionSheet.AddDestructiveButtonWithTitle("Do Nothing", () => {
					actionSheet.Dispose();
				});
				actionSheet.Style = KBActionSheetStyle.Dark;
				actionSheet.ShowFromView(BtnDark, this.View);
			};
		}
	}
}
