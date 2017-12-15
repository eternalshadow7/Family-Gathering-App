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
	public class ParticipantGenerationStats{
		private IntPtr objPtr; // opaque VidyoParticipantGenerationStats reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoParticipantGenerationStatsGetcameraIdNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoParticipantGenerationStatsGetcameraNameNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoParticipantGenerationStatsGetenabledNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoParticipantGenerationStatsGetframeIntervalNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoParticipantGenerationStatsGetheightNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoParticipantGenerationStatsGetidNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoParticipantGenerationStatsGetnameNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoParticipantGenerationStatsGetpixelRateNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoParticipantGenerationStatsGetwidthNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoParticipantGenerationStatsGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoParticipantGenerationStatsSetUserDataNative(IntPtr obj, IntPtr userData);

		public String cameraId;
		public String cameraName;
		public Boolean enabled;
		public ulong frameInterval;
		public ulong height;
		public String id;
		public String name;
		public ulong pixelRate;
		public ulong width;
		public ParticipantGenerationStats(IntPtr obj){
			objPtr = obj;

			cameraId = Marshal.PtrToStringAnsi(VidyoParticipantGenerationStatsGetcameraIdNative(objPtr));
			cameraName = Marshal.PtrToStringAnsi(VidyoParticipantGenerationStatsGetcameraNameNative(objPtr));
			enabled = VidyoParticipantGenerationStatsGetenabledNative(objPtr);
			frameInterval = VidyoParticipantGenerationStatsGetframeIntervalNative(objPtr);
			height = VidyoParticipantGenerationStatsGetheightNative(objPtr);
			id = Marshal.PtrToStringAnsi(VidyoParticipantGenerationStatsGetidNative(objPtr));
			name = Marshal.PtrToStringAnsi(VidyoParticipantGenerationStatsGetnameNative(objPtr));
			pixelRate = VidyoParticipantGenerationStatsGetpixelRateNative(objPtr);
			width = VidyoParticipantGenerationStatsGetwidthNative(objPtr);
		}
	};
}
