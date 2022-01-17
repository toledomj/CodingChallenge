/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Refactor
{
    public class FormaGeometricaNew
    {
        public static string Imprimir(List<FormaGeometricaBase> listaFormas, ITraduccionReporte idioma)
        {
            var sb = new StringBuilder();

            if (!listaFormas.Any())
            {
                sb.Append(idioma.ListaVacia());
            }
            else
            {
                sb.Append(idioma.LabelTitulo());

                List<LineaReporte> reporte = new List<LineaReporte>();

                foreach(FormaGeometricaBase forma in listaFormas)
                {
                    LineaReporte nodo = reporte.FirstOrDefault(x => x.Tipo == forma.Tipo);

                    if (nodo == null)
                    {
                        // Agrego nueva linea al reporte.
                        LineaReporte nuevaLinea = new LineaReporte(forma.Tipo);
                        nuevaLinea.CantidadDeFormas++;
                        nuevaLinea.AreaTotal += forma.CalcularArea();
                        nuevaLinea.PerimetroTotal += forma.CalcularPerimetro();

                        reporte.Add(nuevaLinea);
                    }
                    else
                    {
                        nodo.CantidadDeFormas++;
                        nodo.AreaTotal += forma.CalcularArea();
                        nodo.PerimetroTotal += forma.CalcularPerimetro();
                    }
                }
                
                foreach(LineaReporte linea in reporte)
                {
                    sb.Append(ObtenerLinea(linea, idioma));
                }
                
                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(reporte.Sum(x => x.CantidadDeFormas) + " " + idioma.LabelFormas() + " ");
                sb.Append(idioma.LabelPerimetro() + " " + (reporte.Sum(x => x.PerimetroTotal)).ToString("#.##") + " ");
                sb.Append(idioma.LabelArea() + " " + (reporte.Sum(x => x.AreaTotal)).ToString("#.##"));
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(LineaReporte linea, ITraduccionReporte idioma)
        {
            TraduccionForma forma = idioma.ListaFormas().FirstOrDefault(x => x.Tipo == linea.Tipo);

            if (forma != null)
            {
                string nombreForma = (linea.CantidadDeFormas == 1 ? forma.Singular : forma.Plural);
                return $"{linea.CantidadDeFormas} {nombreForma} | {idioma.LabelArea()} {linea.AreaTotal:#.##} | {idioma.LabelPerimetro()} {linea.PerimetroTotal:#.##} <br/>";
            }
            else
            {
                return String.Empty;
            }
        }
    }
}
