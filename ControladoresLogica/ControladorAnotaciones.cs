using System;
using Entidades;
using AccesoDatos;

namespace ControladoresLogica
{
    public class ControladorAnotaciones
    {
        public void AgregarAnotacion(int idProyecto, int idCodigoUsuario, string text)
        {
            var anotacion = new Anotaciones_Proyecto
            {
                archivado = false,
                descripcion = text,
                fecha = DateTime.Now,
                id_actividad_proyecto = 0,
                id_proyecto = idProyecto,
                id_subproyecto = 0,
                id_usuario = idCodigoUsuario,
                mostrar = true,
                resaltar = true,
                orden = 999
            };


            var bdAnot = new AnotacionesBD();
            bdAnot.Insertar(anotacion);
        }
    }
}
