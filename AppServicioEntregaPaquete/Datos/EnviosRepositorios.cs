using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppServicioEntregaPaquete.Modelo;

namespace AppServicioEntregaPaquete.Datos
{
    public class EnviosRepositorios
    {
        private List<Package> data = new List<Package>();

        public IEnumerable<Package> getPackage()
        {
            Package c1 = new Package();

            Package c2 = new Package();

            data.Add(c1);
            data.Add(c2);

            return data;
        }
    }
}