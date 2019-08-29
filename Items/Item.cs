public abstract class Item {

  public string _name { get; set; }
  public int _stackLimit { get; set; } = 1;
  public int _stackSize { get; set; } = 1;
}