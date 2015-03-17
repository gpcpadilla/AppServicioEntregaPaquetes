
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaPaquete.Modelo
{
    public class Package
    {
        #region "Atributos"
        private int codigopaquete;
        private int ccremitente;
        private int ccdestinatario;
        private string nombreremitente;
        private string nombredestinatario;
        private string direccionremitente;
        private string direcciondestinatario;
        private string ciudadremitente;
        private string ciudaddestinatario;
        private string estado;
        private string departamentoremitente;
        private string departamentodestinatario;
        private int codigopostalremitente;
        private int codigopostaldestinatario;
        private double pesokg = 2;
        private double costogramo = 1500;

        #endregion

        #region "Propiedades"
        /// <summary>
        /// Establece o retorna el codigo del paquete 
        /// </summary>
        public int CodigoPaquete
        {
            get { return codigopaquete; }
            set { codigopaquete = value; }
        }
        /// <summary>
        /// Establece o retorna la cedula del remitente
        /// </summary>
        public int CedulaRemitente
        {
            get { return codigopaquete; }
            set { codigopaquete = value; }
        }
        /// <summary>
        /// Establece o retorna la cedula del destinatario
        /// </summary>
        public int CedulaDestinatario
        {
            get { return ccdestinatario; }
            set { ccdestinatario = value; }
        }
        /// <summary>
        /// Establece o retorna el nombre del remitente
        /// </summary>
        public string NombreRemitente
        {
            get { return nombreremitente; }
            set { nombreremitente = value; }
        }
        /// <summary>
        /// Establece o retorna el nombre del destinatario
        /// </summary>
        public string Nombre
        {
            get { return nombredestinatario; }
            set { nombredestinatario = value; }
        }

        /// <summary>
        /// Establece o retorna la dirrecion del remitente
        /// </summary>
        public string DireccionRemitente
        {
            get { return direccionremitente; }
            set { direccionremitente = value; }
        }

        /// <summary>
        /// Establece o retorna la dirrecion del destinatario
        /// </summary>
        public string DireccionDestinatario
        {
            get { return direcciondestinatario; }
            set { direcciondestinatario = value; }
        }
        /// <summary>
        /// Establece o retorna el estado
        /// </summary>
        /// 

        public string CiudadRemitente
        {
            get { return ciudaddestinatario; }
            set { ciudaddestinatario = value; }
        }

        /// <summary>
        /// Establece o retorna la dirrecion del destinatario
        /// </summary>
        public string CiudadDEstinatario
        {
            get { return direcciondestinatario; }
            set { direcciondestinatario = value; }
        }
        /// <summary>
        /// Establece o retorna el estado
        /// </summary>


        public string Estado
        {

            get { return estado; }
            set { estado = value; }
        }

        /// <summary>
        /// Establece o retorna el departamento del remitente
        /// </summary>
        /// 
        public string DepartamentoRemitente
        {
            get { return departamentoremitente; }
            set { departamentoremitente = value; }
        }

        /// <summary>
        /// Establece o retorna el departamento del destinatario
        /// </summary>
        /// 
        public string DepartamentoDestinatario
        {
            get { return departamentodestinatario; }
            set { departamentodestinatario = value; }
        }

        /// <summary>
        /// Establece o retorna el codigo postal del remitente 
        /// </summary>

        public int CodigoPostalRemitente
        {
            get { return codigopostalremitente; }
            set { codigopostalremitente = value; }
        }

        /// <summary>
        /// Establece o retorna el codigo postal del destinatario
        /// </summary>
        /// 
        public int CodigoPostalDestinatario
        {
            get { return codigopostaldestinatario; }
            set { codigopostaldestinatario = value; }
        }

        /// <summary>
        /// Establece o retorna el peso kg
        /// </summary>
        public double PesoKG
        {
            get { return pesokg; }
            set { pesokg = value; }
        }

        /// <summary>
        /// Establece o retorna el costo por cada gramo 
        /// </summary>
        public double CostoGramo
        {
            get { return costogramo; }
            set { costogramo = value; }
        }
        #endregion

        #region "Constructores"
        ///<summary>
        ///Contructor por defecto  de Package
        ///</summary>
        public Package()
        {
            this.codigopaquete = 6754;
            this.ccremitente = 104742720;
            this.ccdestinatario = 33466225;
            this.nombreremitente = "geovanni padilla cervantes";
            this.nombredestinatario = "edwin";
            this.direccionremitente = "nuevo bosque mz16-lt10-2et";
            this.direcciondestinatario = "utb";
            this.ciudadremitente = "cartagena";
            this.ciudaddestinatario = "cartagena";
            this.estado = "enviado";
            this.departamentoremitente = "bolivar";
            this.departamentodestinatario = "bolivar";
            this.codigopostalremitente = 13001;
            this.codigopostaldestinatario = 13002;
            this.pesokg = 2;
            this.costogramo = 3.500;
        }

        ///<summary>
        ///Contructor de inicialización Package
        ///</summary>
        ///<param name="codigopaquet"> Codigo del paquete </param>
        ///<param name="ccremitente"> Cedula del remitente </param>
        ///<param name="ccdestinatario"> Cedula del destinatario </param>
        ///<param name="nombreremitente"> Nombre del remitente</param>
        ///<param name="nombredestinatario"> Nombre del destinatario</param>
        ///<param name="direccionremitente"> Direccion del remitente</param>
        ///<param name="cuidadremitente"> Direccion del remitente</param>
        ///<param name="ciudaddestinatario"> Direccion del destinatario</param>
        ///<param name="direcciondestinatario"> Direccion del destinatario</param>
        ///<param name="estado"> Estado De Envio</param>
        ///<param name="departamentoremitente"> Departamento del remitente</param>
        ///<param name="departamentodestinatario"> Departamento del destinatario</param>
        ///<param name="codigopostalremitente"> Codigo postal del remitente</param>
        ///<param name="codigopostaldestinatario"> codigo postal del destinatario</param>
        ///<param name="pesokg"> Peso en KG</param>
        ///<param name="costogramo"> Costo del gramo </param>
        ///
        public Package(int codigopaquete, int ccremitente, int ccdestinatario, string nombreremitente,
            string nombredestinatario, string direccionremitente, string direcciondestinatario,
            string ciudadremitente, string ciudaddestinatario, string estado, string departamentoremitente,
            string departamentodestinatario, int codigopostalremitente, int codigopostaldestinatario,
            double pesokg, double costogramo)
        {
            this.codigopaquete = codigopaquete;
            this.ccremitente = ccremitente;
            this.ccdestinatario = ccdestinatario;
            this.nombreremitente = nombreremitente;
            this.direccionremitente = direccionremitente;
            this.direcciondestinatario = direcciondestinatario;
            this.ciudadremitente = ciudadremitente;
            this.estado = estado;
            this.departamentoremitente = departamentoremitente;
            this.departamentodestinatario = departamentodestinatario;
            this.codigopostalremitente = codigopostalremitente;
            this.codigopostaldestinatario = codigopostaldestinatario;
            this.pesokg = pesokg;
            this.costogramo = costogramo;

        }
        #endregion

        #region "Métodos Sobre Escritos"
        /// <summary>
        /// Retorna el valor del objeto representado en una cadena
        /// </summary>
        public override string ToString()
        {
            return "\n=============================================\n" +
                     "Codigo Del Paquete:" + this.codigopaquete + "\n" + 
                     "Cedula Del Remitente:  " + this.ccremitente + "\n" +
                     "Cedula Del Destinatario:  " + this.ccdestinatario + "\n" +
                     "Nombre Del Remitente:  " + this.nombreremitente + "\n" +
                     "Nombre Del Destinatario:  " + this.nombredestinatario + "\n" +
                     "Direccion Del Remitente:  " + this.direccionremitente + "\n" +
                     "Direccion Del Destinatario:  " + this.direcciondestinatario + "\n" +
                     "Ciudad Del Remitente:  " + this.ciudadremitente + "\n" +
                     "Ciudad Del Destinatario:  " + this.ciudaddestinatario + "\n" +
                     "Estado Del Envio:  " + this.estado + "\n" +
                     "Departamento Del Remitente:  " + this.departamentoremitente + "\n" +
                     "Departamento Del Destinatario:  " + this.departamentodestinatario + "\n" +
                     "Codigo Postal Del Remitente:  " + this.codigopostalremitente + "\n" +
                     "Codigo Postal Del Destinatario:  " + this.codigopostaldestinatario + "\n" +
                     "Peso En KG:  " + this.pesokg + "\n" +
                     "Costo En Gramos:  " + this.costogramo +
                   "\n=============================================\n";

        }

        /// <summary>
        /// Método que compara dos objectos
        /// </summary>
        public override bool Equals(object obj)
        {
            Package o = (Package)obj;
            bool result = false;

            if ((this.codigopaquete == o.codigopaquete) &&
                (this.ccremitente == o.ccremitente) &&
                (this.ccdestinatario == o.ccdestinatario) &&
                (this.nombreremitente == o.nombreremitente) &&
                (this.nombredestinatario == o.nombredestinatario) &&
                (this.direccionremitente == o.direccionremitente) &&
                (this.direcciondestinatario == o.direcciondestinatario) &&
                (this.ciudadremitente == o.ciudadremitente) &&
                (this.ciudaddestinatario == o.direcciondestinatario) &&
                (this.estado == o.estado) &&
                (this.departamentoremitente == o.departamentoremitente) &&
                (this.departamentodestinatario == o.departamentodestinatario) &&
                (this.codigopostalremitente == o.codigopostalremitente) &&
                (this.codigopostaldestinatario == o.codigopostaldestinatario) &&
                (this.costogramo == o.costogramo) &&
                (this.pesokg == o.pesokg))

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
        /// calcula el costo del envio 
        /// </summary>
        public double calculateCost()
        {

            return (this.costogramo * this.pesokg);
        }



        #endregion





    }
}