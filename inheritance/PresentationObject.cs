namespace inheritance
{
    public class PresentationObject
    {
        public int Width { get; set;}
        public int Height { get; set;}

        public void Copy()
        {
            System.Console.WriteLine("Object copied");
        }

        public void Duplicate()
        {
            System.Console.WriteLine("Object was duplicated");
        }
    }
}
