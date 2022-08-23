

using AutoMapper;
using IBLV.Application.Dtos.Endereco;
using IBLV.Application.Dtos.Membro;
using IBLV.Application.Dtos.Usuarios;
using IBVL.Domain.Core.Enums;
using IBVL.Domain.Entities;

namespace IBLV.Web.Api.Mappings
{
    public class DomainToDtoMappingProfile : Profile
    {

        public DomainToDtoMappingProfile()
        {

            CreateMap<Usuario, UsuarioCreateDto>();

            CreateMap<Membro, MembroCreateDto>();

        }
    }

    public class DtoToDomainProfile : Profile
    {
        public DtoToDomainProfile()
        {
            CreateMap<UsuarioCreateDto, Usuario>()
               .AfterMap((dto, entity) =>
               {
                   entity.Id = Guid.NewGuid();
                   entity.DataCriacao = DateTime.Now;
               });

            CreateMap<MembroCreateDto, Membro>()
                .ConstructUsing(m => 
                new Membro(m.Nome, m.DateDeNascimmento, 
                                                Enum.Parse<EstadoCivil>(m.EstadoCivil.ToString()),
                                                m.TelefoneResidencia, m.TelefoneCelular, m.TelefoneContato,
                                                new Endereco(m.Endereco.Logradouro, m.Endereco.Complemento,m.Endereco.Numero,
                                                m.Endereco.Cep, m.Endereco.Bairro, m.Endereco.Cidade, m.Endereco.Estado, m.Id)));
        }
    }

}
