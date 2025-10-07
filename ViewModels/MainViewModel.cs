using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
            //ToDo todo = ToDos[ToDos.IndexOf(ToDos.Where(x => x.ID == id).First())];
            //todo.Done = todo.Done;
            //Trace.WriteLine(todo.Done);
        }
        [RelayCommand]
        private void AddNewToDo()
        {
            if (newToDo.Title != "")
                ToDos.Add(newToDo);
            NewToDo = new ToDo();
        }
        [RelayCommand]
        private void DeleteDoneToDos()
        {
            ObservableCollection<ToDo>  newArray = new ObservableCollection<ToDo>(ToDos.Where(x => !x.Done));
            if(newArray.Count > 0)
            {
                ToDos = newArray;
            }
            else
            {
                ToDos = new();
            }
        }
    }
}
