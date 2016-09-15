using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Internal.SafeParcel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common.internal.safeparcel']/class[@name='AbstractSafeParcelable']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/internal/safeparcel/AbstractSafeParcelable", DoNotGenerateAcw=true)]
	public abstract partial class AbstractSafeParcelable : global::Java.Lang.Object, global::Android.Gms.Common.Internal.SafeParcel.ISafeParcelable {


		public static class InterfaceConsts {

			// The following are fields from: com.google.android.gms.common.internal.safeparcel.SafeParcelable

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.internal.safeparcel']/interface[@name='SafeParcelable']/field[@name='NULL']"
			[Register ("NULL")]
			public const string Null = (string) "SAFE_PARCELABLE_NULL_STRING";
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/internal/safeparcel/AbstractSafeParcelable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractSafeParcelable); }
		}

		protected AbstractSafeParcelable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common.internal.safeparcel']/class[@name='AbstractSafeParcelable']/constructor[@name='AbstractSafeParcelable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractSafeParcelable ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AbstractSafeParcelable)) {
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

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.internal.safeparcel']/class[@name='AbstractSafeParcelable']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Android.Gms.Common.Internal.SafeParcel.AbstractSafeParcelable __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Internal.SafeParcel.AbstractSafeParcelable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.internal.safeparcel']/class[@name='AbstractSafeParcelable']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='Android.OS.Parcel'] and parameter[2][@type='Android.OS.ParcelableWriteFlags']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public abstract void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags);

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/internal/safeparcel/AbstractSafeParcelable", DoNotGenerateAcw=true)]
	internal partial class AbstractSafeParcelableInvoker : AbstractSafeParcelable {

		public AbstractSafeParcelableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractSafeParcelableInvoker); }
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.internal.safeparcel']/class[@name='AbstractSafeParcelable']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='Android.OS.Parcel'] and parameter[2][@type='Android.OS.ParcelableWriteFlags']]"
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
