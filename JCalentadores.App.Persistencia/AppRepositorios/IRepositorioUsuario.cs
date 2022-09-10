using System;
using System.Collections.Generic;
using System.Linq;
using JCalentadores.App.Dominio;
namespace JCalentadores.App.Persistencia
{
public interface IRepositorioUsuario
{
    IEnumerable<Usuarios> GetAllUsuarios();
    Usuarios AddUsuarios(Usuarios usuarios);
    Usuarios UpdateUsuarios(Usuarios usuarios);
    void DeleteUsuarios(int id);
    Usuarios GetUsuarios(int id);

}
}
