namespace Day5Lab
{
    public struct Point  //Sealed
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
            //Int32 I = new Int32();
            //I = 20;
        }

        public string PrintPoint()
        {
            return $"X: {X} Y : {Y} ";
        }
    }

    //public class test :Point
    //{ 

    //}

}
