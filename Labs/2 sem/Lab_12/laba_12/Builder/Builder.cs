using System.Text;

namespace laba_12.Builder
{
    class Builders
    {

    }

    class Flour
    {
        public string Sort { get; set; }
    }
 
    class Salt
    {
        public string Name { get; set; }
    }
 
    class Additives
    {
        public string Name { get; set; }
    }

    class Bread
    { 
        public Flour Flour { get; set; }
        public Salt Salt { get; set; }
        public Additives Additives { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Flour != null)
                sb.Append(Flour.Sort + "\n");
            if (Salt != null)
                sb.Append("Object: " + Salt.Name);
            
            return sb.ToString();
        }
    }

    abstract class BreadBuilder
    {
        public Bread Bread { get; private set; }
        public void CreateBread()
        {
            Bread = new Bread();
        }
        public abstract void SetFlour();
        public abstract void SetSalt();
        public abstract void SetAdditives();
    }
    
    class Baker
    {
        public Bread Bake(BreadBuilder breadBuilder)
        {
            breadBuilder.CreateBread();
            breadBuilder.SetFlour();
            breadBuilder.SetSalt();
            breadBuilder.SetAdditives();
            return breadBuilder.Bread;
        }
    }
    
    class RyeBreadBuilder : BreadBuilder
    {
        public override void SetFlour()
        {
            this.Bread.Flour = new Flour { Sort = "Added object with builder pattern" };
        }

        public override void SetSalt()
        {
            this.Bread.Salt = new Salt { Name = "Triangle" };
        }

        public override void SetAdditives()
        {
            //not use
        }
    }
    
  
}