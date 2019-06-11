namespace Interpreter
{
    public class DozensExpression:Expression
    {
        public override string One()
        {
            return "C";
        }

        public override string Nine()
        {
            return "XC";
        }

        public override string Four()
        {
            return "XL";
        }

        public override string Five()
        {
            return "X";
        }

        public override int Multiply()
        {
            return 10;
        }
    }
}
