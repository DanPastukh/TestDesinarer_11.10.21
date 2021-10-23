using DAL_TestSystem;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TestClient
{
    public partial class FormEnterUser : Form
    {
        Socket sendSocket = null;
        public FormEnterUser()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPHostEntry iPHostEntry = Dns.GetHostEntry("localhost");
            IPAddress iPAddress = iPHostEntry.AddressList[1];
            int port = Convert.ToInt32(33000);
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, port);
            sendSocket.Connect(iPEndPoint);
            
            BinaryFormatter bf = new BinaryFormatter();
            byte[] sendByte = new byte[20000];
            using (var ms = new MemoryStream())
            {
                User userSend = new User() { Login = textBoxLogin.Text, Password = textBoxPassWord.Text };
                bf.Serialize(ms, userSend);
                sendByte = ms.ToArray();
            }
            sendSocket.Send(sendByte);

            //MessageBox.Show("Client");
            int userId = 0;
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Byte[] receiveByte = new byte[20000];
                    sendSocket.Receive(receiveByte);
                    using (var memStream = new MemoryStream())
                    {
                        var binForm = new BinaryFormatter();
                        memStream.Write(receiveByte, 0, receiveByte.Length);
                        memStream.Seek(0, SeekOrigin.Begin);
                        userId=Convert.ToInt32( binForm.Deserialize(memStream));
                    }
                    if (userId != 0)
                    {
                        //MessageBox.Show("No if");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Wrong data. Try another!");
                    }
                   // MessageBox.Show("User null");
                }
                UserTestForm userTestForm = new UserTestForm(userId);
                userTestForm.ShowDialog();
            });
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            sendSocket.Close();
            this.Close();
        }
    }
}
