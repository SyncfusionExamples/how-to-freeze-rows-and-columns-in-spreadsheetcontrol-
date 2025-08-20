# How to freeze rows and columns in spreadsheetcontrol

This sample demonstrates how to freeze rows and columns in [WPF Spreadsheet](https://www.syncfusion.com/wpf-controls/spreadsheet) control.

`SpreadsheetControl` provides you with a feature that enables you to freeze rows or columns of the spreadsheet, while scrolling.  To apply the freeze panes, there are two ways in `Spreadsheet`.

### By Ribbon:

Go to the Views tab and click the Freeze Pane button. Select any of the three following options:

* FreezePanes- Freeze the row and column before the CurrentCell.
* FreezeTopRow- Freeze top row only.
* FreezeFirstColumn- Freeze the first column only.

### By Code:

You can specify the number of `FrozenRows` and `FrozenColumns` to freeze the range of rows and columns. If you want to keep the freeze range in saved work sheet, invoke `FreezePanes` method of specified range.

``` csharp
//To freeze 5 rows and 3 columns.
this.spreadSheetControl.WorkbookLoaded += SpreadSheetControl_WorkbookLoaded;
 
private void SpreadSheetControl_WorkbookLoaded(object sender, Syncfusion.UI.Xaml.Spreadsheet.Helpers.WorkbookLoadedEventArgs args)
{
    //To maintain the freeze state in saved work sheet.
    spreadSheetControl.Workbook.ActiveSheet.Range[5, 3].FreezePanes();
    //To freeze the rows and columns in the view
    var gridModel = spreadSheetControl.ActiveGrid;
    gridModel.FrozenColumns = 3;
    gridModel.FrozenRows = 5;
}
```
