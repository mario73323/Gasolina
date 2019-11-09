using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaGasolina.Clases
{
    public class Cliente
    {
      
        private string nombre;
        public string Nombres
        {
            get { return nombre; }
            set 
            {
                nombre = value; 
            }
        }
        
        private int cedula;
        public int Cedula 
        {
            get { return cedula; }
            set { cedula = value; }
        }
        private string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private List<Gasolina> gasolina;

        public List<Gasolina> Gasolina
        {
            get { return gasolina; }
            set { gasolina = value; }
        }
       
        public override string ToString()
        {
            return
                "            DATOS DEL CLIENTE\n"+
                "\nNombre:          "+Nombres + 
                "\nNumero Cedula:   " + Cedula + 
                "\nDeireccion:      " + Direccion;
                
        }

        public Cliente(string nombres, int cedula, string direccion, List<Gasolina> gasolina)
        {
            Nombres = nombres;
            Cedula = cedula;
            Direccion = direccion;
            Gasolina = gasolina;
        }
    }
}
