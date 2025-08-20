namespace Resume.Models;

public class TerminalModel
{
    public int Id { get; set; }
    public string Type { get; set; }
    public string Item { get; set; }


    public TerminalModel() { }
    
    public TerminalModel(string type, string item)
    {
        Type = type;
        Item = item;
    }
}