﻿using AimpYouTubeDL.Api.FileManager;
using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.AlbumArt
{
	[ComImport]
	[Guid("41494D50-4578-416C-6241-727450727632")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionAlbumArtProvider2 : IAIMPExtensionAlbumArtProvider
	{
		[PreserveSig] HRESULT Get2(IAIMPFileInfo FileInfo, IAIMPPropertyList Options, out IAIMPImageContainer Image);
	}
}