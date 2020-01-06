using Foundation;
using System;
using UIKit;

namespace PageRegistration
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
        partial void TxtNext_TouchUpInside(UIButton sender)
        {
            var userProfile = Storyboard.InstantiateViewController("user") as UserProfileView;

            int countPhotos = 1;

            userProfile.Name = FullNameTextField.Text;
            userProfile.Address = AddressTextField.Text;
            userProfile.Phone = PhoneTextField.Text;
            userProfile.Web = WebsiteTextField.Text;
            userProfile.photo = Int32.TryParse(CountPhotosTextField.Text, out countPhotos) ? Int32.Parse(CountPhotosTextField.Text) : 1;
            userProfile.ModalPresentationStyle = UIModalPresentationStyle.FullScreen;

            this.PresentViewController(userProfile, true, null);
        }
    }
}