namespace TodoApi.DTOs
{
    public class TodoItemDTO
    {
        public long ID {get;set;}
        public string? Name {get; set;}
        public bool IsComplete {get; set;}       
    }
}