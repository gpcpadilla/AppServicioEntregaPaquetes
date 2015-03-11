using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppServicioEntregaPaquete.Modelo

namespace AppServisioEntregaPaquete.Datos
{
    public class Repositorios
    {
        private List<Package> data = new List<Package>();

        public IEnumerable<Package> getPackage()
        {
            Package p1 = new Package();

            Package p2 = new Package();

            data.Add(p1);
            data.Add(p2);

            return data;
        }
        }
    }
