﻿using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace PackageResourcesSample.Skia.Tizen
{
	class Program
	{
		static void Main(string[] args)
		{
			var host = new TizenHost(() => new PackageResourcesSample.App(), args);
			host.Run();
		}
	}
}
