using LightCleanArchitecture.Domain.Entities;
using RMgmt.Application.Common.Mappings;

namespace LightCleanArchitecture.Application.Dtos
{
    public static class TodoListDtoExtension
    {
        private static readonly IMapper _mapper;

        static TodoListDtoExtension()
        {
            var mapperConfiguration =
          new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());

            _mapper = mapperConfiguration.CreateMapper();
        }

        public static TodoList ToModel(this TodoListDto bedDto)
        {
            return _mapper.Map<TodoList>(bedDto);
        }

        public static TodoListDto ToDto(this TodoList bed)
        {
            return _mapper.Map<TodoListDto>(bed);
        }
    }
}
