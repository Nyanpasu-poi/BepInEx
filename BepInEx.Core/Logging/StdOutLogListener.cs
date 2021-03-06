﻿using BepInEx.Logging;
using UnityInjector.ConsoleUtil;

namespace BepInEx.Core.Logging
{
	/// <summary>
	/// Logs entries to StdOut, for platforms that spawn a console instance and hijack the original output stream.
	/// </summary>
	public class StdOutLogListener : ILogListener
	{
		public void LogEvent(object sender, LogEventArgs eventArgs)
		{
			string log = $"[{eventArgs.Level,-7}:{((ILogSource)sender).SourceName,10}] {eventArgs.Data}\r\n";

			ConsoleManager.StandardOutStream?.Write(log);
		}

		public void Dispose() { }
	}
}