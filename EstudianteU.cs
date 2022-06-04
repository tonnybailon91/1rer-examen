using System;
class EstudianteU:Estudiante, IEstudiantes
{
    public int Cantidad_creditos{ set; get; }
    public int Precio_credito{ set; get;}

    public EstudianteU(int Cantidad_creditos, int Precio_credito,
    string nombre, string apellido, string institucion, int cedula)
    : base (nombre, apellido, institucion, cedula)
    {
        this.Cantidad_creditos = Cantidad_creditos;
        this.Precio_credito = Precio_credito;
    }


    public  void imprimir_datos()
    {
        Console.WriteLine("nombre"+ nombre);
        Console.WriteLine("Apellido"+ apellido);
        Console.WriteLine("direccion"+ institucion);
        Console.WriteLine("cedula"+ cedula);
        Console.WriteLine("la cantidad de creditos is"+ Cantidad_creditos);
        Console.WriteLine("el precio de creditos is"+ Precio_credito);
        
    }
    public  void valor_anual()
    {
        int operacion;
        operacion = Cantidad_creditos * Precio_credito;
        
        Console.WriteLine("el sueldo is:"+ operacion );

    }
}