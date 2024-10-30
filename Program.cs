class program
{
    public static void Main(string[] args)
    {
        Wizard w = new Wizard(4, 3, 100, 5, 90, 40);
        w.gethealing(90, 4);
        w.getpoison(4, 90, 40);
        Character c1 = new Character("Leader", 4, 50, 3, 8, "strikes");
        Character c2 = new Character("Manager", 0, -50, -4, -5, "king");
        Console.WriteLine(c1.getname());
        Console.WriteLine(c1.checkproficiency());
        Console.WriteLine(c1.checklifespan());
        c1.getdistinctcolor(50,4);
        Console.WriteLine(c1.getinitialingposition(3,8));
        c1.gettype("strikes");
        Console.WriteLine(c2.getname());
        Console.WriteLine(c2.checkproficiency());
        Console.WriteLine(c2.checklifespan());
        c2.getdistinctcolor(0,-50);
        c2.gettype("king");
        Console.WriteLine(c2.getinitialingposition(-4,-5));
        Warrior w1 = new Warrior(50);
        Console.WriteLine(w1.getLifespan());
    }
