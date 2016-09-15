using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FirebaseMessagingQuickstart
{
    class LoginDialog : DialogFragment
    {
        //Create class properties
        protected EditText NameEditText;
        protected EditText PasswordEditText;
        protected Button LoginButton;
        protected Button ClearButton;

        /// <summary>
        /// Method that creates and returns an instance of this dialog
        /// </summary>
        /// <returns></returns>
        public static LoginDialog NewInstance()
        {
            var dialogFragment = new LoginDialog();
            return dialogFragment;
        }

        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Begin building a new dialog.
            var builder = new AlertDialog.Builder(Activity);

            //Get the layout inflater
            var inflater = Activity.LayoutInflater;

            //Inflate the layout for this dialog
            var dialogView = inflater.Inflate(Resource.Layout.login_layout, null);

            if (dialogView != null)
            {
                //Initialize the properties
                NameEditText = dialogView.FindViewById<EditText>(Resource.Id.nameEditText);
                PasswordEditText = dialogView.FindViewById<EditText>(Resource.Id.passwordEditText);
                

                builder.SetView(dialogView);
                builder.SetPositiveButton("Login", HandlePositiveButtonClick);
                builder.SetNegativeButton("Cancel", HandleNegativeButtonClick);
            }


            //Create the builder 
            var dialog = builder.Create();

            //Now return the constructed dialog to the calling activity
            return dialog;
        }
        

        private void HandlePositiveButtonClick(object sender, DialogClickEventArgs e)
        {
            var dialog = (AlertDialog)sender;
            
            
                dialog.Dismiss();
            

        }

        private void HandleNegativeButtonClick(object sender, DialogClickEventArgs e)
        {
            var dialog = (AlertDialog)sender;
            dialog.Dismiss();
        }

    }
}