// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using modul4_103022330077;

internal class fanLaptop
{
    enum State { turbo, balanced, quite, performance };

    State fanState = State.quite;
    public fanLaptop()
    {
         private void turboOff()
    {
        if (this.fanState == State.turbo)
        {
            fanState = State.quite;
        }
    }
    private void turboOn()
    {
        if (this.fanState == State.quite)
        {
            fanState = State.turbo;
        }
    }
    private void modeUp()
    {
        if (this.fanState == State.quite)
        {
            fanState = State.balanced;
            Console.WriteLine("fan quite beruban menjadi balnced");
        }
        else if (this.fanState == State.balanced)
        {
            Console.WriteLine("fan quite beruban menjadi performance");
            fanState = State.performance;
        }
        else if (this.fanState == State.performance)
        {
            fanState = State.turbo;
            Console.WriteLine("fan quite beruban menjadi turbo");
        }
        else if (this.fanState == State.turbo)
        {
            fanState = State.turbo;
            Console.WriteLine("fan quite mencapai batas");

        }
    }

    public void modeDown()
    {
        if (this.fanState == State.turbo)
        {
            fanState = State.performance;
            Console.WriteLine("fan quite berubah menjadi performance");
        }
        else if (this.fanState == State.performance)
        {
            fanState = State.balanced;
            Console.WriteLine("fan quite beruban menjadi balanced");
        }
        else if (this.fanState == State.balanced)
        {
            fanState = State.quite;
            Console.WriteLine("fan quite beruban menjadi quite");
        }
        else if (this.fanState == State.quite)
        {
            fanState = State.quite;
            Console.WriteLine("fan quite sudah quite");
        }
    }
}
 

    

class Program
{
    static void Main(string[] args)
    {
        Produk kode = new Produk();
        Console.WriteLine("Kode Produk Elektronik");
        for (int i = 0; i < kode.kodeProduk.Length; i++)
        {
            Console.WriteLine(kode.kodeProduk[i] + " - " + kode.produkElektronik[i]);
        }
        fanLaptop fan = new fanLaptop();

        fan.modeUp();
        fan.modeUp();
        fan.modeUp();
        fan.modeDown();
        fan.modeDown();
        fan.modeDown();

    }
}
public class Produk
{

    public string[] kodeProduk = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109" };
    public string[] produkElektronik = { "laptop", "smartphone", "tablet", "hedset", "keyboard", "mouse", "printer", "monitor", "smartwatch", "kamera" };

}