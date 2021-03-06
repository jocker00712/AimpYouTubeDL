﻿namespace AimpYouTubeDL.Api.Core.Enums
{
	public enum FlagsServiceShutdown
	{
		AIMP_SERVICE_SHUTDOWN_FLAGS_HIBERNATE = 0x1,
		AIMP_SERVICE_SHUTDOWN_FLAGS_POWEROFF = 0x2,
		AIMP_SERVICE_SHUTDOWN_FLAGS_SLEEP = 0x3,
		AIMP_SERVICE_SHUTDOWN_FLAGS_REBOOT = 0x4,
		AIMP_SERVICE_SHUTDOWN_FLAGS_LOGOFF = 0x5,
		AIMP_SERVICE_SHUTDOWN_FLAGS_CLOSE_APP = 0x10,
		AIMP_SERVICE_SHUTDOWN_FLAGS_NO_CONFIRM = 0x20,
	}
}