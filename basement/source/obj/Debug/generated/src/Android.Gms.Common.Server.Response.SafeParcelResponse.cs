using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Server.Response {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='SafeParcelResponse']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/server/response/SafeParcelResponse", DoNotGenerateAcw=true)]
	public partial class SafeParcelResponse : global::Android.Gms.Common.Server.Response.FastSafeParcelableJsonResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/server/response/SafeParcelResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SafeParcelResponse); }
		}

		protected SafeParcelResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getVersionCode;
#pragma warning disable 0169
		static Delegate GetGetVersionCodeHandler ()
		{
			if (cb_getVersionCode == null)
				cb_getVersionCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersionCode);
			return cb_getVersionCode;
		}

		static int n_GetVersionCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Common.Server.Response.SafeParcelResponse __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Server.Response.SafeParcelResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VersionCode;
		}
#pragma warning restore 0169

		static IntPtr id_getVersionCode;
		public virtual unsafe int VersionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='SafeParcelResponse']/method[@name='getVersionCode' and count(parameter)=0]"
			[Register ("getVersionCode", "()I", "GetGetVersionCodeHandler")]
			get {
				if (id_getVersionCode == IntPtr.Zero)
					id_getVersionCode = JNIEnv.GetMethodID (class_ref, "getVersionCode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getVersionCode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersionCode", "()I"));
				} finally {
				}
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
			global::Android.Gms.Common.Server.Response.SafeParcelResponse __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Server.Response.SafeParcelResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='SafeParcelResponse']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public override unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
