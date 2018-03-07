using System;
using UIKit;
using CoreGraphics;

namespace KnobDemo
{
    public partial class ViewController : UIViewController
    {
        partial void AngleChanged(UISlider sender)
        {
            
            //((KnobControlChild)this.View.Subviews[0]).RotationAngle = sender.Value;
            KnobObjectChild.Transform = CGAffineTransform.MakeRotation((float)sender.Value * ((nfloat)Math.PI) / 180.0f);
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ArtboardKnobDrawing artboardKnobDrawing = new ArtboardKnobDrawing();

            artboardKnobDrawing.DrawParentImage = true;
            KnobObjectParent.Image = artboardKnobDrawing.GenerateArtboardKnobDrawingBitmap();

            artboardKnobDrawing.DrawParentImage = false;
            KnobObjectChild.Image = artboardKnobDrawing.GenerateArtboardKnobDrawingBitmap();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
