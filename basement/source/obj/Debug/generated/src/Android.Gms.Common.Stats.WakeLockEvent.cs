using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common.stats']/class[@name='WakeLockEvent']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/stats/WakeLockEvent", DoNotGenerateAcw=true)]
	public sealed partial class WakeLockEvent : global::Android.Gms.Common.Stats.StatsEvent {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.common.stats']/class[@name='WakeLockEvent']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/stats/WakeLockEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WakeLockEvent); }
		}

		internal WakeLockEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JILjava_lang_String_ILjava_util_List_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_FJLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common.stats']/class[@name='WakeLockEvent']/constructor[@name='WakeLockEvent' and count(parameter)=13 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='long'] and parameter[8][@type='int'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='float'] and parameter[12][@type='long'] and parameter[13][@type='java.lang.String']]"
		[Register (".ctor", "(JILjava/lang/String;ILjava/util/List;Ljava/lang/String;JILjava/lang/String;Ljava/lang/String;FJLjava/lang/String;)V", "")]
		public unsafe WakeLockEvent (long p0, int p1, string p2, int p3, global::System.Collections.Generic.IList<string> p4, string p5, long p6, int p7, string p8, string p9, float p10, long p11, string p12)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			IntPtr native_p9 = JNIEnv.NewString (p9);
			IntPtr native_p12 = JNIEnv.NewString (p12);
			try {
				JValue* __args = stackalloc JValue [13];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (native_p8);
				__args [9] = new JValue (native_p9);
				__args [10] = new JValue (p10);
				__args [11] = new JValue (p11);
				__args [12] = new JValue (native_p12);
				if (GetType () != typeof (WakeLockEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JILjava/lang/String;ILjava/util/List;Ljava/lang/String;JILjava/lang/String;Ljava/lang/String;FJLjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(JILjava/lang/String;ILjava/util/List;Ljava/lang/String;JILjava/lang/String;Ljava/lang/String;FJLjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_JILjava_lang_String_ILjava_util_List_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_FJLjava_lang_String_ == IntPtr.Zero)
					id_ctor_JILjava_lang_String_ILjava_util_List_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_FJLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(JILjava/lang/String;ILjava/util/List;Ljava/lang/String;JILjava/lang/String;Ljava/lang/String;FJLjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JILjava_lang_String_ILjava_util_List_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_FJLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_JILjava_lang_String_ILjava_util_List_Ljava_lang_String_JILjava_lang_String_Ljava_lang_String_FJLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p8);
				JNIEnv.DeleteLocalRef (native_p9);
				JNIEnv.DeleteLocalRef (native_p12);
			}
		}

		static IntPtr id_getEventType;
		public override unsafe int EventType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.stats']/class[@name='WakeLockEvent']/method[@name='getEventType' and count(parameter)=0]"
			[Register ("getEventType", "()I", "GetGetEventTypeHandler")]
			get {
				if (id_getEventType == IntPtr.Zero)
					id_getEventType = JNIEnv.GetMethodID (class_ref, "getEventType", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getEventType);
				} finally {
				}
			}
		}

		static IntPtr id_getTimeMillis;
		public override unsafe long TimeMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.stats']/class[@name='WakeLockEvent']/method[@name='getTimeMillis' and count(parameter)=0]"
			[Register ("getTimeMillis", "()J", "GetGetTimeMillisHandler")]
			get {
				if (id_getTimeMillis == IntPtr.Zero)
					id_getTimeMillis = JNIEnv.GetMethodID (class_ref, "getTimeMillis", "()J");
				try {
					return JNIEnv.CallLongMethod  (Handle, id_getTimeMillis);
				} finally {
				}
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.stats']/class[@name='WakeLockEvent']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public override unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
