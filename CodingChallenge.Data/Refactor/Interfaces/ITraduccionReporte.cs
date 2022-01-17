using System.Collections.Generic;

namespace CodingChallenge.Data.Refactor
{
    public interface ITraduccionReporte
    {
        string ListaVacia();
        string LabelTitulo();
        string LabelFormas();
        string LabelPerimetro();
        string LabelArea();
        List<TraduccionForma> ListaFormas();
    }
}
