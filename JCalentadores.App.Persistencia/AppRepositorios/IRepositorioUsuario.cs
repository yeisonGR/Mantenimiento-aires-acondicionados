using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JCalentadores.App.Dominio;

namespace JCalentadores.App.Persistencia
{
    public interface IRepositorioUsuario
    {
        IEnumerable<Usuarios> GetAllUsuarios();
        Usuarios AddUsuarios(Usuarios usuario);
        Usuarios UpdateUsuarios(Usuarios usuario);
        void DeleteUsuarios(int idUsuario);    
        Usuarios GetUsuarios(int idUsuario); 
        IEnumerable<Usuarios> GetUsuariosPorFiltro(string filtro);
        
    }
}