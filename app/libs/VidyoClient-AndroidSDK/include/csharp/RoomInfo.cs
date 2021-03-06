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
	public class RoomInfo{
		private IntPtr objPtr; // opaque VidyoRoomInfo reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoRoomInfoGetIsFavoriteNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoRoomInfoGetIsPublicNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRoomInfoGetcreationTimeNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRoomInfoGetdescriptionNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRoomInfoGetidNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRoomInfoGetlanguageNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRoomInfoGetmessageListNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRoomInfoGetmessageListArrayNative(IntPtr obj, ref int size);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoRoomInfoFreemessageListArrayNative(IntPtr obj, int size);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRoomInfoGetnameNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern int VidyoRoomInfoGetnumUsersNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRoomInfoGetownerListNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRoomInfoGetownerListArrayNative(IntPtr obj, ref int size);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoRoomInfoFreeownerListArrayNative(IntPtr obj, int size);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern Room.RoomType VidyoRoomInfoGettypeNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRoomInfoGetuserListNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRoomInfoGetuserListArrayNative(IntPtr obj, ref int size);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoRoomInfoFreeuserListArrayNative(IntPtr obj, int size);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoRoomInfoGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoRoomInfoSetUserDataNative(IntPtr obj, IntPtr userData);

		public Boolean IsFavorite;
		public Boolean IsPublic;
		public ulong creationTime;
		public String description;
		public String id;
		public String language;
		public List<ChatMessage> messageList;
		public String name;
		public int numUsers;
		public List<String> ownerList;
		public Room.RoomType type;
		public List<String> userList;
		public RoomInfo(IntPtr obj){
			objPtr = obj;

			List<ChatMessage> csMessageList = new List<ChatMessage>();
			int nMessageListSize = 0;
			IntPtr nMessageList = VidyoRoomInfoGetmessageListArrayNative(VidyoRoomInfoGetmessageListNative(objPtr), ref nMessageListSize);
			int nMessageListIndex = 0;
			while (nMessageListIndex < nMessageListSize) {
				ChatMessage csTmessageList = new ChatMessage(Marshal.ReadIntPtr(nMessageList + (nMessageListIndex * Marshal.SizeOf(nMessageList))));
				csMessageList.Add(csTmessageList);
				nMessageListIndex++;
			}

			List<String> csOwnerList = new List<String>();
			int nOwnerListSize = 0;
			IntPtr nOwnerList = VidyoRoomInfoGetownerListArrayNative(VidyoRoomInfoGetownerListNative(objPtr), ref nOwnerListSize);
			int nOwnerListIndex = 0;
			while (nOwnerListIndex < nOwnerListSize) {
				csOwnerList.Add(Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(nOwnerList + (nOwnerListIndex * Marshal.SizeOf(nOwnerList)))));
				nOwnerListIndex++;
			}

			List<String> csUserList = new List<String>();
			int nUserListSize = 0;
			IntPtr nUserList = VidyoRoomInfoGetuserListArrayNative(VidyoRoomInfoGetuserListNative(objPtr), ref nUserListSize);
			int nUserListIndex = 0;
			while (nUserListIndex < nUserListSize) {
				csUserList.Add(Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(nUserList + (nUserListIndex * Marshal.SizeOf(nUserList)))));
				nUserListIndex++;
			}

			IsFavorite = VidyoRoomInfoGetIsFavoriteNative(objPtr);
			IsPublic = VidyoRoomInfoGetIsPublicNative(objPtr);
			creationTime = VidyoRoomInfoGetcreationTimeNative(objPtr);
			description = Marshal.PtrToStringAnsi(VidyoRoomInfoGetdescriptionNative(objPtr));
			id = Marshal.PtrToStringAnsi(VidyoRoomInfoGetidNative(objPtr));
			language = Marshal.PtrToStringAnsi(VidyoRoomInfoGetlanguageNative(objPtr));
			messageList = csMessageList;
			name = Marshal.PtrToStringAnsi(VidyoRoomInfoGetnameNative(objPtr));
			numUsers = VidyoRoomInfoGetnumUsersNative(objPtr);
			ownerList = csOwnerList;
			type = VidyoRoomInfoGettypeNative(objPtr);
			userList = csUserList;
			VidyoRoomInfoFreeuserListArrayNative(nUserList, nUserListSize);
			VidyoRoomInfoFreeownerListArrayNative(nOwnerList, nOwnerListSize);
			VidyoRoomInfoFreemessageListArrayNative(nMessageList, nMessageListSize);
		}
	};
}
