namespace FinalRegular
{
    public class Constants
    {
        public const string ClienteNoExisteErrorMessage = "El numero de DNI ingresado no es correcto";
        public const string ClientesCSV = "clientes.csv";
        public const string SaldosCSV = "saldos.csv";
        
        public const string HeadTitle = "###   Laboratorio de Computación II   ###";
        public const string Divisor = ",";

        public const string Labo2NoContentOrOnlyWhiteSpacesErrorMessage = "No ha ingresado contenido o solo caracteres en blanco";
        public const string FileAlreadyExistsErrorMessage = "El archivo ya existe";
        public static string[] menuOptions = { "Identificarse", "Consultas", "Movimientos", "Despedir", "Salir" };

    }
}