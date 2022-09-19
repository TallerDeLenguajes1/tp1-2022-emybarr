namespace Ejercicio2
{
    public class DatosPersonales
    {
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private DateTime fechaDivorcio;
        private char genero; 
        private char estadoCivil;
        private int hijos;
        private int edad;
        

        public string Apellido { get => apellido; set => apellido = value; }
        public int Hijos { get => hijos; set => hijos = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime FechaDivorcio { get => fechaDivorcio; set => fechaDivorcio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public int Edad { get => edad; set => edad = value; }

        public DatosPersonales(string Ape, string Nom, DateTime fNac,char sexo,char eCivil)
    {
     this.Apellido =Ape;
     this.Nombre = Nom;
     this.FechaDeNacimiento = fNac;
     this.Genero= sexo;
     this.EstadoCivil = eCivil;

    }

    
        public int calcularEdad()
        {
            Edad = DateTime.Today.Year - FechaDeNacimiento.Year;

            if (DateTime.Today.Month < FechaDeNacimiento.Month)
            {
                --Edad;                
            }
            else if (DateTime.Today.Month == FechaDeNacimiento.Month && DateTime.Today.Day < FechaDeNacimiento.Day)
            {
                --Edad;
            }

            return Edad;
        }
}
}