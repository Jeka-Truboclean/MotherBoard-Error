namespace _12._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter RAM value (GB):\n> ");
            try
            {
                int ramValue = int.Parse(Console.ReadLine());
                Motherboard motherboard = new Motherboard(ramValue, 2.6, "Intel Core i10 10th Gen");
                Console.WriteLine($"Motherboard successfully initialized with {motherboard.Ram}GB RAM.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    public class Motherboard
    {
        private Processor processor;
        public Motherboard(int ram, double ghz, string name)
        {
            Processor = new Processor(name, ghz);
            Ram = ram;
        }
        public int Ram
        {
            get { return ram; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("RAM must be more than 0");
                }
                ram = value;
            }
        }
        public Processor Processor
        {
            get { return processor; }
            set { processor = value; }
        }

        private int ram;
    }
    public class Processor
    {
        public Processor(string name, double gHz)
        {
            Name = name;
            GHz = gHz;
        }
        public string Name { get; set; }
        public double GHz { get; set; }
    }
}
