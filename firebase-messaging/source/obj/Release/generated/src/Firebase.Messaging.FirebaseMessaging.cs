using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Firebase.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='FirebaseMessaging']"
	[global::Android.Runtime.Register ("com/google/firebase/messaging/FirebaseMessaging", DoNotGenerateAcw=true)]
	public partial class FirebaseMessaging : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='FirebaseMessaging']/field[@name='INSTANCE_ID_SCOPE']"
		[Register ("INSTANCE_ID_SCOPE")]
		public const string InstanceIdScope = (string) "FCM";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/firebase/messaging/FirebaseMessaging", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FirebaseMessaging); }
		}

		protected FirebaseMessaging (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Firebase.Messaging.FirebaseMessaging Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='FirebaseMessaging']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/google/firebase/messaging/FirebaseMessaging;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/google/firebase/messaging/FirebaseMessaging;");
				try {
					return global::Java.Lang.Object.GetObject<global::Firebase.Messaging.FirebaseMessaging> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_send_Lcom_google_firebase_messaging_RemoteMessage_;
#pragma warning disable 0169
		static Delegate GetSend_Lcom_google_firebase_messaging_RemoteMessage_Handler ()
		{
			if (cb_send_Lcom_google_firebase_messaging_RemoteMessage_ == null)
				cb_send_Lcom_google_firebase_messaging_RemoteMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Lcom_google_firebase_messaging_RemoteMessage_);
			return cb_send_Lcom_google_firebase_messaging_RemoteMessage_;
		}

		static void n_Send_Lcom_google_firebase_messaging_RemoteMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Firebase.Messaging.FirebaseMessaging __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.FirebaseMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Firebase.Messaging.RemoteMessage message = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Send (message);
		}
#pragma warning restore 0169

		static IntPtr id_send_Lcom_google_firebase_messaging_RemoteMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='FirebaseMessaging']/method[@name='send' and count(parameter)=1 and parameter[1][@type='com.google.firebase.messaging.RemoteMessage']]"
		[Register ("send", "(Lcom/google/firebase/messaging/RemoteMessage;)V", "GetSend_Lcom_google_firebase_messaging_RemoteMessage_Handler")]
		public virtual unsafe void Send (global::Firebase.Messaging.RemoteMessage message)
		{
			if (id_send_Lcom_google_firebase_messaging_RemoteMessage_ == IntPtr.Zero)
				id_send_Lcom_google_firebase_messaging_RemoteMessage_ = JNIEnv.GetMethodID (class_ref, "send", "(Lcom/google/firebase/messaging/RemoteMessage;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (message);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_send_Lcom_google_firebase_messaging_RemoteMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Lcom/google/firebase/messaging/RemoteMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_subscribeToTopic_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSubscribeToTopic_Ljava_lang_String_Handler ()
		{
			if (cb_subscribeToTopic_Ljava_lang_String_ == null)
				cb_subscribeToTopic_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SubscribeToTopic_Ljava_lang_String_);
			return cb_subscribeToTopic_Ljava_lang_String_;
		}

		static void n_SubscribeToTopic_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic)
		{
			global::Firebase.Messaging.FirebaseMessaging __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.FirebaseMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			__this.SubscribeToTopic (topic);
		}
#pragma warning restore 0169

		static IntPtr id_subscribeToTopic_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='FirebaseMessaging']/method[@name='subscribeToTopic' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("subscribeToTopic", "(Ljava/lang/String;)V", "GetSubscribeToTopic_Ljava_lang_String_Handler")]
		public virtual unsafe void SubscribeToTopic (string topic)
		{
			if (id_subscribeToTopic_Ljava_lang_String_ == IntPtr.Zero)
				id_subscribeToTopic_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "subscribeToTopic", "(Ljava/lang/String;)V");
			IntPtr native_topic = JNIEnv.NewString (topic);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_topic);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_subscribeToTopic_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribeToTopic", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_topic);
			}
		}

		static Delegate cb_unsubscribeFromTopic_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnsubscribeFromTopic_Ljava_lang_String_Handler ()
		{
			if (cb_unsubscribeFromTopic_Ljava_lang_String_ == null)
				cb_unsubscribeFromTopic_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnsubscribeFromTopic_Ljava_lang_String_);
			return cb_unsubscribeFromTopic_Ljava_lang_String_;
		}

		static void n_UnsubscribeFromTopic_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic)
		{
			global::Firebase.Messaging.FirebaseMessaging __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.FirebaseMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			__this.UnsubscribeFromTopic (topic);
		}
#pragma warning restore 0169

		static IntPtr id_unsubscribeFromTopic_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='FirebaseMessaging']/method[@name='unsubscribeFromTopic' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unsubscribeFromTopic", "(Ljava/lang/String;)V", "GetUnsubscribeFromTopic_Ljava_lang_String_Handler")]
		public virtual unsafe void UnsubscribeFromTopic (string topic)
		{
			if (id_unsubscribeFromTopic_Ljava_lang_String_ == IntPtr.Zero)
				id_unsubscribeFromTopic_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unsubscribeFromTopic", "(Ljava/lang/String;)V");
			IntPtr native_topic = JNIEnv.NewString (topic);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_topic);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_unsubscribeFromTopic_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unsubscribeFromTopic", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_topic);
			}
		}

	}
}
