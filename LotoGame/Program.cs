

Console.WriteLine("LOTO GAME ! PLEASE ENTER THE NUMBER OF COLUMNS");

int[] lottery = new int[6];
int columns=Convert.ToInt32(Console.ReadLine());
for (int j = 0; j < columns; j++)
{
    for (int i = 0; i < lottery.Length; i++)
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 91);
        int isExist = Array.IndexOf(lottery, number);
        if (isExist == -1)
        {
            lottery[i] = number;
        }

        else
        {
            i--;
        }

    }
    if (lottery.Count()==6)
    {
        Array.Sort(lottery);
        foreach (var item in lottery)
        {
            Console.Write(item + " ");
            

        }
       
        Console.WriteLine("");

    }
    
    
}



Console.ReadLine();
