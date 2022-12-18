using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Socket_Client {
    public partial class Form1 : Form {
        private TcpClientEx Client { get; set; }
        private string IPadress = "192.168.hoge.fuga";  //環境に合わせる
        private string soruceIPadress = "192.168.hoge.fuga";
        private string sorcePort = "1023";
        private string destPort = "1024";

        public Form1()
        {
            InitializeComponent();
            try
            {
                // 接続情報有効チェック
                if(!CheckConnectionSettings(destPort, sorcePort, IPadress)) return;
                
                // 接続先IPEndPoint作成
                var remoteEndPoint = new IPEndPoint(IPAddress.Parse(IPadress), int.Parse(destPort));
                
                // 接続元IPEndPoint作成
                var localEndPoint = new IPEndPoint(IPAddress.Parse(soruceIPadress), int.Parse(sorcePort));

                // クライアント作成
                Client = new TcpClientEx(localEndPoint);

                // サーバーに接続
                Client.Client.Connect(remoteEndPoint);

                // 接続ログ出力
                Console.WriteLine("サーバーに接続しました。");

                // データ受信待機開始
                var data = new CommunicationData(Client);
                Client.Socket.BeginReceive(data.Data, 0, data.Data.Length, SocketFlags.None, ReceiveCallback, data);
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                //接続ログ出力
                Console.WriteLine("サーバに接続できませんでした");
            }
        }


        private bool CheckConnectionSettings(string destPort, string sourcePort, string ipAddress)
        {
            // ポート番号空チェック
            if(string.IsNullOrEmpty(destPort) || string.IsNullOrEmpty(sourcePort))
            {
                MessageBox.Show("ポート番号が空です。");
                return false;
            }

            // ポート番号数値チェック
            if(!Regex.IsMatch(destPort, "^[0-9]+$") || !Regex.IsMatch(sourcePort, "^[0-9]+$"))
            {
                MessageBox.Show("ポート番号は数値を指定してください。");
                return false;
            }

            var destPortNum = int.Parse(destPort);
            var sourcePortNum = int.Parse(sourcePort);

            // ポート番号有効値チェック
            if(destPortNum < IPEndPoint.MinPort || IPEndPoint.MaxPort < destPortNum ||
                sourcePortNum < IPEndPoint.MinPort || IPEndPoint.MaxPort < sourcePortNum)
            {
                MessageBox.Show("無効なポート番号が指定されています。");
                return false;
            }

            // IPアドレス有効チェック
            if(!IPAddress.TryParse(ipAddress, out IPAddress _))
            {
                MessageBox.Show("無効なIPアドレスが指定されています。");
                return false;
            }

            return true;
        }

        private void ReceiveCallback(IAsyncResult result)
        {
            try
            {
                // ユーザー定義型のオブジェクト取得
                var data = result.AsyncState as CommunicationData;

                // 切断をクリックしている場合
                if(data.Client.Socket == null) return;

                // サーバーからのデータを受信
                data.Client.Socket?.EndReceive(result);

                // 受信データを出力
                Console.WriteLine($"サーバーからデータ受信<<{data}");

                // 再度サーバーからのデータ受信を待機
                data.Client.Socket.BeginReceive(data.Data, 0, data.Data.Length, SocketFlags.None, ReceiveCallback, data);
            }
            catch(Exception e)
            {
                // 切断ログ出力
                Console.WriteLine("サーバーから切断されました。");
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if(Client != null)
            {
                Client.Client.Close();
                Client.Client.Dispose();
                Client = null;
            }
        }

        private void blueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 送信データを作成
                var data = Encoding.UTF8.GetBytes("0");

                // サーバーにデータを送信
                Client?.Socket.Send(data);

                // 送信ログ出力
                Console.WriteLine($"サーバーにデータ送信>>{Encoding.UTF8.GetString(data)}");
            }
            catch(Exception)
            {
                Console.WriteLine("データ送信に失敗しました。");
            }
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 送信データを作成
                var data = Encoding.UTF8.GetBytes("1");

                // サーバーにデータを送信
                Client?.Socket.Send(data);

                // 送信ログ出力
                Console.WriteLine($"サーバーにデータ送信>>{Encoding.UTF8.GetString(data)}");
            }
            catch(Exception)
            {
                Console.WriteLine("データ送信に失敗しました。");
            }
        }

        private void greenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 送信データを作成
                var data = Encoding.UTF8.GetBytes("2");

                // サーバーにデータを送信
                Client?.Socket.Send(data);

                // 送信ログ出力
                Console.WriteLine($"サーバーにデータ送信>>{Encoding.UTF8.GetString(data)}");
            }
            catch(Exception)
            {
                Console.WriteLine("データ送信に失敗しました。");
            }
        }

        private void yellowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 送信データを作成
                var data = Encoding.UTF8.GetBytes("3");

                // サーバーにデータを送信
                Client?.Socket.Send(data);

                // 送信ログ出力
                Console.WriteLine($"サーバーにデータ送信>>{Encoding.UTF8.GetString(data)}");
            }
            catch(Exception)
            {
                Console.WriteLine("データ送信に失敗しました。");
            }
        }
    }
}
