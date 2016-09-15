using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zze']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/zze", DoNotGenerateAcw=true)]
	public partial class Zze : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zze']/field[@name='GOOGLE_PLAY_SERVICES_PACKAGE']"
		[Register ("GOOGLE_PLAY_SERVICES_PACKAGE")]
		[Obsolete ("deprecated")]
		public const string GooglePlayServicesPackage = (string) "com.google.android.gms";

		static IntPtr GOOGLE_PLAY_SERVICES_VERSION_CODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zze']/field[@name='GOOGLE_PLAY_SERVICES_VERSION_CODE']"
		[Register ("GOOGLE_PLAY_SERVICES_VERSION_CODE")]
		public static int GooglePlayServicesVersionCode {
			get {
				if (GOOGLE_PLAY_SERVICES_VERSION_CODE_jfieldId == IntPtr.Zero)
					GOOGLE_PLAY_SERVICES_VERSION_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GOOGLE_PLAY_SERVICES_VERSION_CODE", "I");
				return JNIEnv.GetStaticIntField (class_ref, GOOGLE_PLAY_SERVICES_VERSION_CODE_jfieldId);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zze']/field[@name='GOOGLE_PLAY_STORE_PACKAGE']"
		[Register ("GOOGLE_PLAY_STORE_PACKAGE")]
		public const string GooglePlayStorePackage = (string) "com.android.vending";

		static IntPtr rp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zze']/field[@name='rp']"
		[Register ("rp")]
		public static bool Rp {
			get {
				if (rp_jfieldId == IntPtr.Zero)
					rp_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "rp", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, rp_jfieldId);
			}
			set {
				if (rp_jfieldId == IntPtr.Zero)
					rp_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "rp", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, rp_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr rq_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zze']/field[@name='rq']"
		[Register ("rq")]
		public static bool Rq {
			get {
				if (rq_jfieldId == IntPtr.Zero)
					rq_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "rq", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, rq_jfieldId);
			}
			set {
				if (rq_jfieldId == IntPtr.Zero)
					rq_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "rq", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, rq_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/zze", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Zze); }
		}

		protected Zze (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getErrorPendingIntent_ILandroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zze']/method[@name='getErrorPendingIntent' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("getErrorPendingIntent", "(ILandroid/content/Context;I)Landroid/app/PendingIntent;", "")]
		public static unsafe global::Android.App.PendingIntent GetErrorPendingIntent (int p0, global::Android.Content.Context p1, int p2)
		{
			if (id_getErrorPendingIntent_ILandroid_content_Context_I == IntPtr.Zero)
				id_getErrorPendingIntent_ILandroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "getErrorPendingIntent", "(ILandroid/content/Context;I)Landroid/app/PendingIntent;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.App.PendingIntent __ret = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getErrorPendingIntent_ILandroid_content_Context_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getErrorString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zze']/method[@name='getErrorString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("getErrorString", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetErrorString (int p0)
		{
			if (id_getErrorString_I == IntPtr.Zero)
				id_getErrorString_I = JNIEnv.GetStaticMethodID (class_ref, "getErrorString", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getErrorString_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zze']/method[@name='getOpenSourceSoftwareLicenseInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Obsolete (@"deprecated")]
		[Register ("getOpenSourceSoftwareLicenseInfo", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetOpenSourceSoftwareLicenseInfo (global::Android.Content.Context p0)
		{
			if (id_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_ == IntPtr.Zero)
				id_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getOpenSourceSoftwareLicenseInfo", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOpenSourceSoftwareLicenseInfo_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRemoteContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zze']/method[@name='getRemoteContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRemoteContext", "(Landroid/content/Context;)Landroid/content/Context;", "")]
		public static unsafe global::Android.Content.Context GetRemoteContext (global::Android.Content.Context p0)
		{
			if (id_getRemoteContext_Landroid_content_Context_ == IntPtr.Zero)
				id_getRemoteContext_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getRemoteContext", "(Landroid/content/Context;)Landroid/content/Context;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Content.Context __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRemoteContext_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRemoteResource_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zze']/method[@name='getRemoteResource' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRemoteResource", "(Landroid/content/Context;)Landroid/content/res/Resources;", "")]
		public static unsafe global::Android.Content.Res.Resources GetRemoteResource (global::Android.Content.Context p0)
		{
			if (id_getRemoteResource_Landroid_content_Context_ == IntPtr.Zero)
				id_getRemoteResource_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getRemoteResource", "(Landroid/content/Context;)Landroid/content/res/Resources;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Content.Res.Resources __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRemoteResource_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isGooglePlayServicesAvailable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zze']/method[@name='isGooglePlayServicesAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Obsolete (@"deprecated")]
		[Register ("isGooglePlayServicesAvailable", "(Landroid/content/Context;)I", "")]
		public static unsafe int IsGooglePlayServicesAvailable (global::Android.Content.Context p0)
		{
			if (id_isGooglePlayServicesAvailable_Landroid_content_Context_ == IntPtr.Zero)
				id_isGooglePlayServicesAvailable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isGooglePlayServicesAvailable", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_isGooglePlayServicesAvailable_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isUserRecoverableError_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='zze']/method[@name='isUserRecoverableError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("isUserRecoverableError", "(I)Z", "")]
		public static unsafe bool IsUserRecoverableError (int p0)
		{
			if (id_isUserRecoverableError_I == IntPtr.Zero)
				id_isUserRecoverableError_I = JNIEnv.GetStaticMethodID (class_ref, "isUserRecoverableError", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isUserRecoverableError_I, __args);
			} finally {
			}
		}

	}
}
