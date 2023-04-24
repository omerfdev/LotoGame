using System.Collections.Immutable;
using System.ComponentModel.Design;

Console.WriteLine("LOTO GAME ! PLEASE ENTER THE NUMBER OF COLUMNS");

int[] kolon = new int[6];
int columns=Convert.ToInt32(Console.ReadLine());
for (int j = 0; j < columns; j++)
{
    for (int i = 0; i < kolon.Length; i++)
    {
        Random rnd = new Random();
        int sayi = rnd.Next(1, 91);
        int varmı = Array.IndexOf(kolon, sayi);
        if (varmı == -1)
        {
            kolon[i] = sayi;
        }

        else
        {
            i--;
        }

    }
    if (kolon.Count()==6)
    {
        Array.Sort(kolon);
        foreach (var item in kolon)
        {
            Console.Write(item + " ");

        }
        Console.WriteLine("");

    }
    
    
}



Console.ReadLine();
