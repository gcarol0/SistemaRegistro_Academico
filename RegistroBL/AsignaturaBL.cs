using RegistroBOL;
using RegistroDAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroBL
{
    public class AsignaturaBL
    {
        public bool Guardar(AsignaturaBOL asignatura)
        {
            try
            {
                AsignaturaDAL obj = new AsignaturaDAL();
                obj.Guardar(asignatura);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Actualizar(AsignaturaBOL asignatura)
        {
            try
            {
                AsignaturaDAL obj = new AsignaturaDAL();
                obj.Modificar(asignatura);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Eliminar(int codAsignatura)
        {
            try
            {
                AsignaturaDAL obj = new AsignaturaDAL();
                obj.Eliminar(codAsignatura);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public AsignaturaBOL ObtenerAsignaturaPorID(int codAsignatura)
        {
            try
            {
                AsignaturaDAL obj = new AsignaturaDAL();
                return obj.SeleccionarPorID(codAsignatura);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<AsignaturaBOL> ObtenerAsignaturas()
        {
            try
            {
                AsignaturaDAL obj = new AsignaturaDAL();
                return obj.ObtenerAsignaturas();
            }
            catch (Exception)
            {
                return new List<AsignaturaBOL>();
            }
        }
    }

}
