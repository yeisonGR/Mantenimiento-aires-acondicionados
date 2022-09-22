using System;

namespace JCalentadores.App.Dominio{
public class Usuarios
{
    public int id {get;set;}
    public string nombre {get;set;}
    public string apellido {get;set;}
    public int cedula {get;set;}
    public string email {get;set;}
    public string telefono {get;set;}
    public string direccion {get;set;}
    public string nit {get;set;}
    public Boolean admin {get;set;}
    public Boolean confirmado {get;set;}
    public string token {get;set;}
    public string tipoUsuario {get;set;}
    public int numeroRegistro {get;set;}
    public DateTime horario {get;set;}
    public int metodoPago {get;set;}
    public int tipoPersona {get;set;}
   
}
}