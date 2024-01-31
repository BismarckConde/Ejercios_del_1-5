Console.WriteLine(" INGRESE UN NUMERO ");

if (int.TryParse(Console.ReadLine(), out int N))
{
    Console.WriteLine(" HAS INTRODUCIDO EL NUMERO "+N+" GRACIAS ");
}
else
{
    Console.WriteLine(" POR FAVOR INGRESE UN NUMERO ENTERO...");
}
Console.ReadKey();