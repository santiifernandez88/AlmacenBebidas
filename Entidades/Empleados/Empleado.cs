using System.Data.Common;
using System.Runtime.CompilerServices;

namespace Entidades.Empleados
{
    public enum PuestosDeTrabajo
    {
        Jefe,
        Encargado,
        Vendedor
    }
    public class Empleado : Persona
    {
        private int id;
        private float sueldo;
        private PuestosDeTrabajo puesto;

        public Empleado(string nombre, string apellido, int edad, int dni, float sueldo, PuestosDeTrabajo puesto) : base(nombre, apellido, edad, dni)
        {
            this.sueldo = sueldo;
            this.puesto = puesto;
        }

        public Empleado(int id, string nombre, string apellido, int edad, int dni, float sueldo, PuestosDeTrabajo puesto) : base(nombre, apellido, edad, dni)
        {
            this.id = id;
            this.sueldo = sueldo;
            this.puesto = puesto;
        }

        public int Id { get => id; set => id = value; }
        public float Sueldo { get => sueldo; set => sueldo = value; }
        public PuestosDeTrabajo Puesto { get => puesto; set => puesto = value; }


        public static bool operator ==(Empleado emp1, Empleado emp2)
        {
            return emp1.Dni == emp2.Dni;
        }

        public static bool operator !=(Empleado emp1, Empleado emp2)
        {
            return !(emp1 == emp2);
        }

    }
}