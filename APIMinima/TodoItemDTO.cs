namespace APIMinima
{
    public class TodoItemDTO
    {

        public int id { get; set; }

        public string? Name { get; set; }

        public bool IsComplete { get; set; }

        public TodoItemDTO() { }

        public TodoItemDTO(Todo todoItem) =>
            (id, Name, IsComplete) = (todoItem.id, todoItem.Name, todoItem.IsComplete);

    }
}
