
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

int[] ArrayNumeri = { 2, 5, 7, 9, 12 };
Quadrato(ArrayNumeri);


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

//Funzione che crea un nuovo array con gli elementi che sono il quadrato degli elementi del primo array

int[] ArrayNumeriDaMoltiplicare= { 2, 5, 7, 9, 12 };
ArrayQuadrato(ArrayNumeriDaMoltiplicare);
void ArrayQuadrato(int[] ArrayNumeriDaMoltiplicare)

//Stampo l'array base
{

    Console.Write("[ ");
    for (int i = 0; i < ArrayNumeriDaMoltiplicare.Length; i++)
    {
        if (i == ArrayNumeriDaMoltiplicare.Length - 1)
        {
            Console.Write(ArrayNumeriDaMoltiplicare[i]);
        }
        else
        {
            Console.Write(ArrayNumeriDaMoltiplicare[i] + ", ");
        }
    }
    Console.WriteLine(" ]");

    //Stampo la modifica

    for (int i = 0; i < ArrayNumeriDaMoltiplicare.Length; i++)
    {
        int nuemroquadrato = ArrayNumeriDaMoltiplicare[i] * ArrayNumeriDaMoltiplicare[i];
  
        
    }
   

}


//Funzione somma

int[] ArrayNumeriDaSommare = { 2, 5, 7, 9, 12 };
SommaNumeri(ArrayNumeriDaSommare);


void SommaNumeri(int[] ArrayNumeriDaSommare)

//Stampo l'array base
{

    Console.Write("[ ");
    for (int i = 0; i < ArrayNumeriDaSommare.Length; i++)
    {
        if (i == ArrayNumeriDaSommare.Length - 1)
        {
            Console.Write(ArrayNumeriDaSommare[i]);
        }
        else
        {
            Console.Write(ArrayNumeriDaSommare[i] + ", ");
        }
    }
    Console.WriteLine(" ]");

    //Stampo la modifica

    int somma = ArrayNumeriDaSommare.Sum();
    Console.WriteLine(somma);
    
    
}