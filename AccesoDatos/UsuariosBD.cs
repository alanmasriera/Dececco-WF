using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;

namespace AccesoDatos
{
    public static class UsuariosBD
    {
        public static List<USUARIO> ObtenerUsuariosActivos()
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.USUARIOs
                           where s.activo == true
                           select s);
                return sub.ToList();
            }
        }

        public static USUARIO ObtenerUsuario(int idUsuario)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.USUARIOs
                           where s.id_usuario == idUsuario
                           select s);
                return sub.Any() ? sub.First() : null;
            }
        }

        public static USUARIO Exist(USUARIO usuario)
        {
            using (var bd = new DescarEntity())
            {
                var us = (from u in bd.USUARIOs
                          where u.nombre_usuario == usuario.nombre_usuario
                          select u);

                return us.Any() ? us.First() : null;
            }
        }

        public static void Eliminar(USUARIO user)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.USUARIOs
                           where s.id_usuario == user.id_usuario
                           select s).Single();

                var det = (from s in bd.Calendario_Laboral
                           where s.id_calendario_laboral == user.id_calendario_laboral
                           select s).Single();

                bd.Calendario_Laboral.Remove(det);
                bd.USUARIOs.Remove(sub);
                bd.SaveChanges();
            }
        }


        public static USUARIO Insertar(USUARIO usuario)
        {
            using (var bd = new DescarEntity())
            {
                bd.USUARIOs.Add(usuario);
                bd.SaveChanges();

                return usuario;
            }
        }

        public static USUARIO Actualizar(USUARIO usuario)
        {
            using (var bd = new DescarEntity())
            {
                var user = (from us in bd.USUARIOs
                          where us.id_usuario == usuario.id_usuario
                          select us).Single();

                user.activo = usuario.activo;
                user.apellido = usuario.apellido;
                user.id_calendario_laboral = usuario.id_calendario_laboral;
                user.id_grupo_usuario = usuario.id_grupo_usuario;
                user.legajo = usuario.legajo;
                user.nombre = usuario.nombre;
                user.nombre_usuario = usuario.nombre_usuario;
                user.password_usuario = usuario.password_usuario;

                bd.SaveChanges();
                return user;
            }
        }

        public static bool EstaHabilitadoParaActividad(USUARIO usuario, Actividad_proyecto actividad)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.USUARIOs
                           join tau in bd.Tipo_Actividad_usuario on s.id_usuario equals tau.id_usuario
                           join ta in bd.Tipo_actividad on tau.id_tipo_actividad equals ta.id_tipo_actividad
                           join a in bd.Actividads on ta.id_tipo_actividad equals a.id_tipo_actividad
                           where actividad.id_actividad == a.id_actividad
                           && tau.id_usuario == usuario.id_usuario
                           select tau.habilitado);

                return sub.Any() ? sub.First().HasValue && sub.First().Value == true ? true : false : false;
            }
        }

        public static int ObtenerCantidadCalificaciones(USUARIO usuario)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.Tipo_Actividad_usuario
                           where s.habilitado == true
                           && s.id_usuario == usuario.id_usuario
                           select s);

                return sub.ToList().Count;
            }
        }

        public static List<USUARIO> ObtenerTodosUsuarios()
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.USUARIOs
                           select s);
                return sub.ToList();
            }
        }
    }
}
