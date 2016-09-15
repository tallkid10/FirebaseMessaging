using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Apis {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.common.api']/interface[@name='ResultCallback']"
	[Register ("com/google/android/gms/common/api/ResultCallback", "", "Android.Gms.Common.Apis.IResultCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.google.android.gms.common.api.Result"})]
	public partial interface IResultCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/interface[@name='ResultCallback']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='R']]"
		[Register ("onResult", "(Lcom/google/android/gms/common/api/Result;)V", "GetOnResult_Lcom_google_android_gms_common_api_Result_Handler:Android.Gms.Common.Apis.IResultCallbackInvoker, Xamarin.GooglePlayServices.Basement")]
		void OnResult (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/api/ResultCallback", DoNotGenerateAcw=true)]
	internal class IResultCallbackInvoker : global::Java.Lang.Object, IResultCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/common/api/ResultCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IResultCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IResultCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResultCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.common.api.ResultCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResultCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onResult_Lcom_google_android_gms_common_api_Result_;
#pragma warning disable 0169
		static Delegate GetOnResult_Lcom_google_android_gms_common_api_Result_Handler ()
		{
			if (cb_onResult_Lcom_google_android_gms_common_api_Result_ == null)
				cb_onResult_Lcom_google_android_gms_common_api_Result_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResult_Lcom_google_android_gms_common_api_Result_);
			return cb_onResult_Lcom_google_android_gms_common_api_Result_;
		}

		static void n_OnResult_Lcom_google_android_gms_common_api_Result_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Common.Apis.IResultCallback __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.IResultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResult_Lcom_google_android_gms_common_api_Result_;
		public unsafe void OnResult (global::Java.Lang.Object p0)
		{
			if (id_onResult_Lcom_google_android_gms_common_api_Result_ == IntPtr.Zero)
				id_onResult_Lcom_google_android_gms_common_api_Result_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Lcom/google/android/gms/common/api/Result;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onResult_Lcom_google_android_gms_common_api_Result_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
