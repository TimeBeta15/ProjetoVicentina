using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;


using Microsoft.AspNetCore.Mvc;
using Domain.Entity;
using domain.Entity;
using domain.Model;

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
        }
    }
}