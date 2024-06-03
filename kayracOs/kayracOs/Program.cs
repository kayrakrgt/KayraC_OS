using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using System.IO;
using System.ComponentModel.Design;
using Microsoft.VisualBasic;
class Os
{
    static void Main()
    {
        Console.WriteLine("\r\n\r\n'##:::'##::::'###::::'##:::'##:'########:::::'###:::::'#######:::'######::::::'######::::'##'##:::\r\n ##::'##::::'## ##:::. ##:'##:: ##.... ##:::'## ##:::'##.... ##:'##... ##::::'##... ##::: ## ##:::\r\n ##:'##::::'##:. ##:::. ####::: ##:::: ##::'##:. ##:: ##:::: ##: ##:::..::::: ##:::..::'#########:\r\n #####::::'##:::. ##:::. ##:::: ########::'##:::. ##: ##:::: ##:. ######::::: ##:::::::.. ## ##.::\r\n ##. ##::: #########:::: ##:::: ##.. ##::: #########: ##:::: ##::..... ##:::: ##:::::::'#########:\r\n ##:. ##:: ##.... ##:::: ##:::: ##::. ##:: ##.... ##: ##:::: ##:'##::: ##:::: ##::: ##:.. ## ##.::\r\n ##::. ##: ##:::: ##:::: ##:::: ##:::. ##: ##:::: ##:. #######::. ######:::::. ######:::: ## ##:::\r\n..::::..::..:::::..:::::..:::::..:::::..::..:::::..:::.......::::......:::::::......:::::..:..::::\r\n\r\n");
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("Lütfen sistem seçiniz::\n" +
            "1. KayraOS\n" +
            "2. Boot System");

        string sistem = Console.ReadLine();
        if (sistem == "1")
        {
            Console.WriteLine("THE SYSTEM MODULES HAS BEEN LOADİNG");
            Thread.Sleep(1000);
            Console.WriteLine("Modules loaded");
            Thread.Sleep(500);
            Console.Clear();
            
            
            DateTime dateTime = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(dateTime.ToString("HH:mm"));
            static void appLications()
            {
                Console.WriteLine("1. Görev Yöneticisi. \n 2. Hesap Makinesi.\n 3. İnternette arat \n 4. Eglenceli\n 5. Web uygulamarı\n 6. Şifre Yöneticisi");
            }
            appLications();
            string secseneAwq = Console.ReadLine();
            if (secseneAwq == "1")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine("tasklist");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                string output = cmd.StandardOutput.ReadToEnd();

                Console.WriteLine(output);
                cmd.Close();
                Console.ReadKey();

            }
            if (secseneAwq == "2")
            {
                static void hesapMakinesi()
                {
                    Console.WriteLine("1.Toplama\n 2.Çıkarma \n 3. Çarpma \n 4.Bölme");
                    string secseneaq2 = Console.ReadLine();
                    if (secseneaq2 == "1")
                    {
                        Console.WriteLine("1. sayı\n");
                        int toplama1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("2. sayı");
                        int toplama2 = Convert.ToInt32(Console.ReadLine());
                        int sonuc1 = toplama1 + toplama2;
                        Console.WriteLine("sonuc= "+sonuc1);
                        Console.ReadKey();
                    if (secseneaq2 == "2")
                        {
                            Console.WriteLine("1. sayı");
                            int cikartma1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("2. sayı");
                            int cikartma2 = Convert.ToInt32(Console.ReadLine());
                            int sonuc2 = cikartma1 - cikartma2;
                            Console.WriteLine("sonuc="+ sonuc2);
                            Console.ReadKey();
                        }
                    }if (secseneaq2 == "3")
                    {
                        Console.WriteLine("1. sayı");
                        int carpma1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("2. sayı");
                        int carpma2 = Convert.ToInt32(Console.ReadLine());
                        int sonuc3 = carpma1 * carpma2;
                        Console.WriteLine("sonuc:" + sonuc3);
                        Console.ReadKey();
                    }
                    if (secseneaq2 == "4")
                    {
                        Console.WriteLine("1. sayı");
                        int bolme1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("2. sayı");
                        int bolme2 = Convert.ToInt32(Console.ReadLine());
                        int sonuc4 = bolme1 / bolme2;
                        Console.WriteLine("sonuc:" + sonuc4);
                        Console.ReadKey();

                    }
                    
                }hesapMakinesi();
            }
            if (secseneAwq == "3")
            {
                Console.Clear();
                Console.WriteLine("İnternette aratmak istediğiniz şeyi yazınız...:\n (LÜTFEN BOSLUK YERİNE + KOYUNUZ)");
                string webarat = Console.ReadLine();
                Process arat = new Process();
                arat.StartInfo.FileName = ("cmd.exe");
                arat.StartInfo.RedirectStandardInput = true;
                arat.StartInfo.RedirectStandardOutput = true;
                arat.StartInfo.CreateNoWindow = true;
                arat.StartInfo.UseShellExecute = false;
                arat.Start();

                arat.StandardInput.WriteLine("start https://www.google.com/search?q=" + webarat);
                arat.StandardInput.Flush();
                arat.StandardInput.Close();
                string output2 = arat.StandardOutput.ReadToEnd();
                Console.WriteLine(output2);
                arat.Close();
                Console.ReadKey();
            }

            if (secseneAwq == "4")
            {
                Console.WriteLine("1. IkonCız\n");
                string secbabaa = Console.ReadLine();
                if (secbabaa == "1")
                {
                    Process icon = new Process();
                    icon.StartInfo.FileName = ("cmd.exe");
                    icon.StartInfo.RedirectStandardInput = true;
                    icon.StartInfo.RedirectStandardOutput = true;
                    icon.StartInfo.CreateNoWindow = true;
                    icon.StartInfo.UseShellExecute = false;
                    icon.Start();

                    icon.StandardInput.WriteLine("python erorikon.py");
                    icon.StandardInput.Flush();
                    icon.StandardInput.Close();
                    string output3 = icon.StandardOutput.ReadToEnd();
                    Console.WriteLine(output3);
                    icon.Close();
                    Console.ReadKey();
                }
                         
            }
            if (secseneAwq == "5")
            {
                Console.Clear();
                Process web = new Process();
                web.StartInfo.FileName = ("cmd.exe");
                web.StartInfo.RedirectStandardInput = true;
                web.StartInfo.RedirectStandardOutput = true;
                web.StartInfo.CreateNoWindow = true;
                web.StartInfo .UseShellExecute = false;
                web.Start();

                web.StandardInput.WriteLine("python -m http.server 4444");
                web.StandardInput.Flush();
                web.StandardInput.Close();
                string output4 = web.StandardOutput.ReadToEnd();
                Console.WriteLine (output4);
                web.Close();
                Console.WriteLine("4444 üzerinde server açıldı");
                    
                Console.ReadKey();
            }
            if (secseneAwq == "6")
            {
                Console.Clear();
                string kAdi = "admin";
                Console.WriteLine("Kullanıcı Adınız:");
                string kAdiIste = Console.ReadLine();
                string sifre = "admin";
                Console.WriteLine("Şifreniz:");
                string sifreIste = Console.ReadLine();
                if (kAdi == "admin" | sifre == "admin")
                {
                    string DosyaYolu = "text.txt";
                    using (StreamReader oku = new StreamReader(DosyaYolu))
                    {
                        string satir;
                        while ((satir = oku.ReadLine()) != null)
                        {
                            Console.WriteLine(satir);
                            Console.ReadKey();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifre yanlış !!!");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    Console.ReadKey();
                }
                
            }
        }    
        

        

        else
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("SYSTEM REQUİREMENTS\n ------------------------------- \n OS = KayraOS \n Write Lang. = C# \n RAM = 1024 KB \n Processor = KayraIND 4th GEN \n Storage = 16 MB (14 MB Free Space) ");
            Console.ReadKey();
        }
    }
}
