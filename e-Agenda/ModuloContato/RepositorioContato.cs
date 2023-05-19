using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloContato
{
    public class RepositorioContato
    {
        public List<Contato> contatos = new List<Contato>();
        private static int contador;

        public RepositorioContato()
        {
            AddContatoRandom();
        }

        private void AddContatoRandom()
        {
            Contato contato = new("nome1", "1010", "contato@gmail.com", "desempregado", "casa da mae");
            contatos.Add(contato);
            contato = new("nome2", "1020", "contato@gmail.com", "desempregado", "casa da tia");
            contatos.Add(contato);
            contato = new("nome3", "1030", "contato@gmail.com", "desempregado", "casa da mae do outro");
            contatos.Add(contato);
        }

        public void Inserir(Contato contato)
        {
            contador++;
            contato.id = contador;
            contatos.Add(contato);
        }

        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public void Editar(Contato contato)
        {
            Contato contatoSelecionado = SelecionarPorId(contato.id);

            contatoSelecionado.nome = contato.nome;
            contatoSelecionado.telefone = contato.telefone;
            contatoSelecionado.email = contato.email;
            contatoSelecionado.cargo = contato.cargo;
            contatoSelecionado.empresa = contato.empresa;
        }

        private Contato SelecionarPorId(int id)
        {
            return contatos.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);
        }
    }
}
