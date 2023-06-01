namespace WarteZimmer_inderPraxis.Models
{
    public static class Info
    {
        public static Queue<Patienten>? queue = new Queue<Patienten>();
        public static Patienten? p { set; get; }

        public static IEnumerable<Patienten>? x => queue;
        public static List<Patienten> neulist = new List<Patienten>();

        public static void AddPatient(Patienten p)
        {
            queue.Enqueue(p);
            
        }
        public static void Löschen()
        {
            p = queue.Dequeue();
            neulist.Add(p);
            Console.WriteLine( p.name);




        }
        
    }
}
