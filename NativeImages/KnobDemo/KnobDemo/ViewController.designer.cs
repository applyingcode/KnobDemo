// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace KnobDemo
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider AngleSlider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView KnobObjectChild { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView KnobObjectParent { get; set; }

        [Action ("AngleChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AngleChanged (UIKit.UISlider sender);

        void ReleaseDesignerOutlets ()
        {
            if (AngleSlider != null) {
                AngleSlider.Dispose ();
                AngleSlider = null;
            }

            if (KnobObjectChild != null) {
                KnobObjectChild.Dispose ();
                KnobObjectChild = null;
            }

            if (KnobObjectParent != null) {
                KnobObjectParent.Dispose ();
                KnobObjectParent = null;
            }
        }
    }
}