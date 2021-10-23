using DAL_TestSystem;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDesignerDLL;

namespace TestServer
{
    public partial class FormEnterServer : Form
    {
        Socket listenSocket;
        CancellationToken ct;
        CancellationTokenSource tokenSource;
        CancellationToken ctReceive;
        CancellationTokenSource tokenSourceReceive;
        GenericUnitOfWork work;

        public FormEnterServer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            work = new GenericUnitOfWork(new Context(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
            IGenericRepository<User> repUser = work.Repository<User>();
            User user = new User() { Login = textBoxLogin.Text, Password = textBoxPassWord.Text };
            User tmpUser = null;
            tmpUser = repUser.FindAll(x => x.Login == user.Login && x.Password == user.Password).FirstOrDefault();
            if (tmpUser != null&&tmpUser.IsAdmin==true)
            {
                textBoxLogin.Text = null;
                textBoxPassWord.Text = null;
                FormTestServer formTestServer = new FormTestServer(tmpUser);
                formTestServer.Show();

                listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPHostEntry iPHostEntry = Dns.GetHostEntry("localhost");
                IPAddress iPAddress = iPHostEntry.AddressList[1];
                int port = Convert.ToInt32(33000);
                IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, port);
                listenSocket.Bind(iPEndPoint);
                tokenSource = new CancellationTokenSource();
                ct = tokenSource.Token;

                Task.Run(() =>
                {
                    listenSocket.Listen(2);
                    while (true)
                    {
                        if (ct.IsCancellationRequested)
                        {
                            return;
                        }
                        try
                        {
                            Socket clientSocket = listenSocket.Accept();
                            Info info = new Info()
                            {
                                RemoteEndPoint = clientSocket.RemoteEndPoint.ToString(),
                                ClientSocket = clientSocket,
                            };
                            //MessageBox.Show(info.RemoteEndPoint);
                            tokenSourceReceive = new CancellationTokenSource();
                            ctReceive = tokenSourceReceive.Token;
                            Task.Run(() =>
                            {
                                ctReceive.ThrowIfCancellationRequested();
                                while (true)
                                {
                                    if (ctReceive.IsCancellationRequested)
                                    {
                                        return;
                                    }
                                    Socket receiveSocket = info.ClientSocket;
                                    byte[] receiveByte = new byte[10024];
                                    try
                                    {
                                        receiveSocket.Receive(receiveByte);
                                        User userRecieved;
                                        using (MemoryStream ms = new MemoryStream())
                                        {
                                            BinaryFormatter binf = new BinaryFormatter();
                                            ms.Write(receiveByte, 0, receiveByte.Length);
                                            ms.Seek(0, SeekOrigin.Begin);
                                            userRecieved = (User)binf.Deserialize(ms);
                                        }

                                        Info infoSend = info;
                                        User user1 = repUser.FindAll(x => x.Login == userRecieved.Login && x.Password == userRecieved.Password).FirstOrDefault();

                                        //MessageBox.Show(user1.LName);
                                        if (user1!=null)
                                        {
                                            int UserId = user1.Id;

                                            BinaryFormatter bf = new BinaryFormatter();
                                            byte[] sendByte = new byte[20000];
                                            using (var ms = new MemoryStream())
                                            {
                                                bf.Serialize(ms, UserId);
                                                sendByte = ms.ToArray();
                                            }
                                            infoSend.ClientSocket.Send(sendByte);
                                        }
                                        else
                                        {
                                            int UserId = 0;
                                            BinaryFormatter bf = new BinaryFormatter();
                                            byte[] sendByte = new byte[20000];
                                            using (var ms = new MemoryStream())
                                            {
                                                bf.Serialize(ms, UserId);
                                                sendByte = ms.ToArray();
                                            }
                                            infoSend.ClientSocket.Send(sendByte);
                                        }
                                        //MessageBox.Show("Send user from server");
                                    }
                                    catch
                                    {
                                        return;
                                    }
                                }
                            }, tokenSource.Token
                            );
                        }
                        catch
                        {
                            return;
                        }
                    }
                }, tokenSource.Token);
            }
            else
            {
                MessageBox.Show("You enter wrong data.\nEnter correct data.");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                tokenSource.Cancel();
                tokenSourceReceive.Cancel();
            }
            finally
            {
                work.Dispose();
                listenSocket.Close();
            }
            this.Close();
        }

        private void FormEnterServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                tokenSource.Cancel();
                tokenSourceReceive.Cancel();
            }
            finally
            {
                work.Dispose();
                listenSocket.Close();
            }
        }
    }
}
