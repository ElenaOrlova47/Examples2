//Видыы методов:
//1. Методы, которые ничего не возвращают и ничего не принимают:
void Method1()
    {
        Console.WriteLine("Автор: Елена Орлова");  //тело метода
    }
Method1();

//2. Методы, которые ничего не возращают, но могут принимать какие-то аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;    
    }
}
Method21("Текст", 4);

//3.Методы, которые ничего не принимают, но возвращают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//4. Методы, которые что-то принимают и что-то возращают
string Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;
    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string result = Method4(5, "z");
Console.WriteLine(result);