using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Firebase.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='SendException']"
	[global::Android.Runtime.Register ("com/google/firebase/messaging/SendException", DoNotGenerateAcw=true)]
	public sealed partial class SendException : global::Java.Lang.Exception {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='SendException']/field[@name='ERROR_INVALID_PARAMETERS']"
		[Register ("ERROR_INVALID_PARAMETERS")]
		public const int ErrorInvalidParameters = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='SendException']/field[@name='ERROR_SIZE']"
		[Register ("ERROR_SIZE")]
		public const int ErrorSize = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='SendException']/field[@name='ERROR_TOO_MANY_MESSAGES']"
		[Register ("ERROR_TOO_MANY_MESSAGES")]
		public const int ErrorTooManyMessages = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='SendException']/field[@name='ERROR_TTL_EXCEEDED']"
		[Register ("ERROR_TTL_EXCEEDED")]
		public const int ErrorTtlExceeded = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='SendException']/field[@name='ERROR_UNKNOWN']"
		[Register ("ERROR_UNKNOWN")]
		public const int ErrorUnknown = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/firebase/messaging/SendException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SendException); }
		}

		internal SendException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getErrorCode;
		public unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.firebase.messaging']/class[@name='SendException']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getErrorCode);
				} finally {
				}
			}
		}

	}
}
