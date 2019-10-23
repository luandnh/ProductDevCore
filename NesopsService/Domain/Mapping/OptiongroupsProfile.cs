using System;
using AutoMapper;
using NesopsService.Data.Entities;
using NesopsService.Domain.Models;

namespace NesopsService.Domain.Mapping
{
    public partial class OptiongroupsProfile
        : AutoMapper.Profile
    {
        public OptiongroupsProfile()
        {
            CreateMap<NesopsService.Data.Entities.Optiongroups, NesopsService.Domain.Models.OptiongroupsReadModel>();
            CreateMap<NesopsService.Domain.Models.OptiongroupsCreateModel, NesopsService.Data.Entities.Optiongroups>();
            CreateMap<NesopsService.Data.Entities.Optiongroups, NesopsService.Domain.Models.OptiongroupsUpdateModel>();
            CreateMap<NesopsService.Domain.Models.OptiongroupsUpdateModel, NesopsService.Data.Entities.Optiongroups>();
        }

    }
}
