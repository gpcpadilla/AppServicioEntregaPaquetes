using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaPaquete.Modelo
{
    public class OvernightPackage : Package
    {

         #region "Atributos"

         private double costoentreganocturno;

         #endregion

        #region "Propiedades"
       
        /// <summary>
        /// Establece o retorna el costo nocturno
        /// </summary>
         public double CostoEntregaNocturno
        {
            get { return costoentreganocturno; }
            set { costoentreganocturno = value; }
        }
        #endregion

        
        #region "Constructores"
        ///<summary>
        ///Contructor por defecto  de OvernightPackage
        ///</summary>
        public OvernightPackage()
        {

            this.costoentreganocturno = 5000;
        }

        ///<summary>
        ///Contructor de inicialización OvernightPackage
        ///</summary>
        ///<param name="costoentreganocturno"> Costo de entrega nocturno</param>
       
        ///
        public OvernightPackage(double costoentreganocturno)
        {
            this.costoentreganocturno = costoentreganocturno;
            
            
        }
        #endregion

        #region "Métodos Sobre Escritos"
        /// <summary>
        /// Retorna el valor del objeto representado en una cadena
        /// </summary>
        public override string ToString()
        {
            return "\n=============================================\n" +

                     "Costo den entrega nocturno:  " + this.costoentreganocturno;

        }

        /// <summary>
        /// Método que compara dos objectos
        /// </summary>
        public override bool Equals(object obj)
        {
            OvernightPackage o = (OvernightPackage)obj;
            bool result = false;

            if ((this.costoentreganocturno == o.costoentreganocturno))
                
                result = true;

            return result;
        }

        /// <summary>
        /// Devuelve la identificación del objecto
        /// </summary>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        /// <summary>
        /// calcula el costo de entrega nocturno
        /// </summary>
        public double calculateCost()
        {

            return    (base.calculateCost() + this.costoentreganocturno);;
        }






        #endregion

    }
}