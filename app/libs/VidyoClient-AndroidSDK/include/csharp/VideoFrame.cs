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
	public class VideoFrame{
		private IntPtr objPtr; // opaque VidyoVideoFrame reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoVideoFrameConstructCopyNative(IntPtr other);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoVideoFrameDestructNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetDataNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetElapsedTimeNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoVideoFrameGetFormatNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetHeightNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetHeightCbNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetHeightCrNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetHeightYNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetOffsetCbNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetOffsetCrNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetOffsetYNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetPitchCbNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetPitchCrNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetPitchYNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetSizeNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetSizeCbNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetSizeCrNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetSizeYNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetTimestampNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetWidthNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetWidthCbNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetWidthCrNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVideoFrameGetWidthYNative(IntPtr f);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoVideoFrameGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoVideoFrameSetUserDataNative(IntPtr obj, IntPtr userData);

		public VideoFrame(IntPtr other){
			objPtr = VidyoVideoFrameConstructCopyNative(other);
			VidyoVideoFrameSetUserDataNative(objPtr, GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Weak)));
		}
		~VideoFrame(){
			if(objPtr != IntPtr.Zero){
				VidyoVideoFrameSetUserDataNative(objPtr, IntPtr.Zero);
				VidyoVideoFrameDestructNative(objPtr);
			}
		}
		public ulong GetData(){

			ulong ret = VidyoVideoFrameGetDataNative(objPtr);

			return ret;
		}
		public ulong GetElapsedTime(){

			ulong ret = VidyoVideoFrameGetElapsedTimeNative(objPtr);

			return ret;
		}
		public String GetFormat(){

			IntPtr ret = VidyoVideoFrameGetFormatNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public ulong GetHeight(){

			ulong ret = VidyoVideoFrameGetHeightNative(objPtr);

			return ret;
		}
		public ulong GetHeightCb(){

			ulong ret = VidyoVideoFrameGetHeightCbNative(objPtr);

			return ret;
		}
		public ulong GetHeightCr(){

			ulong ret = VidyoVideoFrameGetHeightCrNative(objPtr);

			return ret;
		}
		public ulong GetHeightY(){

			ulong ret = VidyoVideoFrameGetHeightYNative(objPtr);

			return ret;
		}
		public ulong GetOffsetCb(){

			ulong ret = VidyoVideoFrameGetOffsetCbNative(objPtr);

			return ret;
		}
		public ulong GetOffsetCr(){

			ulong ret = VidyoVideoFrameGetOffsetCrNative(objPtr);

			return ret;
		}
		public ulong GetOffsetY(){

			ulong ret = VidyoVideoFrameGetOffsetYNative(objPtr);

			return ret;
		}
		public ulong GetPitchCb(){

			ulong ret = VidyoVideoFrameGetPitchCbNative(objPtr);

			return ret;
		}
		public ulong GetPitchCr(){

			ulong ret = VidyoVideoFrameGetPitchCrNative(objPtr);

			return ret;
		}
		public ulong GetPitchY(){

			ulong ret = VidyoVideoFrameGetPitchYNative(objPtr);

			return ret;
		}
		public ulong GetSize(){

			ulong ret = VidyoVideoFrameGetSizeNative(objPtr);

			return ret;
		}
		public ulong GetSizeCb(){

			ulong ret = VidyoVideoFrameGetSizeCbNative(objPtr);

			return ret;
		}
		public ulong GetSizeCr(){

			ulong ret = VidyoVideoFrameGetSizeCrNative(objPtr);

			return ret;
		}
		public ulong GetSizeY(){

			ulong ret = VidyoVideoFrameGetSizeYNative(objPtr);

			return ret;
		}
		public ulong GetTimestamp(){

			ulong ret = VidyoVideoFrameGetTimestampNative(objPtr);

			return ret;
		}
		public ulong GetWidth(){

			ulong ret = VidyoVideoFrameGetWidthNative(objPtr);

			return ret;
		}
		public ulong GetWidthCb(){

			ulong ret = VidyoVideoFrameGetWidthCbNative(objPtr);

			return ret;
		}
		public ulong GetWidthCr(){

			ulong ret = VidyoVideoFrameGetWidthCrNative(objPtr);

			return ret;
		}
		public ulong GetWidthY(){

			ulong ret = VidyoVideoFrameGetWidthYNative(objPtr);

			return ret;
		}
	};
}
