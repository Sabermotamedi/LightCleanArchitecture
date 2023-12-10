using Domain.Entities;
using RMgmt.Application.Common.Mappings;

namespace Application.Dtos
{
    public static class TodoItemDtoExtension
    {
        private static readonly IMapper _mapper;

        static TodoItemDtoExtension()
        {
            var mapperConfiguration =
          new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());

            _mapper = mapperConfiguration.CreateMapper();
        }

        public static TodoItem ToModel(this TodoItemDto bedDto)
        {
            return _mapper.Map<TodoItem>(bedDto);
        }

        public static TodoItemDto ToDto(this TodoItem bed)
        {
            return _mapper.Map<TodoItemDto>(bed);
        }
    }
}
