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
	public class LocalMicrophone{
		private IntPtr objPtr; // opaque VidyoLocalMicrophone reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoLocalMicrophoneAddToLocalSpeakerNative(IntPtr m, IntPtr speaker);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoLocalMicrophoneAddToRemoteSpeakerNative(IntPtr m, IntPtr remoteSpeaker);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLocalMicrophoneConstructCopyNative(IntPtr other);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalMicrophoneDestructNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoLocalMicrophoneDisableDebugRecordingNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoLocalMicrophoneEnableDebugRecordingNative(IntPtr m, [MarshalAs(UnmanagedType.LPStr)]String dir);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoLocalMicrophoneGetAutoGainNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLocalMicrophoneGetIdNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLocalMicrophoneGetNameNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern Device.DeviceAudioSignalType VidyoLocalMicrophoneGetSignalTypeNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoLocalMicrophoneGetVoiceProcessingNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoLocalMicrophoneGetVolumeNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalMicrophoneHideDebugDialogNative(IntPtr microphone);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoLocalMicrophoneIsDebugRecordingEnabledNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoLocalMicrophoneIsPausedNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalMicrophonePauseNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalMicrophonePlayToneNative(IntPtr m, char dtmfTone);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoLocalMicrophoneRemoveFromLocalSpeakerNative(IntPtr m, IntPtr speaker);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoLocalMicrophoneRemoveFromRemoteSpeakerNative(IntPtr m, IntPtr remoteSpeaker);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalMicrophoneResumeNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoLocalMicrophoneSetAutoGainNative(IntPtr m, Boolean autoGain);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoLocalMicrophoneSetEchoCancellationNative(IntPtr m, IntPtr speaker, Boolean isEnable);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoLocalMicrophoneSetSignalTypeNative(IntPtr m, [MarshalAs(UnmanagedType.I4)]Device.DeviceAudioSignalType signalType);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoLocalMicrophoneSetVoiceProcessingNative(IntPtr m, Boolean voiceProcessing);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalMicrophoneSetVolumeNative(IntPtr m, uint volumePercent);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoLocalMicrophoneShowDebugDialogNative(IntPtr microphone);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoLocalMicrophoneGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoLocalMicrophoneSetUserDataNative(IntPtr obj, IntPtr userData);

		public LocalMicrophone(IntPtr other){
			objPtr = VidyoLocalMicrophoneConstructCopyNative(other);
			VidyoLocalMicrophoneSetUserDataNative(objPtr, GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Weak)));
		}
		~LocalMicrophone(){
			if(objPtr != IntPtr.Zero){
				VidyoLocalMicrophoneSetUserDataNative(objPtr, IntPtr.Zero);
				VidyoLocalMicrophoneDestructNative(objPtr);
			}
		}
		public Boolean AddToLocalSpeaker(LocalSpeaker speaker){

			Boolean ret = VidyoLocalMicrophoneAddToLocalSpeakerNative(objPtr, (speaker != null) ? speaker.GetObjectPtr():IntPtr.Zero);

			return ret;
		}
		public Boolean AddToRemoteSpeaker(RemoteSpeaker remoteSpeaker){

			Boolean ret = VidyoLocalMicrophoneAddToRemoteSpeakerNative(objPtr, (remoteSpeaker != null) ? remoteSpeaker.GetObjectPtr():IntPtr.Zero);

			return ret;
		}
		public Boolean DisableDebugRecording(){

			Boolean ret = VidyoLocalMicrophoneDisableDebugRecordingNative(objPtr);

			return ret;
		}
		public Boolean EnableDebugRecording(String dir){

			Boolean ret = VidyoLocalMicrophoneEnableDebugRecordingNative(objPtr, dir);

			return ret;
		}
		public Boolean GetAutoGain(){

			Boolean ret = VidyoLocalMicrophoneGetAutoGainNative(objPtr);

			return ret;
		}
		public String GetId(){

			IntPtr ret = VidyoLocalMicrophoneGetIdNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public String GetName(){

			IntPtr ret = VidyoLocalMicrophoneGetNameNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public Device.DeviceAudioSignalType GetSignalType(){

			Device.DeviceAudioSignalType ret = VidyoLocalMicrophoneGetSignalTypeNative(objPtr);

			return ret;
		}
		public Boolean GetVoiceProcessing(){

			Boolean ret = VidyoLocalMicrophoneGetVoiceProcessingNative(objPtr);

			return ret;
		}
		public uint GetVolume(){

			uint ret = VidyoLocalMicrophoneGetVolumeNative(objPtr);

			return ret;
		}
		public void HideDebugDialog(){

			VidyoLocalMicrophoneHideDebugDialogNative(objPtr);
		}
		public Boolean IsDebugRecordingEnabled(){

			Boolean ret = VidyoLocalMicrophoneIsDebugRecordingEnabledNative(objPtr);

			return ret;
		}
		public Boolean IsPaused(){

			Boolean ret = VidyoLocalMicrophoneIsPausedNative(objPtr);

			return ret;
		}
		public void Pause(){

			VidyoLocalMicrophonePauseNative(objPtr);
		}
		public void PlayTone(char dtmfTone){

			VidyoLocalMicrophonePlayToneNative(objPtr, dtmfTone);
		}
		public Boolean RemoveFromLocalSpeaker(LocalSpeaker speaker){

			Boolean ret = VidyoLocalMicrophoneRemoveFromLocalSpeakerNative(objPtr, (speaker != null) ? speaker.GetObjectPtr():IntPtr.Zero);

			return ret;
		}
		public Boolean RemoveFromRemoteSpeaker(RemoteSpeaker remoteSpeaker){

			Boolean ret = VidyoLocalMicrophoneRemoveFromRemoteSpeakerNative(objPtr, (remoteSpeaker != null) ? remoteSpeaker.GetObjectPtr():IntPtr.Zero);

			return ret;
		}
		public void Resume(){

			VidyoLocalMicrophoneResumeNative(objPtr);
		}
		public Boolean SetAutoGain(Boolean autoGain){

			Boolean ret = VidyoLocalMicrophoneSetAutoGainNative(objPtr, autoGain);

			return ret;
		}
		public Boolean SetEchoCancellation(LocalSpeaker speaker, Boolean isEnable){

			Boolean ret = VidyoLocalMicrophoneSetEchoCancellationNative(objPtr, (speaker != null) ? speaker.GetObjectPtr():IntPtr.Zero, isEnable);

			return ret;
		}
		public Boolean SetSignalType(Device.DeviceAudioSignalType signalType){

			Boolean ret = VidyoLocalMicrophoneSetSignalTypeNative(objPtr, signalType);

			return ret;
		}
		public Boolean SetVoiceProcessing(Boolean voiceProcessing){

			Boolean ret = VidyoLocalMicrophoneSetVoiceProcessingNative(objPtr, voiceProcessing);

			return ret;
		}
		public void SetVolume(uint volumePercent){

			VidyoLocalMicrophoneSetVolumeNative(objPtr, volumePercent);
		}
		public void ShowDebugDialog(){

			VidyoLocalMicrophoneShowDebugDialogNative(objPtr);
		}
	};
}
