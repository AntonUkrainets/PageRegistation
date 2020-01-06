using Foundation;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace PageRegistration
{
    public partial class UserProfileView : UIViewController
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Web { get; set; }
        public int photo { get; set; }

        private IList<UIImage> images;
        private UIView UserView;

        public UserProfileView(IntPtr handle) : base(handle)
        {
            Name = string.Empty;
            Phone = string.Empty;
            Address = string.Empty;
            Web = string.Empty;

            photo = 0;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();            
            SetValuesFromRegForm();

            UserView = viewIcon;

            images = new List<UIImage>
            {
                UIImage.FromBundle("aqua.png"),
                UIImage.FromBundle("blue.png"),
                UIImage.FromBundle("green.png"),
                UIImage.FromBundle("yellow.png")
            };

            SetImages();
        }
        private void SetValuesFromRegForm()
        {
            if (Phone.Length > 6)
            {
                var attributes = new UIStringAttributes
                {
                    Font = UIFont.SystemFontOfSize(12)
                };

                var mutableAttribString = new NSMutableAttributedString(Phone);
                mutableAttribString.SetAttributes(attributes, new NSRange(0, 6));
                PhoneLabel.AttributedText = mutableAttribString;
            }
            else
                PhoneLabel.Text = Phone;

            NameLabel.Text = Name;
            AddressLabel.Text = Address;
            WebsiteLabel.Text = Web;
        }

        private void Image(UIImage image, double pX, double pY, double width, double height)
        {
            var ViewImage = new UIImageView()
            {
                Image = image,
                Frame = new CoreGraphics.CGRect(pX, pY, width, height)
            };

            UserView.Add(ViewImage);
        }

        private void SetImages()
        {
            switch (photo)
            {
                case 1:
                    Image(images[0], 20, 10, 30, 30);
                    break;
                case 2:
                    Image(images[0], 10, 20, 30, 30);
                    Image(images[1], 40, 20, 30, 30);
                    break;
                case 3:
                    Image(images[0], 10, 20, 30, 30);
                    Image(images[1], 40, 10, 20, 20);
                    Image(images[2], 40, 40, 20, 20);
                    break;
                case 4:
                    Image(images[0], 10, 10, 25, 25);
                    Image(images[1], 40, 10, 25, 25);
                    Image(images[2], 10, 40, 25, 25);
                    Image(images[3], 40, 40, 25, 25);
                    break;
            }
        }
    }
}