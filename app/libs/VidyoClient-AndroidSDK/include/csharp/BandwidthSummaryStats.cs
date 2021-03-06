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
	public class BandwidthSummaryStats{
		private IntPtr objPtr; // opaque VidyoBandwidthSummaryStats reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoBandwidthSummaryStatsGetactualEncoderBitRateNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoBandwidthSummaryStatsGetavailableBandwidthNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoBandwidthSummaryStatsGetleakyBucketDelayNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoBandwidthSummaryStatsGetretransmitBitRateNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoBandwidthSummaryStatsGettargetEncoderBitRateNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoBandwidthSummaryStatsGettotalTransmitBitRateNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoBandwidthSummaryStatsGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoBandwidthSummaryStatsSetUserDataNative(IntPtr obj, IntPtr userData);

		public uint actualEncoderBitRate;
		public uint availableBandwidth;
		public uint leakyBucketDelay;
		public uint retransmitBitRate;
		public uint targetEncoderBitRate;
		public uint totalTransmitBitRate;
		public BandwidthSummaryStats(IntPtr obj){
			objPtr = obj;

			actualEncoderBitRate = VidyoBandwidthSummaryStatsGetactualEncoderBitRateNative(objPtr);
			availableBandwidth = VidyoBandwidthSummaryStatsGetavailableBandwidthNative(objPtr);
			leakyBucketDelay = VidyoBandwidthSummaryStatsGetleakyBucketDelayNative(objPtr);
			retransmitBitRate = VidyoBandwidthSummaryStatsGetretransmitBitRateNative(objPtr);
			targetEncoderBitRate = VidyoBandwidthSummaryStatsGettargetEncoderBitRateNative(objPtr);
			totalTransmitBitRate = VidyoBandwidthSummaryStatsGettotalTransmitBitRateNative(objPtr);
		}
	};
}
