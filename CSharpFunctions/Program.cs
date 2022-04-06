// See https://aka.ms/new-console-template for more information

//DICHIARARE ARRAY
int[] arrayDiNumeri = { 2, 6, 7, 5, 3, 9 };


// PRIMA FUNZIONE E STAMPA 

void StampaArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Elemento " + array[i]);
    }
}

StampaArray(arrayDiNumeri);


// SECONDA FUNZIONE E STAMPA

int Quadrato(int numero)
{
    int quadrato = (int)Math.Pow(numero, 2);
    Console.Write("Il quadrato di " + numero + " è: ");
    return quadrato;
}

Console.WriteLine("Digita un numero da QUADRATIZZARE :) ");
int numeroDigitato = int.Parse(Console.ReadLine());
int numeroAlQuadrato = Quadrato(numeroDigitato);
Console.WriteLine(numeroAlQuadrato);

// TERZA FUNZIONE E STAMPA

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = copiaArray[i] * copiaArray[i];
    }
    return copiaArray;
}

Console.WriteLine("Array Quadratizzato :)");
int[] arrayDiNumeriAlQuadrato = ElevaArrayAlQuadrato(arrayDiNumeri);
StampaArray(arrayDiNumeriAlQuadrato);

// QUARTA FUNZIONE E STAMPA

int SommaElementiArray(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    int somma = 0;

    for(int i = 0; i < copiaArray.Length; i++)
    {
       somma += copiaArray[i]; ;
    }
    return somma;
}

int somma = SommaElementiArray(arrayDiNumeri);
Console.WriteLine("La somma dell'array è  " + somma);

i