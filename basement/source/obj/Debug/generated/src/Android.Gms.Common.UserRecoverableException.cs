using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='UserRecoverableException']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/UserRecoverableException", DoNotGenerateAcw=true)]
	public partial class UserRecoverableException : global::Java.Lang.Exception {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/UserRecoverableException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserRecoverableException); }
		}

		protected UserRecoverableException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Landroid_content_Intent_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='UserRecoverableException']/constructor[@name='UserRecoverableException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Intent']]"
		[Register (".ctor", "(Ljava/lang/String;Landroid/content/Intent;)V", "")]
		public unsafe UserRecoverableException (string p0, global::Android.Content.Intent p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (UserRecoverableException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Landroid/content/Intent;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Landroid/content/Intent;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Landroid_content_Intent_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Landroid/content/Intent;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Landroid_content_Intent_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Landroid_content_Intent_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getIntent;
#pragma warning disable 0169
		static Delegate GetGetIntentHandler ()
		{
			if (cb_getIntent == null)
				cb_getIntent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntent);
			return cb_getIntent;
		}

		static IntPtr n_GetIntent (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Common.UserRecoverableException __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.UserRecoverableException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Intent);
		}
#pragma warning restore 0169

		static IntPtr id_getIntent;
		public virtual unsafe global::Android.Content.Intent Intent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='UserRecoverableException']/method[@name='getIntent' and count(parameter)=0]"
			[Register ("getIntent", "()Landroid/content/Intent;", "GetGetIntentHandler")]
			get {
				if (id_getIntent == IntPtr.Zero)
					id_getIntent = JNIEnv.GetMethodID (class_ref, "getIntent", "()Landroid/content/Intent;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_getIntent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntent", "()Landroid/content/Intent;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
