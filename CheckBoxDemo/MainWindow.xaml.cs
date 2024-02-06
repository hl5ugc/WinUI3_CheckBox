using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CheckBoxDemo;
/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
    }

    private void Option_Checked(object sender, RoutedEventArgs e)
    {
        SetCheckedState();
    }

    private void Option_Unchecked(object sender, RoutedEventArgs e)
    {
        SetCheckedState();
    }

    private void SelectAll_Checked(object sender, RoutedEventArgs e)
    {
        Option1CheckBox.IsChecked = Option2CheckBox.IsChecked = Option3CheckBox.IsChecked = true;
    }

    private void SelectAll_Unchecked(object sender, RoutedEventArgs e)
    {
        Option1CheckBox.IsChecked = Option2CheckBox.IsChecked = Option3CheckBox.IsChecked = false;
    }

    private void SelectAll_Indeterminate(object sender, RoutedEventArgs e)
    {
        // If the SelectAll box is checked (all options are selected),
        // clicking the box will change it to its indeterminate state.
        // Instead, we want to uncheck all the boxes,
        // so we do this programatically. The indeterminate state should
        // only be set programatically, not by the user.

        if (Option1CheckBox.IsChecked == true &&
            Option2CheckBox.IsChecked == true &&
            Option3CheckBox.IsChecked == true)
        {
            // This will cause SelectAll_Unchecked to be executed, so
            // we don't need to uncheck the other boxes here.
            OptionsAllCheckBox.IsChecked = false;
        }
    }
    private void SetCheckedState()
    {
        if (Option1CheckBox != null)
        {
            if (Option1CheckBox.IsChecked == true &&
                Option2CheckBox.IsChecked == true &&
                Option3CheckBox.IsChecked == true)
            {
                OptionsAllCheckBox.IsChecked = true;
            }
            else if (Option1CheckBox.IsChecked == false &&
                Option2CheckBox.IsChecked == false &&
                Option3CheckBox.IsChecked == false)
            {
                OptionsAllCheckBox.IsChecked = false;
            }
            else
            {
                OptionsAllCheckBox.IsChecked = null;
            }
        }
    }
    //private void toppings_Click(object sender, RoutedEventArgs e)
    //{
    //    string selectedToppingsText = string.Empty;
    //    CheckBox[] checkBoxes = new CheckBox[] { pepperoniCheckBox,beefiCheckBox,
    //        mushroomsCheckBox,onionsCheckBox };

    //    foreach (CheckBox c in checkBoxes)
    //    {
    //        if (c.IsChecked == true)
    //        {
    //            if (selectedToppingsText.Length > 1)
    //            {
    //                selectedToppingsText += ", ";
    //            }
    //            selectedToppingsText += c.Content;
    //        }
    //    }
    //    toppingsList.Text = selectedToppingsText;
    //}


}
