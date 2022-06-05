using AppKit;
using Foundation;
using CoreGraphics;

namespace MJIDE
{
	public class AppDelegate : NSApplicationDelegate
	{
		private NSWindow window;

		public AppDelegate ()
		{
		}

		public override void DidFinishLaunching (NSNotification notification)
		{
			window = new NSWindow(
				new CGRect(x: 0, y: 0, width: 480, height: 270),
				NSWindowStyle.Miniaturizable | NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled,
				NSBackingStore.Buffered,
				false
			);
			window.Center();
			window.Title = "MJIDE";
			var contentViewController = new ViewController();
			var bounds = new CGRect(0, 0, 800, 600);
			window.SetContentSize(bounds.Size);
			contentViewController.View.Frame = bounds;
			window.ContentViewController = contentViewController;
			window.MakeKeyAndOrderFront(null);
		}

		public override void WillTerminate (NSNotification notification)
		{
			// Insert code here to tear down your application
		}
	}
}

