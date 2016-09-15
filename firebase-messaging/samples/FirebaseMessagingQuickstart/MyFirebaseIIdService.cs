using System;
using Android.App;
using Firebase.Iid;
using System.Net.Http;
using ModernHttpClient;
using Android.Widget;
using Android.Content;
using Android.Support.V4.Content;
using System.Collections.Generic;
using System.Linq;

namespace FirebaseMessagingQuickstart
{
    [Service]
    [IntentFilter (new [] { "com.google.firebase.INSTANCE_ID_EVENT" })]
    public class MyFirebaseIIDService : FirebaseInstanceIdService
    {
        const string TAG = "MyFirebaseIIDService";

        /**
         * Called if InstanceID token is updated. This may occur if the security of
         * the previous token had been compromised. Note that this is called when the InstanceID token
         * is initially generated so this is where you would retrieve the token.
         */
        // [START refresh_token]
        public override void OnTokenRefresh ()
        {
            // Get updated InstanceID token.
            var refreshedToken = FirebaseInstanceId.Instance.Token;
            Android.Util.Log.Debug (TAG, "Refreshed token: " + refreshedToken);     //Why is this different than the iid that is shown 

            // TODO: Implement this method to send any registration to your app's servers.
            SendRegistrationToServer (refreshedToken);

            //Have the response give what topics it needs to join
            Firebase.Messaging.FirebaseMessaging.Instance.SubscribeToTopic("news");
        }
        // [END refresh_token]

        /**
         * Persist token to third-party servers.
         *
         * Modify this method to associate the user's FCM InstanceID token with any server-side account
         * maintained by your application.
         */
        void SendRegistrationToServer (string token)
        {
            // Add custom implementation, as needed.
            //TestWebPDFArchiveGet();
            //TestPost(token);
        }

        public async void TestWebPDFArchiveGet()
        {
            try
            {
                //HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"http://arsswebv700:8105//source/DroidAlerts.aspx");
                //HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"https://api.redcard.com/source/DroidAlerts.aspx");
                string address = @"http://192.168.141.47:8101/source/DroidAlerts.aspx";
                Uri uri = new Uri(address);
                using (var httpClient = new HttpClient(new NativeMessageHandler()))
                {
                    string responseFromServer = await httpClient.GetStringAsync(uri);
                    //Toast.MakeText(ApplicationContext,responseFromServer, ToastLength.Long);
                    Console.WriteLine(responseFromServer);

                    Intent intent = new Intent("message"); //put the same message as in the filter you used in the activity when registering the receiver
                    intent.PutExtra("success", responseFromServer);
                    LocalBroadcastManager.GetInstance(this).SendBroadcast(intent);
                }
            }
            catch (Exception ex)
            {
                Android.Util.Log.Info("ERROR:", ex.ToString());
            }
        }

        public void TestPost(string token)
        {
            string address = @"https://droidtest.redcard.com/source/DroidAlerts.aspx";
            string localAddress = @"http://192.168.141.47:8101/source/DroidAlerts.aspx";    //have to use ip instead of 'localhost' because localhost will look on the phone
            Uri uri = new Uri(address);

            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                //client.BaseAddress = uri;
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("token", token)
                });
                var result = client.PostAsync(uri, content).Result;
                string resultContent = result.Content.ReadAsStringAsync().Result;

                string token2 = result.Headers.GetValues("Token").FirstOrDefault();
                var topics = result.Headers.GetValues("Topics");
                //string token3 = result.Headers.GetValues("Token2").FirstOrDefault();
                Console.WriteLine("Token was sent: " + token2);
            }
        }
    }
}
