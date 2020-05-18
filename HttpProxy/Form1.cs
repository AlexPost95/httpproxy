using HttpProxy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpProxy
{
    public partial class Form1 : Form
    {

        private TcpListener tcpListener;
        private bool serverStarted;
        int bufferSize = 1024;
        
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Delegate voor het updaten van de messages in de lijst
        /// </summary>
        /// <param name="message"></param>
        /// <param name="list"></param>
        protected delegate void UpdateDisplayDelegate(string message, ListBox list);

        /// <summary>
        /// Methode om een message aan een lijst toe te voegen
        /// </summary>
        /// <param name="message">De message</param>
        /// <param name="list">Lijst waaraan de message moet worden toegevoegd</param>
        private void AddMessage(string message, ListBox list)
        {
            if (listBoxLog.InvokeRequired)
            {
                listBoxLog.Invoke(new UpdateDisplayDelegate(UpdateDisplay), new object[] { message, list });
            }
            else
            {
                UpdateDisplay(message, list);
            }
        }

        /// <summary>
        /// Methode om een message aan een lijst toe te voegen
        /// </summary>
        /// <param name="message"></param>
        /// <param name="list"></param>
        private void UpdateDisplay(string message, ListBox list)
        {
            list.Items.Add(message);
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (serverStarted == false)
            {
                //call start method if server is not started yet
                Start();
            }
            else
            {
                //call stop method if server has already started
                Stop();
            }
        }

        private void Start()
        {
            tcpListener = new TcpListener(IPAddress.Any, 9000);
            tcpListener.Start();
            Console.WriteLine(tcpListener);
            Task.Run(() => ListenForRequests());
            serverStarted = true;
        }

        private void Stop()
        {
            tcpListener.Stop();
            tcpListener = null;
            serverStarted = false;
        }


        private void ListenForRequests()
        {
            try
            {
                //Let the tcplistener accept clients trying to connect
                TcpClient client = tcpListener.AcceptTcpClient();
                Console.WriteLine(client);
                Task.Run(() => HandleRequest(client));
            }
            catch
            {

                Console.WriteLine("Could not connect to client");
            }
        }

        private async void HandleRequest(TcpClient client)
        {
            using(client)
            using (NetworkStream clientNs = client.GetStream())
            using (MemoryStream clientMs = new MemoryStream())
            {
                Console.WriteLine(clientNs);
                var buffer = new byte[bufferSize];
                int bytesRead;
                Thread.Sleep(5);

                //If the memorystream can read, then
                if (clientNs.CanRead)
                {
                    //If there's data available on the networkstream, then
                    if (clientNs.DataAvailable)
                    {
                        do
                        {
                            //bytesRead = number of bytes read from the networkstream, while data is available
                            bytesRead = clientNs.Read(buffer, 0, buffer.Length);
                            //Fils memorystream with the data while data is available
                            clientMs.Write(buffer, 0, bytesRead);
                            Console.WriteLine(bytesRead);
                        } while (clientNs.DataAvailable);
                    }
                }
                try
                {
                    HttpRequest request = HttpRequest.Parse(clientMs.GetBuffer());
                    Console.WriteLine(request);
                    AddMessage(request.FirstLine, listBoxLog);
                    AddMessage(request.Headers.ToString(), listBoxLog);
                    AddMessage(request.Body.ToString(), listBoxLog);
                }
                catch (Exception)
                {

                    throw;
                }
            }


        }
    }
}
