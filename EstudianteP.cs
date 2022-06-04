using System;
class EstudianteP:Estudiante, IEstudiantes
{
    public int valoranual{ set; get;}

    public EstudianteP (int valor_anual, string nombre, string apellido, string institucion, int cedula )
    :base(nombre, apellido, institucion, cedula)
    {
        this.valoranual = valoranual;
        
    }
    public  void imprimir_datos()
    {
        Console.WriteLine("nombre"+ nombre);
        Console.WriteLine("Apellido"+ apellido);
        Console.WriteLine("direccion"+ institucion);
        Console.WriteLine("cedula"+ cedula);
        Console.WriteLine("el valor anuel is"+ valoranual);
        
    }
    public  void valor_anual()
    {
    
        
        Console.WriteLine("el valor anual is"+ valor_anual);

        
    }

}

