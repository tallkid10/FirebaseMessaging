using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Android.Gms.Actions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='ItemListIntents']"
	[global::Android.Runtime.Register ("com/google/android/gms/actions/ItemListIntents", DoNotGenerateAcw=true)]
	public partial class ItemListIntents : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='ItemListIntents']/field[@name='ACTION_ACCEPT_ITEM']"
		[Register ("ACTION_ACCEPT_ITEM")]
		public const string ActionAcceptItem = (string) "com.google.android.gms.actions.ACCEPT_ITEM";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='ItemListIntents']/field[@name='ACTION_APPEND_ITEM_LIST']"
		[Register ("ACTION_APPEND_ITEM_LIST")]
		public const string ActionAppendItemList = (string) "com.google.android.gms.actions.APPEND_ITEM_LIST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='ItemListIntents']/field[@name='ACTION_CREATE_ITEM_LIST']"
		[Register ("ACTION_CREATE_ITEM_LIST")]
		public const string ActionCreateItemList = (string) "com.google.android.gms.actions.CREATE_ITEM_LIST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='ItemListIntents']/field[@name='ACTION_DELETE_ITEM']"
		[Register ("ACTION_DELETE_ITEM")]
		public const string ActionDeleteItem = (string) "com.google.android.gms.actions.DELETE_ITEM";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='ItemListIntents']/field[@name='ACTION_DELETE_ITEM_LIST']"
		[Register ("ACTION_DELETE_ITEM_LIST")]
		public const string ActionDeleteItemList = (string) "com.google.android.gms.actions.DELETE_ITEM_LIST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='ItemListIntents']/field[@name='ACTION_REJECT_ITEM']"
		[Register ("ACTION_REJECT_ITEM")]
		public const string ActionRejectItem = (string) "com.google.android.gms.actions.REJECT_ITEM";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='ItemListIntents']/field[@name='EXTRA_ITEM_NAME']"
		[Register ("EXTRA_ITEM_NAME")]
		public const string ExtraItemName = (string) "com.google.android.gms.actions.extra.ITEM_NAME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='ItemListIntents']/field[@name='EXTRA_ITEM_NAMES']"
		[Register ("EXTRA_ITEM_NAMES")]
		public const string ExtraItemNames = (string) "com.google.android.gms.actions.extra.ITEM_NAMES";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='ItemListIntents']/field[@name='EXTRA_ITEM_QUERY']"
		[Register ("EXTRA_ITEM_QUERY")]
		public const string ExtraItemQuery = (string) "com.google.android.gms.actions.extra.ITEM_QUERY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='ItemListIntents']/field[@name='EXTRA_LIST_NAME']"
		[Register ("EXTRA_LIST_NAME")]
		public const string ExtraListName = (string) "com.google.android.gms.actions.extra.LIST_NAME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.gms.actions']/class[@name='ItemListIntents']/field[@name='EXTRA_LIST_QUERY']"
		[Register ("EXTRA_LIST_QUERY")]
		public const string ExtraListQuery = (string) "com.google.android.gms.actions.extra.LIST_QUERY";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/actions/ItemListIntents", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ItemListIntents); }
		}

		protected ItemListIntents (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
