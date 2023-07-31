using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Management;
using System.Linq.Expressions;
using System.Threading;

namespace Monitoring_beban
{
    public partial class Form1 : Form
    {
        private bool isConnected = false, state = false, state2 = false;
        private string portconnect, port;
        private string pilihFile = "";
        private FolderBrowserDialog folderDlg = new FolderBrowserDialog();
        private string kata = "Welcome to this Project ,please Connect your Arduino !";
        private int beban = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = !(timer1.Enabled);//turn off timer 1
            button5.Enabled = !(button5.Enabled);//non-actived button 5
            comboBox2.SelectedIndex = 4;//auto select baud rate to 115200 for default
            toolStripStatusLabel1.Text = kata ;//update toolstripstatuslabel contain
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();                 //to connect Arduino
            }
            else
            {
                disconnectFromArduino();            //to disconnect arduino
            }
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                state = !(state);
                if (state == true)
                {
                    serialPort1.Write("#load1ON\n"); //turn on relay 1
                    guna2ImageButton1.BackColor = Color.LightYellow;//change button color
                    beban++; // beban counter become early value +1 
                }
                else
                {
                    serialPort1.Write("#load1OF\n");//turn off relay 1
                    guna2ImageButton1.BackColor = Color.FromArgb(50, 50, 64);//change button color
                    beban--; // beban counter become early value -1 
                }
            }
        }
        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                state2 = !(state2);
                if (state2 == true)
                {
                    serialPort1.Write("#load2ON\n"); //turn on relay 1
                    guna2ImageButton2.BackColor = Color.LightYellow;//change button color
                    beban++; // beban counter become early value +1 
                }
                else
                {
                    serialPort1.Write("#load2OF\n");//turn off relay 1
                    guna2ImageButton2.BackColor = Color.FromArgb(50, 50, 64);//change button color
                    beban--; // beban counter become early value -1 
                }
            }
        }

        //for auto detect arduino COM port connection

        private void timer1_Tick(object sender, EventArgs e)
        {
            comboBox1.Text = AutodetectArduinoPort(); //Auto detect what com port that arduino is connected to
            port = AutodetectArduinoPort();//Auto detect Arduino's Com port
                if (port != portconnect && isConnected)
                {
                    disconnectFromArduino();            //to disconnect arduino
                    MessageBox.Show("Error recieving data ! Please Check your Arduino Connection !");//exception message
                }
           timer1.Interval = 100;//looping every 0,1 s
        }
        // >>>>>>>>>>>>>>>>>>>>>>>>> Serial Communication function <<<<<<<<<<<<<<<<<<<<<<<
        private string AutodetectArduinoPort() // Add system.Management first to 
        {
            //get item from Win32_SerialPort database
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery); 

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();  //take description of each item that connect to PC's PORT from win32_serialport database
                    string deviceId = item["DeviceID"].ToString();  //take COM port name of each item

                    if (desc.Contains("Arduino Mega"))
                    {
                        return deviceId; //return COM Port name 
                    }
                }
            }
            catch (ManagementException e)
            {
                //do nothing
            }
            return null;
        }
        //Connect Arduino to pc
        private void connectToArduino()
        {
            try
            {
                isConnected =!(isConnected);//change isConnected state
                serialPort1.PortName = comboBox1.Text;//set connected COM Port
                serialPort1.BaudRate = Int32.Parse(comboBox2.Text);//set baudrate
                serialPort1.NewLine = "\n";//set new line
                serialPort1.Open();//open serial port
                button2.Text = "Disconnect"; //change button text
                button2.BackColor = Color.Turquoise; //change button color
                portconnect = comboBox1.Text; //insert connected COM port to port connect variable 
                toolStripStatusLabel1.Text = serialPort1.PortName + "  is  connected.";// update toolstripstatuslabel contain
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "ERROR:  " + ex.Message.ToString();// update toolstripstatuslabel contain
            }
        }
        //disconnected Arduino to pc
        private void disconnectFromArduino()
        {
            isConnected = !(isConnected);//change isConnected state
            comboBox1.Text = AutodetectArduinoPort();//update com port
            portconnect = comboBox1.Text; //insert connected COM port to port connect variable
            serialPort1.Close(); //close serial port
            button2.Text = "Connect"; //change button color
            button2.BackColor = Color.LemonChiffon; //change button color
            textBox1.Text = "";// update text box to empty contain
            toolStripStatusLabel1.Text = serialPort1.PortName + "  is  closed.";//update toolstripstatuslabel contain
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>> Recieve data and show at U/I threat function <<<<<<<<<<<<<<<<<<<<<<<

        private void Port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String data = serialPort1.ReadLine();//Catch serial data from serial port to data variable
            Tampilkan(data); //calling function for U/I threat               
        }

        private delegate void TampilkanDelegate(object data);

        private void Tampilkan(object data)
        {
            if (InvokeRequired)
                // This is a worker thread so delegate the task. 
                listBox1.Invoke(new TampilkanDelegate(Tampilkan), data);
            else
            {
                // This is the UI thread so perform the task. 
                listBox1.Items.Add(data);//Show item from microcontroller in listbox1
                listBox1.SelectedIndex = listBox1.Items.Count - 1; //menselect data baru yang di terima
                splitData(data);//splitting data and update to interface and history's file 
            }
        }
        private void splitData(object data)
        {
            if (!isConnected) // avoid error when reconnect arduino
            {
                data = "@,0,0,0,0,0,0,$\n";
            }
            String[] data1 = data.ToString().Split(',');//convert microcontroller's datas to string and split string into sub string (array)
                //convert string() to float()
                 float[] x = new float[data1.Length]; //initialized float list
                 x[0] = float.Parse(data1[1]);
                 x[1] = float.Parse(data1[2]);
                 x[2] = float.Parse(data1[3]);
                 x[3] = float.Parse(data1[4]);
                 x[4] = float.Parse(data1[5]);
                 x[5] = float.Parse(data1[6]);
                //show datas to interface
                 aquaGauge1.Value = x[0];
                 aquaGauge2.Value = x[1];
                 aquaGauge3.Value = x[2];
                 DigitalMeter1.Value = x[3];
                 DigitalMeter2.Value = x[4];
                 DigitalMeter3.Value = x[5];
                //update datas to data history's file
                 try
                 {
                     TextWriter txt = new StreamWriter(textBox1.Text + "/monitoring data.txt", true);//make file with the following name and configuration for the contain
                     txt.WriteLine(DateTime.Now.ToString());//update date time to that file
                     txt.WriteLine("Votage = " + data1[1] + " Volt");//update voltage datas to that file
                     txt.WriteLine("Current = " + data1[2] + " Ampere");//update current datas to that file
                     txt.WriteLine("Power = " + data1[3] + " Watt");//update power datas to that file
                     txt.WriteLine("Energy = " + data1[4] + " KWh");//update energy datas to that file
                     txt.WriteLine("Frequency = " + data1[5] + " Hz");//update frequensy datas to that file
                     txt.WriteLine("Power Factor = " + data1[6]);//update power factor datas to that file
                     txt.WriteLine("Load actived = " + beban.ToString() );//update number of actived load to that file
                     txt.WriteLine("");//giving enter or new line to that file
                     txt.Close(); //close file.txt
                 }
                 catch (Exception ex)
                 {
                     return ; //do nothing 
                 }

        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>> Saving and Showing History <<<<<<<<<<<<<<<<<<<<<<<<<<<
        //choose history's saving place
        private void button7_Click(object sender, EventArgs e) // Open File location
        {
            folderDlg.ShowNewFolderButton = true; //open pc's explorer by pressing button
            DialogResult result = folderDlg.ShowDialog(); //getting condition from pc's explorer
            if (result == DialogResult.OK) //when you press "ok" button
                textBox1.Text = folderDlg.SelectedPath;//update contain of text box by selected directory
        }
        //choose history's saving file
        private void button10_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pilihFile = openFileDialog1.FileName;// set selected file to pilih file 
                timer2.Enabled = !(timer2.Enabled); // turn on timer 2 
            }
        }
        //Autoupdate history from history's file
        private void timer2_Tick(object sender, EventArgs e)
        {
            string baris;

            listBox2.Items.Clear(); //Clear existance datas in listbox
            TextReader txt = new StreamReader(pilihFile); //read datas from file selected
            while ((baris = txt.ReadLine()) != null)
            {
                listBox2.Items.Add(baris); //Adding item to listbox
            }
            listBox2.SelectedIndex = listBox2.Items.Count - 1; //Select last data in listbox
            timer2.Interval = 5000; // timer loop each 5 seconds
        }
    }
}

/* If you need delay method */

/*// >>>>>>>>>>>>>>>>>>>>>>>> delay method <<<<<<<<<<<<<<<<<<<<<<<
public static DateTime PauseForMilliSeconds(int MilliSecondsToPauseFor)
{


    System.DateTime ThisMoment = System.DateTime.Now;
    System.TimeSpan duration = new System.TimeSpan(0, 0, 0, 0, MilliSecondsToPauseFor);
    System.DateTime AfterWards = ThisMoment.Add(duration);


    while (AfterWards >= ThisMoment)
    {
        System.Windows.Forms.Application.DoEvents();
        ThisMoment = System.DateTime.Now;
    }


    return System.DateTime.Now;
}*/

