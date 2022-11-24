int[] ArrayNumeriInteri = { 1, 5, 6, 9, 1, 2, 3 };
SampaArrayNumeriInteri(ArrayNumeriInteri);


void SampaArrayNumeriInteri(int[] ArrayNumeriInteri)
{
    Console.Write("[ ");
    for(int i=0; i < ArrayNumeriInteri.Length; i++)
    {
        if(i == ArrayNumeriInteri.Length -1)
        {
            Console.Write(ArrayNumeriInteri[i]);
        }
        else
        {
            Console.Write(ArrayNumeriInteri[i] + ", ");
        }
    }
    Console.WriteLine(" ]");
}
