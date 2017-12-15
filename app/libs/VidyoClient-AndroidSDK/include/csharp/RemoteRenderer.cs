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
	public class RemoteRenderer{
		private IntPtr objPtr; // opaque VidyoRemoteRenderer reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteRendererConstructCopyNative(IntPtr other);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoRemoteRendererDestructNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteRendererGetIdNative(IntPtr r);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteRendererGetNameNative(IntPtr r);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoRemoteRendererGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoRemoteRendererSetUserDataNative(IntPtr obj, IntPtr userData);

		public RemoteRenderer(IntPtr other){
			objPtr = VidyoRemoteRendererConstructCopyNative(other);
			VidyoRemoteRendererSetUserDataNative(objPtr, GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Weak)));
		}
		~RemoteRenderer(){
			if(objPtr != IntPtr.Zero){
				VidyoRemoteRendererSetUserDataNative(objPtr, IntPtr.Zero);
				VidyoRemoteRendererDestructNative(objPtr);
			}
		}
		public String GetId(){

			IntPtr ret = VidyoRemoteRendererGetIdNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public String GetName(){

			IntPtr ret = VidyoRemoteRendererGetNameNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
	};
}