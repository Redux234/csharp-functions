
//Funzione stampa array di numeri interi

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

//Funzione che eleva al quadrato gli elemnti di un array

int[] ArrayNumeriBase = { 2, 5, 7, 9, 12 };
Quadrato(ArrayNumeriBase);


void Quadrato(int[] ArrayNumeriBase)

    //Stampo l'array base
{

    Console.Write("[ ");
    for (int i = 0; i < ArrayNumeriBase.Length; i++)
    { 
        if (i == ArrayNumeriBase.Length - 1)
        {
            Console.Write(ArrayNumeriBase[i]);
        }
        else
        {
            Console.Write(ArrayNumeriBase[i] + ", ");
        }
    }
    Console.WriteLine(" ]");

    //Stampo la modifica

    Console.Write("[ ");
    for(int i=0; i < ArrayNumeriBase.Length; i++)
    {
        int nuemroquadrato = ArrayNumeriBase[i] * ArrayNumeriBase[i];
        if (i == ArrayNumeriBase.Length - 1)
        {
            Console.Write(nuemroquadrato);
        }
        else
        {
            Console.Write(nuemroquadrato + ", ");
        }
    }
    Console.WriteLine(" ]");
    
}

//




