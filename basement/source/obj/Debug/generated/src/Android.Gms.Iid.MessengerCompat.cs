using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Iid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.iid']/class[@name='MessengerCompat']"
	[global::Android.Runtime.Register ("com/google/android/gms/iid/MessengerCompat", DoNotGenerateAcw=true)]
	public partial class MessengerCompat : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.iid']/class[@name='MessengerCompat']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/iid/MessengerCompat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessengerCompat); }
		}

		protected MessengerCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Handler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.iid']/class[@name='MessengerCompat']/constructor[@name='MessengerCompat' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register (".ctor", "(Landroid/os/Handler;)V", "")]
		public unsafe MessengerCompat (global::Android.OS.Handler p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MessengerCompat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Handler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Handler;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Handler_ == IntPtr.Zero)
					id_ctor_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Handler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Handler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Handler_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_os_IBinder_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.iid']/class[@name='MessengerCompat']/constructor[@name='MessengerCompat' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register (".ctor", "(Landroid/os/IBinder;)V", "")]
		public unsafe MessengerCompat (global::Android.OS.IBinder p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MessengerCompat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/IBinder;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/IBinder;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_IBinder_ == IntPtr.Zero)
					id_ctor_Landroid_os_IBinder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/IBinder;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_IBinder_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_IBinder_, __args);
			} finally {
			}
		}

		static Delegate cb_getBinder;
#pragma warning disable 0169
		static Delegate GetGetBinderHandler ()
		{
			if (cb_getBinder == null)
				cb_getBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBinder);
			return cb_getBinder;
		}

		static IntPtr n_GetBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Iid.MessengerCompat __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Iid.MessengerCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Binder);
		}
#pragma warning restore 0169

		static IntPtr id_getBinder;
		public virtual unsafe global::Android.OS.IBinder Binder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.iid']/class[@name='MessengerCompat']/method[@name='getBinder' and count(parameter)=0]"
			[Register ("getBinder", "()Landroid/os/IBinder;", "GetGetBinderHandler")]
			get {
				if (id_getBinder == IntPtr.Zero)
					id_getBinder = JNIEnv.GetMethodID (class_ref, "getBinder", "()Landroid/os/IBinder;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod  (Handle, id_getBinder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBinder", "()Landroid/os/IBinder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Gms.Iid.MessengerCompat __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Iid.MessengerCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.iid']/class[@name='MessengerCompat']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_send_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetSend_Landroid_os_Message_Handler ()
		{
			if (cb_send_Landroid_os_Message_ == null)
				cb_send_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Landroid_os_Message_);
			return cb_send_Landroid_os_Message_;
		}

		static void n_Send_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Gms.Iid.MessengerCompat __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Iid.MessengerCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		static IntPtr id_send_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.iid']/class[@name='MessengerCompat']/method[@name='send' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("send", "(Landroid/os/Message;)V", "GetSend_Landroid_os_Message_Handler")]
		public virtual unsafe void Send (global::Android.OS.Message p0)
		{
			if (id_send_Landroid_os_Message_ == IntPtr.Zero)
				id_send_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "send", "(Landroid/os/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_send_Landroid_os_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Landroid/os/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Android.Gms.Iid.MessengerCompat __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Iid.MessengerCompat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.iid']/class[@name='MessengerCompat']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
