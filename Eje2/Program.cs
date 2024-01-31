Console.WriteLine(" ¿CUANTOS AÑOS TIENES? ");

if (int.TryParse(Console.ReadLine(), out int Edad))
{
    Console.WriteLine(" AHORA SE QUE EDAD TIENES " + Edad + " AÑOS, GRACIAS ");
    
}   
else
{
    Console.WriteLine(" POR FAVOR INGRESE UNA EDAD REAL...");
}
Console.ReadKey();