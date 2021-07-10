using System;

namespace OpenWSLDistrosSetup
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Open WSL Distros Setup.");
			Console.WriteLine("Before Starting, Please confirm that PowerShell 6+ Is Installed. If it isn't installed, please go to https://github.com/powershell/powershell/ and download the newest release.");
			Console.WriteLine("Press any key to start part 1 of setup.");
			System.Diagnostics.Process.Start("cmd,exe", "pause");
			System.Diagnostics.Process.Start("cmd.exe", "./setup.bat");
			Console.WriteLine("Part 1 of setup has ");
		}
	}
}
