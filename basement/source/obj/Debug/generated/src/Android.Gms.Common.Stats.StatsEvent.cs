using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Common.Stats {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.common.stats']/class[@name='StatsEvent']"
	[global::Android.Runtime.Register ("com/google/android/gms/common/stats/StatsEvent", DoNotGenerateAcw=true)]
	public abstract partial class StatsEvent : global::Android.Gms.Common.Internal.SafeParcel.AbstractSafeParcelable, global::Android.Gms.Common.Internal.IReflectedParcelable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/common/stats/StatsEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatsEvent); }
		}

		protected StatsEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.common.stats']/class[@name='StatsEvent']/constructor[@name='StatsEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StatsEvent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StatsEvent)) {
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

		static Delegate cb_getEventType;
#pragma warning disable 0169
		static Delegate GetGetEventTypeHandler ()
		{
			if (cb_getEventType == null)
				cb_getEventType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEventType);
			return cb_getEventType;
		}

		static int n_GetEventType (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Common.Stats.StatsEvent __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Stats.StatsEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EventType;
		}
#pragma warning restore 0169

		public abstract int EventType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.stats']/class[@name='StatsEvent']/method[@name='getEventType' and count(parameter)=0]"
			[Register ("getEventType", "()I", "GetGetEventTypeHandler")] get;
		}

		static Delegate cb_getTimeMillis;
#pragma warning disable 0169
		static Delegate GetGetTimeMillisHandler ()
		{
			if (cb_getTimeMillis == null)
				cb_getTimeMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimeMillis);
			return cb_getTimeMillis;
		}

		static long n_GetTimeMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Common.Stats.StatsEvent __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Stats.StatsEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeMillis;
		}
#pragma warning restore 0169

		public abstract long TimeMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.stats']/class[@name='StatsEvent']/method[@name='getTimeMillis' and count(parameter)=0]"
			[Register ("getTimeMillis", "()J", "GetGetTimeMillisHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/gms/common/stats/StatsEvent", DoNotGenerateAcw=true)]
	internal partial class StatsEventInvoker : StatsEvent {

		public StatsEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatsEventInvoker); }
		}

		static IntPtr id_getEventType;
		public override unsafe int EventType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.stats']/class[@name='StatsEvent']/method[@name='getEventType' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.stats']/class[@name='StatsEvent']/method[@name='getTimeMillis' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.common.stats']/class[@name='StatsEvent']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='Android.OS.Parcel'] and parameter[2][@type='Android.OS.ParcelableWriteFlags']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
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
