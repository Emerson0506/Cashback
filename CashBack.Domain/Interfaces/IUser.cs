using Cashback.Domain.Entities;

namespace Cashback.Domain.Interfaces
{
    /// <summary>
    /// Contém informações do usuário.
    /// </summary>
    public interface IUser : IListedPeople
    {
        /// <summary>
        /// Nome do usuário.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Email do usuário.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Senha do usuário.
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// Telefone/celular do usuário.
        /// </summary>
        string PhoneNumber { get; set; }
    }
}