using System;

using AppKit;
using Foundation;

namespace MJIDE
{
	public partial class ViewController : NSViewController
	{
		public ViewController () : base (null, null)
		{
		}

        public override void LoadView()
        {
			var text = new NSTextView();
			text.Value = "HELLO THERE";
			this.View = text;
		}
    }
}
