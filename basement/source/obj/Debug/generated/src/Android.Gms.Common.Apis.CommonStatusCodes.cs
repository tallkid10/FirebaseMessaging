using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Apis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/api/CommonStatusCodes", DoNotGenerateAcw=true)]
	public partial class CommonStatusCodes : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='API_NOT_CONNECTED']"
		[Register ("API_NOT_CONNECTED")]
		public const int ApiNotConnected = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='CANCELED']"
		[Register ("CANCELED")]
		public const int Canceled = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='DEAD_CLIENT']"
		[Register ("DEAD_CLIENT")]
		public const int DeadClient = (int) 18;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='DEVELOPER_ERROR']"
		[Register ("DEVELOPER_ERROR")]
		public const int DeveloperError = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const int Error = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public const int InternalError = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='INTERRUPTED']"
		[Register ("INTERRUPTED")]
		public const int Interrupted = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='INVALID_ACCOUNT']"
		[Register ("INVALID_ACCOUNT")]
		public const int InvalidAccount = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='NETWORK_ERROR']"
		[Register ("NETWORK_ERROR")]
		public const int NetworkError = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='RESOLUTION_REQUIRED']"
		[Register ("RESOLUTION_REQUIRED")]
		public const int ResolutionRequired = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='SERVICE_DISABLED']"
		[Register ("SERVICE_DISABLED")]
		[Obsolete ("deprecated")]
		public const int ServiceDisabled = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='SERVICE_VERSION_UPDATE_REQUIRED']"
		[Register ("SERVICE_VERSION_UPDATE_REQUIRED")]
		[Obsolete ("deprecated")]
		public const int ServiceVersionUpdateRequired = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='SIGN_IN_REQUIRED']"
		[Register ("SIGN_IN_REQUIRED")]
		public const int SignInRequired = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const int Success = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='SUCCESS_CACHE']"
		[Register ("SUCCESS_CACHE")]
		public const int SuccessCache = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/field[@name='TIMEOUT']"
		[Register ("TIMEOUT")]
		public const int Timeout = (int) 15;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/api/CommonStatusCodes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CommonStatusCodes); }
		}

		protected CommonStatusCodes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/constructor[@name='CommonStatusCodes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CommonStatusCodes ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CommonStatusCodes)) {
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

		static IntPtr id_getStatusCodeString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='CommonStatusCodes']/method[@name='getStatusCodeString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getStatusCodeString", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetStatusCodeString (int p0)
		{
			if (id_getStatusCodeString_I == IntPtr.Zero)
				id_getStatusCodeString_I = JNIEnv.GetStaticMethodID (class_ref, "getStatusCodeString", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStatusCodeString_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
