using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        UdpClient server;
        IPEndPoint endPoint;

        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new UdpClient(int.Parse(tbServerPort.Text));
            endPoint = new IPEndPoint(IPAddress.Any, 0);
            Thread thr = new Thread(new ThreadStart(ServerStart));
            thr.Start();
            btnStart.Enabled = false;
            btnNew.Enabled = true;
            WriteLog("Action : Server Started Successfully...");
        }
        private void ServerStart()
        {
            // Keep Server Listening

            while (true)
            {
                byte[] buffer = server.Receive(ref endPoint);
                string[] msg = Encoding.UTF8.GetString(buffer).Split('.');
                int clientPort = int.Parse(msg[0]);
                string clientHostName = msg[1];
                string request = msg[2];

                WriteLog(string.Format("Client at Port : {0} at Host : {1} Saay: {2}.", clientPort, clientHostName, request));

                string response = string.Format("Date time at Server : {0}.", DateTime.Now.ToLocalTime());

                buffer = Encoding.UTF8.GetBytes(response);
                server.Send(buffer, buffer.Length, clientHostName, clientPort);

                WriteLog(string.Format("Response Sent to Client at Port : {0} at Host : {1}.", clientPort, clientHostName));
            }
        }
        private void WriteLog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate
            {
                tbLog.Text += string.Format("{0}.{1}", msg, Environment.NewLine);
            });

            this.BeginInvoke(invoker);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }
    }
}
