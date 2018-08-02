using Foundation;
using System;
using UIKit;

namespace Fireworks
{
    public partial class ViewController : UIViewController
    {
        private SimpleParticleGen FireWorks;
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

            FireWorks = new SimpleParticleGen(UIImage.FromFile("xamlogo.png"), View);

            buttonStart.TouchUpInside += delegate (object sender, EventArgs e)
            {
                FireWorks.Start();
            };

            
        }


        partial void switchNight_ValueChanged(UISwitch sender)
        {
            if (switchNight.On)
                this.View.BackgroundColor = UIColor.FromRGB(153, 153, 153);

            else
                this.View.BackgroundColor = UIColor.White;
        }

        partial void sliderSize_ValueChanged(UISlider sender)
        {
            FireWorks.ScaleMax = sliderSize.Value;
        }

        partial void ButtonAbout_TouchUpInside(UIButton sender)
        {
            AboutViewController viewController = (AboutViewController) this.Storyboard.InstantiateViewController("AboutViewController");

            this.PresentViewController(viewController, true, null);
        }
    }
}