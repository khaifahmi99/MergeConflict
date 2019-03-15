class Program {
  static void Main(string[] args){
    Car car1 = new Car("Ferrari", "Red",1999, 400000.00);
    Car car2 = new Car("Porsche", "Black", 2006, 350000.00);
    
    car1.drive();
    car2.drive();
  }
}
