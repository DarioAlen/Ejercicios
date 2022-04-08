namespace Restaurant.Dominio
{
    public class Ingrediente
    {
        private int _codigoIngrediente;
        private string _descripcion;

        public Ingrediente(int codigoIngrediente, string descripcion)
        {
            _codigoIngrediente = codigoIngrediente;
            _descripcion = descripcion;
        }
        public int CodigoIngrediente
        {
            get { return _codigoIngrediente; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
        }
        public string MostrarIngrediente()
        {
            return CodigoIngrediente.ToString() + " " + Descripcion;
        }
    }
}
