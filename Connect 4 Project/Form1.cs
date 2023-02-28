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

namespace Connect_4_Project
{

   
    public partial class Form1 : Form
    {
        client Game_client;
       
        public Form1()
        {
            InitializeComponent();
            Game_client = new client();
           

        }

       

        private void send_button_Click(object sender, EventArgs e)
        {
            try
            {
               Game_client.Send_Massege(this.massegeBox.Text);

            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }


           
        }

       

        private void New_tab_Click(object sender, EventArgs e)
        {
            Thread newTab_thread = new Thread(Game_client.open_tab);
            newTab_thread.Start();
        }

        private void massegeBox_TextChanged(object sender, EventArgs e)
        {
        }
    }

    public class client
    {
        TcpClient tcp_client_player;
        IPAddress severIP;
        int portNumber;
        Socket client_socket;
        NetworkStream client_network_stream;
        StreamWriter client_stream_writer;
        StreamReader client_stream_reader;
        static int Connected_players;


        static client()
        {
            Connected_players = 0;

        }
        public client()
        {
            Connected_players++;
            create_Client("connected" + Connected_players.ToString());
        }
        public void create_Client(string msg)
        {
            tcp_client_player = new TcpClient();
            tcp_client_player.Connect("192.168.1.10", 10024);
            client_network_stream = tcp_client_player.GetStream();
            client_stream_writer = new StreamWriter(client_network_stream);
           // client_stream_reader= new StreamReader(client_network_stream);
            client_stream_writer.AutoFlush= true;

            



        }
        public void Send_Massege(string msg)
        {

            try
            {

                tcp_client_player = new TcpClient();
                tcp_client_player.Connect("192.168.1.10", 10024);
                client_network_stream = tcp_client_player.GetStream();
                client_stream_writer = new StreamWriter(client_network_stream);
              //  client_stream_reader = new StreamReader(client_network_stream);
                client_stream_writer.AutoFlush = true;
                client_stream_writer.WriteLine(msg);
                client_stream_writer.Close();
            }
           catch (Exception e)
            {
                tcp_client_player.Connect("192.168.1.10", 10024);

                client_network_stream = tcp_client_player.GetStream();
                client_stream_writer = new StreamWriter(client_network_stream);


                client_stream_writer.WriteLine(msg);
                client_stream_writer.Close();
            }
        }

        public void open_tab()
        {
            Application.Run(new Form1());
        }
    }
}
