
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media; //ses için gerekli olan dosyamı ekledim
namespace Ses_oynatıcı
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            SoundPlayer ses = new SoundPlayer();
            string yol;
            yol = @"C:\Users\Ahmet Karadağ\Downloads\Imagine Dragons - Believer (Thunder) by One Voice Childrens Choir.wav";//sesin dosyasından güvenlik kısmından bğlantıyı kopyalandım. Başına @ koydum yol olduğu anlaması için.istersen slaşları // yaparakta halledebilirsin
            ses.SoundLocation = yol;//ses.soundlocadion sesin kaynağı demek.yola adlı adresimi sesin kaynağı olarak al
            ses.Play();
            Console.Read();

    }       
        
    }
}
