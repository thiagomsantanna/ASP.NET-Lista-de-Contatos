using System;
using System.Collections.Generic;

namespace PhoneBook_DrinkCompany.Models
{
    public partial class Clientes
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cpnj { get; set; }
        public string Email { get; set; }
        public string TelefoneCelular { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneComercial { get; set; }
        public string Endereco { get; set; }
    }
}
