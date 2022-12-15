using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Socket_Server {

    //通信データクラス
    public class CommunicationData {
        //通信データサイズ最大値
        const int MAX_COMMUNICATION_DATA_SIZE = 5120;

        //通信データバッファ
        public byte[] Data = new byte[MAX_COMMUNICATION_DATA_SIZE];

        //通信クライアント
        public TcpClientEx Client { get; private set; }

        public CommunicationData(TcpClientEx info)
        {
            Client = info;
        }

        //通信データをUTF8でエンコーディングした文字列を取得する
        public override string ToString()
        {
            return Encoding.UTF8.GetString(Data);
        }
    }

    //Activeプロパティを外部から参照できるようにしたTcoListener拡張クラス
    public class TcpListenerEx : TcpListener {
        //  System.Net.Sockets.TcpListener がクライアント接続をアクティブに待機しているかどうかを示す値を取得します。
        //  System.Net.Sockets.TcpListener がアクティブに待機している場合は true。それ以外の場合は false。

        public new bool Active => base.Active;
        public TcpListenerEx(IPEndPoint ep) : base(ep) { }
    }

    /// 接続中クライアントクラス。
    /// TcpClientのSocketプロパティへのアクセスが面倒なのでアクセスを省略するための拡張クラス。

    public class TcpClientEx {
        public EndPoint RemoteEndPoint => Socket.RemoteEndPoint;
        public TcpClient Client { get; private set; }
        public Socket Socket => Client.Client;
        public TcpClientEx(TcpClient client)
        {
            Client = client;
        }

        public TcpClientEx(IPEndPoint ep)
        {
            Client = new TcpClient(ep);
        }
    }
}
