﻿Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0) Console.WriteLine("Число " + a + " чётное.");
else Console.WriteLine("Число " + a + " не чётное.");