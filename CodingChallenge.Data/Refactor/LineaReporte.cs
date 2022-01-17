namespace CodingChallenge.Data.Refactor
{
    public class LineaReporte
    {        
        public FormaGeometricaEnum Tipo { get; private set; }
        public int CantidadDeFormas { get; set; }
        public decimal AreaTotal { get; set; }
        public decimal PerimetroTotal { get; set; }

        public LineaReporte(FormaGeometricaEnum tipo)
        {
            Tipo = tipo;
        }
    }
}
