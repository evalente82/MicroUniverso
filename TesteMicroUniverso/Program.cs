using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteMicroUniverso.Forms;
using TesteMicroUniverso.Models;

namespace TesteMicroUniverso
{
    internal static class Program
    {
        public static Models.Usuario UsuarioLogado { get; private set; }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var db = new AppDbContext())
            {
                db.Database.CreateIfNotExists();
                
            }


            // Criação e exibição do formulário de login
            FrmLogin loginForm = new FrmLogin();
            DialogResult loginResult = loginForm.ShowDialog();

            // Verificação do resultado do login
            if (loginResult == DialogResult.OK)
            {
                // O usuário foi validado com sucesso, então podemos abrir o formulário principal
                Application.Run(new Principal());

                // Após fechar o formulário principal, verifique se o formulário de login ainda está aberto e feche-o também
                if (!loginForm.IsDisposed)
                {
                    loginForm.Close();
                }
            }
            else
            {
                // Caso o login seja cancelado ou inválido, encerre a aplicação
                Application.Exit();
            }
        }

        // Método para validar o usuário e senha no banco de dados usando o Entity Framework
        public static bool ValidarUsuario(string login, string senha)
        {
            using (AppDbContext dbContext = new AppDbContext()) // Substitua pelo contexto do seu banco de dados
            {
                // Faça a consulta ao banco de dados para encontrar o usuário com o nome de usuário fornecido
                Models.Usuario usuarioEncontrado = dbContext.Usuarios.FirstOrDefault(u => u.Login == login);

                // Verifique se o usuário foi encontrado e se a senha está correta
                if (usuarioEncontrado != null && usuarioEncontrado.Senha == senha)
                {
                    // Armazene o usuário logado na variável UsuarioLogado
                    UsuarioLogado = usuarioEncontrado;
                    return true; // O usuário foi validado com sucesso
                }
            }

            return false; // O usuário não foi encontrado ou a senha está incorreta
        }
    }
}
