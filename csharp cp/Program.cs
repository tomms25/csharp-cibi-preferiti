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


//-La lunghezza della classifica

Console.WriteLine($"La classifica è composta da {listaCibiPreferiti.Length}:");

//Creo il ciclo for per stampare l' array

for (var i = 0; i < listaCibiPreferiti.Length; i++)
{
    Console.WriteLine(listaCibiPreferiti[i]);
}


//Classifica cibo preferito top 

Console.WriteLine("1° =" + listaCibiPreferiti[0]);

//Classifica cibo preferito ma non troppo

Console.WriteLine("9° =" + listaCibiPreferiti[8]);

//**BONUS**
//Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione **mediana.** Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.

if (listaCibiPreferiti.Length % 2 == 0)
{
    int ciboDiMezzo = listaCibiPreferiti.Length / 2;

    Console.WriteLine($"Il cibo di mezza classifica è {listaCibiPreferiti[ciboDiMezzo - 1]} e {listaCibiPreferiti[ciboDiMezzo]}");
}
else
{
    int ciboDiMezzo = listaCibiPreferiti.Length / 2;
    Console.WriteLine($"il cibo di mezzo della classifica è {listaCibiPreferiti[ciboDiMezzo]});
}
