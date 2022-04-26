using CleanArchitecture.Application.TodoLists.Queries.ExportTodos;

namespace CleanArchitecture.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    // pattern -> adapter
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
