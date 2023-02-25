// 1. Ничего не принимают и не возвращают (void)
void Method1()
{
    Console.WriteLine("Author ...");
}
Method1();






// 2. Что-то принимают, ничего не возвращают (void)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("text message");

void Method21(string msg, int count)
{
    int i = 0;
    while ( i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
Method21("Hi", 2);// также можно явно указывать Method21(msg: "Hi", count: 4); такие 
// именованные аргументы можно ставить в любом порядке, например Method21(count:4, msg "Hi");




// 3. Ничего не принимают, что-то возвращают
int Method3() // тип данных указывается т.к будет возвращено что-то, нужен его формат
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);




// 4. Что-то принимают, что-то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result  = String.Empty;
    while(i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "qwerty");
Console.WriteLine(res);

// то же но с FOR
string Method41(int count, string text)
{
    
    string result  = String.Empty;
    for (int i = 0; i < count; i++)
    {
         result = result + text;
    }

    return result;
}
string res1 = Method41(10, "qwerty");
Console.WriteLine(res1);
