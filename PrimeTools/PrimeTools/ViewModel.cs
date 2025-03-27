using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PrimeTools;

public class ViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Tool> Tools { get; set; } = new ObservableCollection<Tool>();

    private Tool _selectedTool;
    public Tool SelectedTool
    {
        get => _selectedTool;
        set
        {
            _selectedTool = value;
            OnPropertyChanged();
        }
    }
    public ViewModel()
    {
        Tool gcdTool = CreateTool.GcdTool();
        
        Tools.Add(gcdTool);
        SelectedTool = gcdTool;
        
        
        // Add a tool name to display
        // You can add as many tools as you like:
        //Tools.Add(new Tool { Name = "Eulers Quotient" });
    }
    
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    
}