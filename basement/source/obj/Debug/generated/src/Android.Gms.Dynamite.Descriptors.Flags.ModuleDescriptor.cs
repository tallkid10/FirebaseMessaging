using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Dynamite.Descriptors.Flags {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.dynamite.descriptors.com.google.android.gms.flags']/class[@name='ModuleDescriptor']"
	[global::Android.Runtime.Register ("com/google/android/gms/dynamite/descriptors/com/google/android/gms/flags/ModuleDescriptor", DoNotGenerateAcw=true)]
	public partial class ModuleDescriptor : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.dynamite.descriptors.com.google.android.gms.flags']/class[@name='ModuleDescriptor']/field[@name='MODULE_ID']"
		[Register ("MODULE_ID")]
		public const string ModuleId = (string) "com.google.android.gms.flags";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.dynamite.descriptors.com.google.android.gms.flags']/class[@name='ModuleDescriptor']/field[@name='MODULE_VERSION']"
		[Register ("MODULE_VERSION")]
		public const int ModuleVersion = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/dynamite/descriptors/com/google/android/gms/flags/ModuleDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ModuleDescriptor); }
		}

		protected ModuleDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.dynamite.descriptors.com.google.android.gms.flags']/class[@name='ModuleDescriptor']/constructor[@name='ModuleDescriptor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ModuleDescriptor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ModuleDescriptor)) {
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
}
