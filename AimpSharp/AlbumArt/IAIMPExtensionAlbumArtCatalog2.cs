﻿using AimpSharp.FileManager;
using AimpSharp.Objects;
using System;
using System.Runtime.InteropServices;

namespace AimpSharp.AlbumArt
{
	[ComImport]
	[Guid("41494D50-4578-416C-6241-727443617432")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IAIMPExtensionAlbumArtCatalog2 : IAIMPExtensionAlbumArtCatalog
	{
		[PreserveSig] HRESULT Show2(IAIMPFileInfo FileInfo, out IAIMPImageContainer Image);
	}
}