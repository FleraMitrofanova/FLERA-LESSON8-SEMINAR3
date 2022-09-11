void CheckOnPolindrom(string word)
{
    int checkPol = 0;
    int lenght=word.Length; 
    int size = lenght/2;

    for(int i = 0, j = lenght-1; j>i; i++,j--)
    {
       if(word[i]==word[j])
       {
        checkPol++;
       }
    }
    if(checkPol==size)
    {
        Console.WriteLine("Полиндром");
    } else
    Console.WriteLine("Не полиндром");
}

Console.Write("Введите число: ");
string? word = Console.ReadLine();
CheckOnPolindrom(word);
