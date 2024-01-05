using AutoMapper;
using FluentAssertions;
using LightCleanArchitecture.Application.Common.Interfaces;
using LightCleanArchitecture.Application.Dtos;
using LightCleanArchitecture.Domain.Entities;
using LightCleanArchitecture.Domain.Enums;
using System.Reflection;

namespace LightCleanArchitecture.Application.UnitTests.Mappings
{
    public class TodoItemMappingTests
    {
        private readonly IConfigurationProvider _configuration;
        private readonly IMapper _mapper;

        public TodoItemMappingTests()
        {
            _configuration = new MapperConfiguration(config =>
           config.AddMaps(Assembly.GetAssembly(typeof(IApplicationDbContext))));

            _mapper = _configuration.CreateMapper();
        }

        [Fact]
        public void Should_Map_TodoItem_To_TodoItemDto()
        {
            // Arrange
            var todoItem = new TodoItem
            {
                Id = 1,
                ListId = 2,
                Title = "Sample Todo",
                Note = "This is a test",
                Priority = PriorityLevel.High,
                Reminder = DateTime.Now.AddDays(1),
                Done = false,
                Created = DateTimeOffset.Now,
                CreatedBy = "TestUser",
                LastModified = DateTimeOffset.Now,
                LastModifiedBy = "TestUser",
                List = new TodoList() // You might need to initialize List property as well
            };

            // Act
            var todoItemDto = _mapper.Map<TodoItemDto>(todoItem);

            // Assert
            todoItemDto.Should().NotBeNull();
            todoItemDto.Id.Should().Be(todoItem.Id);
            todoItemDto.ListId.Should().Be(todoItem.ListId);
            todoItemDto.Title.Should().Be(todoItem.Title);
            todoItemDto.Note.Should().Be(todoItem.Note);
            todoItemDto.Priority.Should().Be(todoItem.Priority);
            todoItemDto.Reminder.Should().Be(todoItem.Reminder);
            todoItemDto.Done.Should().Be(todoItem.Done);
            todoItemDto.Created.Should().Be(todoItem.Created);
            todoItemDto.CreatedBy.Should().Be(todoItem.CreatedBy);
            todoItemDto.LastModified.Should().Be(todoItem.LastModified);
            todoItemDto.LastModifiedBy.Should().Be(todoItem.LastModifiedBy);
        }


        [Fact]
        public void Should_Map_TodoItemDto_To_TodoItem()
        {
            // Arrange
            var todoItemDto = new TodoItemDto
            {
                Id = 1,
                ListId = 2,
                Title = "Sample Todo",
                Note = "This is a test",
                Priority = PriorityLevel.High,
                Reminder = DateTime.Now.AddDays(1),
                Done = false,
                Created = DateTimeOffset.Now,
                CreatedBy = "TestUser",
                LastModified = DateTimeOffset.Now,
                LastModifiedBy = "TestUser"
            };

            // Act
            var todoItem = _mapper.Map<TodoItem>(todoItemDto);

            // Assert
            todoItem.Should().NotBeNull();
            todoItem.Id.Should().Be(todoItemDto.Id);
            todoItem.ListId.Should().Be(todoItemDto.ListId);
            todoItem.Title.Should().Be(todoItemDto.Title);
            todoItem.Note.Should().Be(todoItemDto.Note);
            todoItem.Priority.Should().Be(todoItemDto.Priority);
            todoItem.Reminder.Should().Be(todoItemDto.Reminder);
            todoItem.Done.Should().Be(todoItemDto.Done);
            todoItem.Created.Should().Be(todoItemDto.Created);
            todoItem.CreatedBy.Should().Be(todoItemDto.CreatedBy);
            todoItem.LastModified.Should().Be(todoItemDto.LastModified);
            todoItem.LastModifiedBy.Should().Be(todoItemDto.LastModifiedBy);
        }
    }
}
