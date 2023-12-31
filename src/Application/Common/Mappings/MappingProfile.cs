﻿using LightCleanArchitecture.Application.Dtos;
using LightCleanArchitecture.Domain.Entities;

namespace LightCleanArchitecture.Application.Common.Mappings;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<TodoItem, TodoItemDto>()
            .ReverseMap();

        CreateMap<TodoList, TodoListDto>()
            .ReverseMap();
    }
}
