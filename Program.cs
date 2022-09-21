internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Süleyman");
        byte b = 5;     //1 byte yer kaplar 0-255 arası değerleri alır.
        sbyte c = 1;    //1 byte yer kaplar -128 - 127 arası değerleri alır.
        short s = 5;    //2 byte yer kaplar
        ushort us = 5;  //2 byte yer kaplar 0-65.365 değerleri alır.

        Int16 i16 = 2;  //2 byte yer kaplar
        int i = 2;      //4 byte yer kaplar
        Int32 i32 = 2;  //4 byte yer kaplar
        Int64 i64 = 2;  //8 byte yer kaplar

        uint ui =  2;     //4 byte yer kaplar
        long l =   4;     //8 byte yer kaplar
        ulong ul = 4;    //8 byte yer kaplar

        float f =  5;     //4 byte yer kaplar reel sayılar
        double d = 5;     //8 byte yer kaplar reel sayılar
        decimal de = 5;   //16 byte yer kaplar reel sayılar

        char cb = '2';          //2 byte yer kaplar
        string str ="Süleyman"; //sınırsınız

        bool b1 = true;   //True Veya False için
        bool b2 = false;

        DateTime dt = DateTime.Now; //Tarih Ve Saat
        Console.WriteLine(dt);

        object o1 = "x";
        object o2 = "y";
        object o3 = 4;
        object o4 = 4.3;

        // string ifadeler

        //string str1  = "";
        //string str1 = null;
        string str1 = string.Empty;
        str1 = "süleyman arslan";
        string ad = "süleyman";
        string soyad = "arslan";
        string tamIsim = ad + " " + soyad;

        //integer tanımlama şekilleri

        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 * integer2;

        // boollean ifade

        bool bool1 = 10>2;

        // değişken dönüşümleri

        string str20 = "20";
        int int20 = 20;      
        string yenideger = str20 + int20.ToString();
        Console.WriteLine(yenideger); // Çıktısı 2020

        int int21 = int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21); // Çıktısı 40 

        int int22 = int20 + int.Parse(str20); // Çıktısı 40

        // DateTime

        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);

        string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine(datetime2);
        // saat
        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);


    }
}