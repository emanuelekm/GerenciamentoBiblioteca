using BCrypt.Net;

namespace GerenciamentoBiblioteca
{
    public static class PasswordHasher
    {
        public static string Hash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        public static bool Verify(string senhaDigitada, string hashArmazenado)
        {
            return BCrypt.Net.BCrypt.Verify(senhaDigitada, hashArmazenado);
        }
    }
}

