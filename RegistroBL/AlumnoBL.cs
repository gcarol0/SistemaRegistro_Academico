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
    public class AlumnoBL
    {        
        public bool Guardar(AlumnoBOL alumno)
        {
            try
            {
                AlumnoDAL obj = new AlumnoDAL();
                obj.Guardar(alumno);
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public bool Actualizar(AlumnoBOL alumno)
        {
            try
            {
                AlumnoDAL obj = new AlumnoDAL();
                obj.Modificar(alumno);
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public bool Eliminar(int id)
        {
            try
            {
                AlumnoDAL obj = new AlumnoDAL();
                obj.Eliminar(id);
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public AlumnoBOL ObtenerAlumnoPorID(int id)
        {
            try
            {
                AlumnoDAL obj = new AlumnoDAL();
                return obj.SeleccionarPorID(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<AlumnoBOL> ObtenerAlumnos()
        {
            try
            {
                AlumnoDAL obj = new AlumnoDAL();
                return obj.ObtenerAlumnos();
            }
            catch (Exception)
            {
                return new List<AlumnoBOL>();
            }
        }

    }
}
