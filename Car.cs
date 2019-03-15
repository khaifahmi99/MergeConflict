public class Car {
  private string _model;
  private string _color;
  private int _yearReleased;
  private float _price;
  
  public string Model {
    get{ return _model; }
    set { _model = value; }
  }
  
  public Car(string model, string color, int yearReleased, float price) {
    _model = model;
    _color = color;
    _yearReleased = yearReleased;
    _price = price;
  }
  
  public void Drive(){
    Console.WriteLine("This is a {0} {1} driving!!!");
  }
  
}
