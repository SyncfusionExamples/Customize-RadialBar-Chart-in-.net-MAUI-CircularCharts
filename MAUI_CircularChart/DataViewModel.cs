using System.Collections.ObjectModel;

namespace MAUI_CircularChart
{
    public class ViewModel
    {
        public ObservableCollection<DataModel> Products { get; set; }

        public ObservableCollection<Brush> CustomPaletteBrushes { get; set; }

        public ViewModel() 
        {
            Products = new ObservableCollection<DataModel>
            {
                new DataModel { Name="Vehicle", Value=62.70},
                new DataModel { Name="Education", Value=29.50},
                new DataModel { Name="Personal", Value=45.60},
                new DataModel { Name="Home", Value=85.20},
              
            };

            CustomPaletteBrushes = new ObservableCollection<Brush>
            {
                new SolidColorBrush(Color.FromRgb(255,0,0)),
                 new SolidColorBrush(Color.FromRgb(0,0,255)),
                 new SolidColorBrush(Color.FromRgb(60,179,113)),
                 new SolidColorBrush(Color.FromRgb(255,165,0))
            };

        }
    }
}
