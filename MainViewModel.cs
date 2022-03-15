using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM.ViewModels.Commands;
using DataAccessLayer.Models;


namespace MVVM.ViewModels.Commands.MainView  // huvud
{
    public class MainViewModel : BaseViewModel // ifall man följer exempel från workshop kommer det att skapa två st knappar en med edit och en med lägga till
    {

        /*  Här är bara testkod från workshopen!
         * 
         * private User selectedDog;

        public ObservableCollection<Dog> Dogs { get; set; } = new ObservableCollection<Dog>();

        public Dog SelectedDog { get => selectedDog; set { selectedDog = value; OnPropertyChanged(); } }

        public ICommand OpenNewDogViewCommand { get; set; }

        public ICommand OpenEditDogViewCommand { get; set; }

        public MainViewModel()
        {
            OpenNewDogViewCommand = new OpenAddDogViewCommand(this);
            OpenEditDogViewCommand = new OpenEditDogViewCommand(this);
        }

        internal void RefreshDogs()
        {
            Dogs.Clear();

            IEnumerable<Dog> dogs = App.DataManager.GetAll();

            foreach (Dog dog in dogs)
            {
                Dogs.Add(dog);

            }   */ 
        }

    }

}
