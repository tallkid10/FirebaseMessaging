using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Apis {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='ResultCallbacks']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/api/ResultCallbacks", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.google.android.gms.common.api.Result"})]
	public abstract partial class ResultCallbacks : global::Java.Lang.Object, global::Android.Gms.Common.Apis.IResultCallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/api/ResultCallbacks", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResultCallbacks); }
		}

		protected ResultCallbacks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='ResultCallbacks']/constructor[@name='ResultCallbacks' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResultCallbacks ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ResultCallbacks)) {
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

		static Delegate cb_onFailure_Lcom_google_android_gms_common_api_Status_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lcom_google_android_gms_common_api_Status_Handler ()
		{
			if (cb_onFailure_Lcom_google_android_gms_common_api_Status_ == null)
				cb_onFailure_Lcom_google_android_gms_common_api_Status_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Lcom_google_android_gms_common_api_Status_);
			return cb_onFailure_Lcom_google_android_gms_common_api_Status_;
		}

		static void n_OnFailure_Lcom_google_android_gms_common_api_Status_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Common.Apis.ResultCallbacks __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.ResultCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.Apis.Statuses p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.Statuses> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='ResultCallbacks']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.api.Status']]"
		[Register ("onFailure", "(Lcom/google/android/gms/common/api/Status;)V", "GetOnFailure_Lcom_google_android_gms_common_api_Status_Handler")]
		public abstract void OnFailure (global::Android.Gms.Common.Apis.Statuses p0);

		static IntPtr id_onResult_Lcom_google_android_gms_common_api_Result_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='ResultCallbacks']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='R']]"
		[Register ("onResult", "(Lcom/google/android/gms/common/api/Result;)V", "")]
		public unsafe void OnResult (global::Java.Lang.Object p0)
		{
			if (id_onResult_Lcom_google_android_gms_common_api_Result_ == IntPtr.Zero)
				id_onResult_Lcom_google_android_gms_common_api_Result_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Lcom/google/android/gms/common/api/Result;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_onResult_Lcom_google_android_gms_common_api_Result_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onSuccess_Lcom_google_android_gms_common_api_Result_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_google_android_gms_common_api_Result_Handler ()
		{
			if (cb_onSuccess_Lcom_google_android_gms_common_api_Result_ == null)
				cb_onSuccess_Lcom_google_android_gms_common_api_Result_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lcom_google_android_gms_common_api_Result_);
			return cb_onSuccess_Lcom_google_android_gms_common_api_Result_;
		}

		static void n_OnSuccess_Lcom_google_android_gms_common_api_Result_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Common.Apis.ResultCallbacks __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.ResultCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='ResultCallbacks']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='R']]"
		[Register ("onSuccess", "(Lcom/google/android/gms/common/api/Result;)V", "GetOnSuccess_Lcom_google_android_gms_common_api_Result_Handler")]
		public abstract void OnSuccess (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/api/ResultCallbacks", DoNotGenerateAcw=true)]
	internal partial class ResultCallbacksInvoker : ResultCallbacks, global::Android.Gms.Common.Apis.IResultCallback {

		public ResultCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResultCallbacksInvoker); }
		}

		static IntPtr id_onFailure_Lcom_google_android_gms_common_api_Status_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/class[@name='ResultCallbacks']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.api.Status']]"
		[Register ("onFailure", "(Lcom/google/android/gms/common/api/Status;)V", "GetOnFailure_Lcom_google_android_gms_common_api_Status_Handler")]
		public override unsafe void OnFailure (global::Android.Gms.Common.Apis.Statuses p0)
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
