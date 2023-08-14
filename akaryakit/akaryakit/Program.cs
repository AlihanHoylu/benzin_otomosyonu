using System.Drawing;
using System.IO;

internal class Program
{
    public static double dizelfiyat = 27.56;
    public static double benzinfiyat = 29.4;

    public static int dizellitre = 100;
    public static int benzinlitre = 100;

    public static double girenpara;
    public static double cikanpara;
    public static double para = 5000;



    public static string[] dizin = { "C:\\Program Files\\akaryakitprogram\\kayit.txt", "C:\\Program Files\\akaryakitprogram\\para.txt" };
    public static int ation;
    private static void Main()
    {
        Console.ResetColor();
        ation = 0;
        cagir();
        Console.WriteLine("--------------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Akaryakit uygulamasina hosgeldiniz");
        Console.ResetColor();
        Console.WriteLine("--------------------------------------");
        Console.Write("Akaryakit fiyatini listelemek icin tuslayiniz");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("              [1]");
        Console.WriteLine("");
        Console.ResetColor();
        Console.Write("Akaryakit fiyatini degistirmek icin tuslayiniz");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("             [2]");
        Console.WriteLine("");
        Console.ResetColor();
        Console.Write("Depodaki akaryakit miktarini listelemek icin tuslayiniz");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("    [3]");
        Console.WriteLine("");
        Console.ResetColor();
        Console.Write("Depoya akaryakit eklemek icin tuslayiniz");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("                   [4]");
        Console.WriteLine("");
        Console.ResetColor();
        Console.Write("Satis ekranini acmak icin tuslayiniz");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("                       [5]");
        Console.ResetColor();
        Console.WriteLine("--------------------------------------");
        try
        {
            ation = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            if (ation == 1)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Benzin fiyati: " + benzinfiyat);
                Console.WriteLine("Dizel fiyati: " + dizelfiyat);
                Main();
            }

            if (ation == 2)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Akaryakit fiyat düzenleme ekranina hosgeldiniz", Color.Green);
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Benzin fiyati: " + benzinfiyat);
                Console.WriteLine("Dizel fiyati: " + dizelfiyat);
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Benzin fiyatini degistirmek icin tuslayiniz");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                [1]");

                Console.ResetColor();
                Console.WriteLine("");
                Console.Write("Dizel fiyatini degistirmek icin tuslayiniz");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                 [2]");

                Console.ResetColor();
                Console.WriteLine("");
                Console.Write("Iptal etmek icin tuslayiniz");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                                [3]");

                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------");
                int degisim = Convert.ToInt32(Console.ReadLine());
                if (degisim == 2)
                {
                    try
                    {
                        Console.WriteLine("Yeni dizel akaryakit fiyatini giriniz...");

                        dizelfiyat = Convert.ToDouble(Console.ReadLine());
                        StreamWriter yazdizel = new StreamWriter(dizin[0]);
                        yazdizel.WriteLine(benzinfiyat);
                        yazdizel.WriteLine(dizelfiyat);
                        yazdizel.WriteLine(benzinlitre);
                        yazdizel.WriteLine(dizellitre);
                        yazdizel.Close();
                        Console.WriteLine("Yeni dizel akaryakit fiyati: " + dizelfiyat);
                        Main();
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Islem sirasinda bir hata oluştu...");
                        Main();
                    }
                }
                if (degisim == 1)
                {
                    try
                    {
                        Console.WriteLine("Yeni benzin fiyatini giriniz...");

                        benzinfiyat = Convert.ToDouble(Console.ReadLine());
                        StreamWriter yazdizel = new StreamWriter(dizin[0]);
                        yazdizel.WriteLine(benzinfiyat);
                        yazdizel.WriteLine(dizelfiyat);
                        yazdizel.WriteLine(benzinlitre);
                        yazdizel.WriteLine(dizellitre);
                        yazdizel.Close();
                        Console.WriteLine("Yeni benzin fiyati: " + benzinfiyat);
                        Main();
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Islem sirasinda bir hata oluştu...");
                        Main();
                    }
                }
                if (degisim == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Islem iptal edildi...");
                    Main();
                }

            }
            if (ation == 3)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Depodaki benzinin litresi: " + benzinlitre);
                Console.WriteLine("Depodaki dizel yakitin litresi: " + dizellitre);
                Main();
            }
            if (ation == 4)
            {

                Console.WriteLine("-------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Akaryakit fiyat düzenleme ekranina hosgeldiniz", Color.Green);
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------");


                Console.Write("Depoya benzin eklemek icin tuslayiyiniz");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                    [1]");

                Console.ResetColor();
                Console.WriteLine("");
                Console.Write("Depoya dizel akaryakit eklemek icin tuslayiyiniz");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("      [2]");

                Console.ResetColor();
                Console.WriteLine("");
                Console.Write("Iptal etmek icin 3 tuslayiniz...");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                           [3]");

                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------");
                int degisim = Convert.ToInt32(Console.ReadLine());
                if (degisim == 1)
                {
                    try
                    {
                        Console.WriteLine("Depoya kac litre benzin ekleneceğini yaziniz...");
                        int eklenenbenzin = Convert.ToInt32(Console.ReadLine());
                        if (eklenenbenzin <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Bu miktarda ekleme yapamazsiniz...");
                            Main();
                        }
                        else
                        {
                            benzinlitre += eklenenbenzin;
                            StreamWriter yazdizel = new StreamWriter(dizin[0]);
                            yazdizel.WriteLine(benzinfiyat);
                            yazdizel.WriteLine(dizelfiyat);
                            yazdizel.WriteLine(benzinlitre);
                            yazdizel.WriteLine(dizellitre);
                            yazdizel.Close();
                            Console.WriteLine("Benzinin litresinin kac tlden alindigini yaziniz");
                            int alimpara = Convert.ToInt32(Console.ReadLine());
                            cikanpara = eklenenbenzin * alimpara;
                            para -= cikanpara;
                            StreamWriter muhasebeyaz = new StreamWriter(dizin[1]);
                            muhasebeyaz.WriteLine(para);
                            muhasebeyaz.Close();
                            Main();
                        }
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Islem sirasinda bir hata oluştu...");
                        Main();
                    }
                }
                if (degisim == 2)
                {
                    try
                    {
                        Console.WriteLine("Depoya kac litre dizel yakit ekleneceğini yaziniz...");
                        int eklenendizel = Convert.ToInt32(Console.ReadLine());
                        if (eklenendizel <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Bu miktarda ekleme yapamazsiniz...");
                            Main();
                        }
                        else
                        {
                            dizellitre += eklenendizel;
                            StreamWriter yazdizel = new StreamWriter(dizin[0]);
                            yazdizel.WriteLine(benzinfiyat);
                            yazdizel.WriteLine(dizelfiyat);
                            yazdizel.WriteLine(benzinlitre);
                            yazdizel.WriteLine(dizellitre);
                            yazdizel.Close();
                            Console.WriteLine("Dizel akaryakitin litresinin kac tlden alindigini yaziniz");
                            int alimpara = Convert.ToInt32(Console.ReadLine());
                            cikanpara = eklenendizel * alimpara;
                            para -= cikanpara;
                            StreamWriter muhasebeyaz = new StreamWriter(dizin[1]);
                            muhasebeyaz.WriteLine(para);
                            muhasebeyaz.Close();
                            Main();
                        }
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Islem sirasinda bir hata oluştu...");
                        Main();
                    }
                }
                if (degisim == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Islem iptal edildi");
                    Main();
                }
            }
            if (ation == 5)
            {
                try
                {
                    int satistur;
                    int satislitre;
                    string aliciadi;
                    string alicisoyadi;
                    string onay;


                    Console.WriteLine("------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Akaryakit satis ekranina hosgeldiniz", Color.Green);
                    Console.ResetColor();
                    Console.WriteLine("------------------------------------");
                    Console.Write("Benzin satisi yapmak icin tuslayiniz");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("           [1]");
                    Console.WriteLine("");
                    Console.ResetColor();
                    Console.Write("Dizel yakit satisi yapmak icin tuslayiniz");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("      [2]");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Console.ResetColor();
                    Console.Write("Islemi iptal etmek icin tuslayiniz");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("             [3]");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.Write("Para miktarini listelemek icin tuslayiniz");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("      [4]");
                    Console.ResetColor();
                    Console.WriteLine("------------------------------------");
                    satistur = Convert.ToInt32(Console.ReadLine());

                    if (satistur == 1)
                    {
                        Console.WriteLine("Depoda " + benzinlitre + " litre benzin vardir");
                        Console.WriteLine("Kac litre benzin satmak istediğinizi yaziniz...");
                        satislitre = Convert.ToInt32(Console.ReadLine());
                        if (satislitre <= benzinlitre)
                        {
                            Console.WriteLine("Alici adi giriniz...");
                            aliciadi = Convert.ToString(Console.ReadLine()) + "";
                            Console.WriteLine("Alici soy adi giriniz...");
                            alicisoyadi = Convert.ToString(Console.ReadLine()) + "";
                            girenpara = satislitre * Convert.ToDouble(benzinfiyat);
                            Console.WriteLine(aliciadi + " " + alicisoyadi + " isimli musteriye " + satislitre + " litre benzinin " + benzinfiyat + " fiyatindan satisini onayliyorsaniz onay yaziniz... ");
                            Console.Write("Toplam tutar " + girenpara + "==>");
                            onay = Console.ReadLine() + "";
                            if (onay == "onay")
                            {
                                Console.WriteLine(aliciadi + " " + alicisoyadi + " isimli müstriye " + satislitre + " litre benzin " + benzinfiyat + " fiyatindan satilmistir... ");

                                benzinlitre -= satislitre;
                                StreamWriter yazdizel = new StreamWriter(dizin[0]);
                                yazdizel.WriteLine(benzinfiyat);
                                yazdizel.WriteLine(dizelfiyat);
                                yazdizel.WriteLine(benzinlitre);
                                yazdizel.WriteLine(dizellitre);
                                yazdizel.Close();
                                Console.WriteLine("Toplam tutar: " + girenpara);
                                Console.WriteLine("Depoda " + benzinlitre + " litre benzin kalmistir");

                                StreamWriter muhasebeyaz = new StreamWriter(dizin[1]);
                                string a = (Convert.ToString(aliciadi) + " " + Convert.ToString(alicisoyadi) + " isimli musteriye " + Convert.ToString(satislitre) + " litre benzin " + Convert.ToString(benzinfiyat) + " fiyatindan satildi ");
                                para += girenpara;
                                muhasebeyaz.WriteLine(para);
                                Console.WriteLine(a);
                                muhasebeyaz.WriteLineAsync(a);
                                muhasebeyaz.Close();

                                Main();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Satis onaylanmamistir...");
                                Main();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Depoda bu kadar benzin yok...");
                            Main();
                        }





                    }

                    if (satistur == 2)
                    {
                        Console.WriteLine("Depoda " + dizellitre + " litre dizel akaryakit vardir");
                        Console.WriteLine("Kac litre dizel akaryakit satmak istediğinizi yaziniz...");

                        satislitre = Convert.ToInt32(Console.ReadLine());
                        if (satislitre <= dizellitre)
                        {
                            Console.WriteLine("Alici adi giriniz...");
                            aliciadi = Convert.ToString(Console.ReadLine()) + "";
                            Console.WriteLine("Alici soy adi giriniz...");
                            alicisoyadi = Convert.ToString(Console.ReadLine()) + "";
                            girenpara = satislitre * Convert.ToDouble(dizelfiyat);
                            Console.WriteLine(aliciadi + " " + alicisoyadi + " isimli musteriye " + satislitre + " dizel akaryakit benzinin " + dizelfiyat + " fiyatindan satisini onayliyorsaniz onay yaziniz... ");
                            Console.Write("Toplam tutar: " + girenpara + "==>");
                            onay = Console.ReadLine() + "";
                            if (onay == "onay")
                            {
                                Console.WriteLine(aliciadi + " " + alicisoyadi + " isimli müstriye " + satislitre + " litre dizel akaryakit " + dizelfiyat + " fiyatindan satilmistir... ");

                                dizellitre -= satislitre;
                                StreamWriter yazdizel = new StreamWriter(dizin[0]);
                                yazdizel.WriteLine(benzinfiyat);
                                yazdizel.WriteLine(dizelfiyat);
                                yazdizel.WriteLine(benzinlitre);
                                yazdizel.WriteLine(dizellitre);
                                yazdizel.Close();
                                Console.WriteLine("Toplam tutar: " + girenpara);
                                Console.WriteLine("Depoda " + dizellitre + " litre dizel akaryakit kalmistir");
                                StreamWriter muhasebeyaz = new StreamWriter(dizin[1]);
                                string a = (Convert.ToString(aliciadi) + " " + Convert.ToString(alicisoyadi) + " isimli musteriye " + Convert.ToString(satislitre) + " litre dizel akaryakit " + Convert.ToString(dizelfiyat) + " fiyatindan satildi ");
                                para += girenpara;
                                muhasebeyaz.WriteLine(para);
                                Console.WriteLine(a);
                                muhasebeyaz.WriteLineAsync(a);
                                muhasebeyaz.Close();
                                Main();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Satis onaylanmamistir...");
                                Main();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Depoda bu kadar dizel akaryakit yok...");
                            Main();
                        }
                    }
                    if (satistur == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Islem iptal edildi");
                        Main();
                    }
                    if (satistur == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Kasadaki para: " + para);
                        Main();

                    }
                    if (satistur != 1 && satistur != 2 && satistur != 3 && satistur != 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hatali tuslama yaptiniz");
                        Console.ResetColor();
                        Main();
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Islem sirasinda bir hata olustu...");
                    Main();
                }

            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hatali tuslama yaptiniz");
            Console.ResetColor();
            Main();
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hatali tuslama yaptiniz");
            Main();
        }


    }

    public static void cagir()
    {
        StreamReader oku = new StreamReader(dizin[0]);
        benzinfiyat = Convert.ToDouble(oku.ReadLine());
        dizelfiyat = Convert.ToDouble(oku.ReadLine());
        benzinlitre = Convert.ToInt32(oku.ReadLine());
        dizellitre = Convert.ToInt32(oku.ReadLine());
        oku.Close();

        StreamReader paraoku = new StreamReader(dizin[1]);
        para = Convert.ToDouble(paraoku.ReadLine());
        paraoku.Close();

    }
}