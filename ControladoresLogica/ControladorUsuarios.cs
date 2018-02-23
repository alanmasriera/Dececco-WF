using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace ControladoresLogica
{
    /// <summary>
    /// Controlador de los Usuarios
    /// </summary>
    public class ControladorUsuarios
    {
        /// <summary>
        /// Obtiene todos los usuario ACTIVOS de la base de datos.
        /// </summary>
        /// <returns></returns>
        public static List<USUARIO> ObtenerTodosUsuarios()
        {
            return UsuariosBD.ObtenerUsuariosActivos();
        }

        /// <summary>
        /// Retorna el usuario con el ID indicado
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public static USUARIO ObtenerUsuario(int idUsuario)
        {
            return UsuariosBD.ObtenerUsuario(idUsuario);
        }

        /// <summary>
        /// Verifica si existe el usuario
        /// </summary>
        /// <param name="usuario">El usuario con los nuevos datos</param>
        /// <returns>El usuario indicado, null si no encuentra</returns>
        public static USUARIO Exist(USUARIO usuario)
        {
            return UsuariosBD.Exist(usuario);
        }

        /// <summary>
        /// Inserta un nuevo usuario en la base de datos, y crea el calendario para el mismo,
        /// con calendario base indicado. Éste calendario se actualiza con el nuevo id.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static USUARIO InsertarYcreaCalendario(USUARIO usuario)
        {
            Calendario_Laboral calendario = new Calendario_Laboral()
            {
                es_calendario_base = false,
                id_calendario_padre = usuario.id_calendario_laboral,
                nombre_calendario = usuario.FullName
            };
            calendario = ControladorCalendario.Insertar(calendario);
            usuario.id_calendario_laboral = calendario.id_calendario_laboral;
            return UsuariosBD.Insertar(usuario);
        }

        /// <summary>
        /// Actualiza los datos de un usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static USUARIO Actualizar(USUARIO usuario)
        {
            return UsuariosBD.Actualizar(usuario);
        }

        /// <summary>
        /// Elimina el usuario de la base de datos
        /// </summary>
        /// <param name="user"></param>
        public static void Eliminar(USUARIO user)
        {
            UsuariosBD.Eliminar(user);
        }

        public static bool EstaHabilitadoParaActividad(USUARIO usuario, Actividad_proyecto actividad)
        {
            return UsuariosBD.EstaHabilitadoParaActividad(usuario, actividad);
        }

        public static int ObtenerCantidadCalificaciones(USUARIO usuario)
        {
            return UsuariosBD.ObtenerCantidadCalificaciones(usuario);
        }
    }
}
