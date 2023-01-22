AirsoftWeaponStore AWS = new AirsoftWeaponStore();
Console.WriteLine(AWS);
class AirsoftWeaponStore
{
   private string name;
    private int price;
    private int countInStore;

    public string Name { get => name; set => name = value; }
    public int Price { get => price; set => price = value; }
    public int CountInStore { get => countInStore; set => countInStore = value; }
    public AirsoftWeaponStore()
    {
        Name = "AK 105";
        Price = 10000;
        CountInStore = 120;
    }
    public AirsoftWeaponStore(string _name, int _price,int _count)
    {
        _name=Name;
        _price = Price;
        _count = CountInStore;
    }
    public override string ToString() 
    {
        return "Name:" + Name + " " + "Price:" + Price + " Rubels " + "Count in Store:" + CountInStore;
    
    }
   
    
}
