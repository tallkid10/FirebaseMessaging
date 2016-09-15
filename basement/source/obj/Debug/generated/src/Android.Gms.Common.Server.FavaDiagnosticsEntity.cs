using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Server {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common.server']/class[@name='FavaDiagnosticsEntity']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/server/FavaDiagnosticsEntity", DoNotGenerateAcw=true)]
	public partial class FavaDiagnosticsEntity : global::Android.Gms.Common.Internal.SafeParcel.AbstractSafeParcelable, global::Android.Gms.Common.Internal.IReflectedParcelable {


		static IntPtr zx_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.server']/class[@name='FavaDiagnosticsEntity']/field[@name='zx']"
		[Register ("zx")]
		public string Zx {
			get {
				if (zx_jfieldId == IntPtr.Zero)
					zx_jfieldId = JNIEnv.GetFieldID (class_ref, "zx", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, zx_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (zx_jfieldId == IntPtr.Zero)
					zx_jfieldId = JNIEnv.GetFieldID (class_ref, "zx", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, zx_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr zy_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.server']/class[@name='FavaDiagnosticsEntity']/field[@name='zy']"
		[Register ("zy")]
		public int Zy {
			get {
				if (zy_jfieldId == IntPtr.Zero)
					zy_jfieldId = JNIEnv.GetFieldID (class_ref, "zy", "I");
				return JNIEnv.GetIntField (Handle, zy_jfieldId);
			}
			set {
				if (zy_jfieldId == IntPtr.Zero)
					zy_jfieldId = JNIEnv.GetFieldID (class_ref, "zy", "I");
				try {
					JNIEnv.SetField (Handle, zy_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/server/FavaDiagnosticsEntity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FavaDiagnosticsEntity); }
		}

		protected FavaDiagnosticsEntity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common.server']/class[@name='FavaDiagnosticsEntity']/constructor[@name='FavaDiagnosticsEntity' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register (".ctor", "(ILjava/lang/String;I)V", "")]
		public unsafe FavaDiagnosticsEntity (int p0, string p1, int p2)
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
				if (GetType () != typeof (FavaDiagnosticsEntity)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_I == IntPtr.Zero)
					id_ctor_ILjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Android.Gms.Common.Server.FavaDiagnosticsEntity __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Server.FavaDiagnosticsEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.server']/class[@name='FavaDiagnosticsEntity']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
