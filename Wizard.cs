 public class Wizard
 {
     public int proficiency;
     public int healing;
     public int poison;
     public int ragespells;
     public int lifespan;
     public int strikepower;
     public Wizard(int proficiency, int healing, int poison, int ragespells, int lifespan,int strikepower)
     {
         this.proficiency = proficiency;
         this.healing = healing;
         this.poison = poison;
         this.ragespells = ragespells;
         this.lifespan = lifespan;
         this.strikepower = strikepower;
     }
     public void gethealing(int lifespan, int proficiency)
     {
         Console.WriteLine($"The restoring lifespan in the healing is:{2*proficiency}");
     }
     public void getpoison(int lifespan, int proficiency,int strikepower)
     {
         Console.WriteLine($"The reduces lifespan is:{proficiency/2} and the rage increasing is:{proficiency*1.5}");
     }
     }
