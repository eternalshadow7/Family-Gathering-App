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
	public class Contact{
		private IntPtr objPtr; // opaque VidyoContact reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoContactGetemailsNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoContactGetemailsArrayNative(IntPtr obj, ref int size);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoContactFreeemailsArrayNative(IntPtr obj, int size);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoContactGetgroupsNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoContactGetgroupsArrayNative(IntPtr obj, ref int size);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoContactFreegroupsArrayNative(IntPtr obj, int size);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoContactGethandleNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoContactGetidNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoContactGetnameNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoContactGetnicknameNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoContactGetphotoNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern ContactPresenceState VidyoContactGetpresenceStateNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoContactGetpresenceStatusNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern ContactSubscriptionState VidyoContactGetpublicationStateNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern ContactSubscriptionState VidyoContactGetsubscriptionStateNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoContactGettelephonesNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoContactGettelephonesArrayNative(IntPtr obj, ref int size);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoContactFreetelephonesArrayNative(IntPtr obj, int size);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoContactGettimestampNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoContactGetUserDataNative(IntPtr obj);

		[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoContactSetUserDataNative(IntPtr obj, IntPtr userData);

		public enum ContactPresenceState{
			ContactpresencestateUnavailable,
			ContactpresencestateDoNotDisturb,
			ContactpresencestateExtendedAway,
			ContactpresencestateAway,
			ContactpresencestateAvailable,
			ContactpresencestateInterestedInChat
		}
		public enum ContactSubscriptionState{
			ContactsubscriptionstateUnavailable,
			ContactsubscriptionstateNotSubscribed,
			ContactsubscriptionstatePreapproved,
			ContactsubscriptionstateAwaitingApproval,
			ContactsubscriptionstateSubscribed
		}
		public class ContactProperty{
			private IntPtr objPtr; // opaque VidyoContactProperty reference.
			public IntPtr GetObjectPtr(){
				return objPtr;
			}
			[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
			private static extern IntPtr VidyoContactPropertyGettypesNative(IntPtr obj);

			[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
			private static extern IntPtr VidyoContactPropertyGettypesArrayNative(IntPtr obj, ref int size);

			[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
			private static extern void VidyoContactPropertyFreetypesArrayNative(IntPtr obj, int size);

			[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
			private static extern IntPtr VidyoContactPropertyGetvalueNative(IntPtr obj);

			[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
			public static extern IntPtr VidyoContactPropertyGetUserDataNative(IntPtr obj);

			[DllImport("libVidyoClient", CallingConvention = CallingConvention.Cdecl)]
			public static extern void VidyoContactPropertySetUserDataNative(IntPtr obj, IntPtr userData);

			public List<String> types;
			public String value;
			public ContactProperty(IntPtr obj){
				objPtr = obj;

				List<String> csTypes = new List<String>();
				int nTypesSize = 0;
				IntPtr nTypes = VidyoContactPropertyGettypesArrayNative(VidyoContactPropertyGettypesNative(objPtr), ref nTypesSize);
				int nTypesIndex = 0;
				while (nTypesIndex < nTypesSize) {
					csTypes.Add(Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(nTypes + (nTypesIndex * Marshal.SizeOf(nTypes)))));
					nTypesIndex++;
				}

				types = csTypes;
				value = Marshal.PtrToStringAnsi(VidyoContactPropertyGetvalueNative(objPtr));
				VidyoContactPropertyFreetypesArrayNative(nTypes, nTypesSize);
			}
		};
		public List<ContactProperty> emails;
		public List<String> groups;
		public String handle;
		public String id;
		public String name;
		public String nickname;
		public String photo;
		public ContactPresenceState presenceState;
		public String presenceStatus;
		public ContactSubscriptionState publicationState;
		public ContactSubscriptionState subscriptionState;
		public List<ContactProperty> telephones;
		public ulong timestamp;
		public Contact(IntPtr obj){
			objPtr = obj;

			List<ContactProperty> csEmails = new List<ContactProperty>();
			int nEmailsSize = 0;
			IntPtr nEmails = VidyoContactGetemailsArrayNative(VidyoContactGetemailsNative(objPtr), ref nEmailsSize);
			int nEmailsIndex = 0;
			while (nEmailsIndex < nEmailsSize) {
				ContactProperty csTemails = new ContactProperty(Marshal.ReadIntPtr(nEmails + (nEmailsIndex * Marshal.SizeOf(nEmails))));
				csEmails.Add(csTemails);
				nEmailsIndex++;
			}

			List<String> csGroups = new List<String>();
			int nGroupsSize = 0;
			IntPtr nGroups = VidyoContactGetgroupsArrayNative(VidyoContactGetgroupsNative(objPtr), ref nGroupsSize);
			int nGroupsIndex = 0;
			while (nGroupsIndex < nGroupsSize) {
				csGroups.Add(Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(nGroups + (nGroupsIndex * Marshal.SizeOf(nGroups)))));
				nGroupsIndex++;
			}

			List<ContactProperty> csTelephones = new List<ContactProperty>();
			int nTelephonesSize = 0;
			IntPtr nTelephones = VidyoContactGettelephonesArrayNative(VidyoContactGettelephonesNative(objPtr), ref nTelephonesSize);
			int nTelephonesIndex = 0;
			while (nTelephonesIndex < nTelephonesSize) {
				ContactProperty csTtelephones = new ContactProperty(Marshal.ReadIntPtr(nTelephones + (nTelephonesIndex * Marshal.SizeOf(nTelephones))));
				csTelephones.Add(csTtelephones);
				nTelephonesIndex++;
			}

			emails = csEmails;
			groups = csGroups;
			handle = Marshal.PtrToStringAnsi(VidyoContactGethandleNative(objPtr));
			id = Marshal.PtrToStringAnsi(VidyoContactGetidNative(objPtr));
			name = Marshal.PtrToStringAnsi(VidyoContactGetnameNative(objPtr));
			nickname = Marshal.PtrToStringAnsi(VidyoContactGetnicknameNative(objPtr));
			photo = Marshal.PtrToStringAnsi(VidyoContactGetphotoNative(objPtr));
			presenceState = VidyoContactGetpresenceStateNative(objPtr);
			presenceStatus = Marshal.PtrToStringAnsi(VidyoContactGetpresenceStatusNative(objPtr));
			publicationState = VidyoContactGetpublicationStateNative(objPtr);
			subscriptionState = VidyoContactGetsubscriptionStateNative(objPtr);
			telephones = csTelephones;
			timestamp = VidyoContactGettimestampNative(objPtr);
			VidyoContactFreetelephonesArrayNative(nTelephones, nTelephonesSize);
			VidyoContactFreegroupsArrayNative(nGroups, nGroupsSize);
			VidyoContactFreeemailsArrayNative(nEmails, nEmailsSize);
		}
	};
}
