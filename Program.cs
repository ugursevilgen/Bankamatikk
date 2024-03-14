using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bankamatikk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bakiye = 2500;
            string sifre = "ab18";

            Console.WriteLine("Hoşgeldiniz! \nLütfen yapmak istediğiniz işlemi tuşlayınız: \n ");

            Console.WriteLine("1 - Kartlı İşlem \n");
            Console.WriteLine("2 - Kartsız İşlem\n");
            string baslangic = Console.ReadLine();

            if (baslangic == "1")
            {
                while (true)
                {
                    Console.Write("Lütfen şifrenizi giriniz: ");
                    string girilenSifre = Console.ReadLine();

                    int hak = 3;

                    if (girilenSifre == sifre)
                    {

                        Console.WriteLine("Başarılı bir şekilde giriş yaptınız.");

                        Console.WriteLine("\n***ANA MENÜ***\n\nLütfen yapmak istediğiniz işlemi tuşlayınız");

                        Console.WriteLine("1 - Para çekme");
                        Console.WriteLine("2 - Para yatırma");
                        Console.WriteLine("3 - Para Transferi");
                        Console.WriteLine("4 - Eğitim Ödemeleri");
                        Console.WriteLine("5 - Ödemeler");
                        Console.WriteLine("6 - Bilgi güncelleme");


                        string AnaMenu = Console.ReadLine();

                        if (AnaMenu == "1")
                        {
                            Console.Write("Çekmek istediğiniz tutarı giriniz: ");
                            double cekilecekTutar = Convert.ToDouble(Console.ReadLine());


                            if (cekilecekTutar <= bakiye)
                            {

                                Console.WriteLine("Çekilen tutar: " + cekilecekTutar + "Güncel Bakiyeniz: " + (bakiye - cekilecekTutar));
                                Console.WriteLine("\n 9 Ana Menüye Dön \n0 Hesaptan Çık");
                                string secim = Console.ReadLine();
                                bakiye = bakiye - cekilecekTutar;

                                if (secim == "9")
                                {
                                    // GO TO ANA MENÜ
                                }
                                else if (secim == "0")
                                {
                                    Console.WriteLine("Hesaptan çıkış yapıldı.");
                                }


                            }

                            else if (cekilecekTutar > bakiye)
                            {
                                Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır.");
                                Console.WriteLine("\n 9 Ana Menüye Dön \n0 Hesaptan Çık");
                                string secim = Console.ReadLine();
                                if (secim == "9")
                                {
                                    // GO TO ANA MENÜ
                                }
                                else if (secim == "0")
                                {
                                    Console.WriteLine("Hesaptan çıkış yapıldı.");
                                }
                            }
                        }


                        else if (AnaMenu == "2")
                        {
                            Console.WriteLine("1 Kredi Kartına Para Yatırın");
                            Console.WriteLine("2 Kendi Hesabına Para Yatır");
                            string secim = Console.ReadLine();
                            if (secim == "1")
                            {
                                hak = 3;

                                while (hak > 0)
                                {
                                    Console.WriteLine("12 haneli kredi kartı numaranızı giriniz.");
                                    string kredikartı = Console.ReadLine();

                                    if (kredikartı.Length != 12)
                                    {
                                        hak--;
                                        Console.WriteLine("Lütfen kontrol ederek tekrar tuşlayınız.");
                                    }
                                    if (hak == 0)
                                    {
                                        Console.WriteLine("\n 9 Ana Menüye Dön \n0 Hesaptan Çık");
                                        string secim1 = Console.ReadLine();
                                        if (secim1 == "9")
                                        {
                                            // GO TO ANA MENÜ
                                        }
                                        else if (secim1 == "0")
                                        {
                                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                                        }
                                    }
                                    else if (kredikartı.Length == 12)
                                    {
                                        Console.Write("yatırılacak tutarı giriniz:");
                                        double yatirilacakTutar = Convert.ToDouble(Console.ReadLine());
                                        if (bakiye >= yatirilacakTutar)
                                        {
                                            bakiye = bakiye + yatirilacakTutar;
                                            Console.WriteLine("Kredi Kartına ödeme yapılmıştır./Güncel Bakiye: " + bakiye);
                                            Console.WriteLine("\n 9 Ana Menüye Dön \n0 Hesaptan Çık");
                                            string secim1 = Console.ReadLine();
                                            if (secim1 == "9")
                                            {
                                                // GO TO ANA MENÜ
                                            }
                                            else if (secim1 == "0")
                                            {
                                                Console.WriteLine("Hesaptan çıkış yapıldı.");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Hesabınızda yeterli bakiye bulunmamaktadır.");
                                            Console.WriteLine("\n 9 Ana Menüye Dön \n0 Hesaptan Çık");
                                            string secim1 = Console.ReadLine();
                                            if (secim1 == "9")
                                            {
                                                // GO TO ANA MENÜ
                                            }
                                            else if (secim1 == "0")
                                            {
                                                Console.WriteLine("Hesaptan çıkış yapıldı.");
                                            }
                                        }
                                    }
                                }
                            }
                            else if (secim == "2")
                            {
                                Console.Write("Lütfen hesabınıza yatırmak istediğiniz tutarı giriniz: ");
                                double yatacakmiktar = Convert.ToDouble(Console.ReadLine());
                                if (bakiye >= yatacakmiktar)
                                {
                                    bakiye = bakiye - yatacakmiktar;
                                    Console.WriteLine("Tutar hesabınıza aktarılmıştır. Güncel Bakiyeniz: " + bakiye);
                                    Console.WriteLine("\n 9 Ana Menüye Dön \n0 Hesaptan Çık");
                                    string secim1 = Console.ReadLine();
                                    if (secim1 == "9")
                                    {
                                        // GO TO ANA MENÜ
                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Hesaptan çıkış yapıldı.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır.");
                                    Console.WriteLine("\n 9 Ana Menüye Dön \n0 Hesaptan Çık");
                                    string secim1 = Console.ReadLine();
                                    if (secim1 == "9")
                                    {
                                        // GO TO ANA MENÜ
                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Hesaptan çıkış yapıldı.");
                                    }
                                }
                            }
                        }

                        else if (AnaMenu == "3")
                        {
                            Console.WriteLine("Yapmak istediğiniz işlemi tuşlayınız");
                            Console.WriteLine("1 - Başka Hesaba EFT");
                            Console.WriteLine("2 - Başka Hesaba Havale");
                            string secim2 = Console.ReadLine();

                            if (secim2 == "1")
                            {

                                Console.Write("EFT yapılacak hesap numarasını başına TR ekleyerek  giriniz: ");
                                string EFThesapNo = Console.ReadLine();
                                if (EFThesapNo.StartsWith("TR") && EFThesapNo.Length == 14)
                                {
                                    Console.Write("Lütfen yatırmak istediğiniz tutarı giriniz: ");
                                    double gonderilecekTutar = Convert.ToDouble(Console.ReadLine());
                                    if (gonderilecekTutar > bakiye)
                                    {
                                        Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır.");
                                        Console.WriteLine("\n 9 Ana Menüye Dön \n0 Hesaptan Çık");
                                        string secim = Console.ReadLine();
                                        if (secim == "9")
                                        {
                                            // GO TO ANA MENÜ
                                        }
                                        else if (secim == "0")
                                        {
                                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                                        }
                                    }
                                    else if (gonderilecekTutar < bakiye)
                                    {
                                        bakiye = bakiye - gonderilecekTutar;
                                        Console.WriteLine("EFT başarıyla oldu. Yeni Bakiyeniz: " + bakiye);
                                        Console.WriteLine("\n 9 Ana Menüye Dön \n0 Hesaptan Çık");
                                        string secim = Console.ReadLine();
                                        if (secim == "9")
                                        {
                                            // GO TO ANA MENÜ
                                        }
                                        else if (secim == "0")
                                        {
                                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                                        }

                                    }

                                }

                                else
                                {
                                    Console.WriteLine("Yanlış EFT Numarası. Lütfen başına TR ekleyin ve 12 haneli bir numara girin.");

                                }

                            }
                            else if (secim2 == "2")
                            {

                                Console.Write(" 11 haneli hesap numarasını giriniz: ");
                                string hesapNo = Console.ReadLine();
                                if (hesapNo.Length == 11)
                                {
                                    Console.Write("Lütfen yatırmak istediğiniz tutarı giriniz: ");
                                    double gonderilecekTutar = Convert.ToDouble(Console.ReadLine());
                                    if (gonderilecekTutar > bakiye)
                                    {
                                        Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır. \n9 Ana Menüye Dön\n0 Hesaptan çık");
                                        string secim = Console.ReadLine();
                                        if (secim == "9")
                                        {
                                            // GO TO ANA MENÜ
                                        }
                                        else if (secim == "0")
                                        {
                                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                                        }
                                    }
                                    else if (gonderilecekTutar < bakiye)
                                    {
                                        bakiye = bakiye - gonderilecekTutar;
                                        Console.WriteLine("EFT yapılmıştır. Yeni Bakiyeniz: " + bakiye);

                                        Console.WriteLine("\n 9 Ana Menüye Dön \n0 Hesaptan Çık");
                                        string secim = Console.ReadLine();
                                        if (secim == "9")
                                        {
                                            // GO TO ANA MENÜ
                                        }
                                        else if (secim == "0")
                                        {
                                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                                        }

                                    }

                                }

                                else
                                {
                                    Console.WriteLine("Hatalı Hesap Numarası. Lütfen 11 haneli bir numara girin.");

                                }
                            }

                        }
                        else if (AnaMenu == "4")
                        {
                            Console.WriteLine("Eğitim Ödemeleri için şu anda hizmet veremiyoruz. ");
                        }
                        else if (AnaMenu == "5")
                        {
                            Console.WriteLine("Elektrik Faturası 1 ");
                            Console.WriteLine("Telefon  Faturası 2 ");
                            Console.WriteLine("İnternet Faturası 3 ");
                            Console.WriteLine("Su       Faturası 4 ");
                            Console.WriteLine("OGS     Ödemeleri 5 ");

                            int secim5 = Convert.ToInt32(Console.ReadLine());
                            if (secim5 == 1)
                            {
                                Console.WriteLine(" Lütfen ödemek istediğiniz Elektrik Faturası tutarını giriniz. ");
                                int faturaTutari = Convert.ToInt32(Console.ReadLine());

                                bakiye = bakiye - faturaTutari;

                                Console.WriteLine(" Faturanız Ödenmiştir. \n Yeni Bakiye=  " + bakiye);
                            }
                            else if (secim5 == 2)
                            {
                                Console.WriteLine(" Lütfen ödemek istediğiniz Telefon  Faturası tutarını giriniz. ");
                                int faturaTutari2 = Convert.ToInt32(Console.ReadLine());

                                bakiye = bakiye - faturaTutari2;

                                Console.WriteLine(" Faturanız Ödenmiştir. \n Yeni Bakiye=  " + bakiye);
                            }
                            else if (secim5 == 3)
                            {
                                Console.WriteLine(" Lütfen ödemek istediğiniz İnternet  Faturası tutarını giriniz. ");
                                int faturaTutari3 = Convert.ToInt32(Console.ReadLine());

                                bakiye = bakiye - faturaTutari3;

                                Console.WriteLine(" Faturanız Ödenmiştir. \n Yeni Bakiye=  " + bakiye);
                            }
                            else if (secim5 == 4)
                            {
                                Console.WriteLine(" Lütfen ödemek istediğiniz Su   Faturası tutarını giriniz. ");
                                int faturaTutari4 = Convert.ToInt32(Console.ReadLine());

                                bakiye = bakiye - faturaTutari4;

                                Console.WriteLine(" Faturanız Ödenmiştir. \n Yeni Bakiye=  " + bakiye);
                            }
                            else if (secim5 == 5)
                            {
                                Console.WriteLine(" Lütfen ödemek istediğiniz OGS Ödeme tutarını giriniz. ");
                                int faturaTutari5 = Convert.ToInt32(Console.ReadLine());

                                bakiye = bakiye - faturaTutari5;

                                Console.WriteLine(" OGS Ödenmiştir. \n Yeni Bakiye=  " + bakiye);
                            }
                        }
                        else if (AnaMenu == "6")
                        {
                            Console.WriteLine("Lütfen yapmak istediğiniz işlemi tuşlayınız: ");
                            Console.WriteLine("1 Şifre değiştirme");
                            string sifreDegistir = Console.ReadLine();
                            Console.WriteLine("Lütfen yeni şifrenizi tuşlayınız: ");
                            string yeniSifre = Console.ReadLine();
                            sifre = yeniSifre;
                            Console.WriteLine("Şifren başarıyla değişmiştir. \n 9 Ana Menüye Dön \n0 Hesaptan Çık");
                            string secim1 = Console.ReadLine();

                            if (secim1 == "9")
                            {
                                // GO TO ANA MENÜ
                            }
                            else if (secim1 == "0")
                            {
                                Console.WriteLine("Hesaptan çıkış yapıldı.");
                            }
                        }

                        break;
                    }
                    else
                    {
                        hak--;
                        Console.WriteLine("Yanlış şifre. Kalan giriş hakkı " + hak);
                    }

                    if (hak == 0)
                    {
                        Console.WriteLine("3 defa hatalı girdiniz kartınız bloke olmuştur.");
                        break;
                    }
                }
            }
            else if (baslangic == "2")
            {

                Console.WriteLine("\n***ANA MENÜ***\n\nLütfen yapmak istediğiniz işlemi tuşlayınız");

                Console.WriteLine("1 - CepBank Para çekme");
                Console.WriteLine("2 - Para yatırma");
                Console.WriteLine("3 - Kredi Kartı Ödeme");
                Console.WriteLine("4 - Eğitim Ödemeleri");
                Console.WriteLine("5 - Ödemeler");

                string AnaMenu2 = Console.ReadLine();

                if (AnaMenu2 == "1")
                {
                    Console.WriteLine("Cep Telefonu numaranızı başında 0 olmadan giriniz:");
                    string cepNo = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("TC Kimlik No giriniz:");
                    string kimlikNo = Convert.ToString(Console.ReadLine());

                    int hak2 = 3;

                    if (cepNo == "5012345678" && kimlikNo == "11234567890")
                    {

                        Console.WriteLine("CepBank'ınıza tanımlanan 1000TRY ödemeniz yapılmıştır.");

                    }
                    else
                    {
                        hak2--;
                        Console.WriteLine("Yanlış bilgiler. Kalan giriş hakkı " + hak2);
                    }

                    if (hak2 == 0)
                    {
                        Console.WriteLine("3 defa hatalı girdiniz. Hesabınız bloke olmuştur. \n 1 saat sonra tekrar deneyiniz.");

                    }

                }
                else if (AnaMenu2 == "2")
                {

                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi tuşlayınız");

                    Console.WriteLine("1 - Nakit Ödeme");
                    Console.WriteLine("2 - Hesaptan Ödeme");
                    Console.WriteLine("\n 9 Ana Menüye Dön \n0 Hesaptan Çık");




                }
                else if (AnaMenu2 == "3")
                {

                    Console.WriteLine("12 haneli kredi kartı numaranızı giriniz.");
                    string kredikartı2 = Convert.ToString(Console.ReadLine());

                    if (kredikartı2.Length != 12)
                    {

                        Console.WriteLine("Lütfen kontrol ederek tekrar tuşlayınız.");
                        
                    }
                    else if (kredikartı2.Length == 12)
                    {
                        Console.Write("yatırılacak tutarı giriniz:");
                        double yatirilacakTutar2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Kredi Kartına ödeme yapılmıştır.");
                        Console.WriteLine("\n 9 Ana Menüye Dön \n0 Hesaptan Çık");

                        string secim = Console.ReadLine();
                        if (secim == "9")
                        {
                            // GO TO ANA MENÜ
                        }
                        else if (secim == "0")
                        {
                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                        }



                    }
                    else if (AnaMenu2 == "4")
                    {

                        Console.WriteLine("Eğitim Ödemeleri için şu anda hizmet veremiyoruz. ");
                    }


                    Console.ReadLine();
                }
            }
        }
    }
}

