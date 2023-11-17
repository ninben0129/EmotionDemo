using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net.Sockets;
using System.Text;
using System.Net;
using UnityEditor;




public class client : MonoBehaviour
{
    [MenuItem("test/client")]
    public static void Main()
    {
        //今回送るHello World!
        string st = "3,2";
        SocketClient(st);
    }


    public static void SocketClient(string st)
    {
        //IPアドレスやポートを設定している。
        IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        IPEndPoint remoteEP = new IPEndPoint(ipAddress, 9999);

        //ソケットを作成
        Socket socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

        //接続する。失敗するとエラーで落ちる。
        socket.Connect(remoteEP);

        //Sendで送信している。
        byte[] msg = Encoding.UTF8.GetBytes(st);
        socket.Send(msg);

        //Receiveで受信している。
        byte[] bytes = new byte[1024];
        int bytesRec = socket.Receive(bytes);
        string data1 = Encoding.UTF8.GetString(bytes, 0, bytesRec);
        Debug.Log(data1);

        //ソケットを終了している。
        socket.Shutdown(SocketShutdown.Both);
        socket.Close();
    }
}
