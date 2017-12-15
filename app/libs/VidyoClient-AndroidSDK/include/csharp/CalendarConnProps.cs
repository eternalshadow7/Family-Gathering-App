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
	public class CalendarConnProps{
		private IntPtr objPtr; // opaque VidyoCalendarConnProps reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern CalendarConnectParamType VidyoCalendarConnPropsGetconnPropTypeNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoCalendarConnPropsGetconnPropValueNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoCalendarConnPropsGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoCalendarConnPropsSetUserDataNative(IntPtr obj, IntPtr userData);

		public enum CalendarConnectParamType{
			CalendarconnectparamtypeUnknown,
			CalendarconnectparamtypeUserId,
			CalendarconnectparamtypePasswordToken,
			CalendarconnectparamtypeMailbox,
			CalendarconnectparamtypeServerAddress
		}
		public CalendarConnectParamType connPropType;
		public String connPropValue;
		public CalendarConnProps(IntPtr obj){
			objPtr = obj;

			connPropType = VidyoCalendarConnPropsGetconnPropTypeNative(objPtr);
			connPropValue = Marshal.PtrToStringAnsi(VidyoCalendarConnPropsGetconnPropValueNative(objPtr));
		}
	};
}