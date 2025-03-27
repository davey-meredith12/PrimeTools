using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PrimeTools;

public class Tool : INotifyPropertyChanged
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string HowItWorks { get; set; }
    
    private int _inputCount;
    public int InputCount
    {
        get => _inputCount;
        set { _inputCount = value; OnPropertyChanged(); }
    }
    
    public ObservableCollection<InputItem> Inputs { get; set; } = new();

    
    /*private string _input1;
    public string Input1
    {
        get => _input1;
        set { _input1 = value; OnPropertyChanged(); }
    }

    private string _input2;
    public string Input2
    {
        get => _input2;
        set { _input2 = value; OnPropertyChanged(); }
    }*/

    private string _result;
    public string Result
    {
        get => _result;
        set { _result = value; OnPropertyChanged(); }
    }

    public ICommand ComputeCommand { get; set; }
    public ICommand ExplanationCommand { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    
    public string Explanation { get; set; }
}



public class InputItem : INotifyPropertyChanged
{
    private string _value;
    public string Value
    {
        get => _value;
        set { _value = value; OnPropertyChanged(); }
    }

    private string _label;
    public string Label
    {
        get => _label;
        set { _label= value; OnPropertyChanged(); }
    }
    
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
