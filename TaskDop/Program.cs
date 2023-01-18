/*Задача со звездочкой. Написать программу для перевода римских чисел в десятичные арабские.
III -> 3
LVIII -> 58
MCMXCIV -> 1994
*/

int ConvertRomanToArab(char charStrRoman)
{
    int ArabNum = 0;
    switch (charStrRoman)
    {
        case 'I': ArabNum = 1; break;
        case 'V': ArabNum = 5; break;
        case 'X': ArabNum = 10; break;
        case 'L': ArabNum = 50; break;
        case 'C': ArabNum = 100; break;
        case 'D': ArabNum = 500; break;
        case 'M': ArabNum = 1000; break;
    }
    return ArabNum;
}

int ParseRomanString(string romanStr)
{
    int numArab = 0;
    int sumArabNum = 0;
    for (int i = 0; i < romanStr.Length; i++)
    {
        numArab = ConvertRomanToArab(romanStr[i]);

        if ((i + 1) < romanStr.Length && numArab < ConvertRomanToArab(romanStr[i + 1]))
            sumArabNum -= numArab;
        else
            sumArabNum += numArab;
    }
    return sumArabNum;
}

bool CheckRomanString(string romanStr)
{
    List<char> romanlist = new List<char>();

    romanlist.Add('I');
    romanlist.Add('V');
    romanlist.Add('X');
    romanlist.Add('L');
    romanlist.Add('C');
    romanlist.Add('D');
    romanlist.Add('M');

    for (int i = 0; i < romanStr.Length; i++)
    {
        if (!romanlist.Contains(romanStr[i]))
            return true;
    }
    return false;
}
Console.WriteLine();
Console.Write("Введите римское число: ");
string roman = Console.ReadLine();

if (CheckRomanString(roman))
    Console.WriteLine("Некорректные данные");
else
    Console.WriteLine($"{roman} -> {ParseRomanString(roman)}");
