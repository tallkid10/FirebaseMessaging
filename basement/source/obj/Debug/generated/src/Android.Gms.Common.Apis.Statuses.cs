using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Apis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/api/Status", DoNotGenerateAcw=true)]
	public sealed partial class Statuses : global::Android.Gms.Common.Internal.SafeParcel.AbstractSafeParcelable, global::Android.Gms.Common.Apis.IResult, global::Android.Gms.Common.Internal.IReflectedParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sq_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/field[@name='sq']"
		[Register ("sq")]
		public static global::Android.Gms.Common.Apis.Statuses Sq {
			get {
				if (sq_jfieldId == IntPtr.Zero)
					sq_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sq", "Lcom/google/android/gms/common/api/Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sq_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.Statuses> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/field[@name='sr']"
		[Register ("sr")]
		public static global::Android.Gms.Common.Apis.Statuses Sr {
			get {
				if (sr_jfieldId == IntPtr.Zero)
					sr_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sr", "Lcom/google/android/gms/common/api/Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sr_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.Statuses> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ss_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/field[@name='ss']"
		[Register ("ss")]
		public static global::Android.Gms.Common.Apis.Statuses Ss {
			get {
				if (ss_jfieldId == IntPtr.Zero)
					ss_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ss", "Lcom/google/android/gms/common/api/Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ss_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.Statuses> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr st_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/field[@name='st']"
		[Register ("st")]
		public static global::Android.Gms.Common.Apis.Statuses St {
			get {
				if (st_jfieldId == IntPtr.Zero)
					st_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "st", "Lcom/google/android/gms/common/api/Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, st_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.Statuses> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr su_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/field[@name='su']"
		[Register ("su")]
		public static global::Android.Gms.Common.Apis.Statuses Su {
			get {
				if (su_jfieldId == IntPtr.Zero)
					su_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "su", "Lcom/google/android/gms/common/api/Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, su_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.Statuses> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sv_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/field[@name='sv']"
		[Register ("sv")]
		public static global::Android.Gms.Common.Apis.Statuses Sv {
			get {
				if (sv_jfieldId == IntPtr.Zero)
					sv_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sv", "Lcom/google/android/gms/common/api/Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sv_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.Statuses> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sw_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/field[@name='sw']"
		[Register ("sw")]
		public static global::Android.Gms.Common.Apis.Statuses Sw {
			get {
				if (sw_jfieldId == IntPtr.Zero)
					sw_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sw", "Lcom/google/android/gms/common/api/Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sw_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.Statuses> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/api/Status", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Statuses); }
		}

		internal Statuses (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/constructor[@name='Status' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe Statuses (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Statuses)) {
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

		static IntPtr id_ctor_ILjava_lang_String_Landroid_app_PendingIntent_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/constructor[@name='Status' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.app.PendingIntent']]"
		[Register (".ctor", "(ILjava/lang/String;Landroid/app/PendingIntent;)V", "")]
		public unsafe Statuses (int p0, string p1, global::Android.App.PendingIntent p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Statuses)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;Landroid/app/PendingIntent;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;Landroid/app/PendingIntent;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_Landroid_app_PendingIntent_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_Landroid_app_PendingIntent_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Landroid/app/PendingIntent;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Landroid_app_PendingIntent_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_Landroid_app_PendingIntent_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/constructor[@name='Status' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe Statuses (int p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (Statuses)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_hasResolution;
		public unsafe bool HasResolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/method[@name='hasResolution' and count(parameter)=0]"
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

		static IntPtr id_isCanceled;
		public unsafe bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler")]
			get {
				if (id_isCanceled == IntPtr.Zero)
					id_isCanceled = JNIEnv.GetMethodID (class_ref, "isCanceled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isCanceled);
				} finally {
				}
			}
		}

		static IntPtr id_isInterrupted;
		public unsafe bool IsInterrupted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/method[@name='isInterrupted' and count(parameter)=0]"
			[Register ("isInterrupted", "()Z", "GetIsInterruptedHandler")]
			get {
				if (id_isInterrupted == IntPtr.Zero)
					id_isInterrupted = JNIEnv.GetMethodID (class_ref, "isInterrupted", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isInterrupted);
				} finally {
				}
			}
		}

		static IntPtr id_isSuccess;
		public unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/method[@name='isSuccess' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/method[@name='getResolution' and count(parameter)=0]"
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

		static IntPtr id_getStatus;
		public unsafe global::Android.Gms.Common.Apis.Statuses Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/google/android/gms/common/api/Status;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/google/android/gms/common/api/Status;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.Statuses> (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getStatusCode;
		public unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getStatusCode);
				} finally {
				}
			}
		}

		static IntPtr id_getStatusMessage;
		public unsafe string StatusMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/method[@name='getStatusMessage' and count(parameter)=0]"
			[Register ("getStatusMessage", "()Ljava/lang/String;", "GetGetStatusMessageHandler")]
			get {
				if (id_getStatusMessage == IntPtr.Zero)
					id_getStatusMessage = JNIEnv.GetMethodID (class_ref, "getStatusMessage", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStatusMessage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_startResolutionForResult_Landroid_app_Activity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/method[@name='startResolutionForResult' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='Status']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
