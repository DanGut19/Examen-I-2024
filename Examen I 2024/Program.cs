using Examen_I_2024;

Console.WriteLine("Examen 1 2024");

try
{
    double Parcial1, Parcial2, Parcial3;
    Asignatura asignatura = new Asignatura();
    asignatura.Nombre = "Jose Daniel";
    asignatura.NumeroCuenta = "200319991112";
    asignatura.Email = "JDMorales@unitec.edu";
    asignatura.Nombre = "Matematicas";
    asignatura.Horario = "18:00 - 19:30";
    asignatura.Docente = "Roger Galeas";
    asignatura.InformacionAlumno();
    asignatura.MostrarAsignatura();

    Console.WriteLine("Ingrese Nota Primer Parcial");
    Parcial1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese Nota Segundo Parcial");
    Parcial2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese Nota Tercer Parcial");
    Parcial3 = double.Parse(Console.ReadLine());

    Nota nota = new Nota(Parcial1, Parcial2, Parcial3);
    nota.CalcularNotaFinal(Parcial1, Parcial2, Parcial3);
    nota.CalcularNotaFinal();
    Console.WriteLine(nota.CalcularNotaFinal(Parcial1, Parcial2, Parcial3));
    Console.WriteLine(nota.CalcularNotaFinal());

} catch (Exception e)
{
    Console.WriteLine(e.Message);
}
