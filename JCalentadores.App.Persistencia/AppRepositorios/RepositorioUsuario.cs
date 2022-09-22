using System;
using System.Collections.Generic;
using System.Linq;
using JCalentadores.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace JCalentadores.App.Persistencia
{

    public class RepositorioUsuario : IRepositorioUsuario
    {
        /// <summary>
        /// Referencia al contexto de Paciente
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioUsuario(AppContext appContext)
        {
            _appContext = appContext;
        }


        public Usuarios AddUsuarios(Usuarios usuario)
        {
            var usuarioAdicionado = _appContext.usuarios.Add(usuario);
            _appContext.SaveChanges();
            return usuarioAdicionado.Entity;

        }

        void IRepositorioUsuario.DeleteUsuarios(int idUsuario)
        {
            var usuarioEncontrado = _appContext.usuarios.FirstOrDefault(p => p.id == idUsuario);
            if (usuarioEncontrado == null)
                return;
            _appContext.usuarios.Remove(usuarioEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Usuarios> GetAllUsuarios()
        {
            return GetAllUsuarios_();
        }

        public IEnumerable<Usuarios> GetUsuariosPorFiltro(string filtro)
        {
            var usuarios = GetAllUsuarios(); // Obtiene todos los saludos
            if (usuarios != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    usuarios = usuarios.Where(s => s.nombre.Contains(filtro));
                }

            }
            return usuarios;

        }

        public IEnumerable<Usuarios> GetAllUsuarios_()
        {
            //return _appContext.Pacientes.Include(p =>p.SignoVital);
            return _appContext.usuarios;
        }

        public Usuarios GetUsuarios(int idUsuario)
        {
            return _appContext.usuarios.FirstOrDefault(p => p.id == idUsuario);
        }

        public Usuarios UpdateUsuarios(Usuarios usuarios)
        {
            var usuarioEncontrado = _appContext.usuarios.FirstOrDefault(p => p.id == usuarios.id);
            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.nombre = usuarios.nombre;
                usuarioEncontrado.apellido = usuarios.apellido;
                usuarioEncontrado.cedula = usuarios.cedula;
                usuarioEncontrado.email = usuarios.email;
                usuarioEncontrado.direccion = usuarios.direccion;
                usuarioEncontrado.nit = usuarios.nit;
                usuarioEncontrado.admin = usuarios.admin;
                usuarioEncontrado.confirmado = usuarios.confirmado;
                usuarioEncontrado.token = usuarios.token;
                usuarioEncontrado.tipoUsuario = usuarios.tipoUsuario;
                usuarioEncontrado.numeroRegistro = usuarios.numeroRegistro;
                usuarioEncontrado.horario = usuarios.horario;
                usuarioEncontrado.metodoPago = usuarios.metodoPago;
                usuarioEncontrado.tipoPersona = usuarios.tipoPersona;

                _appContext.SaveChanges();


            }
            return usuarioEncontrado;
        }
    }
}

        
        

        
        
       
