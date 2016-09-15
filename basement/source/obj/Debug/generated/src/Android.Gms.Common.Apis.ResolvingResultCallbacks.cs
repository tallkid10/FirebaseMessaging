using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Apis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='ResolvingResultCallbacks']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/api/ResolvingResultCallbacks", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.google.android.gms.common.api.Result"})]
	public abstract partial class ResolvingResultCallbacks : global::Android.Gms.Common.Apis.ResultCallbacks {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/api/ResolvingResultCallbacks", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResolvingResultCallbacks); }
		}

		protected ResolvingResultCallbacks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='ResolvingResultCallbacks']/constructor[@name='ResolvingResultCallbacks' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/app/Activity;I)V", "")]
		protected unsafe ResolvingResultCallbacks (global::Android.App.Activity p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ResolvingResultCallbacks)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Activity;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_I == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Activity_I, __args);
			} finally {
			}
		}

		static IntPtr id_onFailure_Lcom_google_android_gms_common_api_Status_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='ResolvingResultCallbacks']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.api.Status']]"
		[Register ("onFailure", "(Lcom/google/android/gms/common/api/Status;)V", "")]
		public override sealed unsafe void OnFailure (global::Android.Gms.Common.Apis.Statuses p0)
		{
			if (id_onFailure_Lcom_google_android_gms_common_api_Status_ == IntPtr.Zero)
				id_onFailure_Lcom_google_android_gms_common_api_Status_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/google/android/gms/common/api/Status;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_onFailure_Lcom_google_android_gms_common_api_Status_, __args);
			} finally {
			}
		}

		static Delegate cb_onUnresolvableFailure_Lcom_google_android_gms_common_api_Status_;
#pragma warning disable 0169
		static Delegate GetOnUnresolvableFailure_Lcom_google_android_gms_common_api_Status_Handler ()
		{
			if (cb_onUnresolvableFailure_Lcom_google_android_gms_common_api_Status_ == null)
				cb_onUnresolvableFailure_Lcom_google_android_gms_common_api_Status_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUnresolvableFailure_Lcom_google_android_gms_common_api_Status_);
			return cb_onUnresolvableFailure_Lcom_google_android_gms_common_api_Status_;
		}

		static void n_OnUnresolvableFailure_Lcom_google_android_gms_common_api_Status_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Common.Apis.ResolvingResultCallbacks __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.ResolvingResultCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.Apis.Statuses p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.Statuses> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUnresolvableFailure (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='ResolvingResultCallbacks']/method[@name='onUnresolvableFailure' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.api.Status']]"
		[Register ("onUnresolvableFailure", "(Lcom/google/android/gms/common/api/Status;)V", "GetOnUnresolvableFailure_Lcom_google_android_gms_common_api_Status_Handler")]
		public abstract void OnUnresolvableFailure (global::Android.Gms.Common.Apis.Statuses p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/api/ResolvingResultCallbacks", DoNotGenerateAcw=true)]
	internal partial class ResolvingResultCallbacksInvoker : ResolvingResultCallbacks {

		public ResolvingResultCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResolvingResultCallbacksInvoker); }
		}

		static IntPtr id_onUnresolvableFailure_Lcom_google_android_gms_common_api_Status_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='ResolvingResultCallbacks']/method[@name='onUnresolvableFailure' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.api.Status']]"
		[Register ("onUnresolvableFailure", "(Lcom/google/android/gms/common/api/Status;)V", "GetOnUnresolvableFailure_Lcom_google_android_gms_common_api_Status_Handler")]
		public override unsafe void OnUnresolvableFailure (global::Android.Gms.Common.Apis.Statuses p0)
		{
			if (id_onUnresolvableFailure_Lcom_google_android_gms_common_api_Status_ == IntPtr.Zero)
				id_onUnresolvableFailure_Lcom_google_android_gms_common_api_Status_ = JNIEnv.GetMethodID (class_ref, "onUnresolvableFailure", "(Lcom/google/android/gms/common/api/Status;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_onUnresolvableFailure_Lcom_google_android_gms_common_api_Status_, __args);
			} finally {
			}
		}

		static IntPtr id_onSuccess_Lcom_google_android_gms_common_api_Result_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='ResultCallbacks']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='R']]"
		[Register ("onSuccess", "(Lcom/google/android/gms/common/api/Result;)V", "GetOnSuccess_Lcom_google_android_gms_common_api_Result_Handler")]
		public override unsafe void OnSuccess (global::Java.Lang.Object p0)
		{
			if (id_onSuccess_Lcom_google_android_gms_common_api_Result_ == IntPtr.Zero)
				id_onSuccess_Lcom_google_android_gms_common_api_Result_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/google/android/gms/common/api/Result;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_onSuccess_Lcom_google_android_gms_common_api_Result_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
