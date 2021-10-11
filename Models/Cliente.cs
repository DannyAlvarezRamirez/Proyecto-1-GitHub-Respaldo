using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto1.Models
{
    /*
     * esta clase se encarga de modelar un cliente con los parametros respectivos del mismo,
     * contiene sus atributos, constructores y sus parametros o metodos o funciones propias
     */
    public class Cliente
    {
        //atributos
        private int intCedula, intTelefono;
        private string strNombreCompleto;

        //constructores
        //contructor vacio
        public Cliente()
        {
            this.intCedula = 0;
            this.intTelefono = 0;
            this.strNombreCompleto = "";
        }//fin constructor vacio
        //contructor con parametros
        public Cliente(int intCedula, int intTelefono, string strNombreCompleto)
        {
            this.intCedula = intCedula;
            this.intTelefono = intTelefono;
            this.strNombreCompleto = strNombreCompleto;
        }//fin contructor con parametros

        //propiedades
        //CedulaCliente
        public int CedulaCliente {
            set
            {
                this.intCedula = value;
            }
            get
            {
                return this.intCedula;
            }
        }//fin CedulaCliente
        //TelefonoCliente
        public int TelefonoCliente
        {
            set
            {
                this.intTelefono = value;
            }
            get
            {
                return this.intTelefono;
            }
        }//fin TelefonoCliente
        //NombreCompletoCliente
        public string NombreCompletoCliente
        {
            set
            {
                this.strNombreCompleto = value;
            }
            get
            {
                return this.strNombreCompleto;
            }
        }//fin NombreCompletoCliente
        //GetInformacionObjetoCliente
        public string GetInformacionObjetoCliente()
        {
            return "Información del cliente*\nCedula = " + this.intCedula + ", \nNombre Completo = " + this.strNombreCompleto + ", " +
                "\nTelefono = " + this.strNombreCompleto;
        }//fin GetInformacionObjetoCliente

    }//fin clase Cliente
}//fin Proyecto1
