//1
//creo un array di 6 numeri e lo chiamo arrayUno
int[] arrayUno = new[] { 2, 6, 7, 5, 3, 9 };

//creo una funzione che mi ciclerà su un array
void StampaArray(int[] array) 
{
    //ciclo per la lunghezza dell' array
	for (int i = 0; i < array.Length; i++)
	{
        //stampo ogni singolo elemento dell' array e gli do un trattino
        Console.Write(array[i] + "-");
    }
}

//stampo l' array chiamato arrayUno
StampaArray(arrayUno);


//2
//creo una variabile di nome Quadrato che avrà "numero"
int Quadrato(int numero)
{
    //ritornerà il quadrato di "numero"
    return numero * numero;
}


//3
int[] ElevaArrayAlQuadrato(int[] array)
{
    //creo un array di nome arrayQuadrato
    int[] arrayQuadrato = new int[array.Length];
    for (int i = 0; i < arrayQuadrato.Length; i++)
    {
        arrayQuadrato[i] = Quadrato(array[i]);
    }
    return arrayQuadrato;
}

int[] NewArray = ElevaArrayAlQuadrato(arrayUno);

Console.WriteLine();
StampaArray(NewArray);

//4
int sommaElementiArray(int[] array)
{
    int sommaArray = 0;
    foreach (int i in array)
    {
        sommaArray = sommaArray + i;
    }
    return sommaArray;
}

