using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace MiniChatClient
{
	public class Client
	{
		public Client()
		{

		}

		public void Start()
		{

			Console.WriteLine("Client");

			while (true)
			{
				using (TcpClient socket = new TcpClient("localhost", 7070))
				using (NetworkStream ns = socket.GetStream())
				using (StreamReader sr = new StreamReader(ns))
				using (StreamWriter sw = new StreamWriter(ns))
				{

					string myLine = Console.ReadLine();
					sw.WriteLine(myLine);
					sw.Flush();

					string line = sr.ReadLine();
					Console.WriteLine("Server: " + line);

					if (myLine == "STOP")
					{
						break;
					}

				}
			}
		}

		public void DoClient()
		{

		}
	}
}
