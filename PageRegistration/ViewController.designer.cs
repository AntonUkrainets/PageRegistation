// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PageRegistration
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField AddressTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField CountPhotosTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField FullNameTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PhoneTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton txtNext { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField WebsiteTextField { get; set; }

        [Action ("TxtNext_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TxtNext_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AddressTextField != null) {
                AddressTextField.Dispose ();
                AddressTextField = null;
            }

            if (CountPhotosTextField != null) {
                CountPhotosTextField.Dispose ();
                CountPhotosTextField = null;
            }

            if (FullNameTextField != null) {
                FullNameTextField.Dispose ();
                FullNameTextField = null;
            }

            if (PhoneTextField != null) {
                PhoneTextField.Dispose ();
                PhoneTextField = null;
            }

            if (txtNext != null) {
                txtNext.Dispose ();
                txtNext = null;
            }

            if (WebsiteTextField != null) {
                WebsiteTextField.Dispose ();
                WebsiteTextField = null;
            }
        }
    }
}