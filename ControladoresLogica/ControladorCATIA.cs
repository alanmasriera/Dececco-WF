using System;
using System.Collections.Generic;
using Entidades;
using INFITF;
using ProductStructureTypeLib;

namespace ControladoresLogica
{
    public class ControladorCATIA
    {
        private INFITF.Application CATIA;
        private Product[] productos = new Product[200];
        public ControladorCATIA()
        {
            try
            {
                CATIA = (INFITF.Application)System.Runtime.InteropServices.Marshal.GetActiveObject("CATIA.Application");
            }
            catch (Exception)
            {

            }
        }

        public bool ObtenerEstado()
        {
            if (CATIA != null)
                return true;
            return false;
        }

        private Product CreateProduct(Product product, string nombre)
        {
            if (product == null)
            {
                var doc = CATIA.Documents.Add("Product");
                ((ProductDocument)CATIA.ActiveDocument).Product.ApplyWorkMode(CatWorkModeType.DESIGN_MODE);
                ((ProductDocument)CATIA.ActiveDocument).Product.set_PartNumber(nombre);
                return ((ProductDocument)doc).Product;
            }
            else
            {
                Product doc = null;
                try
                {
                    doc = product.Products.AddNewComponent("Product", nombre);
                    return doc;
                }
                catch (Exception)
                {
                    
                }
                
            }
            return null;


        }

        private void CreatePart(Product product, string nombre)
        {
            Product doc = null;
            try
            {
                if (product == null)
                {
                    var docu = CATIA.Documents.Add("Part");
                }
                else
                    doc = product.Products.AddNewComponent("Part", nombre);
            }
            catch (Exception e)
            {
                
            }
            
        }

        public void GenerarEstructura(int id_proyecto, int id_subproyecto)
        {
            GenerarEstructuraCATIA(null, id_proyecto, id_subproyecto, true);
        }

        private void GenerarEstructuraCATIA(Product product, int id_proyecto, int id_subproyecto, bool esProyecto)
        {
            var controladorSubproyecto = new ControladorSubproyecto();
            var controladorProyecto = new ControladorProyecto();
            var subproyectosHijos = new List<SUBPROYECTO>();
            //Verifica que la raiz del arbol sea un proyecto, o un subroyecto, y si es este ultimo
            //verifica si es unidad o no.
            if (esProyecto)
            {
                if (id_subproyecto != null & id_subproyecto > 1)
                {
                    SUBPROYECTO subproyecto = ControladorSubproyecto.BuscarPorId(id_subproyecto);
                    {
                        product = CreateProduct(null, subproyecto.nombre);
                    }
                }
                else
                {
                    Proyecto proyecto = ControladorProyecto.ObtenerPorID(id_proyecto);
                    product = CreateProduct(null, ((Proyecto)proyecto).nombre_proyecto);
                }
            }
            

            subproyectosHijos = ControladorSubproyecto.ObtenerPorProyecto(id_proyecto, id_subproyecto);
            if (subproyectosHijos.Count > 0)
            {
                foreach (var subproyecto in subproyectosHijos)
                {
                        Product prod = CreateProduct(product, subproyecto.nombre);
                        GenerarEstructuraCATIA(prod, id_proyecto, subproyecto.id_subproyecto, false);
                }
            }
        }
    }
}
