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
	public class UserStats{
		private IntPtr objPtr; // opaque VidyoUserStats reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoUserStatsGethostNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoUserStatsGetidNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoUserStatsGetlatencyTestStatsNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoUserStatsGetportNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoUserStatsGetroomStatsNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoUserStatsGetroomStatsArrayNative(IntPtr obj, ref int size);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoUserStatsFreeroomStatsArrayNative(IntPtr obj, int size);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoUserStatsGetserviceTypeNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoUserStatsGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoUserStatsSetUserDataNative(IntPtr obj, IntPtr userData);

		public String host;
		public String id;
		public LatencyTestStats latencyTestStats;
		public uint port;
		public List<RoomStats> roomStats;
		public String serviceType;
		public UserStats(IntPtr obj){
			objPtr = obj;

			List<RoomStats> csRoomStats = new List<RoomStats>();
			int nRoomStatsSize = 0;
			IntPtr nRoomStats = VidyoUserStatsGetroomStatsArrayNative(VidyoUserStatsGetroomStatsNative(objPtr), ref nRoomStatsSize);
			int nRoomStatsIndex = 0;
			while (nRoomStatsIndex < nRoomStatsSize) {
				RoomStats csTroomStats = new RoomStats(Marshal.ReadIntPtr(nRoomStats + (nRoomStatsIndex * Marshal.SizeOf(nRoomStats))));
				csRoomStats.Add(csTroomStats);
				nRoomStatsIndex++;
			}

			host = Marshal.PtrToStringAnsi(VidyoUserStatsGethostNative(objPtr));
			id = Marshal.PtrToStringAnsi(VidyoUserStatsGetidNative(objPtr));
			port = VidyoUserStatsGetportNative(objPtr);
			roomStats = csRoomStats;
			serviceType = Marshal.PtrToStringAnsi(VidyoUserStatsGetserviceTypeNative(objPtr));
			VidyoUserStatsFreeroomStatsArrayNative(nRoomStats, nRoomStatsSize);
		}
	};
}
