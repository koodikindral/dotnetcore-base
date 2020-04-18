using AutoMapper;

namespace BLL.Mappers
{
    public class BaseBLLMapper<TInObject, TOutObject> : IBaseBLLMapper<TInObject, TOutObject>
        where TInObject : class, new()
        where TOutObject : class, new()

    {
        private readonly IMapper _mapper;

        public BaseBLLMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<TInObject, TOutObject>();
                config.CreateMap<TOutObject, TInObject>();
            }).CreateMapper();
        }

        public TOutObj Map<TInObj, TOutObj>(TInObj inObject)
            where TInObj : class, new()
            where TOutObj : class, new()
        {
            return _mapper.Map<TInObj, TOutObj>(inObject);
        }
    }
}