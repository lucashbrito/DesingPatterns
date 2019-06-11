using System.Runtime.InteropServices.WindowsRuntime;

namespace Interpreter
{
    public class ManyExpression : Expression
    {
        public override string One()
        {
            return "C";
        }

        public override string Nine()
        {
            return "CM";
        }

        public override string Four()
        {
            return "CD";
        }

        public override string Five()
        {
            return "D";
        }

        public override int Multiply()
        {
            return 1000;
        }
    }
}
