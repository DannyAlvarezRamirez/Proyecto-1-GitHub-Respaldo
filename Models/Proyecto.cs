using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto1.Models
{
    /*
     * esta clase se encarga de modelar un proyecto con los parametros respectivos del mismo,
     * contiene sus atributos, constructores y sus parametros o metodos o funciones propias
     */
    public class Proyecto
    {
        //atributos
        private int intIDProyecto, intCantidadDeDormitorios, intCantidadDeBanosCompletos, 
            intCantidadDeMediosBanos;
        private string strTerraza, strTipoDePiso, strMuebleDeCocina, strMetrosDeConstruccionAproximado;
        private bool boolSalaEstaIntegradaConLaCocina, boolAreaDePilasEsAbierta;
        private double doubleCostoAproximadoPorMetroCuadrado;

        //constructores
        //contructor vacio
        public Proyecto()
        {
            this.intIDProyecto = 0;
            this.intCantidadDeDormitorios = 0;
            this.intCantidadDeBanosCompletos = 0;
            this.intCantidadDeMediosBanos = 0;
            this.strTerraza = "";
            this.strTipoDePiso = "";
            this.strMuebleDeCocina = "";
            this.strMetrosDeConstruccionAproximado = "";
            this.boolSalaEstaIntegradaConLaCocina = false;
            this.boolAreaDePilasEsAbierta = false;
            this.doubleCostoAproximadoPorMetroCuadrado = 0.0;
        }//fin constructor vacio
        //contructor con parametros
        public Proyecto(int intIDProyecto, int intCantidadDeDormitorios, int intCantidadDeBanosCompletos, int intCantidadDeMediosBanos, 
            string strTerraza, string strTipoDePiso, string strMuebleDeCocina, string strMetrosDeConstruccionAproximado, 
            bool boolSalaEstaIntegradaConLaCocina, bool boolAreaDePilasEsAbierta, 
            double doubleCostoAproximadoPorMetroCuadrado) 
        {
            this.intIDProyecto = intIDProyecto;
            this.intCantidadDeDormitorios = intCantidadDeDormitorios;
            this.intCantidadDeBanosCompletos = intCantidadDeBanosCompletos;
            this.intCantidadDeMediosBanos = intCantidadDeMediosBanos;
            this.strTerraza = strTerraza;
            this.strTipoDePiso = strTipoDePiso;
            this.strMuebleDeCocina = strMuebleDeCocina;
            this.strMetrosDeConstruccionAproximado = strMetrosDeConstruccionAproximado;
            this.boolSalaEstaIntegradaConLaCocina = boolSalaEstaIntegradaConLaCocina;
            this.boolAreaDePilasEsAbierta = boolAreaDePilasEsAbierta;
            this.doubleCostoAproximadoPorMetroCuadrado = doubleCostoAproximadoPorMetroCuadrado;
        }//fin contructor con parametros

        //propiedades
        /////////////////////////////////////////////////////////////////////////////////////////////////
        //IDProyecto
        public int IDProyecto
        {
            set
            {
                this.intIDProyecto = value;
            }
            get
            {
                return this.intIDProyecto;
            }
        }//fin IDProyecto
        //CantidadDeDormitorios
        public int CantidadDeDormitorios
        {
            set
            {
                this.intCantidadDeDormitorios = value;
            }
            get
            {
                return this.intCantidadDeDormitorios;
            }
        }//fin CantidadDeDormitorios
        //CantidadDeBanosCompletos
        public int CantidadDeBanosCompletos
        {
            set
            {
                this.intCantidadDeBanosCompletos = value;
            }
            get
            {
                return this.intCantidadDeBanosCompletos;
            }
        }//fin CantidadDeBanosCompletos
        //CantidadDeMediosBanos
        public int CantidadDeMediosBanos
        {
            set
            {
                this.intCantidadDeMediosBanos = value;
            }
            get
            {
                return this.intCantidadDeMediosBanos;
            }
        }//fin CantidadDeMediosBanos
        /////////////////////////////////////////////////////////////////////////////////////////////////
        //getIntTerraza
        public int getIntTerraza()
        {
            int numero = 0;
            if (this.strTerraza.Equals("Pequeña"))
            {
                numero = 0;
            }//fin if Pequeña
            else if (this.strTerraza.Equals("Mediana"))
            {
                numero = 1;
            }//fin else if Mediana
            else
            {
                numero = 2;
            }//fin else Grande
            return numero;
        }//fin getIntTerraza
        //getIntTipoDePiso
        public int getIntTipoDePiso()
        {
            int numero = 0;
            if (this.strTipoDePiso.Equals("Concreto lujado"))
            {
                numero = 0;
            }//fin if Concreto lujado
            else if (this.strTipoDePiso.Equals("Porcelanato"))
            {
                numero = 1;
            }//fin else if Porcelanato
            else
            {
                numero = 2;
            }//fin else Cerámica
            return numero;
        }//fin getIntTipoDePiso
        //getIntMuebleDeCocina
        public int getIntMuebleDeCocina()
        {
            int numero = 0;
            if (this.strMuebleDeCocina.Equals("Granito"))
            {
                numero = 0;
            }//fin if Granito
            else if (this.strMuebleDeCocina.Equals("Cuarzo"))
            {
                numero = 1;
            }//fin else if Cuarzo
            else
            {
                numero = 2;
            }//fin else Terrazo
            return numero;
        }//fin getIntMuebleDeCocina
        //getIntMetrosDeConstruccionAproximado
        public int getIntMetrosDeConstruccionAproximado()
        {
            int numero = 0;
            if (this.strMetrosDeConstruccionAproximado.Equals("50m2-80m2"))
            {
                numero = 0;
            }//fin if 50m2-80m2
            else if (this.strMetrosDeConstruccionAproximado.Equals("80 m2-100 m2"))
            {
                numero = 1;
            }//fin else if 80 m2-100 m2
            else if (this.strMetrosDeConstruccionAproximado.Equals("100 m2 -150 m2"))
            {
                numero = 2;
            }//fin else if 100 m2 -150 m2
            else if (this.strMetrosDeConstruccionAproximado.Equals("150m2-200 m2"))
            {
                numero = 3;
            }//fin else if 150m2-200 m2
            else
            {
                numero = 4;
            }//fin else 200 m2-300m2
            return numero;
        }//fin getIntMetrosDeConstruccionAproximado
        /////////////////////////////////////////////////////////////////////////////////////////////////
        //getIntSalaEstaIntegradaConLaCocina
        public int getIntSalaEstaIntegradaConLaCocina()
        {
            int numero= 0;
            if (this.boolSalaEstaIntegradaConLaCocina == true)
            {
                numero = 2;
            }//fin if true
            else
            {
                numero = 3;
            }//fin else false
            return numero;
        }//fin getIntSalaEstaIntegradaConLaCocina
        //getIntAreaDePilasEsAbierta
        public int getIntAreaDePilasEsAbierta()
        {
            int numero = 0;
            if (this.boolAreaDePilasEsAbierta == true)
            {
                numero = 2;
            }//fin if true
            else
            {
                numero = 3;
            }//fin else
            return numero;
        }//fin getIntAreaDePilasEsAbierta
        /////////////////////////////////////////////////////////////////////////////////////////////////
        //getDoubleCostoAproximadoPorMetroCuadrado
        public double getDoubleCostoAproximadoPorMetroCuadrado()
        {
            double resultado = 0.0;
            resultado = ((CantidadDeDormitorios + CantidadDeBanosCompletos + CantidadDeMediosBanos +
                getIntTerraza() + getIntTipoDePiso() + getIntMuebleDeCocina()) +
                (getIntSalaEstaIntegradaConLaCocina() + getIntAreaDePilasEsAbierta() +
                getIntMetrosDeConstruccionAproximado())) * 20000;
            return resultado;
        }//fin getDoubleCostoAproximadoPorMetroCuadrado
        //GetInformacionObjetoCliente
        public string GetInformacionObjetoProyecto()
        {
            return "Información del proyecto*\nID = " + this.intIDProyecto + 
                ", \nCantidad de dormitorios = " + this.intCantidadDeDormitorios + ", " +
                ", \nCantidad de banos completos = " + this.intCantidadDeBanosCompletos + ", " +
                ", \nCantidad de medios banos = " + this.intCantidadDeMediosBanos + ", " +
                ", \nTerraza = " + this.strTerraza + ", " +
                ", \nTipo de piso = " + this.strTipoDePiso + ", " +
                ", \nMuebles de cocina = " + this.strMuebleDeCocina + ", " +
                ", \nLa sala esta integrada con la cocina = " + this.boolSalaEstaIntegradaConLaCocina + ", " +
                ", \nEl area de pilas es abierta = " + this.boolAreaDePilasEsAbierta + ", " +
                ", \nCosto aproximado por metro cuadrado = " + this.doubleCostoAproximadoPorMetroCuadrado;
        }//fin GetInformacionObjetoCliente
    }//fin clase Proyecto
}//fin Proyecto1
