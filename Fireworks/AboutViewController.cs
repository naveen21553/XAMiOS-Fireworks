﻿using Foundation;
using System;
using UIKit;

namespace Fireworks
{
    public partial class AboutViewController : UIViewController
    {
        public AboutViewController (IntPtr handle) : base (handle)
        {
        }

        partial void CloseButton_TouchUpInside(UIButton sender)
        {
            this.DismissViewController(true, null);
        }
    }
}