using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Actions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='ReserveIntents']"
	[global::Android.Runtime.Register ("com/google/android/gms/actions/ReserveIntents", DoNotGenerateAcw=true)]
	public partial class ReserveIntents : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='ReserveIntents']/field[@name='ACTION_RESERVE_TAXI_RESERVATION']"
		[Register ("ACTION_RESERVE_TAXI_RESERVATION")]
		public const string ActionReserveTaxiReservation = (string) "com.google.android.gms.actions.RESERVE_TAXI_RESERVATION";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/actions/ReserveIntents", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReserveIntents); }
		}

		protected ReserveIntents (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
