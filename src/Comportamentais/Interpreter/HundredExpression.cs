namespace Interpreter
{
    public class HundredExpression : Expression
    {
        public override string One()
        {
            return "X";
        }

        public override string Nine()
        {
            return "L";
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
            return 100;
        }
    }
}
