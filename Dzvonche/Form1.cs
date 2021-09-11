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
using WMPLib;
using sun.tools.java;
using AxWMPLib;
using System.Diagnostics;

namespace Dzvonche
{
    public partial class Form1 : Form
    {
        bool sabota = false;
        String[] paths, files;
        bool isConnected = false;
        String[] ports;
        SerialPort port;
        int x = 1, y = 439,m=0,m1=0;
        int opcii = 0;
        int mode = 1, pp = 1;
        int p1 = 0, p11 = 0, v1 = 0, v11 = 0, t1 = 0, t11 = 0, c1 = 0, c11 = 0, pe1 = 0, pe11 = 0, s1 = 0, s11 = 0, se1 = 0, se11 = 0;
        int vp1 = 0, vp11 = 0, vv1 = 0, vv11 = 0, vt1 = 0, vt11 = 0, vc1 = 0, vc11 = 0, vpe1 = 0, vpe11 = 0, vs1 = 0, vs11 = 0, vse1 = 0, vse11 = 0;
        //casovi prva smena
        TimeSpan prv_p = new TimeSpan(7, 15, 0);
        TimeSpan prv_pm = new TimeSpan(7, 10, 0);
        TimeSpan prv_z = new TimeSpan(8, 0, 0);
        TimeSpan vtor_p = new TimeSpan(8, 5, 0);
        TimeSpan vtor_z = new TimeSpan(8, 50, 0);
        TimeSpan tret_p = new TimeSpan(9, 10, 0);
        TimeSpan tret_z = new TimeSpan(9, 55, 0);
        TimeSpan cetvrt_p = new TimeSpan(10, 0, 0);
        TimeSpan cetvrt_z = new TimeSpan(10, 45, 0);
        TimeSpan pet_p = new TimeSpan(10, 50, 0);
        TimeSpan pet_z = new TimeSpan(11, 35, 0);
        TimeSpan sest_p = new TimeSpan(11, 40, 0);
        TimeSpan sest_z = new TimeSpan(12, 25, 0);
        TimeSpan sedmi_p = new TimeSpan(12, 30, 0);
        TimeSpan sedmi_z = new TimeSpan(13, 15, 0);
        TimeSpan ko = new TimeSpan(7, 15, 0);

        //casovi vtora smena
        TimeSpan vprv_p = new TimeSpan(13, 30, 0);
        TimeSpan vprv_z = new TimeSpan(14, 15, 0);
        TimeSpan vvtor_p = new TimeSpan(14, 20, 0);
        TimeSpan vvtor_z = new TimeSpan(15, 5, 0);
        TimeSpan vtret_p = new TimeSpan(15, 25, 0);
        TimeSpan vtret_z = new TimeSpan(16, 10, 0);

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            vp1 = 0;
            vp11 = 0;
            m = 0;
            m1 = 0;
            vv1 = 0;
            vv11 = 0;
            vt1 = 0;
            vt11 = 0;
            vc1 = 0;
            vc11 = 0;
            vpe1 = 0;
            vpe11 = 0;
            vs1 = 0;
            vs11 = 0;
            vse1 = 0;
            vse11 = 0;
            p1 = 0;
            p11 = 0;
            v1 = 0;
            v11 = 0;
            t1 = 0;
            t11 = 0;
            c1 = 0;
            c11 = 0;
            pe1 = 0;
            pe11 = 0;
            s1 = 0;
            s11 = 0;
            se1 = 0;
            se11 = 0;
            timer1.Start();
        }

        private void s_Click(object sender, EventArgs e)
        {
            x = 1;
            sl.Text = e1.Text;
            e1.Text = "се прикажува соопштение";
            sl.Visible = true;
            timer2.Interval = 1;
            timer2.Start();


        }

        private void settings_Click(object sender, EventArgs e)
        {
            if (opcii == 0)
            {
                s.Visible = true;
                soff.Visible = true;
                e1.Visible = true;
                button1.Visible = true;
                add.Visible = true;
                other.Visible = true;
                kolku.Visible = true;
                min5.Visible = true;
                comboBox1.Visible = true;
                povrzi.Visible = true;
                checkBox1.Visible = true;
                settings.Text = "Сокриј";
                opcii = 1;
            }
            else
            {
                s.Visible = false;
                soff.Visible = false;
                e1.Visible = false;
                button1.Visible = false;
                add.Visible = false;
                other.Visible = false;
                kolku.Visible = false;
                min5.Visible = false;
                comboBox1.Visible = false;
                povrzi.Visible = false;
                checkBox1.Visible = false;
                settings.Text = "Oпции";
                opcii = 0;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sabota = checkBox1.Checked;
        }

        private void soff_Click(object sender, EventArgs e)
        {
            sl.Visible = false;
            e1.Text = "внеси соопштение";
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sl.SetBounds(x, y,1,1);
            x--;
            if(sl.Location.X + sl.Width <= 1360)
            {
                x = 1;
            }
            timer2.Stop();
            timer2.Start();
        }

        TimeSpan vcetvrt_p = new TimeSpan(16, 15, 0);
        TimeSpan vcetvrt_z = new TimeSpan(17, 0, 0);
        TimeSpan vpet_p = new TimeSpan(17, 5, 0);
        TimeSpan vpet_z = new TimeSpan(17, 50, 0);
        TimeSpan vsest_p = new TimeSpan(17, 55, 0);
        TimeSpan vsest_z = new TimeSpan(18, 40, 0);
        TimeSpan vsedmi_p = new TimeSpan(18, 45, 0);
        TimeSpan vsedmi_z = new TimeSpan(19, 30, 0);
        TimeSpan vsedmi_zm = new TimeSpan(19, 35, 0);



        public Form1()
        {
            InitializeComponent();
            //disableControls();
            getAvailableComPorts();

            

            foreach (string port in ports)
            {

                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            //timer1.Start();
          //  timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //  timer.Start();
        }

        delegate void UpdateLable(Label La, string value);
       
        public void status(int cas)
        {
            switch (cas)
            {
                case 1:
                    {
                        raspored.Text = "Прв Час";
                        smena.Text = "Прва смена";
                        break;
                    }
                case 2:
                    {
                        raspored.Text = "Втор Час";
                        smena.Text = "Прва смена";
                        break;
                    }
                case 3:
                    {
                        raspored.Text = "Трет Час";
                        smena.Text = "Прва смена";
                        break;
                    }
                case 4:
                    {
                        raspored.Text = "Четврт Час";
                        smena.Text = "Прва смена";
                        break;
                    }
                case 5:
                    {
                        raspored.Text = "Пети Час";
                        smena.Text = "Прва смена";
                        break;
                    }
                case 6:
                    {
                        raspored.Text = "Шести Час";
                        smena.Text = "Прва смена";
                        break;
                    }
                case 7:
                    {
                        raspored.Text = "Седми Час";
                        smena.Text = "Прва смена";
                        break;
                    }

                case 8:
                    {
                        raspored.Text = "Прв Час";
                        smena.Text = "Втора смена";
                        break;
                    }
                case 9:
                    {
                        raspored.Text = "Втор Час";
                        smena.Text = "Втора смена";
                        break;
                    }
                case 10:
                    {
                        raspored.Text = "Трет Час";
                        smena.Text = "Втора смена";
                        break;
                    }
                case 11:
                    {
                        raspored.Text = "Четврт Час";
                        smena.Text = "Втора смена";
                        break;
                    }
                case 12:
                    {
                        raspored.Text = "Пети Час";
                        smena.Text = "Втора смена";
                        break;
                    }
                case 13:
                    {
                        raspored.Text = "Шести Час";
                        smena.Text = "Втора смена";
                        break;
                    }
                case 14:
                    {
                        raspored.Text = "Седми Час";
                        smena.Text = "Втора смена";
                        break;
                    }
                case 15:
                    {
                        raspored.Text = "Мал одмор";
                        smena.Text = "Прва смена";
                        break;
                    }
                case 16:
                    {
                        raspored.Text = "Мал одмор";
                        smena.Text = "Втора смена";
                        break;
                    }
                case 17:
                    {
                        raspored.Text = "Голем одмор";
                        smena.Text = "Прва смена";
                        break;
                    }
                case 18:
                    {
                        raspored.Text = "Голем одмор";
                        smena.Text = "Втора смена";
                        break;
                    }
                case 20:
                    {
                        raspored.Text = "Добредојдовте";
                        smena.Text = "";
                        break;
                    }

            }
        }    
      
        private void povrzi_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
             //   disconnectFromArduino();
            }
        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
            povrzi.Text = "Исклучи";
            //enableControls();
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
            povrzi.Text = "Connect";
        }
      
        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[lb.SelectedIndex];
        }

   
        private void raspored_Click(object sender, EventArgs e)
        {
            
        }

        
        int mala = -1; //mn = mal odmor kolku trae, golem_odmor= golem odmor, kolku_traat = kolku traat casovite

        private void min5_CheckedChanged(object sender, EventArgs e)
        {
            TimeSpan pet_minuti = new TimeSpan(0, 5, 0);
            TimeSpan deset_minuti = new TimeSpan(0, 2*pet_minuti.Minutes, 0);
            TimeSpan petnaeset_minuti = new TimeSpan(0, 3 * pet_minuti.Minutes, 0);
            TimeSpan dvaeset_minuti = new TimeSpan(0, 4 * pet_minuti.Minutes, 0);
            TimeSpan dvpet_minuti = new TimeSpan(0, 5 * pet_minuti.Minutes, 0);
            TimeSpan trieset_minuti = new TimeSpan(0, 6 * pet_minuti.Minutes, 0);
            TimeSpan tripet_minuti = new TimeSpan(0, 7 * pet_minuti.Minutes, 0);
            //casovi prva smena
            //prv_p = prv_p.Subtract(pet_minuti);
            prv_z = prv_z.Subtract(pet_minuti);
            vtor_p = vtor_p.Subtract(pet_minuti); 
            vtor_z = vtor_z.Subtract(deset_minuti);
            tret_p = tret_p.Subtract(deset_minuti);
            tret_z = tret_z.Subtract(petnaeset_minuti);
            cetvrt_p = cetvrt_p.Subtract(petnaeset_minuti);
            cetvrt_z = cetvrt_z.Subtract(dvaeset_minuti);
            pet_p = pet_p.Subtract(dvaeset_minuti);
            pet_z = pet_z.Subtract(dvpet_minuti);
            sest_p = sest_p.Subtract(dvpet_minuti);
            sest_z = sest_z.Subtract(trieset_minuti);
            sedmi_p = sedmi_p.Subtract(trieset_minuti);
            sedmi_z = sedmi_z.Subtract(tripet_minuti);

            //casovi vtora smena
            //vprv_p = vprv_p.Subtract(pet_minuti);
            vprv_z = vprv_z.Subtract(pet_minuti);
            vvtor_p = vvtor_p.Subtract(pet_minuti);
            vvtor_z = vvtor_z.Subtract(deset_minuti);
            vtret_p = vtret_p.Subtract(deset_minuti);
            vtret_z = vtret_z.Subtract(petnaeset_minuti);
            vcetvrt_p = vcetvrt_p.Subtract(petnaeset_minuti);
            vcetvrt_z = vcetvrt_z.Subtract(dvaeset_minuti);
            vpet_p = vpet_p.Subtract(dvaeset_minuti);
            vpet_z = vpet_z.Subtract(dvpet_minuti);
            vsest_p = vsest_p.Subtract(dvpet_minuti);
            vsest_z = vsest_z.Subtract(trieset_minuti);
            vsedmi_p = vsedmi_p.Subtract(trieset_minuti);
            vsedmi_z = vsedmi_z.Subtract(tripet_minuti);

        }

        private void other_CheckedChanged(object sender, EventArgs e)
        {
            int k = int.Parse(kolku.Text);
            TimeSpan pet_minuti = new TimeSpan(0, k, 0);
            //casovi prva smena
            prv_p = prv_p.Subtract(pet_minuti);
            prv_z = prv_z.Subtract(pet_minuti);
            vtor_p = vtor_p.Subtract(pet_minuti); ;
            vtor_z = vtor_z.Subtract(pet_minuti);
            tret_p = tret_p.Subtract(pet_minuti);
            tret_z = tret_z.Subtract(pet_minuti);
            cetvrt_p = cetvrt_p.Subtract(pet_minuti);
            cetvrt_z = cetvrt_z.Subtract(pet_minuti);
            pet_p = pet_p.Subtract(pet_minuti);
            pet_z = pet_z.Subtract(pet_minuti);
            sest_p = sest_p.Subtract(pet_minuti);
            sest_z = sest_z.Subtract(pet_minuti);
            sedmi_p = sedmi_p.Subtract(pet_minuti);
            sedmi_z = sedmi_z.Subtract(pet_minuti);

            //casovi vtora smena
            vprv_p = vprv_p.Subtract(pet_minuti);
            vprv_z = vprv_z.Subtract(pet_minuti);
            vvtor_p = vvtor_p.Subtract(pet_minuti);
            vvtor_z = vvtor_z.Subtract(pet_minuti);
            vtret_p = vtret_p.Subtract(pet_minuti);
            vtret_z = vtret_z.Subtract(pet_minuti);
            vcetvrt_p = vcetvrt_p.Subtract(pet_minuti);
            vcetvrt_z = vcetvrt_z.Subtract(pet_minuti);
            vpet_p = vpet_p.Subtract(pet_minuti);
            vpet_z = vpet_z.Subtract(pet_minuti);
            vsest_p = vsest_p.Subtract(pet_minuti);
            vsest_z = vsest_z.Subtract(pet_minuti);
            vsedmi_p = vsedmi_p.Subtract(pet_minuti);
            vsedmi_z = vsedmi_z.Subtract(pet_minuti);


        }

        public void normal_CheckedChanged(object sender, EventArgs e)
        {
            //casovi prva smena
            prv_p = new TimeSpan(7, 15, 0);
            prv_z = new TimeSpan(8, 0, 0);
            vtor_p = new TimeSpan(8, 5, 0);
            vtor_z = new TimeSpan(8, 50, 0);
            tret_p = new TimeSpan(9, 10, 0);
            tret_z = new TimeSpan(9, 55, 0);
            cetvrt_p = new TimeSpan(10, 0, 0);
            cetvrt_z = new TimeSpan(10, 45, 0);
            pet_p = new TimeSpan(10, 50, 0);
            pet_z = new TimeSpan(11, 35, 0);
            sest_p = new TimeSpan(11, 40, 0);
            sest_z = new TimeSpan(12, 25, 0);
            sedmi_p = new TimeSpan(12, 30, 0);
            sedmi_z = new TimeSpan(13, 15, 0);

            //casovi vtora smena
            vprv_p = new TimeSpan(13, 30, 0);
            vprv_z = new TimeSpan(14, 15, 0);
            vvtor_p = new TimeSpan(14, 20, 0);
            vvtor_z = new TimeSpan(15, 5, 0);
            vtret_p = new TimeSpan(15, 25, 0);
            vtret_z = new TimeSpan(16, 10, 0);
            vcetvrt_p = new TimeSpan(16, 15, 0);
            vcetvrt_z = new TimeSpan(17, 0, 0);
            vpet_p = new TimeSpan(17, 5, 0);
            vpet_z = new TimeSpan(17, 50, 0);
            vsest_p = new TimeSpan(17, 55, 0);
            vsest_z = new TimeSpan(18, 40, 0);
            vsedmi_p = new TimeSpan(18, 45, 0);
            vsedmi_z = new TimeSpan(19, 30, 0);
        }
        public void esp8266()
        {
            if (isConnected && (int)DateTime.Now.DayOfWeek != 0 && (int)DateTime.Now.DayOfWeek != 6)
            {
                port.Write("#1\n");
            }
            if (isConnected && (int)DateTime.Now.DayOfWeek == 6 && sabota)
            {
                port.Write("#1\n");
            }
        }

        TimeSpan razlika, currentTimee;
        DateTime currentTime;
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now;  //segasno vreme
            currentTimee = DateTime.Now.TimeOfDay; //saat
            //promena na labeli za vreme i data
            vreme.Text = currentTimee.ToString();
            datum.Text = currentTime.ToShortDateString();
            razlika = ko.Subtract(currentTimee);
            kedzvone.Text = razlika.ToString();
            if (!isConnected)
            {
                try
                {
                    connectToArduino();

                }
                catch
                {

                }
            }
            //posle sedmi
            if (vse11==0 &&((currentTimee >= vsedmi_z) &&(currentTimee<=vsedmi_zm))) 
            {
                m = 0;
                vse11 = 1;
                p1 = 0;
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                        status(20);
                        //windows media player
                        mala = 1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
            } 
            //posle 7mi i pred prvi
            //izgasi muzikata posle 7mi
            if(((currentTimee >= vsedmi_zm )&& m == 0))
            {
                try
                {
                    timer1.Stop();
                    timer1.Start();
                    m = 1;
                    m1 = 0;
                    mala = -1;
                }
                catch { }
            }

            //pusti muzika pred prvi
            if ((currentTimee >= prv_pm && m1 == 0) && currentTimee<=prv_p)
            {
                try
                {
                    timer1.Stop();
                    timer1.Start();
                    m1 = 1;
                    mala = 1;
                }
                catch
                {

                }
                
            }

            //ispituvanje na toa koj cas e prva smena
            if (p1 == 0 && (currentTimee >= prv_p) && (currentTimee <= prv_z)) //pocetok na prv cas
            {
                //dozvola za proverka na vtoriot uslov
                p1 = 1;
                p11 = 0;
              
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(1);
                        //windows media player
                        mala = -1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                ko = prv_z;
              
            } //pocetok na 1v
            else
            if (p11 == 0 && (currentTimee >= prv_z) && (currentTimee <= vtor_p)) //mal odmor
            {
                p11 = 1;
                v1 = 0;
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(15);
                        //arduino

                        esp8266();
                        //windows media player
                        mala = 1;
                        //     pauzado = new DateTime(g, m, d, prv_z.Hours, prv_z.Minutes + mn, 0);

                    }
                    catch
                    {

                    }
                ko = vtor_p;
            } //mal odmor
            else
            if (v1 == 0 && (currentTimee >= vtor_p) && (currentTimee <= vtor_z)) //pocetok na 2ri
            {
                v1 = 1;
                v11 = 0;
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(2);
                        //windows media player
                        mala = -1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = vtor_z;
              
            } //pocetok na 2ri
            else
            if (v11 == 0 && (currentTimee >= vtor_z) && (currentTimee <= tret_p)) //golem odmor
            {
                v11 = 1;
                t1 = 0;
                
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(17);
                        //windows media player
                        mala = 1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = tret_p;
                
            } //golem odmor
            else
            if (t1 == 0 && (currentTimee >= tret_p) && (currentTimee <= tret_z)) //3t cas
            {
                t1 = 1;
                t11 = 0;
              
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(3);
                        //windows media player
                        mala = -1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = tret_z;
            } //3t cas
            else
            if (t11 == 0 && (currentTimee >= tret_z) && (currentTimee <= cetvrt_p)) //mal odmor
            {
                t11 = 1;
                c1 = 0;
               
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(15);
                        //windows media player
                        mala = 1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = cetvrt_p;
            } // mal odmor
            else
            if (c1 == 0 && ((currentTimee >= cetvrt_p) && (currentTimee <= cetvrt_z))) //4t cas
            {
                c1 = 1;
                c11 = 0;
               
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(4);
                        //windows media player
                        mala = -1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = cetvrt_z;
            } //4t cas
            else
            if (c11 == 0 && ((currentTimee >= cetvrt_z) && (currentTimee <= pet_p))) //mal odmor
            {
                c11 = 1;
                p1 = 0;
                
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(15);
                        //windows media player
                        mala = 1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = pet_p;
            } //mal odmor
            else
            if (p1 == 0 && ((currentTimee >= pet_p) && (currentTimee <= pet_z))) //5t cas
            {
                p1 = 1;
                p11 = 0;
                
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(5);
                        //windows media player
                        mala = -1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = pet_z;
                
            }//5t cas
            else
            if (p11 == 0 && ((currentTimee >= pet_z) && (currentTimee <= sest_p))) //mal odmor 15
            {
                p11 = 1;
                s1 = 0;
                
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(15);
                        //windows media player
                        mala = 1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = sest_p;
            } //mal odmor 15
            else
            if (s1 == 0 && ((currentTimee >= sest_p) && (currentTimee <= sest_z)))
            {
                s1 = 1;
                s11 = 0;
                
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(6);
                        //windows media player
                        mala = -1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = sest_z;
            } //6ti cas
            else
            if (s11 == 0 &&((currentTimee >= sest_z) && (currentTimee <= sedmi_p))) //mal odmor 15
            {
                s11 = 1;
                se1 = 0;
                
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(15);
                        //windows media player
                        mala = 1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = sedmi_p;
                
            } //mal odmor 15
            else
            if (se1 == 0 &&((currentTimee >= sedmi_p) && (currentTimee <= sedmi_z))) //7mi cas
            {
                se1 = 1;
                se11 = 0;
                
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(7);
                        //windows media player
                        mala = -1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = sedmi_z;
            } //7mi cas

            if (se11==0 &&((currentTimee >= sedmi_z) && (currentTimee <= vprv_p))) //megu prva i vtora smena
            {
                se11 = 1;
                vp1 = 0;
               
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(20);
                        //windows media player
                        mala = 1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = vprv_p;
               
            } //megu prva i vtora smena

            //ispituvanje na toa koj cas e vtora smena
            if (vp1 == 0 &&((currentTimee >= vprv_p) && (currentTimee <= vprv_z))) //pocetok na prv cas
            {
                vp1 = 1;
                vp11 = 0;

                try
                {
                    timer1.Stop();
                    timer1.Start();
                    status(8);
                    //windows media player
                    mala = -1;
                    //arduino
                    esp8266();
                }
                catch
                {
                }
                
                ko = vprv_z;
            } //pocetok na 1v
            else
            if (vp11==0 &&((currentTimee >= vprv_z) && (currentTimee <= vvtor_p))) //mal odmor
            {
                vp11 = 1;
                vv1 = 0;
               
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(16);
                        //arduino

                        esp8266();
                        //windows media player
                        mala = 1;
                        //     pauzado = new DateTime(g, m, d, prv_z.Hours, prv_z.Minutes + mn, 0);

                    }
                    catch
                    {

                    }
                
                ko = vvtor_p;
            } //mal odmor
            else
            if (vv1==0 &&((currentTimee >= vvtor_p) && (currentTimee <= vvtor_z))) //pocetok na 2ri
            {
                vv1 = 1;
                vv11 = 0;
                
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(9);
                        //windows media player
                        mala = -1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                   }
                
                ko = vvtor_z;
            } //pocetok na 2ri
            else
            if (vv11 == 0 &&((currentTimee >= vvtor_z) && (currentTimee <= vtret_p))) //golem odmor
            {
                vv11 = 1;
                vt1 = 0;
                
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(18);
                        //windows media player
                        mala = 1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = vtret_p;
            } //golem odmor
            else
            if (vt1 == 0 &&((currentTimee >= vtret_p) && (currentTimee <= vtret_z))) //3t cas
            {
                vt1 = 1;
                vt11 = 0;
               
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(10);
                        //windows media player
                        mala = -1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = vtret_z;
            } //3t cas
            else
            if (vt11==0 &&((currentTimee >= vtret_z) && (currentTimee <= vcetvrt_p))) //mal odmor
            {
                vt11 = 1;
                vc1 = 0;
                
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(16);
                        //windows media player
                        mala = 1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = vcetvrt_p;
            } // mal odmor
            else
            if (vc1==0 &&((currentTimee >= vcetvrt_p) && (currentTimee <= vcetvrt_z))) //4t cas
            {
                vc1 = 1;
                vc11 = 0;
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(11);
                        //windows media player
                        mala = -1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = vcetvrt_z;
            } //4t cas
            else
            if (vc11==0 &&((currentTimee >= vcetvrt_z) && (currentTimee <= vpet_p))) //mal odmor
            {
                vc11 = 1;
                vp1 = 0;
                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(16);
                        //windows media player
                        mala = 1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = vpet_p;

            } //mal odmor
            else
            if (vp1 == 0 &&((currentTimee >= vpet_p) && (currentTimee <= vpet_z))) //5t cas
            {
                vp1 = 1;
                vp11 = 0;

                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(12);
                        //windows media player
                        mala = -1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = vpet_z;

            }//5t cas
            else
            if (vp11==0 &&((currentTimee >= vpet_z) && (currentTimee <= vsest_p))) //mal odmor 15
            {
                vp11 = 1;
                vs1 = 0;

                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(16);
                        //windows media player
                        mala = 1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = vsest_p;
            } //mal odmor 15
            else
            if (vs1==0 &&((currentTimee >= vsest_p) && (currentTimee <= vsest_z))) //6ti
            {
                vs1 = 1;
                vs11 = 0;

                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(13);
                        //windows media player
                        mala = -1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = vsest_z;
            } //6ti cas
            else
            if (vs11== 0 &&((currentTimee >= vsest_z) && (currentTimee <= vsedmi_p))) //mal odmor 15
            {
                vs11 = 1;
                vse1 = 0;

                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(16);
                        //windows media player
                        mala = 1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = vsedmi_p;
            } //mal odmor 15
            else
            if (vse1==0 &&((currentTimee >= vsedmi_p) && (currentTimee <= vsedmi_z))) //7mi cas
            {
                vse1 = 1;
                vse11 = 0;

                    try
                    {
                    timer1.Stop();
                    timer1.Start();
                    status(14);
                        //windows media player
                        mala = -1;
                        //arduino
                        esp8266();
                    }
                    catch
                    {
                    }
                
                ko = vsedmi_z;
            } //7mi cas

           


            if ((mala == -1))
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            if ((mala == 1) && (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying))
            {
                try
                {
                    if (pp == 1)
                    {
                        pp = 0;
                        lb.SelectedIndex = 0;
                    }
                    else
                    {
                        if (lb.SelectedIndex < lb.Items.Count - 1)
                        {
                            lb.SelectedIndex += 1;
                        }
                        else
                        {
                            lb.SelectedIndex = 0;
                        }
                    }

                    axWindowsMediaPlayer1.URL = paths[lb.SelectedIndex];

                }
                catch { }
            }
            
    


        }

        private void add_Click(object sender, EventArgs e)
        {
            //lb.Items.Add(openFileDialog1.FileName);

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Музика(*.mp3)|*.mp3";
            //Code to select multiple files 
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save the names of the track in files array 
                paths = ofd.FileNames; //Save the paths of the tracks in path array 

                //Display the music titles in listbox 
                for (int i = 0; i < files.Length; i++)
                {
                    lb.Items.Add(files[i]); //Display Songs in Listbox 
                }

            }

        }
    }
}