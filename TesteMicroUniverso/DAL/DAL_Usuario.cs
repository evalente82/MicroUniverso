using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteMicroUniverso.Models;

namespace TesteMicroUniverso.DAL
{
    public class DAL_Usuario
    {
        public async Task<List<Usuario>> ListUsuarios()
        {
            var dbContext = new AppDbContext();
            var results = await dbContext.Usuarios.ToListAsync();
            return results;
        }

        public async Task<Usuario> CadastrarUsuario(Usuario usuario)
        {
            var dbContext = new AppDbContext();

            dbContext.Usuarios.Add(usuario);
            await dbContext.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> EditarUsuario(Usuario editarUsuario)
        {
            var dbContext = new AppDbContext();
            Usuario usuarioExistente = await dbContext.Usuarios.FirstOrDefaultAsync(u => u.IdUsuario == editarUsuario.IdUsuario);
            if (usuarioExistente != null)
            {
                // Atualize as propriedades do usuário existente com as novas informações
                usuarioExistente.Login = editarUsuario.Login;
                usuarioExistente.Senha = editarUsuario.Senha;
                usuarioExistente.Papel = editarUsuario.Papel;
                usuarioExistente.ValorMinAprovacao = editarUsuario.ValorMinAprovacao;
                usuarioExistente.ValorMaxAprovacao = editarUsuario.ValorMaxAprovacao;

                // Salve as alterações no banco de dados
                await dbContext.SaveChangesAsync();

                // Retorna o objeto Usuario atualizado (opcional)
                return usuarioExistente;
            }
            else
            {
                // Lidar com o cenário onde o usuário não foi encontrado (opcional)
                // Por exemplo, lançar uma exceção ou retornar null.
                throw new ArgumentException("Usuário não encontrado no banco de dados.");
            }
        }

        public async Task DeletarUsuario(int id)
        {
            var dbContext = new AppDbContext();
            Usuario usuarioExistente = await dbContext.Usuarios.FirstOrDefaultAsync(u => u.IdUsuario == id);

            if (usuarioExistente != null)
            {
                dbContext.Usuarios.Remove(usuarioExistente);
                await dbContext.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentException("Usuário não encontrado no banco de dados.");
            }
        }
    }
}
