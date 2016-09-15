using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/ConnectionResult", DoNotGenerateAcw=true)]
	public sealed partial class ConnectionResult : global::Android.Gms.Common.Internal.SafeParcel.AbstractSafeParcelable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='API_UNAVAILABLE']"
		[Register ("API_UNAVAILABLE")]
		public const int ApiUnavailable = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='CANCELED']"
		[Register ("CANCELED")]
		public const int Canceled = (int) 13;

		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='DEVELOPER_ERROR']"
		[Register ("DEVELOPER_ERROR")]
		public const int DeveloperError = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='DRIVE_EXTERNAL_STORAGE_REQUIRED']"
		[Register ("DRIVE_EXTERNAL_STORAGE_REQUIRED")]
		[Obsolete ("deprecated")]
		public const int DriveExternalStorageRequired = (int) 1500;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public const int InternalError = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='INTERRUPTED']"
		[Register ("INTERRUPTED")]
		public const int Interrupted = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='INVALID_ACCOUNT']"
		[Register ("INVALID_ACCOUNT")]
		public const int InvalidAccount = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='LICENSE_CHECK_FAILED']"
		[Register ("LICENSE_CHECK_FAILED")]
		public const int LicenseCheckFailed = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='NETWORK_ERROR']"
		[Register ("NETWORK_ERROR")]
		public const int NetworkError = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='RESOLUTION_REQUIRED']"
		[Register ("RESOLUTION_REQUIRED")]
		public const int ResolutionRequired = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='RESTRICTED_PROFILE']"
		[Register ("RESTRICTED_PROFILE")]
		public const int RestrictedProfile = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='SERVICE_DISABLED']"
		[Register ("SERVICE_DISABLED")]
		public const int ServiceDisabled = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='SERVICE_INVALID']"
		[Register ("SERVICE_INVALID")]
		public const int ServiceInvalid = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='SERVICE_MISSING']"
		[Register ("SERVICE_MISSING")]
		public const int ServiceMissing = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='SERVICE_MISSING_PERMISSION']"
		[Register ("SERVICE_MISSING_PERMISSION")]
		public const int ServiceMissingPermission = (int) 19;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='SERVICE_UPDATING']"
		[Register ("SERVICE_UPDATING")]
		public const int ServiceUpdating = (int) 18;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='SERVICE_VERSION_UPDATE_REQUIRED']"
		[Register ("SERVICE_VERSION_UPDATE_REQUIRED")]
		public const int ServiceVersionUpdateRequired = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='SIGN_IN_FAILED']"
		[Register ("SIGN_IN_FAILED")]
		public const int SignInFailed = (int) 17;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='SIGN_IN_REQUIRED']"
		[Register ("SIGN_IN_REQUIRED")]
		public const int SignInRequired = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const int Success = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='TIMEOUT']"
		[Register ("TIMEOUT")]
		public const int Timeout = (int) 14;

		static IntPtr rb_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/field[@name='rb']"
		[Register ("rb")]
		public static global::Android.Gms.Common.ConnectionResult Rb {
			get {
				if (rb_jfieldId == IntPtr.Zero)
					rb_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "rb", "Lcom/google/android/gms/common/ConnectionResult;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, rb_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Common.ConnectionResult> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/ConnectionResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionResult); }
		}

		internal ConnectionResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/constructor[@name='ConnectionResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe ConnectionResult (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ConnectionResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_ILandroid_app_PendingIntent_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/constructor[@name='ConnectionResult' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.app.PendingIntent']]"
		[Register (".ctor", "(ILandroid/app/PendingIntent;)V", "")]
		public unsafe ConnectionResult (int p0, global::Android.App.PendingIntent p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ConnectionResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILandroid/app/PendingIntent;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILandroid/app/PendingIntent;)V", __args);
					return;
				}

				if (id_ctor_ILandroid_app_PendingIntent_ == IntPtr.Zero)
					id_ctor_ILandroid_app_PendingIntent_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILandroid/app/PendingIntent;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILandroid_app_PendingIntent_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILandroid_app_PendingIntent_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_ILandroid_app_PendingIntent_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/constructor[@name='ConnectionResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.app.PendingIntent'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(ILandroid/app/PendingIntent;Ljava/lang/String;)V", "")]
		public unsafe ConnectionResult (int p0, global::Android.App.PendingIntent p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (ConnectionResult)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILandroid/app/PendingIntent;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILandroid/app/PendingIntent;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_ILandroid_app_PendingIntent_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_ILandroid_app_PendingIntent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILandroid/app/PendingIntent;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILandroid_app_PendingIntent_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILandroid_app_PendingIntent_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getErrorCode;
		public unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getErrorCode);
				} finally {
				}
			}
		}

		static IntPtr id_getErrorMessage;
		public unsafe string ErrorMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/method[@name='getErrorMessage' and count(parameter)=0]"
			[Register ("getErrorMessage", "()Ljava/lang/String;", "GetGetErrorMessageHandler")]
			get {
				if (id_getErrorMessage == IntPtr.Zero)
					id_getErrorMessage = JNIEnv.GetMethodID (class_ref, "getErrorMessage", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getErrorMessage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_hasResolution;
		public unsafe bool HasResolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/method[@name='hasResolution' and count(parameter)=0]"
			[Register ("hasResolution", "()Z", "GetHasResolutionHandler")]
			get {
				if (id_hasResolution == IntPtr.Zero)
					id_hasResolution = JNIEnv.GetMethodID (class_ref, "hasResolution", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_hasResolution);
				} finally {
				}
			}
		}

		static IntPtr id_isSuccess;
		public unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "GetIsSuccessHandler")]
			get {
				if (id_isSuccess == IntPtr.Zero)
					id_isSuccess = JNIEnv.GetMethodID (class_ref, "isSuccess", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isSuccess);
				} finally {
				}
			}
		}

		static IntPtr id_getResolution;
		public unsafe global::Android.App.PendingIntent Resolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/method[@name='getResolution' and count(parameter)=0]"
			[Register ("getResolution", "()Landroid/app/PendingIntent;", "GetGetResolutionHandler")]
			get {
				if (id_getResolution == IntPtr.Zero)
					id_getResolution = JNIEnv.GetMethodID (class_ref, "getResolution", "()Landroid/app/PendingIntent;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (JNIEnv.CallObjectMethod  (Handle, id_getResolution), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_startResolutionForResult_Landroid_app_Activity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/method[@name='startResolutionForResult' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("startResolutionForResult", "(Landroid/app/Activity;I)V", "")]
		public unsafe void StartResolutionForResult (global::Android.App.Activity p0, int p1)
		{
			if (id_startResolutionForResult_Landroid_app_Activity_I == IntPtr.Zero)
				id_startResolutionForResult_Landroid_app_Activity_I = JNIEnv.GetMethodID (class_ref, "startResolutionForResult", "(Landroid/app/Activity;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_startResolutionForResult_Landroid_app_Activity_I, __args);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='ConnectionResult']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public override unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
