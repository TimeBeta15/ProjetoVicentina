using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using Domain.Model;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Domain.Entity;

namespace Infra.Data.Mapping
{
    
    public class AutoMapperProf : Profile
    {
        public AutoMapperProf()
        {
            CreateMap<Produto, ProdutoModel>().ReverseMap();
        }
    }
}