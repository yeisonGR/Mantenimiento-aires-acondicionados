using System;
using JCalentadores.App.Dominio;
using JCalentadores.App.Persistencia;

namespace JCalentadores.App.Persistencia
{   
    
    
        private static IRepositorioUsuario _repoUsuarios= new RepositorioUsuario (new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Aires Acondicionados");
            //AddPaciente();
            BuscarUsuarios(1);
            //AsignarMedico();
        }

        private static void AddUsuarios()
        {
            var usuarios = new Usuarios
            {
                nombre = "Ivan",
                apellido = "Castro Ruiz",                
            };
            _repoUsuarios.AddUsuarios(usuarios);
          
        }

        private static void BuscarUsuarios(int id)
        {
            var usuarios = _repoUsuarios.GetUsuarios(id);
            Console.WriteLine(usuarios.nombre+" "+usuarios.apellido);
        }      
    }
