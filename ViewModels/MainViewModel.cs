using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<ToDo> toDos = new ObservableCollection<ToDo>();

        [ObservableProperty]
        public ToDo newToDo = new ToDo();

        [RelayCommand]
        private void ToggleDone(int id)
        {
            ToDo todo = ToDos[ToDos.IndexOf(ToDos.Where(x => x.ID == id).First())];
            todo.Done = !todo.Done;
        }
        [RelayCommand]
        private void AddNewToDo()
        {
            if (newToDo.Title != "")
                ToDos.Add(newToDo);
            Console.WriteLine(NewToDo.Title);
            NewToDo = new ToDo();
        }
    }
}
