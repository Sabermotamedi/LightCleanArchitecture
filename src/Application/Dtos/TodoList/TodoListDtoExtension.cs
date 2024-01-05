using LightCleanArchitecture.Application.Common.Mappings;
using LightCleanArchitecture.Domain.Entities;

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

        public static List<TodoListDto> ToDto(this List<TodoList> todoLists)
        {
            return _mapper.Map<List<TodoListDto>>(todoLists);
        }
    }
}
