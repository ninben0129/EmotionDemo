using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net.Sockets;
using System.Text;
using System.Net;
using UnityEngine.UI;
using TMPro;
public class ScenarioClient : MonoBehaviour
{
    private Animator _animator;
    private Text _eText;
    private Text _lText;
    private Text _sText;
    private Text _pText;
    [SerializeField] private TextMeshProUGUI Scenario1;
    [SerializeField] private TextMeshProUGUI Scenario2;
    [SerializeField] private TextMeshProUGUI Scenario3;
    private static readonly int Trans = Animator.StringToHash("trans");
    private static readonly int Level = Animator.StringToHash("level");
    private static readonly int Scenario = Animator.StringToHash("scenario");
    private static readonly int Person = Animator.StringToHash("person");
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Send()
    {
        int person=_animator.GetInteger(Person);
        int trans = _animator.GetInteger(Trans);
        string target = person.ToString() + "," + trans.ToString();
        string answer = SocketClient(target);
        string[] scenarios = answer.Split(',');
        Scenario1.text = scenarios[0];
        Scenario2.text = scenarios[1];
        Scenario3.text = scenarios[2];
        
    }
    
    public static String SocketClient(string st)
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
        

        //ソケットを終了している。
        socket.Shutdown(SocketShutdown.Both);
        socket.Close();

        return data1;
    }
}
