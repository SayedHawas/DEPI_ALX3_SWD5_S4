namespace Day5Lab
{
    public class Manager : Employee
    {
        public string Tasks { get; set; }
        public double Bouns { get; set; }

        public override double InCome()
        {
            return base.InCome() + Bouns;
        }
        public override string SayInfo()
        {
            return $"{base.SayInfo()}\n Tasks : {Tasks}\nBouns : {Bouns}";
        }

        public struct Project
        {
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string ProjectName { get; set; }
            public string ProjectDescription { get; set; }

            public string ShowDetails()
            {
                return $"Project Name : {ProjectName}\nStart : {StartDate}\nEnd : {EndDate}\nDescription :  {ProjectDescription}";
            }
        }
    }
}
