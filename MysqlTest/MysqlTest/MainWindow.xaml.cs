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
using System.Windows.Shapes;

namespace MysqlTest
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        
        public Window1()
        {
            InitializeComponent();

            string[] TimeArray;
            TimeArray = new string[9];
            TimeArray[0] = "thirty minutes";
            TimeArray[1] = "an hour";
            TimeArray[2] = "eight hours";
            TimeArray[3] = "twelve hours";
            TimeArray[4] = "a day";
            TimeArray[5] = "a week";
            TimeArray[6] = "a month";
            TimeArray[7] = "a year";
            TimeArray[8] = "a decade";

            string[] AspectArray;
            AspectArray = new string[5];
            AspectArray[0] = "finances";
            AspectArray[1] = "love life";
            AspectArray[2] = "career prospects";
            AspectArray[3] = "travel plans";
            AspectArray[4] = "relationships";

            string[] EffectArray;
            EffectArray = new string[6];
            EffectArray[0] = "fall apart";
            EffectArray[1] = "exceed your expectation";
            EffectArray[2] = "become awkward in an unexpected way";
            EffectArray[3] = "become manageable";
            EffectArray[4] = "become spectacular";
            EffectArray[5] = "come to a positive outcome";


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
