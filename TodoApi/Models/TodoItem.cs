using Microsoft.CodeAnalysis.CSharp.Syntax;
using TodoApi.DTOs;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long ID {get;set;}
        public string? Name {get; set;}
        public bool IsComplete {get; set;}
        public string? HiddenInformation {get;set;}

        public TodoItemDTO ItemToDto()
        {
            return new TodoItemDTO{
                ID = this.ID,
                IsComplete = this.IsComplete,
                Name = this.Name
            };
        }

        public void ItemFromDto(TodoItemDTO itemDto)
        {
            this.ID = itemDto.ID;
            
        }
    }

    
}