Console.WriteLine("=== Evaluación de préstamo bancario por reglas ===");
Console.WriteLine("Empleado fijo(1), Temporal(2), Independiente(3), Estudiante(4)");
Console.Write("Opcion: ");
int opcion = int.Parse(Console.ReadLine());

Console.Write("Ingreso mensual: ");
double ingresomensual = double.Parse(Console.ReadLine());

Console.WriteLine("Antiguedad laboral en meses (1= Un mes, 2= Dos meses...): ");
int meses = int.Parse(Console.ReadLine());

Console.Write("Monto solicitado: ");
double monto = double.Parse(Console.ReadLine());

Console.WriteLine("Historial crediticio (Exelente=1, Bueno=2, Regular=3, Malo=4): ");
int opcioncredito = int.Parse(Console.ReadLine());

Console.Write("Tiene fiador (Si / No): ");
string fiador = Console.ReadLine();

if (opcion < 1 && opcion > 4)
{
    Console.WriteLine("Error: Tipo de rol no válido");
    return;
}
else if (ingresomensual < 0)
{
    Console.WriteLine("Error: Crédito negativo o no válido");
    return;
}
else if (meses <0 && meses > 744)
{
    Console.WriteLine("Error: Meses laborales no válidos");
    return;
}
else if (monto < 0)
{
    Console.WriteLine("Error: Monto no válido");
    return;
}
else if (opcioncredito < 1 && opcioncredito > 4)
{
    Console.WriteLine("Error: Historial crediticio no válido");
    return;
}

   