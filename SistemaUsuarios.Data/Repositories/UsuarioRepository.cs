using Microsoft.EntityFrameworkCore;
using SistemaUsuarios.Data.Contexts;
using SistemaUsuarios.Data.Entities;

namespace SistemaUsuarios.Data.Repositories
{
    public class UsuarioRepository
    {
        public void Create(Usuario usuario)
        {
            using (var sqlServerContext = new SqlServerContext())
            {
                sqlServerContext.Usuario.Add(usuario);
                sqlServerContext.SaveChanges();
            }
        }

        public void Update(Usuario usuario)
        {
            using (var sqlServerContext = new SqlServerContext())
            {
 
                sqlServerContext.Entry(usuario).State = EntityState.Modified;
                sqlServerContext.SaveChanges();
            }
        }
        public void Delete(Usuario usuario)
        {
            using (var sqlServerContext = new SqlServerContext())
            {
                sqlServerContext.Remove(usuario);
                sqlServerContext.SaveChanges();
            }
        }

        public Usuario GetByEmail(string email)
        {
            using (var sqlServerContext = new SqlServerContext())
            {
                return sqlServerContext.Usuario
                    .FirstOrDefault(u => u.Email.Equals(email));
            }
        }

        public Usuario GetByEmailAndSenha(string email, string senha)
        {
            using (var sqlServerContext = new SqlServerContext())
            {
                return sqlServerContext.Usuario
                    .FirstOrDefault(u => u.Email.Equals(email) 
                                      && u.Senha.Equals(senha));
            }
        }

        public Usuario GetById(Guid id) 
        {
            using (var sqlServerContext = new SqlServerContext())
            {
                return sqlServerContext.Usuario.FirstOrDefault(u => u.IdUsuario.Equals(id));
            }
        }
    }
}
