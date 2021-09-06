using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Servidor
{
    public partial class Form_Servidor : Form
    {
        public Form_Servidor()
        {
            InitializeComponent();
        }

        SimpleTcpServer Server;
        private void Form_Servidor_Load(object sender, EventArgs e)
        {
            Server = new SimpleTcpServer();
            Server.Delimiter = 0x13;
            Server.StringEncoder = Encoding.UTF8;
            Server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txt_Mensaje.Invoke((MethodInvoker)delegate ()
            {
                string recibido = e.MessageString;
                int led = recibido.Length;
                if(led ==9)
                {
                    LED_ON.Visible = true;
                    LED_OFF.Visible = false;
                    LED2_ON.Visible = false;
                    LED2_OFF.Visible = true;
                }
                else
                {
                    LED_ON.Visible = false;
                    LED_OFF.Visible = true;
                    LED2_ON.Visible = true;
                    LED2_OFF.Visible = false;
                }
            });
        }

        private void Btn_Encender_Click(object sender, EventArgs e)
        {
            txt_Mensaje.Clear();
            txt_Mensaje.Text += "Servidor Activado";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtIP.Text);
            Server.Start(ip, Convert.ToInt32(txtPuerto.Text));
        }

        private void Btn_Apagar_Click(object sender, EventArgs e)
        {
            if (Server.IsStarted) 
            {
                txt_Mensaje.Clear();
                Server.Stop();
                txt_Mensaje.Text += "Servidor Apagado";
            }
        }
    }
}
