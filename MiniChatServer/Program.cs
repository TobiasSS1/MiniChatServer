using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniChatServer
{
	class Program
	{
		static void Main(string[] args)
		{
			Start();
		}

		public static void Start()
		{
			Server MyServer = new Server();

			MyServer.Start();

			Console.ReadLine();
		}
	}
}
