﻿using AimpYouTubeDL.Api.Actions.Enums;
using AimpYouTubeDL.Api.Objects;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Actions
{
	[ComImport]
	[Guid("41494D50-5372-7641-6374-696F6E4D616E")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPServiceActionManager
	{
		[PreserveSig] HRESULT GetByID(IAIMPString ID, out IAIMPAction Action);
		[PreserveSig] int MakeHotkey(ActionHotkeyModifier Modifiers, short Key);
	}
}