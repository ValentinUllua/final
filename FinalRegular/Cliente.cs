namespace FinalRegular
{
    class Cliente
    {
        // Campos privados que almacenan los datos del camión
        private Int32 P_DNI;
        private string P_Nombre;
        private string P_CBU;
        private Saldo P_saldo;
        private int P_intentos;
        private Boolean P_bloqueado;

        public Cliente()
        {
            // Inicializa los campos con valores predeterminados
            this.P_DNI = 0;
            this.P_Nombre = "";
            this.P_CBU = "";
            this.P_intentos = 3;
            this.P_bloqueado = false;
            this.P_saldo = new Saldo();
        }

        // Constructor con parámetros para establecer los valores iniciales del camión
        public Cliente(Int32 dni, string nombre, string cbu)
        {
            // Inicializa los campos con los valores proporcionados
            this.P_DNI = dni;
            this.P_Nombre = nombre;
            this.P_CBU = cbu;
            this.P_intentos = 3;
            this.P_bloqueado = false;
            this.P_saldo = new Saldo();
        }
        public Saldo Saldo
        {
            get
            {
                return this.P_saldo;
            }
            set
            {
                this.P_saldo = value;
            }
        }

        public Int32 DNI
        {
            get
            {
                return this.P_DNI;
            }
            set
            {
                this.P_DNI = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.P_Nombre;
            }
            set
            {
                this.P_Nombre = value;
            }
        }
        public string CBU
        {
            get
            {
                return this.P_CBU;
            }
            set
            {
                this.P_CBU = value;
            }
        }

        public int decrementarIntento
        {
            set
            {
                if (this.P_intentos == 0){
                    this.P_bloqueado = true;
                    throw new Exception("Cantidad maxima de intentos, vuelva a internarlo");
                }
                else
                {
                    this.P_intentos = P_intentos--;
                }
            }
        }
        
    }
}
