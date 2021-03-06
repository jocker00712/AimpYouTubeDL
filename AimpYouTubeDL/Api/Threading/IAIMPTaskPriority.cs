﻿using AimpYouTubeDL.Api.Threading.Enums;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.Threading
{
	[ComImport]
	[Guid("41494D50-5461-736B-5072-696F72697479")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPTaskPriority
	{
		[PreserveSig] TaskPriority GetPriority();
	}
}