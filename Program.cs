using System;

namespace ConsoleApp13
{
    class program
    {
        static void Main(string[]args)
        {
            Estudiante EstudianteP = new EstudianteP(100, "tonny", "bailon", "Facci", 0961813086);
            EstudianteP.imprimir_datos();
            EstudianteP.valor_anual();

            Estudiante EstudianteU = new EstudianteU(6, 7, "veronica", "tucker", "medio", 987654323);
            EstudianteU.imprimir_datos();
            EstudianteU.valor_anual();


            Estudiante EstudianteS = new EstudianteS(2, 20, "mauro", "macias", "bajo", 987154323);
            EstudianteU.imprimir_datos();
            EstudianteU.valor_anual(); 
        }
    }
}