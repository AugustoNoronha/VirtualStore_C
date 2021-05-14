using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;
using DAL;
using System.EnterpriseServices;
using System.Data;

namespace BLL
{
    public class CategoriaBLL
    {
        private string query;
        private Conexao conexao = new Conexao();
        public void Criar(CategoriaDTO objetoDTO)
        {
            query = $"insert into categoria(nome, descricao) values ('{objetoDTO.Nome}','{objetoDTO.Descricao}');";
            conexao.executarComandos(query);
        }
        
        public void Alterar (CategoriaDTO objetoDTO)
        {
            query = $"update  categoria set nome = '{objetoDTO.Nome}', descricao = '{objetoDTO.Descricao}' where id = '{objetoDTO.Id}';";
            conexao.executarComandos(query);
        }

        public void Delete(CategoriaDTO objetoDTO)
        {
            query = $"delete from categoria where id = '{objetoDTO.Id}';";
            conexao.executarComandos(query);
        }

        public DataTable Selecionar()
        {
            query = "select * from categoria;";
         return conexao.consultarTabelas(query);
        }
    }
}