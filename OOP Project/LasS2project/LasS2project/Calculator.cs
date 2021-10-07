namespace LasS2project
{
    class Calculator
    {
        //those two are my protected variables, they are the one used in the methods
        private double x;
        private double y;

        /// <summary>
        /// this is my constructer, it takes two doubles
        /// </summary>
        /// <param name="x">number 1</param>
        /// <param name="y">number 2</param>
        public Calculator(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// add both number together
        /// </summary>
        /// <returns>the result of the addition</returns>
        public double Add()
        {
            return x + y;
        }

        /// <summary>
        /// substract y from x
        /// </summary>
        /// <returns>the substraction result</returns>
        public double Substract()
        {
            return x - y; 
        }

        /// <summary>
        /// multiply both numbers
        /// </summary>
        /// <returns>the multiplication result</returns>
        public double Multiply()
        {
            return x * y;
        }

        /// <summary>
        /// divide x by y
        /// </summary>
        /// <returns>the division result or Error2</returns>
        public string Divide()
        {
            if(y == 0)
            {
                return "Error2";
            }

            return (x / y).ToString();
        }

        //My parameters, they are get only
        public double X { get { return x; } }
        public double Y { get { return y; } }
    }
}
