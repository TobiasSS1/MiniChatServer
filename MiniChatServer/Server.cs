using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace MiniChatServer
{
	public class Server
	{

		

		//Constructor
		public Server()
		{

		}

		//Method
		public void Start()
		{
			TcpListener TCPL = new TcpListener(IPAddress.Loopback, 7070);
			 TCPL.Start();
			Console.WriteLine("Server");

				using (TcpClient socket = TCPL.AcceptTcpClient())
				using (NetworkStream ns = socket.GetStream())
				using (StreamReader sr = new StreamReader(ns))
				using (StreamWriter sw = new StreamWriter(ns))
				{
				while (true)
				{

					string line = sr.ReadLine();
					Console.WriteLine("Client: " + line);

					string myLine = Console.ReadLine();
					sw.WriteLine(myLine);
					sw.Flush();

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
