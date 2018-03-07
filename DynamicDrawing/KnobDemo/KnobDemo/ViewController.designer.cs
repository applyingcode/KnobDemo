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

        [Action ("AngleChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AngleChanged (UIKit.UISlider sender);

        void ReleaseDesignerOutlets ()
        {
            if (AngleSlider != null) {
                AngleSlider.Dispose ();
                AngleSlider = null;
            }
        }
    }
}