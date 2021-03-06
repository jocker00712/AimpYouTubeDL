﻿using AimpYouTubeDL.Api.Core;
using AimpYouTubeDL.Api.FileManager;
using AimpYouTubeDL.Api.FileManager.Enums;
using AimpYouTubeDL.Api.Objects;
using Python.Runtime;
using System.Diagnostics;

namespace AimpYouTubeDL.YouTube
{
	public sealed class YouTubeDLInfo
	{
		public string WebpageUrl { get; set; }
		public string Url { get; set; }
		public double Duration { get; set; }

		public string Title { get; set; }
		public string Album { get; set; }
		public string Thumbnail { get; set; }

		private YouTubeDLInfo() { }

		public void UpdateAimpFileInfo(IAIMPFileInfo fileInfo)
		{
			Trace.WriteLine(nameof(UpdateAimpFileInfo), nameof(YouTubeDLInfo));

			fileInfo.SetValueAsString(PropIdFileInfo.AIMP_FILEINFO_PROPID_FILENAME, Plugin.Scheme + WebpageUrl);
			fileInfo.SetValueAsString(PropIdFileInfo.AIMP_FILEINFO_PROPID_TITLE, Title);
			fileInfo.SetValueAsFloat(PropIdFileInfo.AIMP_FILEINFO_PROPID_DURATION, Duration);
			fileInfo.SetValueAsString(PropIdFileInfo.AIMP_FILEINFO_PROPID_ALBUM, Album);
		}

		public IAIMPFileInfo ToAimpFileInfo()
		{
			var fileInfo = Plugin.Core.CreateObject<IAIMPFileInfo>();
			UpdateAimpFileInfo(fileInfo);
			return fileInfo;
		}

		public static YouTubeDLInfo FromResult(PyDict item, PyDict parent)
		{
			var extractor = GetKey<string>(parent ?? item, "extractor");
			extractor = extractor.Split(':')[0];

			var webpageUrl = GetKey<string>(item, "webpage_url") ?? GetKey<string>(item, "url");
			var url = GetKey<string>(item, "url");
			var duration = GetKey<double?>(item, "duration");

			var title = GetKey<string>(item, "title");
			var uploader = GetKey<string>(item, "uploader");
			var thumbnail = GetKey<string>(item, "thumbnail");

			if (extractor == _extractorYoutube)
			{
				thumbnail = thumbnail?.Replace("/vi_webp/", "/vi/").Replace(".webp", ".jpg");
				var index = thumbnail?.IndexOf('?');
				if (index > 0)
				{
					thumbnail = thumbnail.Substring(0, index.Value);
				}
			}

			if (extractor == _extractorSoundcloud && uploader != null)
			{
				title = $"{uploader} - {title}";
			}

			return new YouTubeDLInfo
			{
				WebpageUrl = webpageUrl,
				Url = url,
				Duration = duration ?? 0,

				Title = title ?? url,
				Album = uploader,
				Thumbnail = thumbnail
			};
		}

		private static T GetKey<T>(PyDict obj, string key)
		{
			if (obj.HasKey(key))
			{
				return obj.GetItem(key).As<T>();
			}
			return default;
		}

		private const string _extractorYoutube = "youtube";
		private const string _extractorSoundcloud = "soundcloud";
	}
}