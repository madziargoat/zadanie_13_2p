using Zadanie_13_2p;

class program
{
    static void Main(string[] args)
    {
        tablice tablice = new tablice();
        tablice.powitanie();
        int[] tab = tablice.Stworz_tablice();
        Console.Clear();
        tablice.Wyswietl_Tablice(tab);
        tablice.StortujBabelkowo(tab);
        tablice.Wyswietl_Tablice(tab);

    }
}