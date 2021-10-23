using DAL_TestSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TestDesignerDLL
{
    public class Info : IDisposable
    {
        public Socket ClientSocket { get; set; }
        public string RemoteEndPoint { get; set; }
        public User MyUser { get; set; }

        public void Dispose()
        {
            if (ClientSocket == null)
            {
                ClientSocket.Close();
            }
        }

        public override string ToString()
        {
            return RemoteEndPoint;
        }
    }
}
