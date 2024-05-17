using AutoMapper;
using Core.Entities.Information;
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
        public async Task<List<Info>>? GetInfoAsync(string subName)
        {
            var infos = await _infoRepository.GetListBySpec(new InfoSpecification.GetAll(subName));
            return _mapper.Map<List<Info>>(infos);
        }
    }
}
