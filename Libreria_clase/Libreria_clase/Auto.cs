namespace Libreria_clase
{
    public class Auto
    {
        //atributos: como es nuesrtra clase
        private string motor;
        private string patente;
        private int cantidadAsientos;
        private double cantCombustible;
        private int cantMaximaCombustible;
        private bool estaEncendido;


        //constructores: es el metodo que permite crear nuevas instacncias de nuestra clase
        // visibilidad - comportamiento - nombre siempre es el mismo que la clase - parametros - llaves
        public Auto(string patente, int cantAsientos, string motor)
        {
            this.patente = patente;
            this.cantidadAsientos = cantAsientos;
            this.cantCombustible = 30;
            this.motor = motor;
            this.estaEncendido = false;
            this.cantMaximaCombustible = 65;
        }

        public Auto()
        {

        }

        //getters y setters: nos va a permitir comunicarnos y modificar atributos
        public string GetPatente()
        {
            return this.patente;
        }

        public void SetPatente(string patente)
        {
            if (!string.IsNullOrEmpty(patente))
            {
                this.patente = patente;
                Console.WriteLine("Patente modificada con exito");
            }
            else
            {
                Console.WriteLine("No se aceptan patentes sin valor!!");
            }
            
        }

        public bool SetCantidadAsientos(int cantidad)
        {
            if (cantidad < 1)
            {
                return false;
            }
            else
            {
                this.cantidadAsientos = cantidad;
                return true;
            }
        }


        //comportamientos: metodos que nos dicen que puede hacer nuestra clase
        // visibilidad - comportamiento - retorno - nombre - parametros - llaves
        public string MostrarInformacion()
        {
            return $"Motor: {this.motor} - Patente: {this.patente} - Cant. de asientos: {this.cantidadAsientos} - Cant. combustible: {this.cantCombustible} - Esta encendido: {this.estaEncendido}";
        }

        public bool Acelerar()
        {

            if (this.estaEncendido && this.cantCombustible > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public string Arrancar()
        {
            if (!this.estaEncendido)
            {
                this.estaEncendido = true;    
            }

            if (Acelerar())
            {
                return "EL auto esta en movimiento";
            } else
            {
                return "No no puede avanzar";
            }

            
        }

        public double CargarCombustible(int cantidad)
        {
            if (this.cantCombustible + cantidad <= this.cantMaximaCombustible)
            {
                this.cantCombustible += cantidad;
            }
            else
            {
                this.cantCombustible = this.cantMaximaCombustible;
            }

            return this.cantCombustible;
        }



    }
}
