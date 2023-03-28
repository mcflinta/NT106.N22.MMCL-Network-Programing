using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        UdpClient client;
        IPEndPoint endPoint;

        private void btnSend_Click(object sender, EventArgs e)
        {
            int serverPort = int.Parse(tbServerPort.Text);
            int clientPort = int.Parse(tbClientPort.Text);
            string hostName = tbHostName.Text;
            string msg = string.Format("{0}.{1}.{2}", clientPort, hostName, tbMsg.Text.Trim());
            byte[] buffer = Encoding.UTF8.GetBytes(msg);
            client.Send(buffer, buffer.Length, hostName, serverPort);
            endPoint = new IPEndPoint(IPAddress.Any, 0);
            buffer = client.Receive(ref endPoint);
            msg = Encoding.UTF8.GetString(buffer);
            WriteLog(msg);
        }
        private void WriteLog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate
            {
                tbLog.Text += string.Format("Sever Responed : {0}.{1}", msg, Environment.NewLine);
                tbMsg.Text = string.Empty;
            });

            this.BeginInvoke(invoker);
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            int clientPort = int.Parse(tbClientPort.Text);
            client = new UdpClient(clientPort);

            btnCreateClient.Enabled = tbClientPort.Enabled = tbHostName.Enabled = tbServerPort.Enabled = false;
            btnSend.Enabled = true;
        }
    }
}
