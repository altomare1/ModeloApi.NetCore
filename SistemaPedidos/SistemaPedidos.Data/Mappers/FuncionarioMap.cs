using Dapper.FluentMap.Dommel.Mapping;
using SistemaPedidos.Domain.Entities;

namespace SistemaPedidos.Data.Mappers
{
    public class FuncionarioMap : DommelEntityMap<Funcionario>
    {
        public FuncionarioMap()
        {
            ToTable("Funcionario");
            Map(x => x.FuncionarioID).ToColumn("FuncionarioID").IsKey();
            Map(x => x.Codigo).ToColumn("Codigo");
            Map(x => x.Nome).ToColumn("Nome");
            Map(x => x.Apelido).ToColumn("Apelido");
            Map(x => x.Cpf).ToColumn("Cpf");
            Map(x => x.Telefone).ToColumn("Telefone");
            Map(x => x.Endereco).ToColumn("Endereco");
            Map(x => x.Numero).ToColumn("Numero");
            Map(x => x.Complemento).ToColumn("Complemento");
            Map(x => x.Bairro).ToColumn("Bairro");
            Map(x => x.Cidade).ToColumn("Cidade");
            Map(x => x.Estado).ToColumn("Estado");
            Map(x => x.Cep).ToColumn("Cep");
            Map(x => x.Email).ToColumn("Email");
            Map(x => x.Observacao).ToColumn("Observacao");
            Map(x => x.Status).ToColumn("Status");
            Map(x => x.UsuarioInclusao).ToColumn("UsuarioInclusao");
            Map(x => x.DataInclusao).ToColumn("DataInclusao");
            Map(x => x.UsuarioAltracao).ToColumn("UsuarioAltracao");
            Map(x => x.DataAlteracao).ToColumn("DataAlteracao");
            //Map(x => x.Team).Ignore();
        }
    }
}
