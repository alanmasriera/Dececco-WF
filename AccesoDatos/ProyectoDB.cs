using Entidades;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccesoDatos
{
    public static class ProyectoDB
    {
        static readonly string ConnexionStr = "Descar";
        public static Proyecto Insertar(Proyecto proyecto)
        {
            using (var bd = new DescarEntity())
            {                
                bd.Proyectoes.Add(proyecto);
                bd.SaveChanges();
            }
            return proyecto;
        }

        public static bool AsignarOt(int idProyecto)
        {
            var conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[ConnexionStr].ConnectionString);
            var cmd = new SqlCommand
            {
                CommandText = "cop_proyecto_agregarOT",
                CommandType = System.Data.CommandType.StoredProcedure,
                Connection = conexion
            };


            cmd.Parameters.Add("@id_proyecto", System.Data.SqlDbType.Int, 6, "id_proyecto");
            cmd.Parameters["@id_proyecto"].Value = idProyecto;

            conexion.Open();
            var rows = cmd.ExecuteNonQuery();
            conexion.Close();

            return rows == 1;
        }

        public static List<SUBPROYECTO> ObtenerSubproyectosHijos(Proyecto proyecto)
        {
            using (var bd = new DescarEntity())
            {
                var sub = (from s in bd.SUBPROYECTOes
                           where s.id_proyecto == proyecto.id_proyecto
                           && s.id_subproyecto_padre ==1
                           select s);
                return sub.ToList();
            }
        }

        public static Proyecto ActualizarActivo(int id_proyecto, bool value)
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from p in bd.Proyectoes
                           where p.id_proyecto == id_proyecto
                           select p).Single();

                pro.activo = value;
                bd.SaveChanges();

                return pro;
            }
        }

        public static Proyecto ObtenerPorID(int idProyecto)
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from p in bd.Proyectoes
                            where p.id_proyecto == idProyecto
                            select p);

                return pro.Any() ? pro.First() : null;
            }
        }

        public static bool AsignarMiembros(List<USUARIO> usuarios, int idProyecto)
        {
            try
            {
                using (var bd = new DescarEntity())
                {
                    foreach (var usuario in usuarios)
                    {
                        var usuPro = new Usuario_Proyecto
                        {
                            id_subproyecto = 0,
                            id_usuario = usuario.id_usuario,
                            id_proyecto = idProyecto
                        };

                        bd.Usuario_Proyecto.Add(usuPro);
                        bd.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static List<USUARIO> ObtenerMiembros(Proyecto proyecto)
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from u in bd.USUARIOs
                           join up in bd.Usuario_Proyecto on u.id_usuario equals up.id_usuario
                           where up.id_proyecto == proyecto.id_proyecto
                           select u);

                return pro.ToList();
            }
        }

        public static List<Proyecto> ObtenerProyectosCliente(int idCliente)
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from p in bd.Proyectoes
                           where p.id_cliente == idCliente
                           select p);

                return pro.OrderBy(n => n.nro).ThenBy(f => f.fecha_inicio).ToList();
            }
        }

        public static List<Proyecto> ObtenerProyectosActivosCliente(int idCliente)
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from p in bd.Proyectoes
                           where p.id_cliente == idCliente
                           & p.activo == true
                           select p);

                return pro.OrderBy(n => n.nro).ThenBy(f => f.fecha_inicio).ToList();
            }
        }

        public static List<Proyecto> ObtenerProyectos()
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from p in bd.Proyectoes
                           select p);

                return pro.ToList();
            }
        }


        public static List<Proyecto> ObtenerProyectosActivos()
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from p in bd.Proyectoes
                           where p.activo == true
                           select p);

                return pro.ToList();
            }
        }

        public static List<Tuple<USUARIO, double>> ObtenerHorasTrabajadasPorUsuario(Proyecto proyecto)
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from mh in bd.Movimiento_hora
                           join cmh in bd.Cuerpo_movimiento_hora on mh.id_movimiento_hora equals cmh.id_movimiento_hora
                           join u in bd.USUARIOs on mh.id_usuario equals u.id_usuario
                           join ap in bd.Actividad_proyecto on cmh.id_actividad_proyecto equals ap.id_actividad_proyecto
                           where ap.id_proyecto == proyecto.id_proyecto
                           select new { usuario = u, salida = cmh.salida.Value, entrada = cmh.entrada.Value });

                return pro.AsEnumerable().Select(x => new Tuple<USUARIO,double>(x.usuario, x.salida.Subtract(x.entrada).TotalHours)).ToList();               
            }
        }

        public static Proyecto Update(Proyecto proyAux)
        {
            using (var bd = new DescarEntity())
            {
                var pro = (from p in bd.Proyectoes
                           where p.id_proyecto == proyAux.id_proyecto
                           select p).Single();

                pro.path = proyAux.path;
                pro.nombre_proyecto = proyAux.nombre_proyecto;
                pro.descripcion = proyAux.descripcion;
                pro.prioridad = proyAux.prioridad;
                pro.total_hora = proyAux.total_hora;
                pro.id_calendario_laboral_base = proyAux.id_calendario_laboral_base;
                pro.activo = proyAux.activo;
                pro.archivado = proyAux.archivado;
                pro.fecha_fin_prevista = proyAux.fecha_fin_prevista;
                pro.fecha_fin_real = proyAux.fecha_fin_real;
                pro.fecha_inicio = proyAux.fecha_inicio;
                pro.id_cliente = proyAux.id_cliente;
                pro.id_controlador_1 = proyAux.id_controlador_1;
                pro.id_controlador_2 = proyAux.id_controlador_2;
                pro.id_estado = proyAux.id_estado;
                pro.id_estado_proyecto = proyAux.id_estado_proyecto;
                pro.id_piloto = proyAux.id_piloto;
                pro.id_proyecto_padre = proyAux.id_proyecto_padre;
                pro.id_proyect_manager = proyAux.id_proyect_manager;
                pro.indice = proyAux.indice;
                pro.nro = proyAux.nro;
                pro.observacion = proyAux.observacion;
                pro.orden = proyAux.orden;
                pro.path = proyAux.path;
                pro.prioridad = proyAux.prioridad;
                pro.total_hora = proyAux.total_hora;

                bd.SaveChanges();

                return pro;
            }
        }
    }
}
