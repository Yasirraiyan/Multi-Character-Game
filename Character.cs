public  class Character
{
    public string name { get; set; }
    public int proficiency;
   
    public int lifespan;
    public int x;
    public int y;
    public string attackingtype;
    public Character(string name, int proficiency,  int lifespan, int x, int y,string attackingtype)
    {
        this.name = name;
        this.proficiency = proficiency;
       
        this.lifespan = lifespan;
        this.x = x;
        this.y = y;
        this.attackingtype = attackingtype;
    }
    public string getname()
    {
        return name;
        
    }
    public int checkproficiency()
    {
        if(proficiency>=1&&proficiency<=5)
        {
            Console.WriteLine($"The proficiency is valid and the proficiency is:{proficiency}");
        }
        else
        {
            Console.WriteLine("The proficiency is invalid!");
        }
        return proficiency;
    }
    public int checklifespan()
    {
        if(lifespan>=0 && lifespan<=100)
        {
            Console.WriteLine($"The lifespan is valid and the character's lifespan is:{lifespan}");
        }
        else
        {
            Console.WriteLine("The lifespan is invalid! and character is dead");
        }
        return lifespan;
    }
    public void getdistinctcolor( int lifespan,int proficiency)
    {
        if(lifespan>90&&lifespan<=100&&proficiency==5)
        {
            Console.WriteLine($"The color of the character is green.The lifespan is;{lifespan}.The proficiency is:{proficiency}");
        }
       if(lifespan>60&&lifespan<=80&&proficiency==4)
        {
            Console.WriteLine($"The color of the character is purple.The lifespan is;{lifespan}.The proficiency is:{proficiency}");
        }
       if (lifespan<50&&lifespan>0&&proficiency<4&&proficiency>0)
        {
            Console.WriteLine($"The color of the character is red.The lifespan is;{lifespan}.The proficiency is:{proficiency}");
        }
    }
    public (int,int) getinitialingposition(int x, int y)
    {
        Console.WriteLine($"The tialing position is:{x},{y}");
        return (x,y);
    }
    public void gettype(string attackingtype)
    {
        if (attackingtype == "strikes")
            Console.WriteLine($"The present oponents life is:{proficiency / 2} and the type of character is warrior");
        else
            Console.WriteLine("Invalid!");
    }
    
}
}
