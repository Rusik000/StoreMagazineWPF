using StoreMagazineWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StoreMagazineWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public List<Product> Products { get; set; } = new List<Product>
    {
        new Product
        {
            ID=1,
            Name="Cola",
            Magazine="Coca-Cola",
            Price=1.50
        },
        new Product
        {
            ID=2,
            Name="Quzu Bel",
            Magazine="Bravo",
            Price=14.50
        },
        new Product
        {
            ID=3,
            Name="Quzu Bel Sumuklu",
            Magazine="Neptun",
            Price=13.49
        },
        new Product
        {
            ID=4,
            Name="Cola",
            Magazine="Coca-Cola",
            Price=1.50
        },
        new Product
        {
            ID=5,
            Name="Friskeis it quzu eti ile 85kg",
            Magazine="Bravo",
            Price=0.60
        },
        new Product
        {
            ID=6,
            Name="Fen Mr-222",
            Magazine="Bravo",
            Price=39
        },

        new Product
        {
            ID=7,
            Name="Cola",
            Magazine="Coca-Cola",
            Price=1.50
        },
        new Product
        {
            ID=8,
            Name="Kismis Sari",
            Magazine="Bravo",
            Price=6.99
        },
        new Product
        {
            ID=9,
            Name="Los Boldos Traditional",
            Magazine="Bravo",
            Price=25.99
        },

    };
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
