namespace CyberHullTraining.Challenges.Seventh
{
    internal struct Figure
    {
        private readonly double height;
        private readonly double length;

        public Figure(double height, double length)
        {
            if (height < 0 || length < 0)
            {
                throw new ArgumentException("Height and Length should not be less than 0");
            }
            this.height = height;
            this.length = length;
        }

        public double Square
        { 
            get
            {
                return height * length;
            }
        }
    }
}
