namespace FourWeb.Abstraction.Domain.Entities
{
    public class User : EntityBase
    {
        protected User() { }

        public User(string email, string password, bool isAdmin)
        {
            this.Email = email;
            //TODO: Criptografar a senha do usuário
            this.Password = password;
            this.IsAdmin = isAdmin;
        }

        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool IsAdmin { get; private set; }

        public void GrantAdmin()
        {
            this.IsAdmin = true;
        }

        public void RevokeAdmin()
        {
            this.IsAdmin = false;
        }
    }
}
