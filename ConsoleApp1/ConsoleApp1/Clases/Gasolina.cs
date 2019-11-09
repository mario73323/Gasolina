using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaGasolina.Clases
{
    public class Gasolina
    {
        public Gasolina(string tipo, int galones)
        {
            Tipo = tipo;
            Galones = galones;
        }
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set 
            {
                if (value=="EXTRA" || value=="SUPER" || value=="extra"||value=="super")
                    tipo = value;
                else
                {
                    throw new Exception("el tipo ingresado no existe o no esta registrada");
                }
            }
        }
        private int galones;
        public int Galones
        {
            get { return galones; }
            set { galones = value; }
        }
        private double precio;

        public double Precio
        {
            get 
            {
                if (Tipo == "EXTRA" || Tipo == "extra")
                    return 1.50;
                else
                    return 2;
            }
        }
        private double subtotal;

        public  double Subtotal
        {
            get { return Precio*Galones; }
        }
        private double iva;
        public double Iva
        {
            get { return Subtotal*0.12; }
        }
        private double total;
        public double Total
        {
            get { return Subtotal+Iva; }
        }
        private Cliente cliente;

       

        public  Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public override string ToString()
        {
            return 
                "                   DETALLES DE LA COMPRA \n"+
                "\nTipo:            " + Tipo + 
                "\nGalones:         "+Convert.ToString(Galones) + 
                "\nPrecio:          " + Convert.ToString(Precio) + 
                "\n\n                              Subtotal: " + Convert.ToString(Subtotal) +
                "\n                              Iva:      " + Convert.ToString(Iva) + 
                "\n                              Total:    " + Convert.ToString(Total);       }

    }
}
