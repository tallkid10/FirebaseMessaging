using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Actions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='NoteIntents']"
	[global::Android.Runtime.Register ("com/google/android/gms/actions/NoteIntents", DoNotGenerateAcw=true)]
	public partial class NoteIntents : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='NoteIntents']/field[@name='ACTION_APPEND_NOTE']"
		[Register ("ACTION_APPEND_NOTE")]
		public const string ActionAppendNote = (string) "com.google.android.gms.actions.APPEND_NOTE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='NoteIntents']/field[@name='ACTION_CREATE_NOTE']"
		[Register ("ACTION_CREATE_NOTE")]
		public const string ActionCreateNote = (string) "com.google.android.gms.actions.CREATE_NOTE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='NoteIntents']/field[@name='ACTION_DELETE_NOTE']"
		[Register ("ACTION_DELETE_NOTE")]
		public const string ActionDeleteNote = (string) "com.google.android.gms.actions.DELETE_NOTE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='NoteIntents']/field[@name='EXTRA_NAME']"
		[Register ("EXTRA_NAME")]
		public const string ExtraName = (string) "com.google.android.gms.actions.extra.NAME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='NoteIntents']/field[@name='EXTRA_NOTE_QUERY']"
		[Register ("EXTRA_NOTE_QUERY")]
		public const string ExtraNoteQuery = (string) "com.google.android.gms.actions.extra.NOTE_QUERY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='NoteIntents']/field[@name='EXTRA_TEXT']"
		[Register ("EXTRA_TEXT")]
		public const string ExtraText = (string) "com.google.android.gms.actions.extra.TEXT";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/actions/NoteIntents", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NoteIntents); }
		}

		protected NoteIntents (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
