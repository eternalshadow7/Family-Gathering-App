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
	public class Meeting{
		private IntPtr objPtr; // opaque VidyoMeeting reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoMeetingAddAttendeeNative(IntPtr m, IntPtr a);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingConstructCopyNative(IntPtr other);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoMeetingDestructNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoMeetingGetAttendeesNative(IntPtr m, IntPtr a);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoMeetingGetAttendeesByRoleNative(IntPtr m, IntPtr a, [MarshalAs(UnmanagedType.I4)]MeetingAttendee.AttendeeParticipationRole r);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetBodyNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetEndDateTimeNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetIdNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetLocationNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetOwnerEmailNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetOwnerNameNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetStartDateTimeNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetSubjectNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern MeetingType VidyoMeetingGetTypeNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetVidyoMeetingRoomIdNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoMeetingRemoveAttendeeNative(IntPtr m, IntPtr a);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoMeetingRespondToInviteNative(IntPtr m, IntPtr a, [MarshalAs(UnmanagedType.I4)]MeetingAttendee.AttendeeParticipationStatus s);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingRetrieveBodyNative(IntPtr m);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoMeetingGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoMeetingSetUserDataNative(IntPtr obj, IntPtr userData);

		public class MeetingFeedback{
			private IntPtr objPtr; //opaque VidyoMeetingFeedback reference.
			public IntPtr GetObjectPtr(){
				return objPtr;
			}
		};
		public Meeting(IntPtr other){
			objPtr = VidyoMeetingConstructCopyNative(other);
			VidyoMeetingSetUserDataNative(objPtr, GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Weak)));
		}
		~Meeting(){
			if(objPtr != IntPtr.Zero){
				VidyoMeetingSetUserDataNative(objPtr, IntPtr.Zero);
				VidyoMeetingDestructNative(objPtr);
			}
		}
		public Boolean AddAttendee(MeetingAttendee a){

			Boolean ret = VidyoMeetingAddAttendeeNative(objPtr, (a != null) ? a.GetObjectPtr():IntPtr.Zero);

			return ret;
		}
		public Boolean GetAttendees(List<MeetingAttendee> a){

			IntPtr nA = IntPtr.Zero;

			Boolean ret = VidyoMeetingGetAttendeesNative(objPtr, nA);

			return ret;
		}
		public Boolean GetAttendeesByRole(List<MeetingAttendee> a, MeetingAttendee.AttendeeParticipationRole r){

			IntPtr nA = IntPtr.Zero;

			Boolean ret = VidyoMeetingGetAttendeesByRoleNative(objPtr, nA, r);

			return ret;
		}
		public String GetBody(){

			IntPtr ret = VidyoMeetingGetBodyNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public String GetEndDateTime(){

			IntPtr ret = VidyoMeetingGetEndDateTimeNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public String GetId(){

			IntPtr ret = VidyoMeetingGetIdNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public String GetLocation(){

			IntPtr ret = VidyoMeetingGetLocationNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public String GetOwnerEmail(){

			IntPtr ret = VidyoMeetingGetOwnerEmailNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public String GetOwnerName(){

			IntPtr ret = VidyoMeetingGetOwnerNameNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public String GetStartDateTime(){

			IntPtr ret = VidyoMeetingGetStartDateTimeNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public String GetSubject(){

			IntPtr ret = VidyoMeetingGetSubjectNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public MeetingType GetType(){

			MeetingType ret = VidyoMeetingGetTypeNative(objPtr);

			return ret;
		}
		public String GetVidyoMeetingRoomId(){

			IntPtr ret = VidyoMeetingGetVidyoMeetingRoomIdNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
		public Boolean RemoveAttendee(MeetingAttendee a){

			Boolean ret = VidyoMeetingRemoveAttendeeNative(objPtr, (a != null) ? a.GetObjectPtr():IntPtr.Zero);

			return ret;
		}
		public Boolean RespondToInvite(MeetingAttendee a, MeetingAttendee.AttendeeParticipationStatus s){

			Boolean ret = VidyoMeetingRespondToInviteNative(objPtr, (a != null) ? a.GetObjectPtr():IntPtr.Zero, s);

			return ret;
		}
		public String RetrieveBody(){

			IntPtr ret = VidyoMeetingRetrieveBodyNative(objPtr);

			return Marshal.PtrToStringAnsi(ret);
		}
	};
}
