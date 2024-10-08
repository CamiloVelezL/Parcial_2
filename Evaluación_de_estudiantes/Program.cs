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

    
}
