// DO NOT EDIT! This is an autogenerated file. All changes will be
// overwritten!

//	Copyright (c) 2016 Vidyo, Inc. All rights reserved.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;

namespace VidyoClient
{
	public class ConnectorPKG{

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoConnectorInitializeNative();

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoConnectorSetExperimentalOptionsNative([MarshalAs(UnmanagedType.LPStr)]String options);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoConnectorUninitializeNative();

		public static Boolean Initialize(){

			Boolean ret = VidyoConnectorInitializeNative();

			return ret;
		}
		public static Boolean SetExperimentalOptions(String options){

			Boolean ret = VidyoConnectorSetExperimentalOptionsNative(options);

			return ret;
		}
		public static void Uninitialize(){

			VidyoConnectorUninitializeNative();
		}
#if __ANDROID__
		internal static IntPtr javaClassHandle;
		internal static IntPtr javaClassRef;
		static IntPtr javaMethodRef;
		public static void SetApplicationUIContext(Android.App.Activity context)
		{
			javaClassRef = Android.Runtime.JNIEnv.FindClass("com/vidyo/VidyoClient/Connector/Connector", ref javaClassHandle);
			javaMethodRef = Android.Runtime.JNIEnv.GetStaticMethodID(javaClassRef, "SetApplicationUIContext", "(Landroid/app/Activity;)V");
			Android.Runtime.JNIEnv.CallStaticVoidMethod(javaClassRef, javaMethodRef, new Android.Runtime.JValue(context));
		}
#endif
	};
}
