using AutoMapper;
using ECommerce_User.Contracts;
using ECommerce_User.Entities.Dto;
using ECommerce_User.Entities.Model;
using ECommerce_User.Helper;
using ECommerce_User.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce_User.Services
{
    public class MetaDataServices : IMetaDataServices
    {

        private readonly IMetaDataRepositories fileRepository;
        private readonly IMapper mapper;
        public MetaDataServices(IMetaDataRepositories _fileRepository, IMapper _mapper)
        {
            fileRepository = _fileRepository ?? throw new ArgumentNullException(nameof(_fileRepository));
            mapper = _mapper ?? throw new ArgumentNullException(nameof(_mapper));
       
        }
        ///<summary>
        /// find the key from the metadata 
        ///</summary>
        ///<param name="key"></param> 
        public MetaDataDto FetchMetaData(string search)
        {
            RefSet RefSetFromRepo = fileRepository.getRefSet(search);
            if (RefSetFromRepo == null) {
                return null;
            }
            IEnumerable<Guid> ResultFromRepo = fileRepository.getRefTermGroup(RefSetFromRepo.Id);
            IEnumerable<RefTerm> RefTermFromRepo = fileRepository.getRefTerm(ResultFromRepo);
            IEnumerable<RefTermDto> value = mapper.Map<IEnumerable<RefTermDto>>(RefTermFromRepo);
            MetaDataDto meta = new MetaDataDto();
            meta.Description = RefSetFromRepo.Description;
            meta.Id = RefSetFromRepo.Id;
            meta.Types = RefSetFromRepo.Key;
            meta.RefTerms = value.ToList();
            return meta;
        }
        ///<summary>
        ///Return Error in the format
        ///</summary>
        ///<param name="description"></param>
        ///<param name="statuscode"></param>
        public ErrorDto ErrorToReturn(string statuscode, string description)
        {
            ErrorManage errorManage = new ErrorManage();
            return errorManage.ReturningError(statuscode, description);
        }
    }
}
