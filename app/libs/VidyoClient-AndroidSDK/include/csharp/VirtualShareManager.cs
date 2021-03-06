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
	public class VirtualShareManager{
		private IntPtr objPtr; // opaque VidyoVirtualShareManager reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoVirtualShareManagerConstructCopyNative(IntPtr other);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoVirtualShareManagerDestructNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoVirtualShareManagerLocalMonitorEventNative(IntPtr m, IntPtr endpoint, IntPtr monitor, [MarshalAs(UnmanagedType.I4)]Device.DeviceState state);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoVirtualShareManagerLocalWindowShareEventNative(IntPtr m, IntPtr endpoint, IntPtr windowShare, [MarshalAs(UnmanagedType.I4)]Device.DeviceState state);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoVirtualShareManagerMediaFailedEventNative(IntPtr m, IntPtr endpoint);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoVirtualShareManagerGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoVirtualShareManagerSetUserDataNative(IntPtr obj, IntPtr userData);

		public VirtualShareManager(IntPtr other){
			objPtr = VidyoVirtualShareManagerConstructCopyNative(other);
			VidyoVirtualShareManagerSetUserDataNative(objPtr, GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Weak)));
		}
		~VirtualShareManager(){
			if(objPtr != IntPtr.Zero){
				VidyoVirtualShareManagerSetUserDataNative(objPtr, IntPtr.Zero);
				VidyoVirtualShareManagerDestructNative(objPtr);
			}
		}
		public Boolean LocalMonitorEvent(Endpoint endpoint, LocalMonitor monitor, Device.DeviceState state){

			Boolean ret = VidyoVirtualShareManagerLocalMonitorEventNative(objPtr, (endpoint != null) ? endpoint.GetObjectPtr():IntPtr.Zero, (monitor != null) ? monitor.GetObjectPtr():IntPtr.Zero, state);

			return ret;
		}
		public Boolean LocalWindowShareEvent(Endpoint endpoint, LocalWindowShare windowShare, Device.DeviceState state){

			Boolean ret = VidyoVirtualShareManagerLocalWindowShareEventNative(objPtr, (endpoint != null) ? endpoint.GetObjectPtr():IntPtr.Zero, (windowShare != null) ? windowShare.GetObjectPtr():IntPtr.Zero, state);

			return ret;
		}
		public Boolean MediaFailedEvent(Endpoint endpoint){

			Boolean ret = VidyoVirtualShareManagerMediaFailedEventNative(objPtr, (endpoint != null) ? endpoint.GetObjectPtr():IntPtr.Zero);

			return ret;
		}
	};
}
