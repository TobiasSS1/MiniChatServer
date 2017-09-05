﻿using System;
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
			TcpListener TCPL = new TcpListener(IPAddress.Loopback, 7070);
			Start();

			while (true)
			{
				using (TcpClient socket = TCPL.AcceptTcpClient())
				using (NetworkStream ns = socket.GetStream())
				using (StreamReader sr = new StreamReader(ns))
				using (StreamWriter sw = new StreamWriter(ns))
				{

					string line = sr.ReadLine();
					Console.WriteLine(line);

					string myLine = Console.ReadLine();
					sw.WriteLine(myLine);

					Console.WriteLine("Client: " + line);

					sw.Flush();

					if (line == "STOP" || myLine == "STOP")
					{
						sw.WriteLine();
						sw.Flush();
					}
				}
			}
		}
	}
}