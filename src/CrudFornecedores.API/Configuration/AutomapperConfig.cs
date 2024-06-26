﻿
using AutoMapper;
using CrudFornecedores.API.DTO;
using CrudFornecedores.Domain.Models;

namespace CrudFornecedores.API.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Fornecedor, FornecedorDTO>().ReverseMap();
            CreateMap<Endereco, EnderecoDTO>().ReverseMap();
            CreateMap<ProdutoDTO, Produto>();

            CreateMap<Produto, ProdutoDTO>()
                .ForMember(dest => dest.NomeFornecedor, opt => opt.MapFrom(src => src.Fornecedor.Nome));
        }
    }
}