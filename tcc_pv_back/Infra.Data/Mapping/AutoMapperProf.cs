using AutoMapper;
using Domain.Entity;
using Domain.Model;

namespace Infra.Data.Mapping
{

    public class AutoMapperProf : Profile
    {

        public AutoMapperProf()
        {
            CreateMap<Produto, ProdutoModel>().ReverseMap();
            CreateMap<entradaProduto, entradaProdutoModel>().ReverseMap();
            CreateMap<saidaProduto, saidaProdutoModel>().ReverseMap();
            CreateMap<tabelaCaixa, tabelaCaixaModel>().ReverseMap();
            CreateMap<tabelaContaCapital, tabelaContaCapitalModel>().ReverseMap();
            CreateMap<tabelaContaCorrente, tabelaContaCorrenteModel>().ReverseMap();
            CreateMap<tabelaEmendaImpositiva, tabelaEmendaImpositivaModel>().ReverseMap();
            CreateMap<tabelaEmendaParlamentar, tabelaEmendaParlamentarModel>().ReverseMap();
            CreateMap<tabelaVerbaEstadual, tabelaVerbaEstadualModel>().ReverseMap();
            CreateMap<tabelaVerbaMunicipal, tabelaVerbaMunicipalModel>().ReverseMap();
            CreateMap<tabelaResidente, tabelaResidenteModel>().ReverseMap();
            CreateMap<tabelaQuarto, tabelaQuartoModel>().ReverseMap();
            CreateMap<tabelaDoador, tabelaDoadorModel>().ReverseMap();
            CreateMap<tabelaFornecedor, tabelaFornecedorModel>().ReverseMap();
        }
    }
}
