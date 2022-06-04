using System;

class EstudianteS:Estudiante, IEstudiantes
{
    public int nivel_cursando{ set; get; }
    public int precio_fijo{ set; get;}

    public EstudianteS(int nivel_cursando, int precio_fijo,
    string nombre, string apellido, string institucion, int cedula)
    : base (nombre, apellido, institucion, cedula)
    {
        this.nivel_cursando = nivel_cursando;
        this.precio_fijo = precio_fijo;
    }
    public  void imprimir_datos()
    {
        Console.WriteLine("nombre"+ nombre);
        Console.WriteLine("Apellido"+ apellido);
        Console.WriteLine("direccion"+ institucion);
        Console.WriteLine("cedula"+ cedula);
        Console.WriteLine("el nivel cursado is"+ nivel_cursando);
        Console.WriteLine("el precio fijo is"+ precio_fijo);
        
    }

    public  void valor_anual()
    {
        int operacion; 
        
        operacion= nivel_cursando * precio_fijo;
        

        Console.WriteLine("el sueldo is:" + operacion );

    }

}
