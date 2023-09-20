int[] anArray;

//Creëer een methode waarin een array met 4 elementen wordt gevuld
void vulArray()
{
    anArray = new int[4];
}

vulArray();

//Voeg code toe die de array "vergroot" telkens dit nodig is
int[] anArrayCopy = anArray; //kopie van array maken
anArray = new int[5]; //oorspronkelijke array verlengen

for (int i = 0; i < anArrayCopy.Length-1; i++)
{
    anArray[i] = anArrayCopy[i]; //de lege verlengde array vullen met de elementen van de gekopieerde array
}
//Probeer dan een waarde te geven aan een vijfde element
anArray[4] = 5;

Console.WriteLine(anArray);