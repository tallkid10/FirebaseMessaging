using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Security {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.security']/class[@name='ProviderInstaller']"
	[global::Android.Runtime.Register ("com/google/android/gms/security/ProviderInstaller", DoNotGenerateAcw=true)]
	public partial class ProviderInstaller : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.security']/class[@name='ProviderInstaller']/field[@name='PROVIDER_NAME']"
		[Register ("PROVIDER_NAME")]
		public const string ProviderName = (string) "GmsCore_OpenSSL";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.gms.security']/interface[@name='ProviderInstaller.ProviderInstallListener']"
		[Register ("com/google/android/gms/security/ProviderInstaller$ProviderInstallListener", "", "Android.Gms.Security.ProviderInstaller/IProviderInstallListenerInvoker")]
		public partial interface IProviderInstallListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.security']/interface[@name='ProviderInstaller.ProviderInstallListener']/method[@name='onProviderInstallFailed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onProviderInstallFailed", "(ILandroid/content/Intent;)V", "GetOnProviderInstallFailed_ILandroid_content_Intent_Handler:Android.Gms.Security.ProviderInstaller/IProviderInstallListenerInvoker, Xamarin.GooglePlayServices.Basement")]
			void OnProviderInstallFailed (int p0, global::Android.Content.Intent p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.security']/interface[@name='ProviderInstaller.ProviderInstallListener']/method[@name='onProviderInstalled' and count(parameter)=0]"
			[Register ("onProviderInstalled", "()V", "GetOnProviderInstalledHandler:Android.Gms.Security.ProviderInstaller/IProviderInstallListenerInvoker, Xamarin.GooglePlayServices.Basement")]
			void OnProviderInstalled ();

		}

		[global::Android.Runtime.Register ("com/google/android/gms/security/ProviderInstaller$ProviderInstallListener", DoNotGenerateAcw=true)]
		internal class IProviderInstallListenerInvoker : global::Java.Lang.Object, IProviderInstallListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/gms/security/ProviderInstaller$ProviderInstallListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IProviderInstallListenerInvoker); }
			}

			IntPtr class_ref;

			public static IProviderInstallListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IProviderInstallListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.gms.security.ProviderInstaller.ProviderInstallListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IProviderInstallListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onProviderInstallFailed_ILandroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnProviderInstallFailed_ILandroid_content_Intent_Handler ()
			{
				if (cb_onProviderInstallFailed_ILandroid_content_Intent_ == null)
					cb_onProviderInstallFailed_ILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnProviderInstallFailed_ILandroid_content_Intent_);
				return cb_onProviderInstallFailed_ILandroid_content_Intent_;
			}

			static void n_OnProviderInstallFailed_ILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Android.Gms.Security.ProviderInstaller.IProviderInstallListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Security.ProviderInstaller.IProviderInstallListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnProviderInstallFailed (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onProviderInstallFailed_ILandroid_content_Intent_;
			public unsafe void OnProviderInstallFailed (int p0, global::Android.Content.Intent p1)
			{
				if (id_onProviderInstallFailed_ILandroid_content_Intent_ == IntPtr.Zero)
					id_onProviderInstallFailed_ILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onProviderInstallFailed", "(ILandroid/content/Intent;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_onProviderInstallFailed_ILandroid_content_Intent_, __args);
			}

			static Delegate cb_onProviderInstalled;
#pragma warning disable 0169
			static Delegate GetOnProviderInstalledHandler ()
			{
				if (cb_onProviderInstalled == null)
					cb_onProviderInstalled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnProviderInstalled);
				return cb_onProviderInstalled;
			}

			static void n_OnProviderInstalled (IntPtr jnienv, IntPtr native__this)
			{
				global::Android.Gms.Security.ProviderInstaller.IProviderInstallListener __this = global::Java.Lang.Object.GetObject<global::Android.Gms.Security.ProviderInstaller.IProviderInstallListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnProviderInstalled ();
			}
#pragma warning restore 0169

			IntPtr id_onProviderInstalled;
			public unsafe void OnProviderInstalled ()
			{
				if (id_onProviderInstalled == IntPtr.Zero)
					id_onProviderInstalled = JNIEnv.GetMethodID (class_ref, "onProviderInstalled", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onProviderInstalled);
			}

		}

		public partial class ProviderInstallFailedEventArgs : global::System.EventArgs {

			public ProviderInstallFailedEventArgs (int p0, global::Android.Content.Intent p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			global::Android.Content.Intent p1;
			public global::Android.Content.Intent P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/gms/security/ProviderInstaller_ProviderInstallListenerImplementor")]
		internal sealed partial class IProviderInstallListenerImplementor : global::Java.Lang.Object, IProviderInstallListener {

			object sender;

			public IProviderInstallListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/android/gms/security/ProviderInstaller_ProviderInstallListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ProviderInstallFailedEventArgs> OnProviderInstallFailedHandler;
#pragma warning restore 0649

			public void OnProviderInstallFailed (int p0, global::Android.Content.Intent p1)
			{
				var __h = OnProviderInstallFailedHandler;
				if (__h != null)
					__h (sender, new ProviderInstallFailedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler OnProviderInstalledHandler;
#pragma warning restore 0649

			public void OnProviderInstalled ()
			{
				var __h = OnProviderInstalledHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IProviderInstallListenerImplementor value)
			{
				return value.OnProviderInstallFailedHandler == null && value.OnProviderInstalledHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/security/ProviderInstaller", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProviderInstaller); }
		}

		protected ProviderInstaller (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.gms.security']/class[@name='ProviderInstaller']/constructor[@name='ProviderInstaller' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProviderInstaller ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ProviderInstaller)) {
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

		static IntPtr id_installIfNeeded_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.security']/class[@name='ProviderInstaller']/method[@name='installIfNeeded' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("installIfNeeded", "(Landroid/content/Context;)V", "")]
		public static unsafe void InstallIfNeeded (global::Android.Content.Context p0)
		{
			if (id_installIfNeeded_Landroid_content_Context_ == IntPtr.Zero)
				id_installIfNeeded_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "installIfNeeded", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_installIfNeeded_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_installIfNeededAsync_Landroid_content_Context_Lcom_google_android_gms_security_ProviderInstaller_ProviderInstallListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.gms.security']/class[@name='ProviderInstaller']/method[@name='installIfNeededAsync' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.google.android.gms.security.ProviderInstaller.ProviderInstallListener']]"
		[Register ("installIfNeededAsync", "(Landroid/content/Context;Lcom/google/android/gms/security/ProviderInstaller$ProviderInstallListener;)V", "")]
		public static unsafe void InstallIfNeededAsync (global::Android.Content.Context p0, global::Android.Gms.Security.ProviderInstaller.IProviderInstallListener p1)
		{
			if (id_installIfNeededAsync_Landroid_content_Context_Lcom_google_android_gms_security_ProviderInstaller_ProviderInstallListener_ == IntPtr.Zero)
				id_installIfNeededAsync_Landroid_content_Context_Lcom_google_android_gms_security_ProviderInstaller_ProviderInstallListener_ = JNIEnv.GetStaticMethodID (class_ref, "installIfNeededAsync", "(Landroid/content/Context;Lcom/google/android/gms/security/ProviderInstaller$ProviderInstallListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_installIfNeededAsync_Landroid_content_Context_Lcom_google_android_gms_security_ProviderInstaller_ProviderInstallListener_, __args);
			} finally {
			}
		}

	}
}
