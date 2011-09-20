﻿using System;
using System.Net;
using System.Net.Sockets;

namespace d3emu
{
    using System.IO;
    using System.Threading;

    static class Program
    {
        private static Socket m_socket;

        private static Socket m_gameSocket;

        public const byte PrevService = 0xFE;

        static void Main(string[] args)
        {
            m_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            m_socket.Bind(new IPEndPoint(IPAddress.Any, 6666));

            m_socket.Listen(10);

            m_gameSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            m_gameSocket.Bind(new IPEndPoint(IPAddress.Any, 6665));

            m_gameSocket.Listen(10);

            BeginAccept();

            while (true)
            {
                Console.WriteLine("Waiting for connections...");
                var client = m_socket.Accept();
                new Thread(() => new Client(client).Run()).Start();
            }
        }

        private static bool first = true;

        private static NetworkStream m_gameStream;

        private static byte[] m_buffer = new byte[2048];

        private static void BeginAccept()
        {
            m_gameSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private static void BeginRead()
        {
            m_gameStream.BeginRead(m_buffer, 0, m_buffer.Length, new AsyncCallback(ReadCallback), null);
        }

        private static void ReadCallback(IAsyncResult result)
        {
            int received = m_gameStream.EndRead(result);

            if (received > 0)
            {
                byte[] data = new byte[received];
                Array.Copy(m_buffer, data, received);

                Console.WriteLine("Received GS Packet {0} bytes:", received);
                data.PrintHex();

                if (first) // send hardcoded packets after first client packet
                {
                    first = false;
                    new HardcodedGsPackets(m_gameStream);
                }

                using (BinaryReader br = new BinaryReader(new MemoryStream(data)))
                {
                    var size = br.ReadInt32Reversed(); // inclides size of this field as well

                    var opcode = br.ReadUInt16(); // ?

                    Console.WriteLine("Size {0}, opcode? {1:X4}", size, opcode);

                    if (opcode == 0x783C) // movement
                    {
                        // can't seems figure this out yet
                        //var unk4 = br.ReadUInt16();
                        //var unk1 = br.ReadSingle();
                        //var unk3 = br.ReadSingle();
                        //var unk2 = br.ReadSingle();
                        //var x = br.ReadSingle();
                        //var y = br.ReadSingle();
                        //var z = br.ReadSingle();
                        //var o = br.ReadSingle();

                        //Console.WriteLine("Move: {0} {1} {2} {3} {4} {5} {6} {7}", x, y, z, o, unk1, unk2, unk3, unk4);
                    }
                }

                BeginRead();
            }
            else
            {
                Console.WriteLine("Disconnected!");
            }
        }

        private static void AcceptCallback(IAsyncResult result)
        {
            Socket client = m_gameSocket.EndAccept(result);

            m_gameStream = new NetworkStream(client);

            Console.WriteLine("Client connected...");

            BeginRead();
        }
    }
}
