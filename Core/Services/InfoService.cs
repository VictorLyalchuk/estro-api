using AutoMapper;
using Core.DTOs.Product;
using Core.Entities.Product;
using Core.Interfaces;
using Core.Specification;

namespace Core.Services
{
    public class InfoService : IInfoService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Info> _infoRepository;
        public InfoService(IMapper mapper, IRepository<Info> infoRepository)
        {
            _mapper = mapper;
            _infoRepository = infoRepository;
        }
        public async Task<List<InfoDTO>>? GetInfoAsync()
        {
            var infos = await _infoRepository.GetListBySpec(new InfoSpecification.GetAll());
            return _mapper.Map<List<InfoDTO>>(infos);
        }
    }
}
