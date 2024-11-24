using FinalRegular;

internal static class ProgramHelpers
{
    public static Cliente BuscarCliente(string dni)
    {
        bool bandera = false;
        Cliente cliente = new Cliente();

        if (File.Exists($"{Constants.ClientesCSV}") != false)
        {
            FileStream Archivo = new FileStream(Constants.ClientesCSV, FileMode.Open);
            StreamReader Leer = new StreamReader(Archivo);
            //cabecera
            string cad = Leer.ReadLine();
            string[] vectorcabecera = cad.Split(',');
            if (string.IsNullOrWhiteSpace(cad) != true)
            {
                Console.Clear();
                //contenido del archivo
                while (Leer.EndOfStream == false)
                {
                    cad = Leer.ReadLine();
                    string[] vectorcontenido = cad.Split(',');
                    
                        if (vectorcontenido[0] == dni)
                        {
                            Console.WriteLine($"DNI: {vectorcontenido[0]}\nNombre: {vectorcontenido[1]}\nCBU: {vectorcontenido[2]}\n");
                            cliente = new Cliente(int.Parse(vectorcontenido[0]), vectorcontenido[1], vectorcontenido[2]);
                            bandera = true;
                        }
                    
                }
                Leer.Close();
                Archivo.Close();
                if (!bandera)
                {
                    throw new DNINotExistsException();
                }
            }
            else
            {
                throw new Labo2NoContentOrOnlyWhiteSpaces();
            }
        }
        return cliente;
    }

    public static Saldo BuscarSaldoCliente(string cbu)
    {
        if (File.Exists($"{Constants.SaldosCSV}") != false)
        {
            FileStream Archivo = new FileStream(Constants.SaldosCSV, FileMode.Open);
            StreamReader Leer = new StreamReader(Archivo);
            //cabecera
            string cad = Leer.ReadLine();
            string[] vectorcabecera = cad.Split(',');
            if (string.IsNullOrWhiteSpace(cad) != true)
            {
                Console.Clear();
                //contenido del archivo
                while (Leer.EndOfStream == false)
                {
                    cad = Leer.ReadLine();
                    string[] vectorcontenido = cad.Split(',');
                    for (int i = 0; i < vectorcabecera.Count(); i++)
                    {
                        if (vectorcontenido[i] == cbu)
                        {
                            Console.WriteLine($"CBU: {vectorcontenido[0]}\nPIN: {vectorcontenido[1]}\nSaldo: {vectorcontenido[2]}\n");
                            return new Saldo(vectorcontenido[0], int.Parse(vectorcontenido[1]), double.Parse(vectorcontenido[2]));
                        }
                    }
                }
                Leer.Close();
                Archivo.Close();
                throw new Exception("CBU no existe");
            }
            else
            {
                throw new Labo2NoContentOrOnlyWhiteSpaces();
            }
        }
        return null;
    }

    public static void ActualizarSaldo(Saldo saldo)
    {
        FileStream Archivo = new FileStream(Constants.SaldosCSV, FileMode.Append, FileAccess.Write);
        StreamWriter Grabar = new StreamWriter(Archivo);

        // TODO actualizar

        Grabar.Close();
        Archivo.Close();
    }

}