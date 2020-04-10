namespace CGS
{
    public class Curator : Person
    {
        public string CuratorId { get; set; }
        public double Commission { get; set; }
        const double CommRate = 0.10;

        public Curator()
        {
            
        }

        public Curator(string firstName, string lastName, string curatorId) : base(firstName, lastName)
        {
            CuratorId = curatorId;
            Commission = 0;
        }

        public override string ToString()
        {
            string conservateurInformation = "\nName:" + base.FirstName  +
            base.LastName + "\nCurator ID: " + CuratorId + "\nCommissions paid: " +
                Commission;

            return conservateurInformation;
        }
    }
}