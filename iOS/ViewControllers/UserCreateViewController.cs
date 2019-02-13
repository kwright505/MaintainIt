using Foundation;
using System;
using UIKit;

namespace MaintainIt.iOS
{
    public partial class UserCreateViewController : UIViewController
    {
        public UserCreateViewController (IntPtr handle) : base (handle)
        {
        }

        partial void UIButton4765_TouchUpInside(UIButton sender)
        {
            CheckUserCred();
        }

        public bool CheckUserCred()
        {
            User MyUser = new User();

            MyUser.Username = Username.Text;
            MyUser.Password = PWOriginal.Text;

            if (FNTextView.Text == ""  || Username.Text == "" || PWOriginal.Text == "" || PWConfirm.Text == "")
            {
                var okAlertController = UIAlertController.Create("User not Created!", "Please fill in all fields", UIAlertControllerStyle.Alert);
                okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));


                PresentViewController(okAlertController, true, null);

                return false;
            }

            if (FNTextView.Text == "FirstName" || Username.Text == "Username" || PWOriginal.Text == "Password" || PWConfirm.Text == "Password")
            {
                var okAlertController = UIAlertController.Create("User not Created!", "Please fill in all fields", UIAlertControllerStyle.Alert);
                okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));


                PresentViewController(okAlertController, true, null);

                return false;
            }

            if (PWOriginal.Text != PWConfirm.Text)
            {
                var okAlertController = UIAlertController.Create("User not Created!", "Passwords do not match", UIAlertControllerStyle.Alert);
                okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));


                PresentViewController(okAlertController, true, null);

                PWOriginal.Text = "";
                PWConfirm.Text = "";

                return false;
            }

            else
            {
                return true;
            }

        }

        public class User
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

            /*public User() { }
            public User(string username, string password)
            {
                this.Username = username;

                this.Password = password;
            }*/
        }
    }
}