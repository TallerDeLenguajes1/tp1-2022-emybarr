namespace Ejercicio2
{
    public class Direccion
    {
        private string calle;
        private int numero;

        public string Calle { get => calle; set => calle = value; }
        public int Numero { get => numero; set => numero = value; }

        public Direccion( string c, int n){
            this.Calle = c;
            this.Numero = n;
        }



    }


}