namespace Ejercicio2
{
    public class DatosProfesionales
    {
        private string cargo;
        private string titulo;
        private string universidad; 
        private float sueldo;

        private DateTime fechaIngreso;

        public string Cargo { get => cargo; set => cargo = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Universidad { get => universidad; set => universidad = value; }
        public float Sueldo { get => sueldo; set => sueldo = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }

        public DatosProfesionales(string car, float sldo, DateTime fIngreso ){
            this.Cargo= car;
            this.Sueldo= sldo;
            this.FechaIngreso = fIngreso;

        }

         public double antiguedad()
         {
         DateTime fechaActual = DateTime.Now;
         TimeSpan antiguedad = fechaActual - FechaIngreso;
         return Convert.ToInt32(antiguedad.TotalDays/365.25);
        }
    }
}