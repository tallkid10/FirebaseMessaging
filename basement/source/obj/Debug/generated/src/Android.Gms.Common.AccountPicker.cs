using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='AccountPicker']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/AccountPicker", DoNotGenerateAcw=true)]
	public sealed partial class AccountPicker : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/AccountPicker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccountPicker); }
		}

		internal AccountPicker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_newChooseAccountIntent_Landroid_accounts_Account_Ljava_util_ArrayList_arrayLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='AccountPicker']/method[@name='newChooseAccountIntent' and count(parameter)=8 and parameter[1][@type='android.accounts.Account'] and parameter[2][@type='java.util.ArrayList&lt;android.accounts.Account&gt;'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String[]'] and parameter[8][@type='android.os.Bundle']]"
		[Register ("newChooseAccountIntent", "(Landroid/accounts/Account;Ljava/util/ArrayList;[Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent NewChooseAccountIntent (global::Android.Accounts.Account p0, global::System.Collections.Generic.IList<global::Android.Accounts.Account> p1, string[] p2, bool p3, string p4, string p5, string[] p6, global::Android.OS.Bundle p7)
		{
			if (id_newChooseAccountIntent_Landroid_accounts_Account_Ljava_util_ArrayList_arrayLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_newChooseAccountIntent_Landroid_accounts_Account_Ljava_util_ArrayList_arrayLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "newChooseAccountIntent", "(Landroid/accounts/Account;Ljava/util/ArrayList;[Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/Intent;");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Android.Accounts.Account>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (p7);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newChooseAccountIntent_Landroid_accounts_Account_Ljava_util_ArrayList_arrayLjava_lang_String_ZLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
			}
		}

	}
}
