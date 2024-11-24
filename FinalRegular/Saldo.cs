namespace FinalRegular
{
    class Saldo
    {
        private string P_CBU;
        private int P_PIN;
        private Double P_Monto;
        public Saldo()
        {
            // Inicializa los campos con valores predeterminados
            this.P_CBU = "";
            this.P_PIN = 0;
            this.P_Monto = 0;
        }

        // Constructor con parámetros para establecer los valores iniciales del camión
        public Saldo(string cbu, int pin, Double monto)
        {
            // Inicializa los campos con los valores proporcionados
            this.P_CBU = cbu;
            this.P_PIN = pin;
            this.P_Monto = monto;
        }
        public int PIN
        {
            get
            {
                return this.P_PIN;
            }
            set
            {
                this.P_PIN = value;
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
        public Double Monto
        {
            get
            {
                return this.P_Monto;
            }
            set
            {
                this.P_Monto = value;
            }
        }
    }
}
