using System;
namespace FirstApp {
class ProgramIF {
  static void Main(string[] args) {

	Console.WriteLine("Введите значение радиуса круга:"); //радиус круга
    int r = int.Parse(Console.ReadLine()); //чтение значения радиуса круга
	
	if (r <= 0)
        	{
    	Console.WriteLine("Некорректное значение радиуса круга!\nВведите заново."); 
    	return;
        	}
	
	Console.WriteLine("Введите значение стороны квадрата:"); //сторона квадрата
    int a = int.Parse(Console.ReadLine()); //чтение значения стороны квадрата
	
	if (a <= 0)
        	{
    	Console.WriteLine("Некорректное значение стороны квадрата!\nВведите заново.");
    	return;
        	}
	
	var Ssq = a * a; // формула площади квадрата
	var Sci = 3.14 * (r * r); // формула площади круга
	if (Ssq < Sci)  // условие
		{
		Console.WriteLine("Площадь круга больше площади квадрата"); 
		Console.Write(Sci +">"+ Ssq); 
		} 
	else 
		{
		Console.WriteLine("Площадь квадрата больше площади круга"); 
		Console.Write(Sci +"<"+ Ssq); 
		}
  }
}
}