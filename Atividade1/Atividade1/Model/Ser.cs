using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1.Model
{
    public class Ser
    {

        private string nome;
        private DateTime nascimento;
        private Sexo sexo;
        private Raça raça;

        public Ser()
        {

        }

        public Ser(string nome, DateTime nascimento, Sexo sexo, Raça raça)
        {
            this.nome = nome;
            this.nascimento = nascimento;
            this.sexo = sexo;
            this.raça = raça;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }

        public Sexo Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public Raça Raça
        {
            get { return raça; }
            set { raça = value; }
        }
    }
}
