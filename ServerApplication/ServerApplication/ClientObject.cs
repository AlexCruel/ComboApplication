﻿using ServerApplication.RequestsClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerApplication
{
    public class ClientObject
    {
        public TcpClient client;

        public ClientObject(TcpClient tcpClient)
        {
            client = tcpClient;
        }

        public void Process()
        {
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();
                byte[] data = new byte[256];
                while (true)
                {
                    // Получаем сообщение
                    StringBuilder response = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        response.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);
                    string message = response.ToString();
                    Console.WriteLine(message);

                    // вход 
                    if (message.StartsWith("LoginTo"))
                    {
                        data = Encoding.Unicode.GetBytes(LogIn.LogInTo(message));
                    }

                    stream.Write(data, 0, data.Length);

                    // данные на направл подготовки
                    if (message.StartsWith("GetTD"))
                    {
                        data = Encoding.Unicode.GetBytes(GetFacultySend.GetTD());
                        //
                        //
                        // Отправляем сообщение обратно
                        //  stream.Write(data, 0, data.Length);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
            }
        }
    }
}
