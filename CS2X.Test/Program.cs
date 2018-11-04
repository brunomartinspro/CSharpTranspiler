﻿using CS2X.Core;
using CS2X.Core.Emitters;
using System;
using System.IO;

namespace CS2X.Test
{
	class Program
	{
		static void Main(string[] args)
		{
			// load solution
			string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\");
			var solution = new Solution(Path.Combine(path, @"TestApp\TestApp.csproj"));

			// parse solution
			var task = solution.Parse();
			task.Wait();

			// emit solution
			var emitter = new EmitterC(solution, Path.Combine(path, "TestOutput"), EmitterC.CompilerTargets.VCPP, EmitterC.PlatformTypes.Desktop, EmitterC.GCTypes.Micro);
			emitter.Emit(false);
		}
	}
}
