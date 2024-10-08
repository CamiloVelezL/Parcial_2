//Juego: Desarrollar el juego “Adivina el número” en un programa de C#. El juego es muy sencillo, consiste en adivinar un número ℕ
//aleatorio que el sistema escoge de un determinado rango y lo guarda en memoria sin ser revelado.


//ejemplo: El sistema escoge aleatoriamente un número entre 0 y 100, ese número NO SE PUEDE REVELAR ya que es el número que se adivinará,
//por ende, dicho número se almacenará en memoria. Los participantes comenzarán en orden a jugar y se turnarán para ingresar por pantalla
//un número ℕ hasta acertar el número oculto y salir ganador.

//Requerimientos
//El juego debe tener la funcionalidad de escoger el número de participantes que jugarán:
//mínimo 2 y máximo 4 integrantes. Dependiendo de la cantidad de jugadores, el número ℕ aleatorio se generará en los siguientes rangos:

//Si participan 2 jugadores, el número ℕ aleatorio se generará entre 0 y 50}
//-Si participan 3 jugadores, el número ℕ aleatorio se generará entre 0 y 100
//- Si participan 4 jugadores, el número ℕ aleatorio se generará entre 0 y 200


//Cada jugador comenzará su turno intentando adivinar ese número ℕ aleatorio.
//El programa deberá mostrarle al jugador la siguiente información:

//-Si el número ingresado es mayor al número aleatorio, entonces mostrar por pantalla la palabra “MENOR” y darle la oportunidad
//al siguiente jugador.
//- Si el número ingresado es menor al número aleatorio, entonces mostrar por pantalla la palabra “MAYOR” y darle la oportunidad
//al siguiente jugador.
//- Si el número ingresado coincide con el número aleatorio, entonces mostrar por pantalla la palabra “¡HAS GANADO!”.
//Aquí ya finaliza el juego.

//El programa deberá estar en capacidad de pedir a los jugadores si desean un nuevo “tirito” para volver a jugar y borrar consola,
//de lo contrario, finalizar el programa.

public class Program
{
    static void Main(string[] args)
    {
        //Variable para juegar otra partida
        bool NuevoJuego = true;
        //Objeto números aleatorios
        Random random = new Random();

        while (NuevoJuego)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al juego 'Adivina el número'");

            //Declarar número de jugadores y el rango máximo
            int numJugadores = ObtenerNumeroJugadores();
            int rangoMaximo = ObtenerRangoMaximo(numJugadores);
            // Generar el número secreto
            int numeroSecreto = random.Next(0, rangoMaximo + 1);

            // Control del juego
            bool adivinado = false;
            int turnoActual = 1;

            // Bucle del juego
            while (!adivinado)
            {
                // Iteraraciones
                for (int i = 1; i <= numJugadores && !adivinado; i++)
                {
                    Console.WriteLine($"\nTurno del jugador {i}:");
                    int intento = ObtenerIntento(rangoMaximo);

                    // Comprobar el intento
                    if (intento == numeroSecreto)
                    {
                        Console.WriteLine("¡HAS GANADO!");
                        adivinado = true;
                    }
                    else if (intento < numeroSecreto)
                    {
                        Console.WriteLine("MAYOR");
                    }
                    else
                    {
                        Console.WriteLine("MENOR");
                    }

                    turnoActual++;
                }
            }


        }
    }