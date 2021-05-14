using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DAL;
using DTO;

namespace BLL
{
    public class ProdutoBLL
    {
        private string query;
        private Conexao conexao = new Conexao();
        public void Criar(ProdutoDTO objetoDTO)
        {
            query = $"insert into produtos(nome, valor, descricao, fornecedoId, categoriaId, quantidadeEstoque, clientes_id, fornecedores_id, categoria_id) values ('{objetoDTO.Nome}','{objetoDTO.Valor}','{objetoDTO.Descricao}','{objetoDTO.FornecedorId}','{objetoDTO.CateoriaId}','{objetoDTO.QuantidadeEstoque}','{objetoDTO.ClienteId}','{objetoDTO.Fornecedores_Id}','{objetoDTO.CateoriaId}');";
            conexao.executarComandos(query);
        }

        public void Alterar(ProdutoDTO objetoDTO)
        {
            query = $"update  produtos set nome = '{objetoDTO.Nome}', valor = '{objetoDTO.Valor}',descricao = '{objetoDTO.Descricao}',fornecedoId = '{objetoDTO.FornecedorId}',categoriaId = '{objetoDTO.CateoriaId}',quantidadeEstoque ='{objetoDTO.QuantidadeEstoque}',clientes_id = '{objetoDTO.ClienteId}',fornecedores_id = '{objetoDTO.Fornecedores_Id}',categoria_id ='{objetoDTO.CateoriaId}' where id = '{objetoDTO.Id}';";
            conexao.executarComandos(query);
        }

        public void Delete(ProdutoDTO objetoDTO)
        {
            query = $"delete from produtos where id = '{objetoDTO.Id}';";
            conexao.executarComandos(query);
        }

        public DataTable Selecionar()
        {
            query = "select * from produtos;";
            return conexao.consultarTabelas(query);
        }
    }
}