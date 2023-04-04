// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Create un progetto App Console CibiPreferiti con Visual Studio.
//Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi). L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
//Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
//-La lunghezza della classifica
//- La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
//-Il vostro cibo top (prima posizione della classifica)
//-Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
//Le modalità di consegna sono le solite: repo GitHub, commit e push


//Stampo a video i titoli della lista

Console.WriteLine("I miei cibi preferiti");


//Creo l'array contente tutti i miei cibi preferiti

string[] listaCibiPreferiti = { "Patate al forno", "Ravioli", "Pizza", "Sushi", "Polpettone", "Pasta", "Pollo arrosto", "Hamburger", "Gelato" };

//Creo il ciclo for per stampare l' array

for (var i = 0; i < listaCibiPreferiti.Length; i++)
{
    Console.WriteLine(listaCibiPreferiti[i]);
}


//Classifica cibi preferiti

Console.WriteLine("1° =" + listaCibiPreferiti[0]);
Console.WriteLine("2° =" + listaCibiPreferiti[3]);
Console.WriteLine("3° =" + listaCibiPreferiti[7]);
Console.WriteLine("4° =" + listaCibiPreferiti[2]);
Console.WriteLine("5° =" + listaCibiPreferiti[1]);
Console.WriteLine("6° =" + listaCibiPreferiti[5]);
Console.WriteLine("7° =" + listaCibiPreferiti[4]);
Console.WriteLine("8° =" + listaCibiPreferiti[9]);
Console.WriteLine("1° =" + listaCibiPreferiti[8]);


