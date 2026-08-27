using Libreria_clase;

namespace Test_Auto
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            Auto auto1 = new Auto("AB 123 CD",5,"Naftero");
            //Auto auto2 = new Auto();

            auto1.SetPatente("123132");

            if (auto1.SetCantidadAsientos(0))
            {
                Console.WriteLine("Cantidad de asientos modificada con exito");
            }
            else
            {
                Console.WriteLine("No se logro modifcar la cant de asientos");
            }
            


            Console.WriteLine(auto1.MostrarInformacion());
            //Console.WriteLine(auto2.MostrarInformacion());

            
        }
    }
}
