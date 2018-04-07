using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;
using System.ComponentModel;
using System.Runtime.CompilerServices;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{

    public class TruckInfo {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }


    }
    
    public class TruckData : INotifyPropertyChanged {

        public TruckInfo[] Trucks { get; set; }
        private TruckInfo _SelectedTruck;

        public event PropertyChangedEventHandler PropertyChanged;

        public TruckInfo SelectedTruck {

            get { return _SelectedTruck; }
            set {
                if (_SelectedTruck == value)
                    return;
                _SelectedTruck = value;

                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("SelectedTruck"));

            }
        }



    }
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var info = new TruckInfo()
            {
                ID = "1",
                Name = "Name lala",
                Style = "Mechico"
            };

            var infos = new TruckInfo[] {

                new TruckInfo(){
                    ID = "4",
                    Name = "lala4",
                    Style = "lolo4"
                },

                new TruckInfo()
                {
                    ID = "5",
                    Name = "lala5",
                    Style = "lolo5"
                },

                new TruckInfo()
                {
                    ID ="6",
                    Name = "lala6",
                    Style = "lolo6"
                }
            };

            //DataContext = infos;

            var data = new TruckData()
            {
                Trucks = infos,
            };

            DataContext = data;
        }

        
    }
}
