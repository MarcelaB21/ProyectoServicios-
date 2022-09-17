using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoServicios.App.Dominio.Entidades
{
    public class Personas
    {
      
      public int Id { get ; set ;}  
      public string Nombre { get ; set ;}  
      public string  Apellidos  { get ; set ;}  
      public string  NumeroTelefeno  { get ; set ;}  
      public Genero Genero {get; set;}
    }
}