using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Diagnostics;
using System.Media;
using HootKeys;
using Microsoft.Win32;



namespace EmirAsistan

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TuslariDinle();
        }

        globalKeyboardHook klavye = new globalKeyboardHook();
      
        ChromeOptions options = new ChromeOptions();
        IWebDriver driver;
        ChromeDriverService service = ChromeDriverService.CreateDefaultService();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            key.SetValue("EmirAsistan", "\"" + Application.ExecutablePath + "\"");
            pictureBox2.Hide();
            timer1.Stop();
            label2.Hide();

        }      
        void TuslariDinle()
        {
            klavye.HookedKeys.Add(System.Windows.Forms.Keys.Home);
            
            klavye.KeyDown += new KeyEventHandler(Tuskombinansyonlarý);
        }
        void Tuskombinansyonlarý(object sender,KeyEventArgs e)
        {
            if (e.KeyCode==System.Windows.Forms.Keys.Home)
            {
                this.Show();
            }        
        }
        int c = 7;
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {            
            try
            {
              pictureBox2.Show();                
              pictureBox2.Hide();
              options.AddArguments("use-fake-ui-for-media-stream");
              options.AddArguments("--window-position=-32000,-32000");

                service.HideCommandPromptWindow = true; // service deðiþkenimize konsolumuzun hide özelliðini açýyoruz
               driver = new ChromeDriver(service,options);             
                driver.Navigate().GoToUrl("https://www.google.com/");
               
                driver.FindElement(By.ClassName("goxjub")).Click();
              timer1.Start();   
            }
            catch (Exception)
            {
                MessageBox.Show("Bir daha deneyin", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                driver.Quit();
            }
                                        
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = c.ToString();
            label2.Show();
            pictureBox2.Show();
            c--;
            if (c<=0)
           {
                try
                {
                    pictureBox2.Hide();
                    label2.Hide();
                    timer1.Stop();
                    string a = driver.FindElement(By.XPath(".//input[@class='gLFyf gsfi']")).GetAttribute("value");
                    driver.Quit();
                    pictureBox2.Hide();
                    System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                    //sohbet
                    
                    if (a.IndexOf("ne yersin", 0, a.Length) != -1 || a.IndexOf("neler yersin", 0, a.Length) != -1 || a.IndexOf("ne yemek yersin", 0, a.Length) != -1 || a.IndexOf("aç mýsýn", 0, a.Length) != -1 || a.IndexOf("ýsmarlayayým mý", 0, a.Length) != -1)
                    {
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\yemek2 ben insan deðilim(online-audio-convert.com).wav";
                            ses.Play();
                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\yemek1 ssd alýrým (2)(online-audio-convert.com).wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\yemek3 tatlý yermisin (1)(online-audio-convert.com).wav";
                            ses.Play();
                        }

                    }
                    else if (a.IndexOf("adýn ne", 0, a.Length) != -1 || a.IndexOf("ismin ne", 0, a.Length) != -1 || a.IndexOf("sana ne diyeyim", 0, a.Length) != -1 || a.IndexOf("sana nasýl sesleneyim", 0, a.Length) != -1)
                    {
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AD1-Bana-genellikle-Lusi-diye-seslenirler.wav";
                            ses.Play();
                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AD2-Benim-adým-Lusi.wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AD3-Bana-kýsacasý-Lusi-diyebilirsin.wav";
                            ses.Play();
                        }
                       

                    }
                    else if (a.IndexOf("sevdiðin þarký", 0, a.Length) != -1 || a.IndexOf("þarkýyý dinlersin", 0, a.Length) != -1 || a.IndexOf("þarký dinlersin", 0, a.Length) != -1 || a.IndexOf("þarkýlardan", 0, a.Length) != -1)
                    {
                        ses.SoundLocation = Application.StartupPath + "\\en sevdiðim arkýnýn adý söyle caným(online-audio-convert.com).wav";
                        ses.Play();
                        
                    }
                    else if (a.IndexOf("ne yaparsýn", 0, a.Length) != -1 || a.IndexOf("hobi", 0, a.Length) != -1 || a.IndexOf("hoþlanýrsýn", 0, a.Length) != -1)
                    {
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\Hobi1 Fenerbahçenin basket takýmýný izlemeye bayýlýrým özellikle nando ve vesseli oynuyorsa(online-audio-convert.com).wav";
                            ses.Play();
                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\HOBÝ2 Ýnternette yeni þeyler keþfetmeye bayýlýrým(online-audio-convert.com).wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\Hobi3 boþ zamanlarýmda müzik dinlerime bayýlýrým (1)(online-audio-convert.com).wav";
                            ses.Play();
                        }
                       

                    }
                    else if (a.IndexOf("þarký söyle", 0, a.Length) != -1 || a.IndexOf("þarký söyler misin", 0, a.Length) != -1)
                    {
                        ses.SoundLocation = Application.StartupPath + "\\ÞARký söyle (1)(online-audio-convert.com).wav";
                        ses.Play();
                       
                    }
                    else if (a.IndexOf("tekerleme", 0, a.Length) != -1 || a.IndexOf("tekerleme söyle", 0, a.Length) != -1 || a.IndexOf("karýþýk", 0, a.Length) != -1)
                    {
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\Tekerleme1(online-audio-convert.com).wav";
                            ses.Play();
                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\Tekerleme2(online-audio-convert.com).wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\Tekerleme3(online-audio-convert.com).wav";
                            ses.Play();
                        }
                       
                    }
                    else if (a.IndexOf("teþekkür ederim", 0, a.Length) != -1 || a.IndexOf("teþekkürler", 0, a.Length) != -1 || a.IndexOf("Sað ol", 0, a.Length) != -1 || a.IndexOf("eyvallah", 0, a.Length) != -1)
                    {
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\TÞK1 Rica ederim(online-audio-convert.com).wav";
                            ses.Play();
                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\TÞK2 Görevimiz Efendim(online-audio-convert.com).wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\TÞK3 Bir þey deðil efendim(online-audio-convert.com).wav";
                            ses.Play();
                        }
                        
                    }
                    else if (a.IndexOf("nasýlsýn", 0, a.Length) != -1 || a.IndexOf("iyi misin", 0, a.Length) != -1 || a.IndexOf("kötü müsün", 0, a.Length) != -1 || a.IndexOf("nasýl hissediyorsun", 0, a.Length) != -1 || a.IndexOf("günün nasýl geçiyor", 0, a.Length) != -1)
                    {
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\NASILSIN1(online-audio-convert.com).wav";
                            ses.Play();
                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\NASILSIN3(online-audio-convert.com).wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\NASILSIN2(online-audio-convert.com).wav";
                            ses.Play();
                        }
                      
                    }
                    else if (a.IndexOf("ne ile uðraþýyorsun", 0, a.Length) != -1 || a.IndexOf("ne yapýyorsun", 0, a.Length) != -1 || a.IndexOf("Ne yapýyorsun", 0, a.Length) != -1)
                    {
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\NEYAPIYORSUN2(online-audio-convert.com).wav";
                            ses.Play();
                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\NEYAPIYORSUN3(online-audio-convert.com).wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\NEYAPIYORSUN1(online-audio-convert.com).wav";
                            ses.Play();
                        }
                        
                    }
                    //uygulama baþlat
                    else if (a.IndexOf("steam", 0, a.Length) != -1 || a.IndexOf("Steam", 0, a.Length) != -1)
                    {
                        label2.Text = "Bekleyin...";
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ1-Açýyorum-Efendim.wav";
                            ses.Play();
                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ2-Anlaþýldý-Efendim.wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ3-Tamamdýr-Efendim.wav";
                            ses.Play();
                        }
                        Process.Start(@"C:\Program Files (x86)\Steam\steam.exe");
                        

                    }
                    else if (a.IndexOf("CS GO aç", 0, a.Length) != -1 || a.IndexOf("CS GO baþlat", 0, a.Length) != -1 || a.IndexOf("counter-strike Global offensive baþlat", 0, a.Length) != -1 || a.IndexOf("counter-strike Global offensive aç", 0, a.Length) != -1)
                    {
                        label2.Text = "Bekleyin...";
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ1-Açýyorum-Efendim.wav";
                            ses.Play();
                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ2-Anlaþýldý-Efendim.wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ3-Tamamdýr-Efendim.wav";
                            ses.Play();
                        }
                        Process.Start(@"steam://rungameid/730");
                       
                    }
                    else if (a.IndexOf("Spotify aç", 0, a.Length) != -1 || a.IndexOf("Spotify baþlat", 0, a.Length) != -1 || a.IndexOf("Spotify çalýþtýr", 0, a.Length) != -1)
                    {
                        label2.Text = "Bekleyin...";
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ1-Açýyorum-Efendim.wav";
                            ses.Play();
                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ2-Anlaþýldý-Efendim.wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ3-Tamamdýr-Efendim.wav";
                            ses.Play();
                        }

                        Process.Start(@"C:\Users\emiro\AppData\Roaming\Spotify\Spotify.exe");

                    }
                    else if (a.IndexOf("Epic Games", 0, a.Length) != -1 )
                    {
                        label2.Text = "Bekleyin...";
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ1-Açýyorum-Efendim.wav";
                            ses.Play();
                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ2-Anlaþýldý-Efendim.wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ3-Tamamdýr-Efendim.wav";
                            ses.Play();
                        }

                        Process.Start(@"C:\Program Files (x86)\Epic Games\Launcher\Portal\Binaries\Win32\EpicGamesLauncher.exe");
                        

                    }                   
                    else if (a.IndexOf("League of Legends", 0, a.Length) != -1|| a.IndexOf("LOL", 0, a.Length) != -1 || a.IndexOf("lol", 0, a.Length) != -1)


                    {
                        label2.Text = "Bekleyin...";
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ1-Açýyorum-Efendim.wav";
                            ses.Play();
                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ2-Anlaþýldý-Efendim.wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ3-Tamamdýr-Efendim.wav";
                            ses.Play();
                        }

                        Process.Start(@"C:\Riot Games\Riot Client\RiotClientServices.exe");


                    }
                    else if (a.IndexOf("Valorant", 0, a.Length) != -1 || a.IndexOf("valorant", 0, a.Length) != -1)


                    {
                        label2.Text = "Bekleyin...";
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ1-Açýyorum-Efendim.wav";
                            ses.Play();
                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ2-Anlaþýldý-Efendim.wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ3-Tamamdýr-Efendim.wav";
                            ses.Play();
                        }

                        Process.Start(@"C:\Riot Games\Riot Client\RiotClientServices.exe");


                    }

                    //tarayýcýda göster
                    else if (a.IndexOf("hava durumu", 0, a.Length) != -1 || a.IndexOf("hava", 0, a.Length) != -1)
                    {
                        label2.Text = "Bekleyin...";
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ1-Açýyorum-Efendim.wav";
                            ses.Play();
                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ2-Anlaþýldý-Efendim.wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ3-Tamamdýr-Efendim.wav";
                            ses.Play();
                        }
                        IWebDriver drivers = new ChromeDriver(service);
                        drivers.Navigate().GoToUrl("https://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx?il=%C4%B0stanbul");
                    }
                    else if (a.IndexOf("borsa", 0, a.Length) != -1 || a.IndexOf("piyasa", 0, a.Length) != -1)
                    {
                        label2.Text = "Bekleyin...";
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ1-Açýyorum-Efendim.wav";
                            ses.Play();

                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ2-Anlaþýldý-Efendim.wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ3-Tamamdýr-Efendim.wav";
                            ses.Play();
                        }
                        ChromeDriverService services = ChromeDriverService.CreateDefaultService();//chrome servislerini service deðiþkenimize atýyoruz
                        service.HideCommandPromptWindow = true; // service deðiþkenimize konsolumuzun hide özelliðini açýyoruz
                        IWebDriver drivers = new ChromeDriver(services);
                        drivers.Navigate().GoToUrl("https://uzmanpara.milliyet.com.tr/canli-borsa/https://uzmanpara.milliyet.com.tr/canli-borsa/");
                        
                    }
                    else if (a.IndexOf("instagram'ý aç", 0, a.Length) != -1 || a.IndexOf("Instagram'ý açar mýsýn", 0, a.Length) != -1)
                    {
                        label2.Text = "Bekleyin...";
                        Random rnd = new Random();
                        int b = rnd.Next(0, 3);
                        if (b == 0)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ1-Açýyorum-Efendim.wav";
                            ses.Play();

                        }
                        else if (b == 1)
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ2-Anlaþýldý-Efendim.wav";
                            ses.Play();
                        }
                        else
                        {
                            ses.SoundLocation = Application.StartupPath + "\\AÇ3-Tamamdýr-Efendim.wav";
                            ses.Play();
                        }
                        ChromeDriverService services = ChromeDriverService.CreateDefaultService();//chrome servislerini service deðiþkenimize atýyoruz
                        service.HideCommandPromptWindow = true; // service deðiþkenimize konsolumuzun hide özelliðini açýyoruz
                        IWebDriver drivers = new ChromeDriver(services);
                        drivers.Navigate().GoToUrl("https://www.instagram.com/eren1ozturk_/");
                       
                    }
                    //efendim en sonda olmasý lazým
                    else if (a.IndexOf("Hey", 0, a.Length) != -1 || a == "Lucy" || a.IndexOf("ey", 0, a.Length) != -1)
                    {
                        ses.SoundLocation = Application.StartupPath + "\\Efendim(online-audio-convert.com).wav";
                        ses.Play();
                       
                    }
                    //anlamama(web arama)
                    else
                    {
                        label2.Text = "Bekleyin...";
                        IWebDriver drivers = new ChromeDriver(service);
                        drivers.Navigate().GoToUrl("https://www.google.com/");
                        IWebElement element = drivers.FindElement(By.XPath(".//input[@class='gLFyf gsfi']"));
                        element.SendKeys(a);
                        element.Submit();
                        ses.SoundLocation = Application.StartupPath + "\\WEBDE BUNLARI BULDUM(online-audio-convert.com).wav";
                        ses.Play();

                    }
                    pictureBox2.Hide();
                    driver.Quit();

                    label2.Show();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir daha deneyin", "HATA", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    driver.Quit();
                }
                label2.Hide();
                c = 7;
   
           }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

    }              

//steam baþlat
//IWebElement asistankonus = driver.FindElement(By.XPath(".//input[contains(@value,'Open Steam')]")); Console.WriteLine("steam baslatýlýyor");
//asistankonus.Clear(); asistankonus.SendKeys("I'm opening Steam sir Çeviri");
//asistankonus = driver.FindElement(By.ClassName("Tg7LZd"));
//asistankonus.Click();
//asistankonus = driver.FindElement(By.CssSelector(".tw-menu-btn-image.z1asCe.JKu1je"));
//asistankonus.Click();
//Process.Start(@"C:\Program Files (x86)\Steam\steam.exe");

// hata mesajý
//driver.Navigate().GoToUrl("https://www.google.com/search?q=i%27m+sorry+i+don%27t+understand+you+sir+%C3%A7eviri&rlz=1C1CHZN_trTR987TR987&ei=NnIzYsu1MdCTxc8PmpqnyAc&ved=0ahUKEwjLqJOM2M32AhXQSfEDHRrNCXkQ4dUDCA4&uact=5&oq=i%27m+sorry+i+don%27t+understand+you+sir+%C3%A7eviri&gs_lcp=Cgdnd3Mtd2l6EAM6BwgAEEcQsAM6BQgAEKIESgQIQRgASgQIRhgAULgTWPcsYK4yaAFwAXgAgAGUAYgB9ASSAQMwLjWYAQCgAQHIAQjAAQE&sclient=gws-wiz");
//driver.FindElement(By.CssSelector(".tw-menu-btn-image.z1asCe.JKu1je")).Click();
//Thread.Sleep(3000);
//goto basadon;
