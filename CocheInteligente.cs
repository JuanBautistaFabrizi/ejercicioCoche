using System;
namespace clase_8
{
    public class CocheInteligente: Coches.Coches
    {
        public CocheInteligente(int id, string marca, string modelo, int km, int precio, int velocidad) : base(id, marca, modelo, km, precio, velocidad)
        {
            
        }

        public void Estacionar()
        {

            Console.WriteLine("Reduciendo el trabajo de los chapistas en Warnes");
        }
    }
}