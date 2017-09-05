using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniChatClient
{
	class Program
	{
		static void Main(string[] args)
		{
			Start();	
		}

		public static void Start()
		{
			Client MyClient = new Client();

			MyClient.Start();

			Console.ReadLine();
		}
	}
}
