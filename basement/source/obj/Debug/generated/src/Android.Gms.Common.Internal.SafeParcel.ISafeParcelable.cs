using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Internal.SafeParcel {

	[Register ("com/google/android/gms/common/internal/safeparcel/SafeParcelable", DoNotGenerateAcw=true)]
	public abstract class SafeParcelable : Java.Lang.Object {

		internal SafeParcelable ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.internal.safeparcel']/interface[@name='SafeParcelable']/field[@name='NULL']"
		[Register ("NULL")]
		public const string Null = (string) "SAFE_PARCELABLE_NULL_STRING";

		// The following are fields from: android.os.Parcelable

		// The following are fields from: Android.Runtime.IJavaObject

		// The following are fields from: System.IDisposable
	}

	[Register ("com/google/android/gms/common/internal/safeparcel/SafeParcelable", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'SafeParcelable' type. This type will be removed in a future release.")]
	public abstract class SafeParcelableConsts : SafeParcelable {

		private SafeParcelableConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.common.internal.safeparcel']/interface[@name='SafeParcelable']"
	[Register ("com/google/android/gms/common/internal/safeparcel/SafeParcelable", "", "Android.Gms.Common.Internal.SafeParcel.ISafeParcelableInvoker")]
	public partial interface ISafeParcelable : global::Android.OS.IParcelable {

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/internal/safeparcel/SafeParcelable", DoNotGenerateAcw=true)]
	internal class ISafeParcelableInvoker : global::Java.Lang.Object, ISafeParcelable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/common/internal/safeparcel/SafeParcelable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISafeParcelableInvoker); }
		}

		IntPtr class_ref;

		public static ISafeParcelable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISafeParcelable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.common.internal.safeparcel.SafeParcelable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISafeParcelableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Common.Internal.SafeParcel.ISafeParcelable __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Internal.SafeParcel.ISafeParcelable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		IntPtr id_describeContents;
		public unsafe global::System.Int32 DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod (Handle, id_describeContents);
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
			global::Android.Gms.Common.Internal.SafeParcel.ISafeParcelable __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Internal.SafeParcel.ISafeParcelable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (dest);
			__args [1] = new JValue ((int) flags);
			JNIEnv.CallVoidMethod (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
		}

	}

}
