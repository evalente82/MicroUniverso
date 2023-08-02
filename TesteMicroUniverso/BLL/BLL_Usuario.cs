using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMicroUniverso.DAL;
using TesteMicroUniverso.Models;

namespace TesteMicroUniverso.BLL
{
    public class BLL_Usuario
    {
        DAL_Usuario vDAL_Usuario = new DAL_Usuario();
        public Task<List<Usuario>> ListUsuarios()
        {
            return vDAL_Usuario.ListUsuarios();
        }

        public Task<Usuario> Salvar(Usuario usuario)
        {
            return vDAL_Usuario.CadastrarUsuario(usuario);
        }

        public Task Apagar(int Id)
        {
            return vDAL_Usuario.DeletarUsuario(Id);
        }

        internal Task Editar(Usuario editarUsuario)
        {
            return vDAL_Usuario.EditarUsuario(editarUsuario);
        }
    }
}
