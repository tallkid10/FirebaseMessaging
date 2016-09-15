using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common.internal']/class[@name='DowngradeableSafeParcel']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/internal/DowngradeableSafeParcel", DoNotGenerateAcw=true)]
	public abstract partial class DowngradeableSafeParcel : global::Android.Gms.Common.Internal.SafeParcel.AbstractSafeParcelable, global::Android.Gms.Common.Internal.IReflectedParcelable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/internal/DowngradeableSafeParcel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DowngradeableSafeParcel); }
		}

		protected DowngradeableSafeParcel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common.internal']/class[@name='DowngradeableSafeParcel']/constructor[@name='DowngradeableSafeParcel' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DowngradeableSafeParcel ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DowngradeableSafeParcel)) {
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

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/internal/DowngradeableSafeParcel", DoNotGenerateAcw=true)]
	internal partial class DowngradeableSafeParcelInvoker : DowngradeableSafeParcel {

		public DowngradeableSafeParcelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DowngradeableSafeParcelInvoker); }
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.internal']/class[@name='DowngradeableSafeParcel']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='Android.OS.Parcel'] and parameter[2][@type='Android.OS.ParcelableWriteFlags']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
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
