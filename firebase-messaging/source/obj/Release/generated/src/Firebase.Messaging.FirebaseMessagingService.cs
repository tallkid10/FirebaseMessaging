using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Firebase.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='FirebaseMessagingService']"
	[global::Android.Runtime.Register ("com/google/firebase/messaging/FirebaseMessagingService", DoNotGenerateAcw=true)]
	public partial class FirebaseMessagingService : global::Firebase.Iid.Zzb {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/firebase/messaging/FirebaseMessagingService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FirebaseMessagingService); }
		}

		protected FirebaseMessagingService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='FirebaseMessagingService']/constructor[@name='FirebaseMessagingService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FirebaseMessagingService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FirebaseMessagingService)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_onDeletedMessages;
#pragma warning disable 0169
		static Delegate GetOnDeletedMessagesHandler ()
		{
			if (cb_onDeletedMessages == null)
				cb_onDeletedMessages = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDeletedMessages);
			return cb_onDeletedMessages;
		}

		static void n_OnDeletedMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Firebase.Messaging.FirebaseMessagingService __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.FirebaseMessagingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDeletedMessages ();
		}
#pragma warning restore 0169

		static IntPtr id_onDeletedMessages;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='FirebaseMessagingService']/method[@name='onDeletedMessages' and count(parameter)=0]"
		[Register ("onDeletedMessages", "()V", "GetOnDeletedMessagesHandler")]
		public virtual unsafe void OnDeletedMessages ()
		{
			if (id_onDeletedMessages == IntPtr.Zero)
				id_onDeletedMessages = JNIEnv.GetMethodID (class_ref, "onDeletedMessages", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDeletedMessages);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDeletedMessages", "()V"));
			} finally {
			}
		}

		static Delegate cb_onMessageReceived_Lcom_google_firebase_messaging_RemoteMessage_;
#pragma warning disable 0169
		static Delegate GetOnMessageReceived_Lcom_google_firebase_messaging_RemoteMessage_Handler ()
		{
			if (cb_onMessageReceived_Lcom_google_firebase_messaging_RemoteMessage_ == null)
				cb_onMessageReceived_Lcom_google_firebase_messaging_RemoteMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessageReceived_Lcom_google_firebase_messaging_RemoteMessage_);
			return cb_onMessageReceived_Lcom_google_firebase_messaging_RemoteMessage_;
		}

		static void n_OnMessageReceived_Lcom_google_firebase_messaging_RemoteMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Firebase.Messaging.FirebaseMessagingService __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.FirebaseMessagingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Firebase.Messaging.RemoteMessage message = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageReceived (message);
		}
#pragma warning restore 0169

		static IntPtr id_onMessageReceived_Lcom_google_firebase_messaging_RemoteMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='FirebaseMessagingService']/method[@name='onMessageReceived' and count(parameter)=1 and parameter[1][@type='com.google.firebase.messaging.RemoteMessage']]"
		[Register ("onMessageReceived", "(Lcom/google/firebase/messaging/RemoteMessage;)V", "GetOnMessageReceived_Lcom_google_firebase_messaging_RemoteMessage_Handler")]
		public virtual unsafe void OnMessageReceived (global::Firebase.Messaging.RemoteMessage message)
		{
			if (id_onMessageReceived_Lcom_google_firebase_messaging_RemoteMessage_ == IntPtr.Zero)
				id_onMessageReceived_Lcom_google_firebase_messaging_RemoteMessage_ = JNIEnv.GetMethodID (class_ref, "onMessageReceived", "(Lcom/google/firebase/messaging/RemoteMessage;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (message);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onMessageReceived_Lcom_google_firebase_messaging_RemoteMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMessageReceived", "(Lcom/google/firebase/messaging/RemoteMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onMessageSent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMessageSent_Ljava_lang_String_Handler ()
		{
			if (cb_onMessageSent_Ljava_lang_String_ == null)
				cb_onMessageSent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessageSent_Ljava_lang_String_);
			return cb_onMessageSent_Ljava_lang_String_;
		}

		static void n_OnMessageSent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msgId)
		{
			global::Firebase.Messaging.FirebaseMessagingService __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.FirebaseMessagingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string msgId = JNIEnv.GetString (native_msgId, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageSent (msgId);
		}
#pragma warning restore 0169

		static IntPtr id_onMessageSent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='FirebaseMessagingService']/method[@name='onMessageSent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onMessageSent", "(Ljava/lang/String;)V", "GetOnMessageSent_Ljava_lang_String_Handler")]
		public virtual unsafe void OnMessageSent (string msgId)
		{
			if (id_onMessageSent_Ljava_lang_String_ == IntPtr.Zero)
				id_onMessageSent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMessageSent", "(Ljava/lang/String;)V");
			IntPtr native_msgId = JNIEnv.NewString (msgId);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_msgId);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onMessageSent_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMessageSent", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msgId);
			}
		}

		static Delegate cb_onSendError_Ljava_lang_String_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnSendError_Ljava_lang_String_Ljava_lang_Exception_Handler ()
		{
			if (cb_onSendError_Ljava_lang_String_Ljava_lang_Exception_ == null)
				cb_onSendError_Ljava_lang_String_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSendError_Ljava_lang_String_Ljava_lang_Exception_);
			return cb_onSendError_Ljava_lang_String_Ljava_lang_Exception_;
		}

		static void n_OnSendError_Ljava_lang_String_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msgId, IntPtr native_exception)
		{
			global::Firebase.Messaging.FirebaseMessagingService __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.FirebaseMessagingService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string msgId = JNIEnv.GetString (native_msgId, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception exception = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_exception, JniHandleOwnership.DoNotTransfer);
			__this.OnSendError (msgId, exception);
		}
#pragma warning restore 0169

		static IntPtr id_onSendError_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='FirebaseMessagingService']/method[@name='onSendError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onSendError", "(Ljava/lang/String;Ljava/lang/Exception;)V", "GetOnSendError_Ljava_lang_String_Ljava_lang_Exception_Handler")]
		public virtual unsafe void OnSendError (string msgId, global::Java.Lang.Exception exception)
		{
			if (id_onSendError_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onSendError_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onSendError", "(Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_msgId = JNIEnv.NewString (msgId);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_msgId);
				__args [1] = new JValue (exception);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSendError_Ljava_lang_String_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSendError", "(Ljava/lang/String;Ljava/lang/Exception;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msgId);
			}
		}

	}
}
