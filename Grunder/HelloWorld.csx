class Human
{
    public string First { get; set; }
    public string Last { get; set; }
    public string FullName()
    {
        return $"{this.First} {this.Last}";
    }

}

class SuperHuman : Human
{
    public Boolean canFly { get; set; }
    public Boolean canShootLaser { get; set; }
    public Boolean canDie { get; set; }
}

Human human = new Human{ First = "Matthew", Last = "Westman" };
Console.WriteLine((human.FullName()));
SuperHuman SuperMan = new SuperHuman{ 
    First = "Carl",
    Last = "Kent",
    canDie = false,
    canFly = true,
    canShootLaser = true
};

void SpamConsole(int lenght, string msg)
{
    for(int i = 0; i < lenght; i++)
    {
        Console.WriteLine(msg);
    }
}

SpamConsole(10, "XD");