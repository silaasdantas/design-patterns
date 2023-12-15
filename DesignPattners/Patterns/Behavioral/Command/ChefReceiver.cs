namespace DesignPatterns.Patterns.Behavioral.Command
{
    //Receiver
    public class ChefReceiver
    {
        public void PreparandoPrato()
        {
            Console.WriteLine("Chef esta preparando o prato: Prato");
        }

        public void PreparandoSobremesa()
        {
            Console.WriteLine("Chef esta preparando a sobremesa: Sobremesa");
        }
    }
}
