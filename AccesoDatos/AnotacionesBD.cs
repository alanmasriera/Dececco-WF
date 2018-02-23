using Entidades;

namespace AccesoDatos
{
    public class AnotacionesBD
    {
        public Anotaciones_Proyecto Insertar(Anotaciones_Proyecto anotacion)
        {
            
            using (var bd = new DescarEntity())
            {
                var anot = new Anotaciones_Proyecto
                {
                    archivado = anotacion.archivado,
                    descripcion = anotacion.descripcion,
                    fecha = anotacion.fecha,
                    id_actividad_proyecto = anotacion.id_actividad_proyecto,
                    id_proyecto = anotacion.id_proyecto,
                    id_subproyecto = anotacion.id_subproyecto,
                    id_usuario = anotacion.id_usuario,
                    mostrar = anotacion.mostrar,
                    orden = anotacion.orden,
                    resaltar = anotacion.resaltar
                };

                bd.Anotaciones_Proyecto.Add(anot);
                bd.SaveChanges();
                anotacion.id_anotacion = anot.id_anotacion;
            }
            return anotacion;            
        }

        ////procedimiento modificar
        //public void Modificar(int idTipo_actividad)
        //{
        //    dt = new DataTable("Anotaciones_Proyecto");
        //    da = new SqlClient.SqlDataAdapter("SELECT * FROM Anotaciones_Proyecto WHERE id_anotacion = @id_anotacion", cnn.Coneccion);
        //    da.SelectCommand.Parameters.AddWithValue("@id_anotacion", idTipo_actividad);
        //    da.Fill(dt);
        //    this.AsignarTipos();
        //    if (dt.Rows.Count == 0)
        //    {
        //        throw new Exception("No se ha encontrado el Registro");
        //    }
        //    else {
        //        dr = dt.Rows(0);
        //    }
        //    CrearComandoUpdate();
        //}

        ////procedimiento borrar
        //public void Borrar(int idTipo_actividad)
        //{
        //    dt = new DataTable("Anotaciones_Proyecto");
        //    da = new SqlClient.SqlDataAdapter("SELECT * FROM Anotaciones_Proyecto WHERE id_anotacion = " + idTipo_actividad, cnn.Coneccion);
        //    da.Fill(dt);

        //    this.AsignarTipos();

        //    if (dt.Rows.Count == 0)
        //    {
        //        return;
        //    }
        //    else {
        //        dr = dt.Rows(0);
        //    }

        //    try
        //    {
        //        SqlCommand cmddel = new SqlCommand("cop_Anotaciones_Proyecto_Delete", cnn.Coneccion);
        //        cmddel.CommandType = CommandType.StoredProcedure;
        //        da.DeleteCommand = cmddel;
        //        SqlParameter prm = default(SqlParameter);
        //        prm = da.DeleteCommand.Parameters.Add("@id_anotacion", SqlDbType.Int, 4, "id_anotacion");
        //        dt.Rows(0).Delete();
        //        CrearComandoUpdate();
        //        Guardar();
        //    }
        //    catch (Exception ex)
        //    {
        //        if (Err.Number == 5)
        //        {
        //        }
        //    }
        //}

        ////asigno el tipo de datos a los parametros
        //private void AsignarTipos()
        //{
        //    foreach (DataColumn dc in dt.Columns)
        //    {
        //        switch (dc.ColumnName)
        //        {
        //            case "id_tipo_actividad":
        //                dc.DataType = Type.GetType("System.Int32");
        //                break;
        //            case "descripcion":
        //                dc.DataType = Type.GetType("System.String");
        //                break;
        //            case "id_proyecto":
        //                dc.DataType = Type.GetType("System.Int32");
        //                break;
        //            case "mostrar":
        //                dc.DataType = Type.GetType("System.Boolean");
        //                break;
        //            case "resaltar":
        //                dc.DataType = Type.GetType("System.Boolean");
        //                break;
        //            case "orden":
        //                dc.DataType = Type.GetType("System.Int32");
        //                break;
        //            case "fecha":
        //                dc.DataType = Type.GetType("System.DateTime");
        //                break;
        //            case "archivado":
        //                dc.DataType = Type.GetType("System.Boolean");
        //                break;
        //            case "id_usuario":
        //                dc.DataType = Type.GetType("System.Int32");
        //                break;
        //            case "id_actividad_proyecto":
        //                dc.DataType = Type.GetType("System.Int32");
        //                break;
        //            case "id_subproyecto":
        //                dc.DataType = Type.GetType("System.Int32");
        //                break;
        //        }
        //    }
        //}
    }
}
