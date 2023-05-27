Console.WriteLine(&quot; Name your dog:&quot;);
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);
Dog neighboursDog = new Dog(&quot; Good Girl&quot;);

Console.WriteLine($&quot; My dogs name is {myDog.Name}.&quot;);
Console.WriteLine($&quot; My neighbours dogs name is {neighboursDog.Name}.&quot;);
myDog.Rename(&quot; Bad Boy&quot;);
while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}
myDog.WagTail();

class Dog
{
    private string _name; //field
    private int _levelOfHappiness;
    //constructor
    public Dog(string name) //name - lets the user name the dog
    {
        _name = name;
        _levelOfHappiness = 0;
    }
    //getter
    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHapiness
    {
        get { return _levelOfHappiness; }
    }
    public void Rename(string newName)
    {
        _name = newName;

        Console.WriteLine($&quot; The dog has been renamed to: { newName}
        &quot;);
    }
    public void Bark()
    {
        Console.WriteLine(&quot; Woof - woof! & quot;);
        _levelOfHappiness++;
    }
    public void WagTail()
    {
        Console.WriteLine(&quot; Wiggle - wiggle! & quot;);
    }
}
