namespace Calculator
{
    public class Model
    {
        public string Add(float a, float b)
        {
            return (a + b).ToString();
        }

        public string Sub(float a, float b)
        {
            return (a - b).ToString();
        }

        public string Multi(float a, float b)
        {
            return (a * b).ToString();
        }

        public string Div(float a, float b)
        {
            if (a != 0)
            {
                return (a / b).ToString();
            }
            else
            {
                return "You can't divide by zero";
            }
        }
    }
}
