//Sistema de evaluación de notas de estudiantes:
//El programa permite ingresar las notas de varios estudiantes, calcular su promedio y luego clasificar a cada estudiante
//en diferentes categorías de desempeño académico. Al final, se le pregunta al usuario si quiere ingresar otro grupo de estudiantes.

//Reglas:
//-Si el promedio del estudiante es mayor o igual a 4.5, está en la categoría Excelente.
//- Si el promedio está entre 4.0 y 4.4, está en la categoría Sobresaliente.
//- Si el promedio está entre 3.5 y 3.9, está en la categoría Bueno.
//- Si el promedio es menor a 3.5, está en la categoría Insuficiente.
//Adicional, contar cuántos estudiantes ganaron y cuántos perdieron


public class Program
{
    static void Main(string[] args)
    {
        // Variable para continúa evaluando grupos de estudiantes
        bool continuarEvaluando = true;

        while (continuarEvaluando)
        {
            Console.Clear();
            Console.WriteLine("Sistema de Evaluación de Notas de Estudiantes");

            //Obtener las notas de los estudiantes
            List<double> notas = ObtenerNotas();

            //Calcular el promedio de las notas
            double promedio = CalcularPromedio(notas);

            //Clasificar el desempeño del promedio
            string categoria = ClasificarDesempeno(promedio);

            //Mostrar resultados
            Console.WriteLine($"\nPromedio: {promedio:F2}");
            Console.WriteLine($"Categoría: {categoria}");

            // Contar estudiantes aprobados y reprobados
            int aprobados = ContarAprobados(notas);
            int reprobados = notas.Count - aprobados;

            Console.WriteLine($"\nEstudiantes aprobados: {aprobados}");
            Console.WriteLine($"Estudiantes reprobados: {reprobados}");

            // Preguntar si se desea evaluar otro grupo
            Console.Write("\n¿Desea evaluar otro grupo de estudiantes? (S/N): ");
            continuarEvaluando = Console.ReadLine().Trim().ToUpper() == "S";
        }
    }

    // Método notas de los estudiantes
    static List<double> ObtenerNotas()
    {
        List<double> notas = new List<double>();
        while (true)
        {
            Console.Write("Ingrese una nota (o presione Enter para terminar): ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break; // Terminar si no se ingresa nada

            // Validar que la nota sea un número entre 0 y 5
            if (double.TryParse(input, out double nota) && nota >= 0 && nota <= 5)
            {
                notas.Add(nota);
            }
            else
            {
                Console.WriteLine("Nota inválida. Por favor, ingrese un número entre 0 y 5.");
            }
        }
        return notas;
    }

    // Método para calcular el promedio de las notas
    static double CalcularPromedio(List<double> notas)
    {
        return notas.Count > 0 ? notas.Average() : 0;
    }

    // Método para clasificar el desempeño según el promedio
    static string ClasificarDesempeno(double promedio)
    {
        if (promedio >= 4.5) return "Excelente";
        if (promedio >= 4.0) return "Sobresaliente";
        if (promedio >= 3.5) return "Bueno";
        return "Insuficiente";
    }

    // Método para contar cuántos estudiantes aprobaron
    static int ContarAprobados(List<double> notas)
    {
        return notas.Count(n => n >= 3.5); // Se considera Ganada con nota >= 3.5
    }
}
