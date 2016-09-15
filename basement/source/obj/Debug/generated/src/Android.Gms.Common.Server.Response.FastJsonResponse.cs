using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Server.Response {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='FastJsonResponse']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/server/response/FastJsonResponse", DoNotGenerateAcw=true)]
	public abstract partial class FastJsonResponse : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='FastJsonResponse.Field']"
		[global::Android.Runtime.Register ("com/google/android/gms/common/server/response/FastJsonResponse$Field", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"I", "O"})]
		public partial class Field : global::Android.Gms.Common.Internal.SafeParcel.AbstractSafeParcelable {


			static IntPtr zF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='FastJsonResponse.Field']/field[@name='zF']"
			[Register ("zF")]
			protected int ZF {
				get {
					if (zF_jfieldId == IntPtr.Zero)
						zF_jfieldId = JNIEnv.GetFieldID (class_ref, "zF", "I");
					return JNIEnv.GetIntField (Handle, zF_jfieldId);
				}
				set {
					if (zF_jfieldId == IntPtr.Zero)
						zF_jfieldId = JNIEnv.GetFieldID (class_ref, "zF", "I");
					try {
						JNIEnv.SetField (Handle, zF_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr zG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='FastJsonResponse.Field']/field[@name='zG']"
			[Register ("zG")]
			protected bool ZG {
				get {
					if (zG_jfieldId == IntPtr.Zero)
						zG_jfieldId = JNIEnv.GetFieldID (class_ref, "zG", "Z");
					return JNIEnv.GetBooleanField (Handle, zG_jfieldId);
				}
				set {
					if (zG_jfieldId == IntPtr.Zero)
						zG_jfieldId = JNIEnv.GetFieldID (class_ref, "zG", "Z");
					try {
						JNIEnv.SetField (Handle, zG_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr zH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='FastJsonResponse.Field']/field[@name='zH']"
			[Register ("zH")]
			protected int ZH {
				get {
					if (zH_jfieldId == IntPtr.Zero)
						zH_jfieldId = JNIEnv.GetFieldID (class_ref, "zH", "I");
					return JNIEnv.GetIntField (Handle, zH_jfieldId);
				}
				set {
					if (zH_jfieldId == IntPtr.Zero)
						zH_jfieldId = JNIEnv.GetFieldID (class_ref, "zH", "I");
					try {
						JNIEnv.SetField (Handle, zH_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr zI_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='FastJsonResponse.Field']/field[@name='zI']"
			[Register ("zI")]
			protected bool ZI {
				get {
					if (zI_jfieldId == IntPtr.Zero)
						zI_jfieldId = JNIEnv.GetFieldID (class_ref, "zI", "Z");
					return JNIEnv.GetBooleanField (Handle, zI_jfieldId);
				}
				set {
					if (zI_jfieldId == IntPtr.Zero)
						zI_jfieldId = JNIEnv.GetFieldID (class_ref, "zI", "Z");
					try {
						JNIEnv.SetField (Handle, zI_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr zJ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='FastJsonResponse.Field']/field[@name='zJ']"
			[Register ("zJ")]
			protected string ZJ {
				get {
					if (zJ_jfieldId == IntPtr.Zero)
						zJ_jfieldId = JNIEnv.GetFieldID (class_ref, "zJ", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, zJ_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (zJ_jfieldId == IntPtr.Zero)
						zJ_jfieldId = JNIEnv.GetFieldID (class_ref, "zJ", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, zJ_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr zK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='FastJsonResponse.Field']/field[@name='zK']"
			[Register ("zK")]
			protected int ZK {
				get {
					if (zK_jfieldId == IntPtr.Zero)
						zK_jfieldId = JNIEnv.GetFieldID (class_ref, "zK", "I");
					return JNIEnv.GetIntField (Handle, zK_jfieldId);
				}
				set {
					if (zK_jfieldId == IntPtr.Zero)
						zK_jfieldId = JNIEnv.GetFieldID (class_ref, "zK", "I");
					try {
						JNIEnv.SetField (Handle, zK_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr zL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='FastJsonResponse.Field']/field[@name='zL']"
			[Register ("zL")]
			protected global::Java.Lang.Class ZL {
				get {
					if (zL_jfieldId == IntPtr.Zero)
						zL_jfieldId = JNIEnv.GetFieldID (class_ref, "zL", "Ljava/lang/Class;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, zL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (zL_jfieldId == IntPtr.Zero)
						zL_jfieldId = JNIEnv.GetFieldID (class_ref, "zL", "Ljava/lang/Class;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, zL_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr zM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='FastJsonResponse.Field']/field[@name='zM']"
			[Register ("zM")]
			protected string ZM {
				get {
					if (zM_jfieldId == IntPtr.Zero)
						zM_jfieldId = JNIEnv.GetFieldID (class_ref, "zM", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, zM_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (zM_jfieldId == IntPtr.Zero)
						zM_jfieldId = JNIEnv.GetFieldID (class_ref, "zM", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, zM_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/gms/common/server/response/FastJsonResponse$Field", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Field); }
			}

			protected Field (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Android.Gms.Common.Server.Response.FastJsonResponse.Field __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Server.Response.FastJsonResponse.Field> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.VersionCode;
			}
#pragma warning restore 0169

			static IntPtr id_getVersionCode;
			public virtual unsafe int VersionCode {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='FastJsonResponse.Field']/method[@name='getVersionCode' and count(parameter)=0]"
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

			static Delegate cb_convertBack_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetConvertBack_Ljava_lang_Object_Handler ()
			{
				if (cb_convertBack_Ljava_lang_Object_ == null)
					cb_convertBack_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConvertBack_Ljava_lang_Object_);
				return cb_convertBack_Ljava_lang_Object_;
			}

			static IntPtr n_ConvertBack_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Android.Gms.Common.Server.Response.FastJsonResponse.Field __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Server.Response.FastJsonResponse.Field> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertBack (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_convertBack_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='FastJsonResponse.Field']/method[@name='convertBack' and count(parameter)=1 and parameter[1][@type='O']]"
			[Register ("convertBack", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetConvertBack_Ljava_lang_Object_Handler")]
			public virtual unsafe global::Java.Lang.Object ConvertBack (global::Java.Lang.Object p0)
			{
				if (id_convertBack_Ljava_lang_Object_ == IntPtr.Zero)
					id_convertBack_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "convertBack", "(Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Object __ret;
					if (GetType () == ThresholdType)
						__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_convertBack_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertBack", "(Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
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
				global::Android.Gms.Common.Server.Response.FastJsonResponse.Field __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Server.Response.FastJsonResponse.Field> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
				__this.WriteToParcel (dest, flags);
			}
#pragma warning restore 0169

			static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='FastJsonResponse.Field']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/server/response/FastJsonResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FastJsonResponse); }
		}

		protected FastJsonResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common.server.response']/class[@name='FastJsonResponse']/constructor[@name='FastJsonResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FastJsonResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FastJsonResponse)) {
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

	[global::Android.Runtime.Register ("com/google/android/gms/common/server/response/FastJsonResponse", DoNotGenerateAcw=true)]
	internal partial class FastJsonResponseInvoker : FastJsonResponse {

		public FastJsonResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (FastJsonResponseInvoker); }
		}

	}

}
