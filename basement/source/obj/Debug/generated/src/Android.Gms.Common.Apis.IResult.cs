using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Apis {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.common.api']/interface[@name='Result']"
	[Register ("com/google/android/gms/common/api/Result", "", "Android.Gms.Common.Apis.IResultInvoker")]
	public partial interface IResult : IJavaObject {

		global::Android.Gms.Common.Apis.Statuses Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/interface[@name='Result']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/google/android/gms/common/api/Status;", "GetGetStatusHandler:Android.Gms.Common.Apis.IResultInvoker, Xamarin.GooglePlayServices.Basement")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/api/Result", DoNotGenerateAcw=true)]
	internal class IResultInvoker : global::Java.Lang.Object, IResult {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/common/api/Result");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IResultInvoker); }
		}

		IntPtr class_ref;

		public static IResult GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResult> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.common.api.Result"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResultInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Common.Apis.IResult __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.IResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		IntPtr id_getStatus;
		public unsafe global::Android.Gms.Common.Apis.Statuses Status {
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lcom/google/android/gms/common/api/Status;");
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.Statuses> (JNIEnv.CallObjectMethod (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
