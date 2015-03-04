
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppServicioEntregaPaquete
{
    public class Package
    {
        #region "Atributos"
        private string codigo;
        private string nombre;
        private string direccion;
        private string ciudad;
        private string estado;
        private string departamento;
        private long codigopostalremitente;
        private long codigopostaldestinatario;
        private double pesokg;
        private double costogramo;
        private double costoasociado;
        #endregion
       
         #region "Propiedades"
        /// <summary>
        /// Establece o retorna el valor de la codigo
        /// </summary>
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        /// <summary>
        /// Establece o retorna el nombre
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        /// <summary>
        /// Establece o retorna la dirrecion
        /// </summary>
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
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
        /// Establece o retorna el departamento
        /// </summary>
        /// 
        public string Departamento
        {
            get { return departamento ; }
            set { departamento = value; }
        }

        /// <summary>
        /// Establece o retorna el codigo postal del remitente 
        /// </summary>

        public long CodigoPostalRemitente
        {
            get { return codigopostalremitente; }
            set { codigopostalremitente = value; }
        }

        /// <summary>
        /// Establece o retorna el codigo postal del destinatario
        /// </summary>
        /// 
       public long CodigoPostalDestinatario
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
            this.codigo = "1047424720";
            this.nombre= "geovanni padilla cervantes";
            this.direccion = "nuevo bosque mz16-lt10-2et";
            this.ciudad = "cartagena";
            this.estado = "enviado";
            this.departamento = "bolivar";
            this.codigopostalremitente = 0001;
            this.codigopostaldestinatario = 0002;
            this.pesokg = 2;
            this.costogramo =3.500 ;
        }

        ///<summary>
        ///Contructor de inicialización Package
        ///</summary>
        ///<param name="codigo"> Codigo de la persona</param>
        ///<param name="nombre"> Nombre De La Persona</param>
        ///<param name="direccion"> Direccion De La Persona</param>
        ///<param name="estado"> Estado De Envio</param>
        ///<param name="departamento"> Departamento</param>
        ///<param name="codigopostalremitente"> Codigo postal del remitente</param>
        ///<param name="codigopostaldestinatario"> codigo postal del destinatario</param>
        ///<param name="pesokg"> Peso en KG</param>
        ///<param name="costogramo"> Costo del gramo </param>
        ///
        public Package(string codigo, string nombre, string direccion, string estado, string departamento, 
            long codigopostalremitente, long codigopostaldestinatario, double pesokg, double costogramo )
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.direccion = direccion;
            this.estado = estado;
            this.departamento= departamento;
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
                     "Codigo:  " + this.codigo + "\n" +
                     "Nombre:  " + this.nombre + "\n" +
                     "Direccion:  " + this.direccion + "\n" +
                     "Estado:  " + this.estado + "\n" +
                     "Departamento:  " + this.departamento + "\n" +
                     "Codigo Postal Del Remitentel:  " + this.codigopostalremitente + "\n" +
                     "Codigo Postal Del Destinatario:  " + this.codigopostaldestinatario + "\n" +
                     "Peso En KG:  " + this.pesokg + "\n" +
                     "Costo En Gramos:  " + this.costogramo;

        }

        /// <summary>
        /// Método que compara dos objectos
        /// </summary>
        public override bool Equals(object obj)
        {
            Package o = (Package)obj;
            bool result = false;

            if ((this.codigo == o.codigo) &&
                (this.nombre == o.nombre) &&
                (this.direccion == o.direccion) &&
                (this.estado == o.estado) &&
                (this.departamento== o.departamento) &&
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
        public double calculateCost();
                
              this.costoasociado=(this.costogramo*this.pesokg);

        

        #endregion

        

        

    }
}