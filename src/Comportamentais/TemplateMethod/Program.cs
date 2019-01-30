namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstract a = new ConcreteClass();
            Abstract b = new ConcreteClassB();

            a.TemplateMethod();
            b.TemplateMethod();

        }
    }
}
