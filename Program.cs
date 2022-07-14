
Console.WriteLine("Cual es tu nombre");
string nombre = Convert.ToString(Console.ReadLine());

Console.WriteLine("Hola " + nombre );

Console.WriteLine("¿Que hora es?");
int hora = Int32.Parse(Console.ReadLine());

Console.WriteLine("¿Con cuantos minutos?");
int minutos = Int32.Parse(Console.ReadLine());

Console.WriteLine("Son las " + hora + ":" + minutos);
