﻿using System.Runtime.InteropServices;

namespace AimpYouTubeDL.Api.GUI.Structs
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TAIMPUIControlPlacementConstraints
	{
		public int MaxHeight;
		public int MaxWidth;
		public int MinHeight;
		public int MinWidth;
	}
}