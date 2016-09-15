using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/google/firebase/messaging",
					},
					new Converter<string, Type>[]{
						lookup_com_google_firebase_messaging_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_google_firebase_messaging_mappings;
		static Type lookup_com_google_firebase_messaging_package (string klass)
		{
			if (package_com_google_firebase_messaging_mappings == null) {
				package_com_google_firebase_messaging_mappings = new string[]{
					"com/google/firebase/messaging/FirebaseMessaging:Firebase.Messaging.FirebaseMessaging",
					"com/google/firebase/messaging/FirebaseMessagingService:Firebase.Messaging.FirebaseMessagingService",
					"com/google/firebase/messaging/RemoteMessage:Firebase.Messaging.RemoteMessage",
					"com/google/firebase/messaging/RemoteMessage$Builder:Firebase.Messaging.RemoteMessage/Builder",
					"com/google/firebase/messaging/RemoteMessage$Notification:Firebase.Messaging.RemoteMessage/Notification",
					"com/google/firebase/messaging/SendException:Firebase.Messaging.SendException",
				};
			}

			return Lookup (package_com_google_firebase_messaging_mappings, klass);
		}
	}
}
