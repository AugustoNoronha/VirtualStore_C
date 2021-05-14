using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DAL;
using DTO;

namespace BLL
{
    public class ClienteBLL
    {
        private string query;
        private Conexao conexao = new Conexao();
        public void Criar(ClienteDTO objetoDTO)
        {
            query = $"insert into clientes(id, nome, cpf, endereco, telefone, email, senha) values (null,'{objetoDTO.Nome}','{objetoDTO.Cpf}','{objetoDTO.Endereco}','{objetoDTO.Telefone}','{objetoDTO.Email}','{objetoDTO.Senha}');";
            conexao.executarComandos(query);
        }

        public void Alterar(ClienteDTO objetoDTO)
        {
            query = $"update  clientes set nome = '{objetoDTO.Nome}', cpf = '{objetoDTO.Cpf}',endereco = '{objetoDTO.Endereco}',telefone = '{objetoDTO.Telefone}',email = '{objetoDTO.Email}' where id = '{objetoDTO.Id}';";
            conexao.executarComandos(query);
        }

        public void Delete(ClienteDTO objetoDTO)
        {
            query = $"delete from clientes where id = '{objetoDTO.Id}';";
            conexao.executarComandos(query);
        }

        public DataTable Selecionar()
        {
            query = "select * from clientes;";
            return conexao.consultarTabelas(query);
        }
    }
}