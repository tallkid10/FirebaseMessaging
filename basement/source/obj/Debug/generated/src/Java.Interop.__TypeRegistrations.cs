using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/google/android/gms/actions",
						"com/google/android/gms/ads/identifier",
						"com/google/android/gms/common",
						"com/google/android/gms/common/api",
						"com/google/android/gms/common/internal",
						"com/google/android/gms/common/internal/safeparcel",
						"com/google/android/gms/common/server",
						"com/google/android/gms/common/server/converter",
						"com/google/android/gms/common/server/response",
						"com/google/android/gms/common/stats",
						"com/google/android/gms/common/util",
						"com/google/android/gms/dynamite/descriptors/com/google/android/gms/flags",
						"com/google/android/gms/iid",
						"com/google/android/gms/location/places",
						"com/google/android/gms/security",
						"com/google/firebase",
					},
					new Converter<string, Type>[]{
						lookup_com_google_android_gms_actions_package,
						lookup_com_google_android_gms_ads_identifier_package,
						lookup_com_google_android_gms_common_package,
						lookup_com_google_android_gms_common_api_package,
						lookup_com_google_android_gms_common_internal_package,
						lookup_com_google_android_gms_common_internal_safeparcel_package,
						lookup_com_google_android_gms_common_server_package,
						lookup_com_google_android_gms_common_server_converter_package,
						lookup_com_google_android_gms_common_server_response_package,
						lookup_com_google_android_gms_common_stats_package,
						lookup_com_google_android_gms_common_util_package,
						lookup_com_google_android_gms_dynamite_descriptors_com_google_android_gms_flags_package,
						lookup_com_google_android_gms_iid_package,
						lookup_com_google_android_gms_location_places_package,
						lookup_com_google_android_gms_security_package,
						lookup_com_google_firebase_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_google_android_gms_actions_mappings;
		static Type lookup_com_google_android_gms_actions_package (string klass)
		{
			if (package_com_google_android_gms_actions_mappings == null) {
				package_com_google_android_gms_actions_mappings = new string[]{
					"com/google/android/gms/actions/ItemListIntents:Android.Gms.Actions.ItemListIntents",
					"com/google/android/gms/actions/NoteIntents:Android.Gms.Actions.NoteIntents",
					"com/google/android/gms/actions/ReserveIntents:Android.Gms.Actions.ReserveIntents",
					"com/google/android/gms/actions/SearchIntents:Android.Gms.Actions.SearchIntents",
				};
			}

			return Lookup (package_com_google_android_gms_actions_mappings, klass);
		}

		static string[] package_com_google_android_gms_ads_identifier_mappings;
		static Type lookup_com_google_android_gms_ads_identifier_package (string klass)
		{
			if (package_com_google_android_gms_ads_identifier_mappings == null) {
				package_com_google_android_gms_ads_identifier_mappings = new string[]{
					"com/google/android/gms/ads/identifier/AdvertisingIdClient:Android.Gms.Ads.Identifier.AdvertisingIdClient",
					"com/google/android/gms/ads/identifier/AdvertisingIdClient$Info:Android.Gms.Ads.Identifier.AdvertisingIdClient/Info",
				};
			}

			return Lookup (package_com_google_android_gms_ads_identifier_mappings, klass);
		}

		static string[] package_com_google_android_gms_common_mappings;
		static Type lookup_com_google_android_gms_common_package (string klass)
		{
			if (package_com_google_android_gms_common_mappings == null) {
				package_com_google_android_gms_common_mappings = new string[]{
					"com/google/android/gms/common/AccountPicker:Android.Gms.Common.AccountPicker",
					"com/google/android/gms/common/ConnectionResult:Android.Gms.Common.ConnectionResult",
					"com/google/android/gms/common/GooglePlayServicesNotAvailableException:Android.Gms.Common.GooglePlayServicesNotAvailableException",
					"com/google/android/gms/common/GooglePlayServicesRepairableException:Android.Gms.Common.GooglePlayServicesRepairableException",
					"com/google/android/gms/common/Scopes:Android.Gms.Common.Scopes",
					"com/google/android/gms/common/UserRecoverableException:Android.Gms.Common.UserRecoverableException",
					"com/google/android/gms/common/zzc:Android.Gms.Common.Zzc",
					"com/google/android/gms/common/zze:Android.Gms.Common.Zze",
					"com/google/android/gms/common/zzf:Android.Gms.Common.Zzf",
				};
			}

			return Lookup (package_com_google_android_gms_common_mappings, klass);
		}

		static string[] package_com_google_android_gms_common_api_mappings;
		static Type lookup_com_google_android_gms_common_api_package (string klass)
		{
			if (package_com_google_android_gms_common_api_mappings == null) {
				package_com_google_android_gms_common_api_mappings = new string[]{
					"com/google/android/gms/common/api/CommonStatusCodes:Android.Gms.Common.Apis.CommonStatusCodes",
					"com/google/android/gms/common/api/ResolvingResultCallbacks:Android.Gms.Common.Apis.ResolvingResultCallbacks",
					"com/google/android/gms/common/api/ResultCallbacks:Android.Gms.Common.Apis.ResultCallbacks",
					"com/google/android/gms/common/api/Scope:Android.Gms.Common.Apis.Scope",
					"com/google/android/gms/common/api/Status:Android.Gms.Common.Apis.Statuses",
				};
			}

			return Lookup (package_com_google_android_gms_common_api_mappings, klass);
		}

		static string[] package_com_google_android_gms_common_internal_mappings;
		static Type lookup_com_google_android_gms_common_internal_package (string klass)
		{
			if (package_com_google_android_gms_common_internal_mappings == null) {
				package_com_google_android_gms_common_internal_mappings = new string[]{
					"com/google/android/gms/common/internal/DowngradeableSafeParcel:Android.Gms.Common.Internal.DowngradeableSafeParcel",
				};
			}

			return Lookup (package_com_google_android_gms_common_internal_mappings, klass);
		}

		static string[] package_com_google_android_gms_common_internal_safeparcel_mappings;
		static Type lookup_com_google_android_gms_common_internal_safeparcel_package (string klass)
		{
			if (package_com_google_android_gms_common_internal_safeparcel_mappings == null) {
				package_com_google_android_gms_common_internal_safeparcel_mappings = new string[]{
					"com/google/android/gms/common/internal/safeparcel/AbstractSafeParcelable:Android.Gms.Common.Internal.SafeParcel.AbstractSafeParcelable",
					"com/google/android/gms/common/internal/safeparcel/zzc:Android.Gms.Common.Internal.SafeParcel.Zzc",
				};
			}

			return Lookup (package_com_google_android_gms_common_internal_safeparcel_mappings, klass);
		}

		static string[] package_com_google_android_gms_common_server_mappings;
		static Type lookup_com_google_android_gms_common_server_package (string klass)
		{
			if (package_com_google_android_gms_common_server_mappings == null) {
				package_com_google_android_gms_common_server_mappings = new string[]{
					"com/google/android/gms/common/server/FavaDiagnosticsEntity:Android.Gms.Common.Server.FavaDiagnosticsEntity",
				};
			}

			return Lookup (package_com_google_android_gms_common_server_mappings, klass);
		}

		static string[] package_com_google_android_gms_common_server_converter_mappings;
		static Type lookup_com_google_android_gms_common_server_converter_package (string klass)
		{
			if (package_com_google_android_gms_common_server_converter_mappings == null) {
				package_com_google_android_gms_common_server_converter_mappings = new string[]{
					"com/google/android/gms/common/server/converter/ConverterWrapper:Android.Gms.Common.Server.Converter.ConverterWrapper",
				};
			}

			return Lookup (package_com_google_android_gms_common_server_converter_mappings, klass);
		}

		static string[] package_com_google_android_gms_common_server_response_mappings;
		static Type lookup_com_google_android_gms_common_server_response_package (string klass)
		{
			if (package_com_google_android_gms_common_server_response_mappings == null) {
				package_com_google_android_gms_common_server_response_mappings = new string[]{
					"com/google/android/gms/common/server/response/FastJsonResponse:Android.Gms.Common.Server.Response.FastJsonResponse",
					"com/google/android/gms/common/server/response/FastJsonResponse$Field:Android.Gms.Common.Server.Response.FastJsonResponse/Field",
					"com/google/android/gms/common/server/response/FastSafeParcelableJsonResponse:Android.Gms.Common.Server.Response.FastSafeParcelableJsonResponse",
					"com/google/android/gms/common/server/response/FieldMappingDictionary:Android.Gms.Common.Server.Response.FieldMappingDictionary",
					"com/google/android/gms/common/server/response/FieldMappingDictionary$Entry:Android.Gms.Common.Server.Response.FieldMappingDictionary/Entry",
					"com/google/android/gms/common/server/response/FieldMappingDictionary$FieldMapPair:Android.Gms.Common.Server.Response.FieldMappingDictionary/FieldMapPair",
					"com/google/android/gms/common/server/response/SafeParcelResponse:Android.Gms.Common.Server.Response.SafeParcelResponse",
				};
			}

			return Lookup (package_com_google_android_gms_common_server_response_mappings, klass);
		}

		static string[] package_com_google_android_gms_common_stats_mappings;
		static Type lookup_com_google_android_gms_common_stats_package (string klass)
		{
			if (package_com_google_android_gms_common_stats_mappings == null) {
				package_com_google_android_gms_common_stats_mappings = new string[]{
					"com/google/android/gms/common/stats/ConnectionEvent:Android.Gms.Common.Stats.ConnectionEvent",
					"com/google/android/gms/common/stats/StatsEvent:Android.Gms.Common.Stats.StatsEvent",
					"com/google/android/gms/common/stats/WakeLockEvent:Android.Gms.Common.Stats.WakeLockEvent",
					"com/google/android/gms/common/stats/zzc:Android.Gms.Common.Stats.Zzc",
					"com/google/android/gms/common/stats/zzd:Android.Gms.Common.Stats.Zzd",
					"com/google/android/gms/common/stats/zze:Android.Gms.Common.Stats.Zze",
					"com/google/android/gms/common/stats/zzf:Android.Gms.Common.Stats.Zzf",
				};
			}

			return Lookup (package_com_google_android_gms_common_stats_mappings, klass);
		}

		static string[] package_com_google_android_gms_common_util_mappings;
		static Type lookup_com_google_android_gms_common_util_package (string klass)
		{
			if (package_com_google_android_gms_common_util_mappings == null) {
				package_com_google_android_gms_common_util_mappings = new string[]{
					"com/google/android/gms/common/util/zzc:Android.Gms.Common.Util.Zzc",
					"com/google/android/gms/common/util/zzd:Android.Gms.Common.Util.Zzd",
				};
			}

			return Lookup (package_com_google_android_gms_common_util_mappings, klass);
		}

		static string[] package_com_google_android_gms_dynamite_descriptors_com_google_android_gms_flags_mappings;
		static Type lookup_com_google_android_gms_dynamite_descriptors_com_google_android_gms_flags_package (string klass)
		{
			if (package_com_google_android_gms_dynamite_descriptors_com_google_android_gms_flags_mappings == null) {
				package_com_google_android_gms_dynamite_descriptors_com_google_android_gms_flags_mappings = new string[]{
					"com/google/android/gms/dynamite/descriptors/com/google/android/gms/flags/ModuleDescriptor:Android.Gms.Dynamite.Descriptors.Flags.ModuleDescriptor",
				};
			}

			return Lookup (package_com_google_android_gms_dynamite_descriptors_com_google_android_gms_flags_mappings, klass);
		}

		static string[] package_com_google_android_gms_iid_mappings;
		static Type lookup_com_google_android_gms_iid_package (string klass)
		{
			if (package_com_google_android_gms_iid_mappings == null) {
				package_com_google_android_gms_iid_mappings = new string[]{
					"com/google/android/gms/iid/MessengerCompat:Android.Gms.Iid.MessengerCompat",
				};
			}

			return Lookup (package_com_google_android_gms_iid_mappings, klass);
		}

		static string[] package_com_google_android_gms_location_places_mappings;
		static Type lookup_com_google_android_gms_location_places_package (string klass)
		{
			if (package_com_google_android_gms_location_places_mappings == null) {
				package_com_google_android_gms_location_places_mappings = new string[]{
					"com/google/android/gms/location/places/PlaceReport:Android.Gms.Location.Places.PlaceReport",
				};
			}

			return Lookup (package_com_google_android_gms_location_places_mappings, klass);
		}

		static string[] package_com_google_android_gms_security_mappings;
		static Type lookup_com_google_android_gms_security_package (string klass)
		{
			if (package_com_google_android_gms_security_mappings == null) {
				package_com_google_android_gms_security_mappings = new string[]{
					"com/google/android/gms/security/ProviderInstaller:Android.Gms.Security.ProviderInstaller",
				};
			}

			return Lookup (package_com_google_android_gms_security_mappings, klass);
		}

		static string[] package_com_google_firebase_mappings;
		static Type lookup_com_google_firebase_package (string klass)
		{
			if (package_com_google_firebase_mappings == null) {
				package_com_google_firebase_mappings = new string[]{
					"com/google/firebase/FirebaseApiNotAvailableException:Firebase.FirebaseApiNotAvailableException",
					"com/google/firebase/FirebaseException:Firebase.FirebaseException",
				};
			}

			return Lookup (package_com_google_firebase_mappings, klass);
		}
	}
}
