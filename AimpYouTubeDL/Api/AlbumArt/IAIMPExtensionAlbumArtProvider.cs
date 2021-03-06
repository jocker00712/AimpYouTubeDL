﻿using AimpYouTubeDL.Api.AlbumArt.Enums;
using AimpYouTubeDL.Api.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.AlbumArt
{
	[ComImport]
	[Guid("41494D50-4578-7441-6C62-417274507276")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionAlbumArtProvider
	{
		[PreserveSig] HRESULT Get(IAIMPString FileURI, IAIMPString Artist, IAIMPString Album, IAIMPPropertyList Options, out IAIMPImageContainer Image);
		[PreserveSig] AlbumArtCategory GetCategory();
	}
}