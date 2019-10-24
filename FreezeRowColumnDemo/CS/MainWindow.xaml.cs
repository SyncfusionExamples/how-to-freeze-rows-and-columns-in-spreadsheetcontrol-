using Syncfusion.Windows.Tools.Controls;
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

namespace FreezeRowColumnDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
              this.spreadSheetControl.Open(@"..\..\Data\Sample.xlsx");
             this.spreadSheetControl.WorkbookLoaded += SpreadSheetControl_WorkbookLoaded;
        }
        //To freeze 3 rows and columns.
        private void SpreadSheetControl_WorkbookLoaded(object sender, Syncfusion.UI.Xaml.Spreadsheet.Helpers.WorkbookLoadedEventArgs args)
        {
            //To maintain the freeze state in saved work sheet.
            spreadSheetControl.Workbook.ActiveSheet.Range[3, 3].FreezePanes();
            //To freeze the rows and columns in the view
            var gridModel = spreadSheetControl.ActiveGrid;
            gridModel.FrozenColumns = 3;
            gridModel.FrozenRows = 3;

        }
    }
}
