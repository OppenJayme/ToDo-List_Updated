using TodoListApp1.Models;

namespace TodoListApp1.Page;

public partial class EditTaskPage : ContentPage
{
    
    public ToDoItem Task { get; set; }

    public EditTaskPage(ToDoItem task)
    {
        InitializeComponent();
        Task = task; // Store the task object for later use
        BindingContext = this; // Bind the task to the page's UI
    }

    private void OnUpdateClicked(object? sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void OnMarkFinishedClicked(object? sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void OnDeleteClicked(object? sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void OnBackClicked(object? sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}