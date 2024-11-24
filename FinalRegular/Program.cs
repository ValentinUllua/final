using Microsoft.VisualBasic;

namespace FinalRegular
{
    public class Program
    {
        /**
         * Esta es la funcion principal, contiene la logica para mostrar el menu y luego enviar a cada implementacion lo que se haya requerido.
         * Las opciones posibles para la ejercitacion es Crear el archivo plano, Agregar un nuevo valor y Listar todos los valores existentes. 
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int selectedIndex = 0;
            bool salir = false;
            Console.CursorVisible = false;
            while (salir == false)
            {
                Console.Clear();
                Console.ResetColor();

                Logo.Show();

                Console.WriteLine();
                Console.WriteLine("Seleccione una opción con las flechas {0} o {1}", (char)24, (char)25);
                Console.WriteLine("-----------------------------------------------------");

                for (int i = 0; i < Constants.menuOptions.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write((char)2 + " ");
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write("  ");
                    }

                    Console.WriteLine(Constants.menuOptions[i]);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = Math.Max(0, selectedIndex - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        selectedIndex = Math.Min(Constants.menuOptions.Length - 1, selectedIndex + 1);
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.Spacebar:
                        if (selectedIndex == Constants.menuOptions.Length - 1)
                            salir = true;
                        else
                            HandleMenuOption(Constants.menuOptions[selectedIndex]);
                        break;
                }
            }
        }

        /**
         * Este metodo esta encargado de recibir la opcion de menu deseada por el usuario 
         * Por cada opcion del menu, ejecutaremos Crear, Agregar o Listar según se haya solicitado dicha acción.
         * Las opciones que arroja excepciones en tiempo de ejecucion, deben ser controladas para que el usuario resuelva dicho caso.
         */
        public static void MenuAsync(string userInput)
        {
            switch (userInput)
            {
                case "Identificarse":
                    Console.WriteLine("Bienvenido!"); 
                    Console.WriteLine();
                    Console.WriteLine("Ingrese su DNI:");
                    Cliente cliente = ProgramHelpers.BuscarCliente(Console.ReadLine()!.Trim());
                    Console.WriteLine("Ingrese su PIN:");
                    int pin = int.Parse(Console.ReadLine()!.Trim());
                    break;
                case "Consultas":
                    Console.WriteLine("Consultas");
                    break;
                case "Movimientos":
                    Console.WriteLine("Movimientos");
                    break;
                case "Despedir":
                    Console.WriteLine("Despedir");
                    break;
            }
        }

        /**
         * Este metodo se encarga de obtener la opcion y mostrar cual fue la opcion de menu deseada.  
         * Luego llamaremos al método Menú quien contiene las acciones que llaman a las implementaciones. 
         */
        static void HandleMenuOption(string option)
        {
            // Aquí puedes implementar la lógica para manejar cada opción del menú
            Console.Clear();
            Console.WriteLine($"Seleccionaste: {option}");
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            MenuAsync(option);
        }

    }
}