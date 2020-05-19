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
            tcpListener = new TcpListener(IPAddress.Any, Int32.Parse(txtProxyPort.Text));
            tcpListener.Start();
            AddMessage("Proxy started on port " + Int32.Parse(txtProxyPort.Text), listBoxLog);
            AddMessage("Buffer size: " + Int32.Parse(txtBufferSize.Text), listBoxLog);
            Console.WriteLine(tcpListener);
            Task.Run(() => ListenForRequests());
            serverStarted = true;
        }

        private void Stop()
        {
            tcpListener.Stop();
            AddMessage("Proxy stopped", listBoxLog);

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
                var buffer = new byte[Int32.Parse(txtBufferSize.Text)];
                int bytesRead;

                bytesRead = clientNs.Read(buffer, 0, buffer.Length);
                clientMs.Write(buffer, 0, bytesRead);

                try
                {
                    //HttpRequest request = HttpRequest.Parse(clientMs.GetBuffer());

                    byte[] bytes = clientMs.GetBuffer();
                    var lines = ReadLines(clientMs.GetBuffer());
                    var body = ReadBody(clientMs.GetBuffer());

                    String header = lines[0];
                    String host = lines[1];
                    String user_agent = lines[2];
                    String accept = lines[3];
                    String accept_language = lines[4];
                    String accept_encoding = lines[5];
                    String dnt = lines[6];
                    String connection = lines[7];
                    String upgrade_insecure_requests = lines[8];

                    if (checkBoxLoggingRequestHeaders.Checked)
                    {
                        AddMessage(header, listBoxLog);
                        AddMessage(host, listBoxLog);
                        AddMessage(accept, listBoxLog);
                        AddMessage(accept_language, listBoxLog);
                        AddMessage(accept_encoding, listBoxLog);
                        AddMessage(connection, listBoxLog);
                        AddMessage(upgrade_insecure_requests, listBoxLog);

                    }
                    if (checkBoxLoggingClient.Checked)
                    {
                        AddMessage(user_agent, listBoxLog);
                    }

                    AddMessage(dnt, listBoxLog);

                    var response = "";
                    if (response == null)
                    {
                        try
                        {
                            ////using (TcpClient serverClient = new TcpClient(request.GetRequestedHost(), 80))
                            //using (NetworkStream serverStream = serverClient.GetStream())
                            //{
                            //    var serverBuffer = new byte[Int32.Parse(txtBufferSize.Text)];
                            //    using (MemoryStream ms = new MemoryStream())
                            //    {
                            //    }
                            //}

                        }
                        catch
                        {

                        }
                    }

                }

                catch (Exception)
                {

                    throw;
                }
            }

        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            listBoxLog.Items.Clear();
        }

        /// <summary>
        /// Support function for parsing message, used for reading all lines
        /// </summary>
        /// <param name="ByteArray">HTTP message object</param>
        /// <returns>List of all lines read in byte[]</returns>
        protected static List<string> ReadLines(byte[] ByteArray)
        {
            List<string> lines = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in ByteArray)
            {
                Console.WriteLine(b);
                if (b == '\n')
                {
                    string line = stringBuilder.ToString();
                    lines.Add(line);
                    stringBuilder.Clear();
                    continue;
                }
                if (b == '\r')
                    continue;
                stringBuilder.Append(Convert.ToChar(b));
            }
            lines.Add(stringBuilder.ToString());
            return lines;
        }

        /// <summary>
        /// Read the body of a HTTP message as byte[]
        /// </summary>
        /// <param name="ByteArray">HTTP message</param>
        /// <returns>Byte[] of the body</returns>
        protected static byte[] ReadBody(byte[] ByteArray)
        {
            StringBuilder sb = new StringBuilder();
            int index = 0;
            for (int i = 0; i < ByteArray.Length; i++)
            {
                if (ByteArray[i] == '\n')
                {
                    string line = sb.ToString();
                    if (line == "")
                    {
                        index = i + 1;
                        break;
                    }
                    sb.Clear();
                    continue;
                }
                if (ByteArray[i] == '\r')
                    continue;
                sb.Append(Convert.ToChar(ByteArray[i]));
            }
            if (index > 0)
            {
                return ByteArray.Skip(index).ToArray();
            }
            return new byte[] { };
        }

    }
}
