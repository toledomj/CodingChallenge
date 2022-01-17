namespace CodingChallenge.Data.Refactor
{
    public abstract class FormaGeometricaBase : IFormaGeometrica
    {
        protected readonly decimal _lado;
        public FormaGeometricaEnum Tipo { get; private set; }

        public FormaGeometricaBase(FormaGeometricaEnum tipo, decimal ancho)
        {
            Tipo = tipo;
            _lado = ancho;
        }

        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();
    }
}
