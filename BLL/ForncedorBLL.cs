using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DAL;
using DTO;

namespace BLL
{
    public class ForncedorBLL
    {


        private string query;
        private Conexao conexao = new Conexao();
        public void Criar(FornecedorDTO objetoDTO)
        {
            query = $"insert into fornecedores(nome, cnpj, email, telefone, nomeRepresentante, telefoneRepresentante) values ('{objetoDTO.Nome}','{objetoDTO.Cnpj}','{objetoDTO.Email}','{objetoDTO.Telefone}','{objetoDTO.NomeResponsavel}','{objetoDTO.TelefoneResponsavel}');";
            conexao.executarComandos(query);
        }

        public void Alterar(FornecedorDTO objetoDTO)
        {
            query = $"update  fornecedores set nome = '{objetoDTO.Nome}', cnpj = '{objetoDTO.Cnpj}',email = '{objetoDTO.Email}', telefone = '{objetoDTO.Telefone}', nomeRepresentante = '{objetoDTO.NomeResponsavel}',telefoneRepresentante = '{objetoDTO.TelefoneResponsavel}' where id = '{objetoDTO.Id}';";
            conexao.executarComandos(query);
        }

        public void Delete(FornecedorDTO objetoDTO)
        {
            query = $"delete from fornecedores where id = '{objetoDTO.Id}';";
            conexao.executarComandos(query);
        }

        public DataTable Selecionar()
        {
            query = "select * from fornecedores;";
            return conexao.consultarTabelas(query);
        }
    }
}