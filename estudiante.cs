using System;

class Estudiante
{
   public string nombre{ set;get;}
    public string apellido{ set;get;}
    public string institucion{set; get;}
    public int cedula{set; get;} 

    public Estudiante(string nombre, string apellido, string institucion, int cedula)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.institucion = institucion;
        this.cedula = cedula;
    }
    public void imprimir_datos()
    {}

    public void valor_anual(){}
}
    