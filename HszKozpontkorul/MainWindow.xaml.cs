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

namespace HszKozpontkorul
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_beker_Click(object sender, RoutedEventArgs e)
        {
            double X1 = double.Parse(Txb_X1.Text);
            double Y1 = double.Parse(Txb_Y1.Text);
            double X2 = double.Parse(Txb_X2.Text);
            double Y2 = double.Parse(Txb_Y2.Text);
            double X3 = double.Parse(Txb_X3.Text);
            double Y3 = double.Parse(Txb_Y3.Text);
            double X4 = double.Parse(Txb_X4.Text);
            double Y4 = double.Parse(Txb_Y4.Text);
            double Szog = double.Parse(Txb_szog.Text);

            grid_panel.VerticalAlignment = VerticalAlignment.Center;
            grid_panel.HorizontalAlignment = HorizontalAlignment.Center;
            

            grid_panel.RenderTransformOrigin = new Point(0.5, 0.5);

            TransformGroup transform = new TransformGroup();
            RotateTransform rotate = new RotateTransform(Szog);

            transform.Children.Add(rotate);

            grid_panel.RenderTransform = transform;
           
            
            

            Polyline pl = new Polyline();

            //pl.Stroke = Brushes.Black;
            pl.StrokeThickness = 2;
            pl.Fill = Brushes.Black;

            Point elso = new Point(X1, Y1);
            Point masodik = new Point(X2, Y2);
            Point harmadik = new Point(X3, Y3);
            Point negyedik = new Point(X4, Y4);



            PointCollection haromszogpontok = new PointCollection();
            haromszogpontok.Add(elso);
            haromszogpontok.Add(masodik);
            haromszogpontok.Add(harmadik);
            haromszogpontok.Add(negyedik);

            pl.Points = haromszogpontok;

            grid_panel.Children.Add(pl);
        }
    }
}
