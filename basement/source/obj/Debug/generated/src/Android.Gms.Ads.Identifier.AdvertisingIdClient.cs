using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Ads.Identifier {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.ads.identifier']/class[@name='AdvertisingIdClient']"
	[global::Android.Runtime.Register ("com/google/android/gms/ads/identifier/AdvertisingIdClient", DoNotGenerateAcw=true)]
	public partial class AdvertisingIdClient : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.ads.identifier']/class[@name='AdvertisingIdClient.Info']"
		[global::Android.Runtime.Register ("com/google/android/gms/ads/identifier/AdvertisingIdClient$Info", DoNotGenerateAcw=true)]
		public sealed partial class Info : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/gms/ads/identifier/AdvertisingIdClient$Info", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Info); }
			}

			internal Info (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Z;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.ads.identifier']/class[@name='AdvertisingIdClient.Info']/constructor[@name='AdvertisingIdClient.Info' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
			[Register (".ctor", "(Ljava/lang/String;Z)V", "")]
			public unsafe Info (string p0, bool p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (Info)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Z)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Z)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Z == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Z)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Z, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Z, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_getId;
			public unsafe string Id {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.ads.identifier']/class[@name='AdvertisingIdClient.Info']/method[@name='getId' and count(parameter)=0]"
				[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
				get {
					if (id_getId == IntPtr.Zero)
						id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_isLimitAdTrackingEnabled;
			public unsafe bool IsLimitAdTrackingEnabled {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.ads.identifier']/class[@name='AdvertisingIdClient.Info']/method[@name='isLimitAdTrackingEnabled' and count(parameter)=0]"
				[Register ("isLimitAdTrackingEnabled", "()Z", "GetIsLimitAdTrackingEnabledHandler")]
				get {
					if (id_isLimitAdTrackingEnabled == IntPtr.Zero)
						id_isLimitAdTrackingEnabled = JNIEnv.GetMethodID (class_ref, "isLimitAdTrackingEnabled", "()Z");
					try {
						return JNIEnv.CallBooleanMethod  (Handle, id_isLimitAdTrackingEnabled);
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/ads/identifier/AdvertisingIdClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdvertisingIdClient); }
		}

		protected AdvertisingIdClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.ads.identifier']/class[@name='AdvertisingIdClient']/constructor[@name='AdvertisingIdClient' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AdvertisingIdClient (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AdvertisingIdClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.ads.identifier']/class[@name='AdvertisingIdClient']/constructor[@name='AdvertisingIdClient' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Landroid/content/Context;J)V", "")]
		public unsafe AdvertisingIdClient (global::Android.Content.Context p0, long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (AdvertisingIdClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;J)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_J == IntPtr.Zero)
					id_ctor_Landroid_content_Context_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_J, __args);
			} finally {
			}
		}

		static Delegate cb_finish;
#pragma warning disable 0169
		static Delegate GetFinishHandler ()
		{
			if (cb_finish == null)
				cb_finish = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Finish);
			return cb_finish;
		}

		static void n_Finish (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Ads.Identifier.AdvertisingIdClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Ads.Identifier.AdvertisingIdClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finish ();
		}
#pragma warning restore 0169

		static IntPtr id_finish;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.ads.identifier']/class[@name='AdvertisingIdClient']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "GetFinishHandler")]
		public virtual unsafe void Finish ()
		{
			if (id_finish == IntPtr.Zero)
				id_finish = JNIEnv.GetMethodID (class_ref, "finish", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_finish);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finish", "()V"));
			} finally {
			}
		}

		static IntPtr id_getAdvertisingIdInfo_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.ads.identifier']/class[@name='AdvertisingIdClient']/method[@name='getAdvertisingIdInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAdvertisingIdInfo", "(Landroid/content/Context;)Lcom/google/android/gms/ads/identifier/AdvertisingIdClient$Info;", "")]
		public static unsafe global::Android.Gms.Ads.Identifier.AdvertisingIdClient.Info GetAdvertisingIdInfo (global::Android.Content.Context p0)
		{
			if (id_getAdvertisingIdInfo_Landroid_content_Context_ == IntPtr.Zero)
				id_getAdvertisingIdInfo_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAdvertisingIdInfo", "(Landroid/content/Context;)Lcom/google/android/gms/ads/identifier/AdvertisingIdClient$Info;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Gms.Ads.Identifier.AdvertisingIdClient.Info __ret = global::Java.Lang.Object.GetObject<global::Android.Gms.Ads.Identifier.AdvertisingIdClient.Info> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAdvertisingIdInfo_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getInfo;
#pragma warning disable 0169
		static Delegate GetGetInfoHandler ()
		{
			if (cb_getInfo == null)
				cb_getInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInfo);
			return cb_getInfo;
		}

		static IntPtr n_GetInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Ads.Identifier.AdvertisingIdClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Ads.Identifier.AdvertisingIdClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetInfo ());
		}
#pragma warning restore 0169

		static IntPtr id_getInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.ads.identifier']/class[@name='AdvertisingIdClient']/method[@name='getInfo' and count(parameter)=0]"
		[Register ("getInfo", "()Lcom/google/android/gms/ads/identifier/AdvertisingIdClient$Info;", "GetGetInfoHandler")]
		public virtual unsafe global::Android.Gms.Ads.Identifier.AdvertisingIdClient.Info GetInfo ()
		{
			if (id_getInfo == IntPtr.Zero)
				id_getInfo = JNIEnv.GetMethodID (class_ref, "getInfo", "()Lcom/google/android/gms/ads/identifier/AdvertisingIdClient$Info;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Gms.Ads.Identifier.AdvertisingIdClient.Info> (JNIEnv.CallObjectMethod  (Handle, id_getInfo), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Gms.Ads.Identifier.AdvertisingIdClient.Info> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInfo", "()Lcom/google/android/gms/ads/identifier/AdvertisingIdClient$Info;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setShouldSkipGmsCoreVersionCheck_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.ads.identifier']/class[@name='AdvertisingIdClient']/method[@name='setShouldSkipGmsCoreVersionCheck' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShouldSkipGmsCoreVersionCheck", "(Z)V", "")]
		public static unsafe void SetShouldSkipGmsCoreVersionCheck (bool p0)
		{
			if (id_setShouldSkipGmsCoreVersionCheck_Z == IntPtr.Zero)
				id_setShouldSkipGmsCoreVersionCheck_Z = JNIEnv.GetStaticMethodID (class_ref, "setShouldSkipGmsCoreVersionCheck", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setShouldSkipGmsCoreVersionCheck_Z, __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Ads.Identifier.AdvertisingIdClient __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Ads.Identifier.AdvertisingIdClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.ads.identifier']/class[@name='AdvertisingIdClient']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

	}
}
