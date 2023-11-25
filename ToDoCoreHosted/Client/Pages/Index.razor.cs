using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using ToDoCoreHosted.Shared;

namespace ToDoCoreHosted.Client.Pages
{
    public partial class Index
    {
        [Inject] public HttpClient Http { get; set; }
        private IList<TodoItem> tasks;
        private string error;
        private string newTodo;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                string requestUri = "TodoItems"; //ovo je naziv kontrolera
                //pozivamo metodu na kontroleru za dohvat todo-ova
                tasks = await Http.GetFromJsonAsync<IList<TodoItem>>(requestUri);
            }
            catch (Exception)
            {
                error = "Error Encountered";
            }
        }
        private async Task CheckboxChecked(TodoItem task)
        {
            task.IsDone = !task.IsDone;
            string requestUri = $"TodoItems/{task.Id}";
            //pozivamo metodu za ažuriranje 
            var response = await  Http.PutAsJsonAsync<TodoItem>(requestUri, task);
            if (!response.IsSuccessStatusCode)
            {
                error = response.ReasonPhrase;
            };
        }

        private async Task DeleteTask(TodoItem task)
        {
            tasks.Remove(task);
            string requestUri = $"TodoItems/{task.Id}";
            var response = await Http.DeleteAsync(requestUri);
            if (!response.IsSuccessStatusCode)
            {
                error = response.ReasonPhrase;
            }
        }

        private async Task AddTask()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                TodoItem newTaskItem = new TodoItem
                {
                    Title = newTodo,
                    IsDone = false
                };
                tasks.Add(newTaskItem);
                string requestUri = "TodoItems";
                var response = await Http.PostAsJsonAsync(requestUri,
                newTaskItem);
                if (response.IsSuccessStatusCode)
                {
                    newTodo = string.Empty;
                }
                else
                {
                    error = response.ReasonPhrase;
                }
            }
        }

    }
}
