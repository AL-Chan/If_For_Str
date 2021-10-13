using System;
namespace ThirdApp {
class ProgramSTRING {
  static void Main(string[] args) {
	var dub = 0; // счётчик
	
	Console.WriteLine("Введите предложение:");
	string sentence = Console.ReadLine(); 
	
	Console.WriteLine("Ниже предложение без пробелов:");
	sentence = System.Text.RegularExpressions.Regex.Replace(sentence, "[.,:;!?№() -]", String.Empty); // ЗАМЕНА указанных знаков препинания и пробела на пустую строку
	Console.WriteLine(sentence); // вывод на экран предложения без пробелов

    for (int a = 0; a < sentence.Length - 1; a++)
      if (sentence[a] == sentence[a + 1])
      {
		dub++; //счётчик с шагом 1
      }
	
	if (dub!=0)
	{
	Console.WriteLine("Количество повторяющихся пар букв в предложении: " + dub);
	}
	else
	{
	Console.Write("В этом предложении нет повторяющихся пар букв");
	}
  }
}
}