using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {

        var nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 32);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Whatsapp");

        var iphone = new Iphone("987654321", "iPhone 12", "987654321098765", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Angry Birds");
    }
}