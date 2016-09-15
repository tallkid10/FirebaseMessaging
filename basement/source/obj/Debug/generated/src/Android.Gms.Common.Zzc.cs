using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zzc']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/zzc", DoNotGenerateAcw=true)]
	public partial class Zzc : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zzc']/field[@name='GOOGLE_PLAY_SERVICES_PACKAGE']"
		[Register ("GOOGLE_PLAY_SERVICES_PACKAGE")]
		public const string GooglePlayServicesPackage = (string) "com.google.android.gms";

		static IntPtr GOOGLE_PLAY_SERVICES_VERSION_CODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zzc']/field[@name='GOOGLE_PLAY_SERVICES_VERSION_CODE']"
		[Register ("GOOGLE_PLAY_SERVICES_VERSION_CODE")]
		public static int GooglePlayServicesVersionCode {
			get {
				if (GOOGLE_PLAY_SERVICES_VERSION_CODE_jfieldId == IntPtr.Zero)
					GOOGLE_PLAY_SERVICES_VERSION_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GOOGLE_PLAY_SERVICES_VERSION_CODE", "I");
				return JNIEnv.GetStaticIntField (class_ref, GOOGLE_PLAY_SERVICES_VERSION_CODE_jfieldId);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/zzc", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Zzc); }
		}

		protected Zzc (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getErrorResolutionPendingIntent_Landroid_content_Context_II;
#pragma warning disable 0169
		static Delegate GetGetErrorResolutionPendingIntent_Landroid_content_Context_IIHandler ()
		{
			if (cb_getErrorResolutionPendingIntent_Landroid_content_Context_II == null)
				cb_getErrorResolutionPendingIntent_Landroid_content_Context_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetErrorResolutionPendingIntent_Landroid_content_Context_II);
			return cb_getErrorResolutionPendingIntent_Landroid_content_Context_II;
		}

		static IntPtr n_GetErrorResolutionPendingIntent_Landroid_content_Context_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Android.Gms.Common.Zzc __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Zzc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetErrorResolutionPendingIntent (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getErrorResolutionPendingIntent_Landroid_content_Context_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zzc']/method[@name='getErrorResolutionPendingIntent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getErrorResolutionPendingIntent", "(Landroid/content/Context;II)Landroid/app/PendingIntent;", "GetGetErrorResolutionPendingIntent_Landroid_content_Context_IIHandler")]
		public virtual unsafe global::Android.App.PendingIntent GetErrorResolutionPendingIntent (global::Android.Content.Context p0, int p1, int p2)
		{
			if (id_getErrorResolutionPendingIntent_Landroid_content_Context_II == IntPtr.Zero)
				id_getErrorResolutionPendingIntent_Landroid_content_Context_II = JNIEnv.GetMethodID (class_ref, "getErrorResolutionPendingIntent", "(Landroid/content/Context;II)Landroid/app/PendingIntent;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Android.App.PendingIntent __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (JNIEnv.CallObjectMethod  (Handle, id_getErrorResolutionPendingIntent_Landroid_content_Context_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorResolutionPendingIntent", "(Landroid/content/Context;II)Landroid/app/PendingIntent;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getErrorString_I;
#pragma warning disable 0169
		static Delegate GetGetErrorString_IHandler ()
		{
			if (cb_getErrorString_I == null)
				cb_getErrorString_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetErrorString_I);
			return cb_getErrorString_I;
		}

		static IntPtr n_GetErrorString_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Gms.Common.Zzc __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Zzc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetErrorString (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getErrorString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zzc']/method[@name='getErrorString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getErrorString", "(I)Ljava/lang/String;", "GetGetErrorString_IHandler")]
		public virtual unsafe string GetErrorString (int p0)
		{
			if (id_getErrorString_I == IntPtr.Zero)
				id_getErrorString_I = JNIEnv.GetMethodID (class_ref, "getErrorString", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getErrorString_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorString", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetOpenSourceSoftwareLicenseInfo_Landroid_content_Context_Handler ()
		{
			if (cb_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_ == null)
				cb_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetOpenSourceSoftwareLicenseInfo_Landroid_content_Context_);
			return cb_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_;
		}

		static IntPtr n_GetOpenSourceSoftwareLicenseInfo_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Common.Zzc __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Zzc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetOpenSourceSoftwareLicenseInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zzc']/method[@name='getOpenSourceSoftwareLicenseInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getOpenSourceSoftwareLicenseInfo", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetOpenSourceSoftwareLicenseInfo_Landroid_content_Context_Handler")]
		public virtual unsafe string GetOpenSourceSoftwareLicenseInfo (global::Android.Content.Context p0)
		{
			if (id_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_ == IntPtr.Zero)
				id_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getOpenSourceSoftwareLicenseInfo", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpenSourceSoftwareLicenseInfo", "(Landroid/content/Context;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isGooglePlayServicesAvailable_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsGooglePlayServicesAvailable_Landroid_content_Context_Handler ()
		{
			if (cb_isGooglePlayServicesAvailable_Landroid_content_Context_ == null)
				cb_isGooglePlayServicesAvailable_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_IsGooglePlayServicesAvailable_Landroid_content_Context_);
			return cb_isGooglePlayServicesAvailable_Landroid_content_Context_;
		}

		static int n_IsGooglePlayServicesAvailable_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Common.Zzc __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Zzc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IsGooglePlayServicesAvailable (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isGooglePlayServicesAvailable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zzc']/method[@name='isGooglePlayServicesAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isGooglePlayServicesAvailable", "(Landroid/content/Context;)I", "GetIsGooglePlayServicesAvailable_Landroid_content_Context_Handler")]
		public virtual unsafe int IsGooglePlayServicesAvailable (global::Android.Content.Context p0)
		{
			if (id_isGooglePlayServicesAvailable_Landroid_content_Context_ == IntPtr.Zero)
				id_isGooglePlayServicesAvailable_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "isGooglePlayServicesAvailable", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_isGooglePlayServicesAvailable_Landroid_content_Context_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isGooglePlayServicesAvailable", "(Landroid/content/Context;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isUserResolvableError_I;
#pragma warning disable 0169
		static Delegate GetIsUserResolvableError_IHandler ()
		{
			if (cb_isUserResolvableError_I == null)
				cb_isUserResolvableError_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsUserResolvableError_I);
			return cb_isUserResolvableError_I;
		}

		static bool n_IsUserResolvableError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Gms.Common.Zzc __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Zzc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUserResolvableError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isUserResolvableError_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zzc']/method[@name='isUserResolvableError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isUserResolvableError", "(I)Z", "GetIsUserResolvableError_IHandler")]
		public virtual unsafe bool IsUserResolvableError (int p0)
		{
			if (id_isUserResolvableError_I == IntPtr.Zero)
				id_isUserResolvableError_I = JNIEnv.GetMethodID (class_ref, "isUserResolvableError", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isUserResolvableError_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUserResolvableError", "(I)Z"), __args);
			} finally {
			}
		}

	}
}
