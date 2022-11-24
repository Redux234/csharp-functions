
//Funzione stampa array di numeri interi

int[] ArrayNumeriInteri = { 2, 6, 7, 5, 3, 9 };
SampaArrayNumeriInteri(ArrayNumeriInteri);


void SampaArrayNumeriInteri(int[] ArrayNumeriInteri)
{
    Console.Write("Array 1 base: [ ");
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

int[] ArrayNumeri = { 2, 6, 7, 5, 3, 9 };
Quadrato(ArrayNumeri);


void Quadrato(int[] ArrayNumeriBase)

    //Stampo l'array base
{

    Console.Write("Array 2 base: [ ");
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

    Console.Write("Array 2 al quadrato: [ ");
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

int[] ArrayNumeriDaMoltiplicare= { 2, 6, 7, 5, 3, 9 };
int[] ArrayNumeriAlQuadrato = (int[])ArrayNumeriDaMoltiplicare.Clone() ;
ArrayQuadrato(ArrayNumeriAlQuadrato);


void ArrayQuadrato(int[] ArrayNumeriAlQuadrato)

//Stampo l'array base
{

    Console.Write("Array 3 base[ ");
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

    Console.Write("Array 4, creato array con elementi che sono il quadrato del primo: [");

    for (int i=0; i<ArrayNumeriAlQuadrato.Length; i++)
    {
        ArrayNumeriAlQuadrato[i] = ArrayNumeriAlQuadrato[i] * ArrayNumeriAlQuadrato[i];
       
        if (i == ArrayNumeriAlQuadrato.Length - 1)
        {
            Console.Write(ArrayNumeriAlQuadrato[i]);
        }
        else
        {
            Console.Write(ArrayNumeriAlQuadrato[i] + ", ");
        }
    }
    Console.WriteLine(" ]");
}




//Funzione somma

int[] ArrayNumeriDaSommare = { 2, 6, 7, 5, 3, 9 };
SommaNumeri(ArrayNumeriDaSommare);


void SommaNumeri(int[] ArrayNumeriDaSommare)

//Stampo l'array base
{

    Console.Write("Array 4 base: [ ");
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
    Console.WriteLine("Array 4 somma: [" + somma + "]");
    
    
}

// Quadrato della somma 

int[] ArrayDaSommare = { 2, 6, 7, 5, 3, 9 };
QuadratoDellaSomma(ArrayDaSommare);


void QuadratoDellaSomma(int[] ArrayDaSommare)

//Stampo l'array base
{

    Console.Write("Array 5 base: [ ");
    for (int i = 0; i < ArrayDaSommare.Length; i++)
    {
        if (i == ArrayDaSommare.Length - 1)
        {
            Console.Write(ArrayDaSommare[i]);
        }
        else
        {
            Console.Write(ArrayDaSommare[i] + ", ");
        }
    }
    Console.WriteLine(" ]");

    //Stampo la modifica

    int somma = ArrayDaSommare.Sum();
    int quadratodellasomma = somma * somma;
    Console.WriteLine("Il Quadrato Della somma è: " + quadratodellasomma);


}
