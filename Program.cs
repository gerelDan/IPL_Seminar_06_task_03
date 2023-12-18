// Задача 3: Задайте произвольную строку.
//Выясните, является ли она палиндромом.
string str = "шалаjш";
void IsPalindrom(string stroka)
{
    str = stroka.ToLower();
    bool palindrom = true;
    for (int i = 0; i < str.Length/2; i++)
    {
        if (str[i] != str[str.Length-i-1])
        {
            palindrom = false;
            break;
        }
    }
    if (palindrom) Console.WriteLine($"Строка '{str}' является палиндромом");
    else Console.WriteLine($"Строка '{str}' не является палиндромом");
}
IsPalindrom(str);