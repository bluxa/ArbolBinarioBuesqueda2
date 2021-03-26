using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Arboles_Binarios_de_Busqueda
{
    public class Tareas:Comparador,Comparador2
    {
        public int IdTarea{ get; set; }
        public string NombreTarea {get; set;}
        public string Duracion { get; set; }
        public string Porcentaje { get; set; }
        public string NombreProgramador { get; set; }

        public Tareas()
        {
            
        }

        public Tareas(int idTarea, string nombreTarea, string duracion, string porcentaje, string nombreProgramador)
        {
            IdTarea = idTarea;
            NombreTarea = nombreTarea;
            Duracion = duracion;
            Porcentaje = porcentaje;
            NombreProgramador = nombreProgramador;
        }

        public bool menorQue(Object q)
        {
            Tareas Aux = (Tareas)q;
            return IdTarea < Aux.IdTarea;
        }

        public bool igualQue(Object q)
        {
            Tareas Aux = (Tareas)q;
            return IdTarea == Aux.IdTarea;
        }

        public bool EsigualQue(Object q)
        {
            Tareas Aux = (Tareas)q;
            return NombreTarea == Aux.NombreTarea;
        }

        public bool EsDistinto(Object q)
        {
            Tareas Aux = (Tareas)q;
            return NombreTarea != Aux.NombreTarea;
        }


        public bool menorIgualQue(Object q)
        {
            throw new NotImplementedException();
        }

        public bool mayorQue(Object q)
        {
            Tareas Aux = (Tareas)q;
            return IdTarea > Aux.IdTarea;
        }
        public bool mayorIgualQue(Object q)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            //return NombreTarea+ " - "+NombreProgramador+" - "+Duracion+" - "+Porcentaje;
            return "["+IdTarea +"  " + NombreTarea + " "+ Duracion+ " "+ Porcentaje+ " "+ NombreProgramador+"]    ";
        }




    }
}
