using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JCalentadores.App.Dominio;
using JCalentadores.App.Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace JCalentadores.App.Frontend.Pages
{
   
    public class ListModel : PageModel
    {
        private readonly IRepositorioUsuario repositorioUsuarios;

        public IEnumerable <JCalentadores.App.Dominio.Usuarios> ObUsuarios {get;set;}   
       

        public ListModel()
       {
            this.repositorioUsuarios=new RepositorioUsuario(new JCalentadores.App.Persistencia.AppContext());
       }
       
        public void OnGet(string filtroBusqueda)
        {
            ObUsuarios = repositorioUsuarios.GetAllUsuarios();
          
        }
    }
}