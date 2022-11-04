using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TodoApp.Models;

namespace TodoApp.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public TodoListViewModel()
        {
            AddTaskCommand = new(AddTask,true);
            DeleteTaskCommand = new(RemoveTask, true);
            SeletedTaskToRemove = new();
        }

        private void AddTask()
        {
            AllTasks.Add(new TodoList
            {
                Task = Task

            });
            Task = "";
        }

        private void RemoveTask()
        {
            allTasks.Remove(SeletedTaskToRemove);
        }

        private string task;
        public string Task { get => task; set => SetProperty(ref task, value); }

        private ObservableCollection<TodoList> allTasks = new();

        public ObservableCollection<TodoList> AllTasks { get => allTasks; set => SetProperty(ref allTasks, value); }

        public ActionCommand AddTaskCommand { get; set; }
       
        public ActionCommand DeleteTaskCommand { get; private set; }
        
        public  TodoList SeletedTaskToRemove { get; set; }
    }
}
