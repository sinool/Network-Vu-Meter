
using System.Text;

using System.Net.Sockets;

using NAudio.CoreAudioApi;

namespace VU_METER;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();   
        MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            ComboBox2.Items.AddRange(devices.ToArray());
            try { ComboBox2.SelectedIndex = 0; }
            catch { } 
           
        
            
                
    
    Timer1.Start();
    

    }
    
    
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Timer1_Tick(object sender, EventArgs e)
        {


    String packet = "L0";
    Socket sock = null;
    System.Net.IPEndPoint endpoint = null;


    sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
    System.Net.IPAddress serverAddr = System.Net.IPAddress.Parse("192.168.4.1");
    endpoint = new System.Net.IPEndPoint(serverAddr, 8080);

             if (ComboBox2.SelectedItem != null)
            {
                var device = (MMDevice)ComboBox2.SelectedItem;
              
             int scale = (int)Math.Round(device.AudioMeterInformation.MasterPeakValue * 100 + 0.5);
                
    
     ProgressBar0.Value=scale;   
    packet = scale.ToString() ;
    
    this.Text=packet;
            
            string text = packet;
            byte[] send_buffer = Encoding.ASCII.GetBytes(text);
            sock.SendTo(send_buffer, endpoint);

            }}
}