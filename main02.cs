using System;
namespace SecondApp {
class ProgramFOR {

  static void Main(string[] args) {
    var f = 0; // квадрат числа n
    var p = 1; // начало закономерности
  
    Console.WriteLine("Введите число:");
	int n = int.Parse(Console.ReadLine());
		if (n<0)
			{
				Console.WriteLine("Число n не является натуральным.\nВведите ещё раз натуральное число.");
				return;
			}
	for (int i = 0; i < n; i++) 
    	{
         f = f + p; //присваивание f следующего значения
         p = p + 2; //следующее нечётное число; закономерность
    	}
	Console.WriteLine(n + "^2=" + f); // вывод переменных и текста в одну строчку
  }
}
}