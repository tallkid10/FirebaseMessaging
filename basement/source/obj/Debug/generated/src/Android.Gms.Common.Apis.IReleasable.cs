using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Apis {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.common.api']/interface[@name='Releasable']"
	[Register ("com/google/android/gms/common/api/Releasable", "", "Android.Gms.Common.Apis.IReleasableInvoker")]
	public partial interface IReleasable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.api']/interface[@name='Releasable']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Android.Gms.Common.Apis.IReleasableInvoker, Xamarin.GooglePlayServices.Basement")]
		void Release ();

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/api/Releasable", DoNotGenerateAcw=true)]
	internal class IReleasableInvoker : global::Java.Lang.Object, IReleasable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/common/api/Releasable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IReleasableInvoker); }
		}

		IntPtr class_ref;

		public static IReleasable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReleasable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.common.api.Releasable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReleasableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Common.Apis.IReleasable __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.IReleasable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (Handle, id_release);
		}

	}

}
