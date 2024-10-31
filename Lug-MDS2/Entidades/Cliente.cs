using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int clienteID;
        private string nombre;
        private string apellido;
        private double cuit;
        private string email;
        private double telefono;
        private string direccion;
        //private List<Carrito> carritos;

        public int ClienteID { get => clienteID; set => clienteID = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Cuit { get => cuit; set => cuit = value; }
        public string Email { get => email; set => email = value; }
        public double Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        //public List<Carrito> Carritos { get => carritos; set => carritos = value; }
    }
}
