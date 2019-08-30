public abstract class Item {

  public string _name { get; set; }
  public int _stackLimit 
  {
    get { return _stackLimit; }
    protected set { _stackLimit = value = 1; }
  }
  public int _stackSize { get; set; } = 1;
}