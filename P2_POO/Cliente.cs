using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_POO
{
    public class Cliente
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public string Email { get; private set; }
        public string CPF { get; private set; }


        public Cliente(string nome, string email, string cpf)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome do cliente invalido");

            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("E-mail do cliente invalido");

            if (string.IsNullOrEmpty(cpf))
                throw new ArgumentException("CPF do cliente ivalido");

            Nome = nome;
            Email = email;
            CPF = cpf;
            Id = Guid.NewGuid();
            
        }
    }
}
