using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Firebase.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage']"
	[global::Android.Runtime.Register ("com/google/firebase/messaging/RemoteMessage", DoNotGenerateAcw=true)]
	public sealed partial class RemoteMessage : global::Android.Gms.Common.Internal.SafeParcel.AbstractSafeParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Builder']"
		[global::Android.Runtime.Register ("com/google/firebase/messaging/RemoteMessage$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/firebase/messaging/RemoteMessage$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Builder']/constructor[@name='RemoteMessage.Builder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe Builder (string to)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_to = JNIEnv.NewString (to);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_to);
					if (GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_to);
				}
			}

			static Delegate cb_addData_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddData_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_addData_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_addData_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddData_Ljava_lang_String_Ljava_lang_String_);
				return cb_addData_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_AddData_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
			{
				global::Firebase.Messaging.RemoteMessage.Builder __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
				string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddData (key, value));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_addData_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Builder']/method[@name='addData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addData", "(Ljava/lang/String;Ljava/lang/String;)Lcom/google/firebase/messaging/RemoteMessage$Builder;", "GetAddData_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Firebase.Messaging.RemoteMessage.Builder AddData (string key, string value)
			{
				if (id_addData_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_addData_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addData", "(Ljava/lang/String;Ljava/lang/String;)Lcom/google/firebase/messaging/RemoteMessage$Builder;");
				IntPtr native_key = JNIEnv.NewString (key);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_key);
					__args [1] = new JValue (native_value);

					global::Firebase.Messaging.RemoteMessage.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (JNIEnv.CallObjectMethod  (Handle, id_addData_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addData", "(Ljava/lang/String;Ljava/lang/String;)Lcom/google/firebase/messaging/RemoteMessage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_key);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Firebase.Messaging.RemoteMessage.Builder __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/google/firebase/messaging/RemoteMessage;", "GetBuildHandler")]
			public virtual unsafe global::Firebase.Messaging.RemoteMessage Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/firebase/messaging/RemoteMessage;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/google/firebase/messaging/RemoteMessage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_clearData;
#pragma warning disable 0169
			static Delegate GetClearDataHandler ()
			{
				if (cb_clearData == null)
					cb_clearData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClearData);
				return cb_clearData;
			}

			static IntPtr n_ClearData (IntPtr jnienv, IntPtr native__this)
			{
				global::Firebase.Messaging.RemoteMessage.Builder __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ClearData ());
			}
#pragma warning restore 0169

			static IntPtr id_clearData;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Builder']/method[@name='clearData' and count(parameter)=0]"
			[Register ("clearData", "()Lcom/google/firebase/messaging/RemoteMessage$Builder;", "GetClearDataHandler")]
			public virtual unsafe global::Firebase.Messaging.RemoteMessage.Builder ClearData ()
			{
				if (id_clearData == IntPtr.Zero)
					id_clearData = JNIEnv.GetMethodID (class_ref, "clearData", "()Lcom/google/firebase/messaging/RemoteMessage$Builder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (JNIEnv.CallObjectMethod  (Handle, id_clearData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearData", "()Lcom/google/firebase/messaging/RemoteMessage$Builder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setCollapseKey_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCollapseKey_Ljava_lang_String_Handler ()
			{
				if (cb_setCollapseKey_Ljava_lang_String_ == null)
					cb_setCollapseKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCollapseKey_Ljava_lang_String_);
				return cb_setCollapseKey_Ljava_lang_String_;
			}

			static IntPtr n_SetCollapseKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_collapseKey)
			{
				global::Firebase.Messaging.RemoteMessage.Builder __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string collapseKey = JNIEnv.GetString (native_collapseKey, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCollapseKey (collapseKey));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setCollapseKey_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Builder']/method[@name='setCollapseKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCollapseKey", "(Ljava/lang/String;)Lcom/google/firebase/messaging/RemoteMessage$Builder;", "GetSetCollapseKey_Ljava_lang_String_Handler")]
			public virtual unsafe global::Firebase.Messaging.RemoteMessage.Builder SetCollapseKey (string collapseKey)
			{
				if (id_setCollapseKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setCollapseKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCollapseKey", "(Ljava/lang/String;)Lcom/google/firebase/messaging/RemoteMessage$Builder;");
				IntPtr native_collapseKey = JNIEnv.NewString (collapseKey);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_collapseKey);

					global::Firebase.Messaging.RemoteMessage.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setCollapseKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCollapseKey", "(Ljava/lang/String;)Lcom/google/firebase/messaging/RemoteMessage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_collapseKey);
				}
			}

			static Delegate cb_setData_Ljava_util_Map_;
#pragma warning disable 0169
			static Delegate GetSetData_Ljava_util_Map_Handler ()
			{
				if (cb_setData_Ljava_util_Map_ == null)
					cb_setData_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_util_Map_);
				return cb_setData_Ljava_util_Map_;
			}

			static IntPtr n_SetData_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
			{
				global::Firebase.Messaging.RemoteMessage.Builder __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var data = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_data, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetData (data));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setData_Ljava_util_Map_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Builder']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setData", "(Ljava/util/Map;)Lcom/google/firebase/messaging/RemoteMessage$Builder;", "GetSetData_Ljava_util_Map_Handler")]
			public virtual unsafe global::Firebase.Messaging.RemoteMessage.Builder SetData (global::System.Collections.Generic.IDictionary<string, string> data)
			{
				if (id_setData_Ljava_util_Map_ == IntPtr.Zero)
					id_setData_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/util/Map;)Lcom/google/firebase/messaging/RemoteMessage$Builder;");
				IntPtr native_data = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (data);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_data);

					global::Firebase.Messaging.RemoteMessage.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setData_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Ljava/util/Map;)Lcom/google/firebase/messaging/RemoteMessage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_data);
				}
			}

			static Delegate cb_setMessageId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetMessageId_Ljava_lang_String_Handler ()
			{
				if (cb_setMessageId_Ljava_lang_String_ == null)
					cb_setMessageId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMessageId_Ljava_lang_String_);
				return cb_setMessageId_Ljava_lang_String_;
			}

			static IntPtr n_SetMessageId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_messageId)
			{
				global::Firebase.Messaging.RemoteMessage.Builder __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string messageId = JNIEnv.GetString (native_messageId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessageId (messageId));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setMessageId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Builder']/method[@name='setMessageId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessageId", "(Ljava/lang/String;)Lcom/google/firebase/messaging/RemoteMessage$Builder;", "GetSetMessageId_Ljava_lang_String_Handler")]
			public virtual unsafe global::Firebase.Messaging.RemoteMessage.Builder SetMessageId (string messageId)
			{
				if (id_setMessageId_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessageId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessageId", "(Ljava/lang/String;)Lcom/google/firebase/messaging/RemoteMessage$Builder;");
				IntPtr native_messageId = JNIEnv.NewString (messageId);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_messageId);

					global::Firebase.Messaging.RemoteMessage.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setMessageId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageId", "(Ljava/lang/String;)Lcom/google/firebase/messaging/RemoteMessage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_messageId);
				}
			}

			static Delegate cb_setMessageType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetMessageType_Ljava_lang_String_Handler ()
			{
				if (cb_setMessageType_Ljava_lang_String_ == null)
					cb_setMessageType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMessageType_Ljava_lang_String_);
				return cb_setMessageType_Ljava_lang_String_;
			}

			static IntPtr n_SetMessageType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_messageType)
			{
				global::Firebase.Messaging.RemoteMessage.Builder __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string messageType = JNIEnv.GetString (native_messageType, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessageType (messageType));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setMessageType_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Builder']/method[@name='setMessageType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessageType", "(Ljava/lang/String;)Lcom/google/firebase/messaging/RemoteMessage$Builder;", "GetSetMessageType_Ljava_lang_String_Handler")]
			public virtual unsafe global::Firebase.Messaging.RemoteMessage.Builder SetMessageType (string messageType)
			{
				if (id_setMessageType_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessageType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessageType", "(Ljava/lang/String;)Lcom/google/firebase/messaging/RemoteMessage$Builder;");
				IntPtr native_messageType = JNIEnv.NewString (messageType);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_messageType);

					global::Firebase.Messaging.RemoteMessage.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setMessageType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageType", "(Ljava/lang/String;)Lcom/google/firebase/messaging/RemoteMessage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_messageType);
				}
			}

			static Delegate cb_setTtl_I;
#pragma warning disable 0169
			static Delegate GetSetTtl_IHandler ()
			{
				if (cb_setTtl_I == null)
					cb_setTtl_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetTtl_I);
				return cb_setTtl_I;
			}

			static IntPtr n_SetTtl_I (IntPtr jnienv, IntPtr native__this, int ttl)
			{
				global::Firebase.Messaging.RemoteMessage.Builder __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetTtl (ttl));
			}
#pragma warning restore 0169

			static IntPtr id_setTtl_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Builder']/method[@name='setTtl' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTtl", "(I)Lcom/google/firebase/messaging/RemoteMessage$Builder;", "GetSetTtl_IHandler")]
			public virtual unsafe global::Firebase.Messaging.RemoteMessage.Builder SetTtl (int ttl)
			{
				if (id_setTtl_I == IntPtr.Zero)
					id_setTtl_I = JNIEnv.GetMethodID (class_ref, "setTtl", "(I)Lcom/google/firebase/messaging/RemoteMessage$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (ttl);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setTtl_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTtl", "(I)Lcom/google/firebase/messaging/RemoteMessage$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Notification']"
		[global::Android.Runtime.Register ("com/google/firebase/messaging/RemoteMessage$Notification", DoNotGenerateAcw=true)]
		public partial class Notification : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/firebase/messaging/RemoteMessage$Notification", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Notification); }
			}

			protected Notification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getBody;
#pragma warning disable 0169
			static Delegate GetGetBodyHandler ()
			{
				if (cb_getBody == null)
					cb_getBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
				return cb_getBody;
			}

			static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
			{
				global::Firebase.Messaging.RemoteMessage.Notification __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Notification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Body);
			}
#pragma warning restore 0169

			static IntPtr id_getBody;
			public virtual unsafe string Body {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Notification']/method[@name='getBody' and count(parameter)=0]"
				[Register ("getBody", "()Ljava/lang/String;", "GetGetBodyHandler")]
				get {
					if (id_getBody == IntPtr.Zero)
						id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getBodyLocalizationKey;
#pragma warning disable 0169
			static Delegate GetGetBodyLocalizationKeyHandler ()
			{
				if (cb_getBodyLocalizationKey == null)
					cb_getBodyLocalizationKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBodyLocalizationKey);
				return cb_getBodyLocalizationKey;
			}

			static IntPtr n_GetBodyLocalizationKey (IntPtr jnienv, IntPtr native__this)
			{
				global::Firebase.Messaging.RemoteMessage.Notification __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Notification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.BodyLocalizationKey);
			}
#pragma warning restore 0169

			static IntPtr id_getBodyLocalizationKey;
			public virtual unsafe string BodyLocalizationKey {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Notification']/method[@name='getBodyLocalizationKey' and count(parameter)=0]"
				[Register ("getBodyLocalizationKey", "()Ljava/lang/String;", "GetGetBodyLocalizationKeyHandler")]
				get {
					if (id_getBodyLocalizationKey == IntPtr.Zero)
						id_getBodyLocalizationKey = JNIEnv.GetMethodID (class_ref, "getBodyLocalizationKey", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBodyLocalizationKey), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBodyLocalizationKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getClickAction;
#pragma warning disable 0169
			static Delegate GetGetClickActionHandler ()
			{
				if (cb_getClickAction == null)
					cb_getClickAction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClickAction);
				return cb_getClickAction;
			}

			static IntPtr n_GetClickAction (IntPtr jnienv, IntPtr native__this)
			{
				global::Firebase.Messaging.RemoteMessage.Notification __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Notification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ClickAction);
			}
#pragma warning restore 0169

			static IntPtr id_getClickAction;
			public virtual unsafe string ClickAction {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Notification']/method[@name='getClickAction' and count(parameter)=0]"
				[Register ("getClickAction", "()Ljava/lang/String;", "GetGetClickActionHandler")]
				get {
					if (id_getClickAction == IntPtr.Zero)
						id_getClickAction = JNIEnv.GetMethodID (class_ref, "getClickAction", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getClickAction), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClickAction", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getColor;
#pragma warning disable 0169
			static Delegate GetGetColorHandler ()
			{
				if (cb_getColor == null)
					cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColor);
				return cb_getColor;
			}

			static IntPtr n_GetColor (IntPtr jnienv, IntPtr native__this)
			{
				global::Firebase.Messaging.RemoteMessage.Notification __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Notification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Color);
			}
#pragma warning restore 0169

			static IntPtr id_getColor;
			public virtual unsafe string Color {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Notification']/method[@name='getColor' and count(parameter)=0]"
				[Register ("getColor", "()Ljava/lang/String;", "GetGetColorHandler")]
				get {
					if (id_getColor == IntPtr.Zero)
						id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getColor), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getIcon;
#pragma warning disable 0169
			static Delegate GetGetIconHandler ()
			{
				if (cb_getIcon == null)
					cb_getIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIcon);
				return cb_getIcon;
			}

			static IntPtr n_GetIcon (IntPtr jnienv, IntPtr native__this)
			{
				global::Firebase.Messaging.RemoteMessage.Notification __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Notification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Icon);
			}
#pragma warning restore 0169

			static IntPtr id_getIcon;
			public virtual unsafe string Icon {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Notification']/method[@name='getIcon' and count(parameter)=0]"
				[Register ("getIcon", "()Ljava/lang/String;", "GetGetIconHandler")]
				get {
					if (id_getIcon == IntPtr.Zero)
						id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getIcon), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIcon", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getSound;
#pragma warning disable 0169
			static Delegate GetGetSoundHandler ()
			{
				if (cb_getSound == null)
					cb_getSound = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSound);
				return cb_getSound;
			}

			static IntPtr n_GetSound (IntPtr jnienv, IntPtr native__this)
			{
				global::Firebase.Messaging.RemoteMessage.Notification __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Notification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Sound);
			}
#pragma warning restore 0169

			static IntPtr id_getSound;
			public virtual unsafe string Sound {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Notification']/method[@name='getSound' and count(parameter)=0]"
				[Register ("getSound", "()Ljava/lang/String;", "GetGetSoundHandler")]
				get {
					if (id_getSound == IntPtr.Zero)
						id_getSound = JNIEnv.GetMethodID (class_ref, "getSound", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSound), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSound", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getTag;
#pragma warning disable 0169
			static Delegate GetGetTagHandler ()
			{
				if (cb_getTag == null)
					cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTag);
				return cb_getTag;
			}

			static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
			{
				global::Firebase.Messaging.RemoteMessage.Notification __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Notification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Tag);
			}
#pragma warning restore 0169

			static IntPtr id_getTag;
			public virtual unsafe string Tag {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Notification']/method[@name='getTag' and count(parameter)=0]"
				[Register ("getTag", "()Ljava/lang/String;", "GetGetTagHandler")]
				get {
					if (id_getTag == IntPtr.Zero)
						id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTag), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTag", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getTitle;
#pragma warning disable 0169
			static Delegate GetGetTitleHandler ()
			{
				if (cb_getTitle == null)
					cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
				return cb_getTitle;
			}

			static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
			{
				global::Firebase.Messaging.RemoteMessage.Notification __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Notification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Title);
			}
#pragma warning restore 0169

			static IntPtr id_getTitle;
			public virtual unsafe string Title {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Notification']/method[@name='getTitle' and count(parameter)=0]"
				[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
				get {
					if (id_getTitle == IntPtr.Zero)
						id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getTitleLocalizationKey;
#pragma warning disable 0169
			static Delegate GetGetTitleLocalizationKeyHandler ()
			{
				if (cb_getTitleLocalizationKey == null)
					cb_getTitleLocalizationKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitleLocalizationKey);
				return cb_getTitleLocalizationKey;
			}

			static IntPtr n_GetTitleLocalizationKey (IntPtr jnienv, IntPtr native__this)
			{
				global::Firebase.Messaging.RemoteMessage.Notification __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Notification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.TitleLocalizationKey);
			}
#pragma warning restore 0169

			static IntPtr id_getTitleLocalizationKey;
			public virtual unsafe string TitleLocalizationKey {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Notification']/method[@name='getTitleLocalizationKey' and count(parameter)=0]"
				[Register ("getTitleLocalizationKey", "()Ljava/lang/String;", "GetGetTitleLocalizationKeyHandler")]
				get {
					if (id_getTitleLocalizationKey == IntPtr.Zero)
						id_getTitleLocalizationKey = JNIEnv.GetMethodID (class_ref, "getTitleLocalizationKey", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitleLocalizationKey), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitleLocalizationKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getBodyLocalizationArgs;
#pragma warning disable 0169
			static Delegate GetGetBodyLocalizationArgsHandler ()
			{
				if (cb_getBodyLocalizationArgs == null)
					cb_getBodyLocalizationArgs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBodyLocalizationArgs);
				return cb_getBodyLocalizationArgs;
			}

			static IntPtr n_GetBodyLocalizationArgs (IntPtr jnienv, IntPtr native__this)
			{
				global::Firebase.Messaging.RemoteMessage.Notification __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Notification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetBodyLocalizationArgs ());
			}
#pragma warning restore 0169

			static IntPtr id_getBodyLocalizationArgs;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Notification']/method[@name='getBodyLocalizationArgs' and count(parameter)=0]"
			[Register ("getBodyLocalizationArgs", "()[Ljava/lang/String;", "GetGetBodyLocalizationArgsHandler")]
			public virtual unsafe string[] GetBodyLocalizationArgs ()
			{
				if (id_getBodyLocalizationArgs == IntPtr.Zero)
					id_getBodyLocalizationArgs = JNIEnv.GetMethodID (class_ref, "getBodyLocalizationArgs", "()[Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBodyLocalizationArgs), JniHandleOwnership.TransferLocalRef, typeof (string));
					else
						return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBodyLocalizationArgs", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
				} finally {
				}
			}

			static Delegate cb_getTitleLocalizationArgs;
#pragma warning disable 0169
			static Delegate GetGetTitleLocalizationArgsHandler ()
			{
				if (cb_getTitleLocalizationArgs == null)
					cb_getTitleLocalizationArgs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitleLocalizationArgs);
				return cb_getTitleLocalizationArgs;
			}

			static IntPtr n_GetTitleLocalizationArgs (IntPtr jnienv, IntPtr native__this)
			{
				global::Firebase.Messaging.RemoteMessage.Notification __this = global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Notification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetTitleLocalizationArgs ());
			}
#pragma warning restore 0169

			static IntPtr id_getTitleLocalizationArgs;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage.Notification']/method[@name='getTitleLocalizationArgs' and count(parameter)=0]"
			[Register ("getTitleLocalizationArgs", "()[Ljava/lang/String;", "GetGetTitleLocalizationArgsHandler")]
			public virtual unsafe string[] GetTitleLocalizationArgs ()
			{
				if (id_getTitleLocalizationArgs == IntPtr.Zero)
					id_getTitleLocalizationArgs = JNIEnv.GetMethodID (class_ref, "getTitleLocalizationArgs", "()[Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getTitleLocalizationArgs), JniHandleOwnership.TransferLocalRef, typeof (string));
					else
						return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitleLocalizationArgs", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/firebase/messaging/RemoteMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RemoteMessage); }
		}

		internal RemoteMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCollapseKey;
		public unsafe string CollapseKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage']/method[@name='getCollapseKey' and count(parameter)=0]"
			[Register ("getCollapseKey", "()Ljava/lang/String;", "GetGetCollapseKeyHandler")]
			get {
				if (id_getCollapseKey == IntPtr.Zero)
					id_getCollapseKey = JNIEnv.GetMethodID (class_ref, "getCollapseKey", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCollapseKey), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getData;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/util/Map;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/util/Map;");
				try {
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getFrom;
		public unsafe string From {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage']/method[@name='getFrom' and count(parameter)=0]"
			[Register ("getFrom", "()Ljava/lang/String;", "GetGetFromHandler")]
			get {
				if (id_getFrom == IntPtr.Zero)
					id_getFrom = JNIEnv.GetMethodID (class_ref, "getFrom", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFrom), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMessageId;
		public unsafe string MessageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage']/method[@name='getMessageId' and count(parameter)=0]"
			[Register ("getMessageId", "()Ljava/lang/String;", "GetGetMessageIdHandler")]
			get {
				if (id_getMessageId == IntPtr.Zero)
					id_getMessageId = JNIEnv.GetMethodID (class_ref, "getMessageId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMessageType;
		public unsafe string MessageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage']/method[@name='getMessageType' and count(parameter)=0]"
			[Register ("getMessageType", "()Ljava/lang/String;", "GetGetMessageTypeHandler")]
			get {
				if (id_getMessageType == IntPtr.Zero)
					id_getMessageType = JNIEnv.GetMethodID (class_ref, "getMessageType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessageType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSentTime;
		public unsafe long SentTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage']/method[@name='getSentTime' and count(parameter)=0]"
			[Register ("getSentTime", "()J", "GetGetSentTimeHandler")]
			get {
				if (id_getSentTime == IntPtr.Zero)
					id_getSentTime = JNIEnv.GetMethodID (class_ref, "getSentTime", "()J");
				try {
					return JNIEnv.CallLongMethod  (Handle, id_getSentTime);
				} finally {
				}
			}
		}

		static IntPtr id_getTo;
		public unsafe string To {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage']/method[@name='getTo' and count(parameter)=0]"
			[Register ("getTo", "()Ljava/lang/String;", "GetGetToHandler")]
			get {
				if (id_getTo == IntPtr.Zero)
					id_getTo = JNIEnv.GetMethodID (class_ref, "getTo", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTo), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTtl;
		public unsafe int Ttl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage']/method[@name='getTtl' and count(parameter)=0]"
			[Register ("getTtl", "()I", "GetGetTtlHandler")]
			get {
				if (id_getTtl == IntPtr.Zero)
					id_getTtl = JNIEnv.GetMethodID (class_ref, "getTtl", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getTtl);
				} finally {
				}
			}
		}

		static IntPtr id_getNotification;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage']/method[@name='getNotification' and count(parameter)=0]"
		[Register ("getNotification", "()Lcom/google/firebase/messaging/RemoteMessage$Notification;", "")]
		public unsafe global::Firebase.Messaging.RemoteMessage.Notification GetNotification ()
		{
			if (id_getNotification == IntPtr.Zero)
				id_getNotification = JNIEnv.GetMethodID (class_ref, "getNotification", "()Lcom/google/firebase/messaging/RemoteMessage$Notification;");
			try {
				return global::Java.Lang.Object.GetObject<global::Firebase.Messaging.RemoteMessage.Notification> (JNIEnv.CallObjectMethod  (Handle, id_getNotification), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='RemoteMessage']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public override unsafe void WriteToParcel (global::Android.OS.Parcel @out, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@out);
				__args [1] = new JValue ((int) flags);
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
