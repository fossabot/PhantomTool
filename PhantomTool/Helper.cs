﻿using System;
using System.IO;
using Microsoft.Win32;

namespace NekuSoul.PhantomTool
{
	internal static class Helper
	{
		internal static string GetInstallPath()
		{
			const string registryPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Wizards of the Coast\MTGArena";
			const string registryValue = "Path";
			return Registry.GetValue(registryPath, registryValue, null).ToString();
		}

		internal static string GetAppDataPath() => Path.Combine(
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
			"NekuSoul",
			"PhantomTool");
	}
}
