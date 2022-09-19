namespace Ejercicio2
{
    public class Empleado
    {
        private DatosPersonales dper;
        private Direccion direc;
        private DatosProfesionales dprof;
        private double salario;
        private float descuento;
        private double adicional;
        private double anti;


        public DatosPersonales Dper { get => dper; set => dper = value; }
        public Direccion Direc { get => direc; set => direc = value; }
        public DatosProfesionales Dprof { get => dprof; set => dprof = value; }
  
        public double Adicional { get => adicional; set => adicional = value; }
        public double Anti { get => anti; set => anti = value; }
        public float Descuento { get => descuento; set => descuento = value; }
        public double Salario { get => salario; set => salario = value; }

        public Empleado(DatosPersonales dper, Direccion dir, DatosProfesionales dprof)
        {
            this.Dper =dper;
            this.Dprof = dprof;
            this.Direc = dir;
        }

        public double CalcularSalario()
        {
        
         Descuento = Dprof.Sueldo * (float)0.15;
         Anti =  Dprof.antiguedad();
        if (anti >= 20)
        {
            adicional =Dprof.Sueldo * (float)0.20;
        }
        else
        {
            adicional = Dprof.Sueldo * (anti / 100);
        }
        Salario = Dprof.Sueldo + Adicional - Descuento;
        return (Salario);
    }



      
    }
}