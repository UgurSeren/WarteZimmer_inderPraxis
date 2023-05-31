namespace WarteZimmer_inderPraxis.Models
{
    public static class Info
    {
        public static Queue<Patienten>? queue = new Queue<Patienten>();
        public static Patienten? p { set; get; }

        public static IEnumerable<Patienten> x => queue;

        public static void AddPatient(Patienten p)
        {
            queue.Enqueue(p);
        }
        public static void Löschen()
        {
            p = queue.Dequeue();
            Console.WriteLine(p.name);
              
            
            
        }
        
    }
}
