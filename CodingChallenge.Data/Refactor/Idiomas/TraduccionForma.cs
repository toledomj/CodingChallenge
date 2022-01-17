namespace CodingChallenge.Data.Refactor
{
    public class TraduccionForma
    {
        public FormaGeometricaEnum Tipo { get; private set; }
        public string Singular { get; private set; }
        public string Plural { get; private set; }

        public TraduccionForma(FormaGeometricaEnum tipo, string singular, string plural)
        {
            Tipo = tipo;
            Singular = singular;
            Plural = plural;
        }
    }
}
