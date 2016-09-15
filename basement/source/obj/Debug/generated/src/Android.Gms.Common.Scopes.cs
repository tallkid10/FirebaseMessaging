using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/Scopes", DoNotGenerateAcw=true)]
	public sealed partial class Scopes : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='APP_STATE']"
		[Register ("APP_STATE")]
		public const string AppState = (string) "https://www.googleapis.com/auth/appstate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='CLOUD_SAVE']"
		[Register ("CLOUD_SAVE")]
		public const string CloudSave = (string) "https://www.googleapis.com/auth/datastoremobile";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='DRIVE_APPFOLDER']"
		[Register ("DRIVE_APPFOLDER")]
		public const string DriveAppfolder = (string) "https://www.googleapis.com/auth/drive.appdata";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='DRIVE_FILE']"
		[Register ("DRIVE_FILE")]
		public const string DriveFile = (string) "https://www.googleapis.com/auth/drive.file";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='EMAIL']"
		[Register ("EMAIL")]
		public const string Email = (string) "email";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='FITNESS_ACTIVITY_READ']"
		[Register ("FITNESS_ACTIVITY_READ")]
		public const string FitnessActivityRead = (string) "https://www.googleapis.com/auth/fitness.activity.read";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='FITNESS_ACTIVITY_READ_WRITE']"
		[Register ("FITNESS_ACTIVITY_READ_WRITE")]
		public const string FitnessActivityReadWrite = (string) "https://www.googleapis.com/auth/fitness.activity.write";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='FITNESS_BODY_READ']"
		[Register ("FITNESS_BODY_READ")]
		public const string FitnessBodyRead = (string) "https://www.googleapis.com/auth/fitness.body.read";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='FITNESS_BODY_READ_WRITE']"
		[Register ("FITNESS_BODY_READ_WRITE")]
		public const string FitnessBodyReadWrite = (string) "https://www.googleapis.com/auth/fitness.body.write";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='FITNESS_LOCATION_READ']"
		[Register ("FITNESS_LOCATION_READ")]
		public const string FitnessLocationRead = (string) "https://www.googleapis.com/auth/fitness.location.read";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='FITNESS_LOCATION_READ_WRITE']"
		[Register ("FITNESS_LOCATION_READ_WRITE")]
		public const string FitnessLocationReadWrite = (string) "https://www.googleapis.com/auth/fitness.location.write";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='FITNESS_NUTRITION_READ']"
		[Register ("FITNESS_NUTRITION_READ")]
		public const string FitnessNutritionRead = (string) "https://www.googleapis.com/auth/fitness.nutrition.read";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='FITNESS_NUTRITION_READ_WRITE']"
		[Register ("FITNESS_NUTRITION_READ_WRITE")]
		public const string FitnessNutritionReadWrite = (string) "https://www.googleapis.com/auth/fitness.nutrition.write";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='GAMES']"
		[Register ("GAMES")]
		public const string Games = (string) "https://www.googleapis.com/auth/games";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='PLUS_LOGIN']"
		[Register ("PLUS_LOGIN")]
		public const string PlusLogin = (string) "https://www.googleapis.com/auth/plus.login";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='PLUS_ME']"
		[Register ("PLUS_ME")]
		public const string PlusMe = (string) "https://www.googleapis.com/auth/plus.me";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='PLUS_MOMENTS']"
		[Register ("PLUS_MOMENTS")]
		public const string PlusMoments = (string) "https://www.googleapis.com/auth/plus.moments.write";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common']/class[@name='Scopes']/field[@name='PROFILE']"
		[Register ("PROFILE")]
		public const string Profile = (string) "profile";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/Scopes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Scopes); }
		}

		internal Scopes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
