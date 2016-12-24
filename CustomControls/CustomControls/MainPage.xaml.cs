using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomControls
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnAddTask(object sender, EventArgs args)
        {
            DisplayAlert("Add Task", "Task added!", "OK");
        }
    }
}
