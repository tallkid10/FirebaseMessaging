using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Actions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='SearchIntents']"
	[global::Android.Runtime.Register ("com/google/android/gms/actions/SearchIntents", DoNotGenerateAcw=true)]
	public partial class SearchIntents : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='SearchIntents']/field[@name='ACTION_SEARCH']"
		[Register ("ACTION_SEARCH")]
		public const string ActionSearch = (string) "com.google.android.gms.actions.SEARCH_ACTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='SearchIntents']/field[@name='EXTRA_QUERY']"
		[Register ("EXTRA_QUERY")]
		public const string ExtraQuery = (string) "query";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/actions/SearchIntents", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SearchIntents); }
		}

		protected SearchIntents (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
