using AutoMapper;
using FluentAssertions;
using LightCleanArchitecture.Application.Common.Interfaces;
using LightCleanArchitecture.Application.Dtos;
using LightCleanArchitecture.Domain.Entities;
using LightCleanArchitecture.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LightCleanArchitecture.Application.UnitTests.Mappings
{
    public class TodoListMappingTests
    {
        private readonly IConfigurationProvider _configuration;
        private readonly IMapper _mapper;

        public TodoListMappingTests()
        {
            _configuration = new MapperConfiguration(config =>
           config.AddMaps(Assembly.GetAssembly(typeof(IApplicationDbContext))));

            _mapper = _configuration.CreateMapper();
        }

        [Fact]
        public void ShouldMapTodoListToTodoListDto()
        {
            // Arrange
            var todoList = new TodoList
            {
                Id = 1,
                Title = "Sample Todo List",
                Colour = Colour.Blue,
                Items = new List<TodoItem>
                {
                    new TodoItem { Id = 1, Title = "Item 1" },
                    new TodoItem { Id = 2, Title = "Item 2" }
                },
                Created = DateTimeOffset.Now,
                CreatedBy = "TestUser",
                LastModified = DateTimeOffset.Now,
                LastModifiedBy = "TestUser"
            };

            // Act
            var todoListDto = _mapper.Map<TodoListDto>(todoList);

            // Assert
            todoListDto.Should().NotBeNull();
            todoListDto.Id.Should().Be(todoList.Id);
            todoListDto.Title.Should().Be(todoList.Title);
            todoListDto.Colour.Should().Be(todoList.Colour);
            todoListDto.Items.Should().HaveCount(todoList.Items.Count);
            todoListDto.Created.Should().Be(todoList.Created);
            todoListDto.CreatedBy.Should().Be(todoList.CreatedBy);
            todoListDto.LastModified.Should().Be(todoList.LastModified);
            todoListDto.LastModifiedBy.Should().Be(todoList.LastModifiedBy);
        }

        [Fact]
        public void ShouldMapTodoListDtoToTodoList()
        {
            // Arrange
            var todoListDto = new TodoListDto
            {
                Id = 1,
                Title = "Sample Todo List",
                Colour = Colour.Blue,
                Items = new List<TodoItemDto>
                {
                    new TodoItemDto { Id = 1, Title = "Item 1" },
                    new TodoItemDto { Id = 2, Title = "Item 2" }
                },
                Created = DateTimeOffset.Now,
                CreatedBy = "TestUser",
                LastModified = DateTimeOffset.Now,
                LastModifiedBy = "TestUser"
            };

            // Act
            var todoList = _mapper.Map<TodoList>(todoListDto);

            // Assert
            todoList.Should().NotBeNull();
            todoList.Id.Should().Be(todoListDto.Id);
            todoList.Title.Should().Be(todoListDto.Title);
            todoList.Colour.Should().Be(todoListDto.Colour);
            todoList.Items.Should().HaveCount(todoListDto.Items.Count);
            todoList.Created.Should().Be(todoListDto.Created);
            todoList.CreatedBy.Should().Be(todoListDto.CreatedBy);
            todoList.LastModified.Should().Be(todoListDto.LastModified);
            todoList.LastModifiedBy.Should().Be(todoListDto.LastModifiedBy);
        }

    }
}
