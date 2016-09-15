using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Firebase.Messaging;
using Firebase.Iid;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using ModernHttpClient;
using Java.Lang;
using Android.Content;
using Android.Support.V4.Content;
using System.Net.Http.Headers;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Auth;
using Android.Views;
using Newtonsoft.Json.Linq;
using System.Text;
using Newtonsoft.Json;

namespace FirebaseMessagingQuickstart
{
    [Activity(Label = "Firebase Messaging Quickstart", MainLauncher = true, Icon = "@mipmap/ic_launcher")]
    public class MainActivity : AppCompatActivity
    {
        const string TAG = "MainActivity";
        private static MainActivity mainActivity;

        private EditText LoginNameEditText;
        private EditText LoginPasswordEditText;

        protected override void OnResume()
        {
            base.OnResume();
            ServiceBroadcastReceiver bReceiver = new ServiceBroadcastReceiver();
            LocalBroadcastManager.GetInstance(this).RegisterReceiver(bReceiver, new IntentFilter("message"));
        }

        protected override void OnPause()
        {
            base.OnPause();
            ServiceBroadcastReceiver bReceiver = new ServiceBroadcastReceiver();
            LocalBroadcastManager.GetInstance(this).UnregisterReceiver(bReceiver);
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            mainActivity = this;

            SetContentView(Resource.Layout.activity_main);

            if (GetString(Resource.String.google_app_id) == "YOUR-APP-ID")
                throw new System.Exception("Invalid google-services.json file.  Make sure you've downloaded your own config file and added it to your app project with the 'GoogleServicesJson' build action.");

            // If a notification message is tapped, any data accompanying the notification
            // message is available in the intent extras. In this sample the launcher
            // intent is fired when the notification is tapped, so any accompanying data would
            // be handled here. If you want a different intent fired, set the click_action
            // field of the notification message to the desired intent. The launcher intent
            // is used when no click_action is specified.
            //
            // Handle possible data accompanying notification message.
            // [START handle_data_extras]
            if (Intent.Extras != null)
            {
                foreach (var key in Intent.Extras.KeySet())
                {
                    var value = Intent.Extras.GetString(key);
                    Android.Util.Log.Debug(TAG, "Key: {0} Value: {1}", key, value);
                }
            }
            // [END handle_data_extras]

            var subscribeButton = FindViewById<Button>(Resource.Id.subscribeButton);
            subscribeButton.Click += delegate
            {
                // [START subscribe_topics]
                FirebaseMessaging.Instance.SubscribeToTopic("news");
                Android.Util.Log.Debug(TAG, "Subscribed to news topic");
                // [END subscribe_topics]
            };

            #region Set Button Clicks
            var logTokenButton = FindViewById<Button>(Resource.Id.logTokenButton);
            logTokenButton.Click += delegate { Android.Util.Log.Debug(TAG, "InstanceID token: " + FirebaseInstanceId.Instance.Token); };

            var responseButton = FindViewById<Button>(Resource.Id.callAPIButton);
            responseButton.Click += delegate { TestGetFromWcfPublicApi(); };

            var saveButton = FindViewById<Button>(Resource.Id.saveButton);
            saveButton.Click += delegate { TestGetFromTodoApi(); };

            var getButton = FindViewById<Button>(Resource.Id.getButton);
            getButton.Click += delegate { retrieveset(); };
            #endregion

            Task.Run(() =>
            {
                var instanceID = FirebaseInstanceId.Instance;
                Android.Util.Log.Debug(TAG, "Before Refresh: {0}", instanceID.Token);

                //instanceID.DeleteToken(GetString(Resource.String.gcm_defaultSenderId), FirebaseMessaging.InstanceIdScope);

                instanceID.DeleteInstanceId();
                var iid1 = instanceID.Token;
                var iid2 = instanceID.GetToken(GetString(Resource.String.gcm_defaultSenderId), FirebaseMessaging.InstanceIdScope);
                Android.Util.Log.Debug(TAG, "Iid1: {0}, iid2: {1}", iid1, iid2);
            });

            // [END get_token]
        }

        #region Login Popup
        public void TestLogin()
        {
            //var dialog = LoginDialog.NewInstance();
            //dialog.Show(FragmentManager, "dialog");

            LayoutInflater inflater = LayoutInflater.From(this);
            View subView = inflater.Inflate(Resource.Layout.login_layout, null);
            //Initialize the properties
            LoginNameEditText = subView.FindViewById<EditText>(Resource.Id.nameEditText);
            LoginPasswordEditText = subView.FindViewById<EditText>(Resource.Id.passwordEditText);

            Android.App.AlertDialog.Builder builder = new Android.App.AlertDialog.Builder(this);
            builder.SetTitle("AlertDialog");
            //builder.SetMessage("AlertDialog Message");
            builder.SetView(subView);
            Android.App.AlertDialog alertDialog = builder.Create();

            builder.SetPositiveButton("Login", HandlePositiveButtonClick);
            builder.SetNegativeButton("Cancel", HandleNegativeButtonClick);

            builder.Show();
        }

        private void HandlePositiveButtonClick(object sender, DialogClickEventArgs e)
        {
            var dialog = (Android.App.AlertDialog)sender;

            string name = LoginNameEditText.Text;
            string password = LoginPasswordEditText.Text;
            EditText responseText = FindViewById<EditText>(Resource.Id.responseText);
            responseText.Text = string.Format("{0} - {1}", name, password);

            dialog.Dismiss();
        }

        private void HandleNegativeButtonClick(object sender, DialogClickEventArgs e)
        {
            var dialog = (Android.App.AlertDialog)sender;
            dialog.Dismiss();
        }
        #endregion

        #region Broadcast Receiver
        //Let's MyFirebaseIIDService send messages back to MainActivity (let us know db connection was made/success/error/etc) http://stackoverflow.com/questions/3841043/how-does-a-service-return-result-to-an-activity
        private class ServiceBroadcastReceiver : BroadcastReceiver
        {
            public override void OnReceive(Context context, Intent intent)
            {
                string message = intent.GetStringExtra("success");
                Toast.MakeText(mainActivity.ApplicationContext, message, ToastLength.Long).Show();
            }
        } 
        #endregion

        #region Store Settings Locally
        private void saveset()
        {
            EditText responseText = FindViewById<EditText>(Resource.Id.responseText);

            //store
            var prefs = Application.Context.GetSharedPreferences("FirebaseInfo", FileCreationMode.Private);
            var prefEditor = prefs.Edit();
            prefEditor.PutString("Name", "rpgray");
            prefEditor.PutString("Password", responseText.Text);
            prefEditor.Commit();

        }

        // Function called from OnCreate
        private void retrieveset()
        {
            //retreive 
            var prefs = Application.Context.GetSharedPreferences("FirebaseInfo", FileCreationMode.Private);
            var name = prefs.GetString("Name", null);
            var pass = prefs.GetString("Password", null);

            //Show a toast
            RunOnUiThread(() => Toast.MakeText(this, string.Format("{0} - {1}", name, pass), ToastLength.Long).Show());

        }
        #endregion

        #region API stuff
        public async void TestWebPDFArchiveGet()
        {
            try
            {
                //HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"http://arsswebv700:8105//source/DroidAlerts.aspx");
                //HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"https://api.redcard.com/source/DroidAlerts.aspx");
                string address = @"https://droidtest.redcard.com/source/DroidAlerts.aspx";
                Uri uri = new Uri(address);
                using (var httpClient = new HttpClient(new NativeMessageHandler()))
                {
                    /*
                        HttpWebRequest webRequest = (HttpWebRequest) WebRequest.Create(@"https://api.redcard.com/Source/ViewClaimsDocument.aspx?authtoken=adb37f4c-d908-4af3-8ebe-8e787a7858fd&recipientType=Insured&claimNumber=1604746501&memberId=100150797");
                        HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                    */

                    HttpResponseMessage response = await httpClient.GetAsync(uri);
                    HttpResponseHeaders responseHeadersCollection = response.Headers;
                    foreach (var value in responseHeadersCollection)
                    {
                        string key = value.Key;
                        Android.Util.Log.Debug(TAG, "Key: {0} Value: {1}", key, value.Value.FirstOrDefault());
                    }

                    /*
                    ConnectionString
                    Database
                    DataSource
                    */


                    string responseFromServer = await httpClient.GetStringAsync(uri);
                    EditText responseText = FindViewById<EditText>(Resource.Id.responseText);
                    responseText.Text = responseFromServer;
                    Console.WriteLine(responseFromServer);
                }
            }
            catch (System.Exception ex)
            {
                Android.Util.Log.Info("ERROR:", ex.ToString());
            }
        }
       
        public void TestPost()
        {
            //string localAddress = @"http://192.168.141.47:5000/api/Todo/";    //10.0.2.2 is built into android to access 'localhost' of your computer
            string localAddress = @"http://169.254.80.80:58985/api/Todo/";

            Uri uri = new Uri(localAddress);

            string resultContent2 = string.Empty;

            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                //Create json Object
                //var json = new JObject();
                //json.Add("name", "walk somewhere");
                //json.Add("isComplete", "false");
                //var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");

                //Can serialize simple classes
                TodoItem item = new TodoItem()
                {
                    Name = "Go to the park",
                    IsComplete = false
                };
                var serializedJSON = JsonConvert.SerializeObject(item);
                var content = new StringContent(serializedJSON.ToString(), Encoding.UTF8, "application/json");

                string resultContent = "";
                try
                {
                    var result = client.PostAsync(uri, content).Result;         //Need to add .Result since we're in a using
                    resultContent2 = result.Content.ReadAsStringAsync().Result; //Need to add .Result since we're in a using
                    //var resultJSON = JObject.Parse(resultContent2);
                    //var location = resultJSON.GetValue("Location");
                    var resultItem = JsonConvert.DeserializeObject<TodoItem>(resultContent2);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("error " + ex);
                    throw;
                }                   
                
                Console.WriteLine("Token was sent: " + resultContent);
            }
        }

        public void TestGetFromTodoApi()
        {
            string localAddress = @"http://169.254.80.80:58985/api/Todo/";  //IIS Express
            //string localAddress = @"http://169.254.80.80:5000/api/Todo/";   //IIS
            Uri uri = new Uri(localAddress);


            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string resultContent = "";
                try
                {
                    var result = client.GetAsync(uri).Result;         //Need to add .Result since we're in a using
                    var resultContent2 = result.Content.ReadAsStringAsync().Result; //Need to add .Result since we're in a using
                    //var resultJSON = JObject.Parse(resultContent2);
                    //var location = resultJSON.GetValue("Location");
                    var resultItems = JsonConvert.DeserializeObject<List<TodoItem>>(resultContent2);
                    System.Text.StringBuilder builder = new System.Text.StringBuilder();

                    foreach (TodoItem item in resultItems)
                    {
                        builder.AppendLine($"Name: {item.Name}");
                        builder.AppendLine($"Key: {item.Key}");
                        builder.AppendLine($"IsComplete: {item.IsComplete}");

                        Console.WriteLine(builder.ToString());
                        builder.Clear();
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("error " + ex);
                    throw;
                }

                Console.WriteLine("Token was sent: " + resultContent);
            }
        }

        public void TestGetFromWcfPublicApi()
        {
            //string localAddress = @"http://169.254.80.80:58985/api/Todo/";  //IIS Express
            string localAddress = @"http://169.254.80.80:8101/api/values/";   //IIS
            Uri uri = new Uri(localAddress);

            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string resultContent = "";
                try
                {
                    var result = client.GetAsync(uri).Result;         //Need to add .Result since we're in a using
                    var resultContent2 = result.Content.ReadAsStringAsync().Result; //Need to add .Result since we're in a using
                    //var resultJSON = JObject.Parse(resultContent2);
                    //var location = resultJSON.GetValue("Location");
                    var resultItems = JsonConvert.DeserializeObject<List<TodoItem>>(resultContent2);
                    System.Text.StringBuilder builder = new System.Text.StringBuilder();

                    foreach (TodoItem item in resultItems)
                    {
                        builder.AppendLine($"Name: {item.Name}");
                        builder.AppendLine($"Key: {item.Key}");
                        builder.AppendLine($"IsComplete: {item.IsComplete}");

                        Console.WriteLine(builder.ToString());
                        builder.Clear();
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("error " + ex);
                    throw;
                }

                Console.WriteLine("Token was sent: " + resultContent);
            }
        }
        #endregion
    }
}
