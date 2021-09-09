using System;
using clase_8;

namespace Coches
{
    public class Coches
    {
        static void Main(string[] args)
        {
            Coches auto1 = new Coches(1234,"Ford","Mondeo",8350,50000,0);
            auto1.Acelerar(50);
            Console.WriteLine($"La velocidad actual es de {auto1.velocidad}");
            auto1.Frenar(30);
            Console.WriteLine($"La velocidad actual es de {auto1.velocidad}");
            CocheInteligente coche2 = new CocheInteligente(12345,"ferrari","gtx",5000,400000,0);
            coche2.Estacionar();
            
            
           Console.ReadKey();

        }
        public int id {get;set;}
        public string marca {get;set;}
        public string modelo {get;set;}
        public int km {get;set;}
        public int precio {get;set;}
        public int velocidad {get;set;}

        public Coches(int id,string marca,string modelo,int km,int precio,int velocidad)
        {

            this.id=id;
            this.marca=marca;
            this.modelo = modelo;
            this.km = km;
            this.precio = precio;
            this.velocidad = velocidad;
        }

        public void Acelerar(int cantidad)
        {
           Console.WriteLine($"Incrementando la velocidad en {cantidad}km/h");
            velocidad += cantidad;
        }

        public void Frenar(int cantidad)
        {
            Console.WriteLine($"Dismunuyendo la velocidad en {cantidad}km/h");
            velocidad -= cantidad;
        }
    }
    
}
        
        
