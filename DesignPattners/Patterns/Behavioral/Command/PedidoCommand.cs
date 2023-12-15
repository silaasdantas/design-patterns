namespace DesignPatterns.Patterns.Behavioral.Command
{
    //ConcreteCommand
    public class PedidoCommand : Command
    {
        public ChefReceiver Chef { get; set; }
        public string Acao { get; set; }
        public PedidoCommand(ChefReceiver chef, string acao)
        {
            Chef = chef;
            Acao = acao;
        }

        public override void Execute()
        {
            if (Acao.Equals("Prato"))
            {
                Chef.PreparandoPrato();
            }
            else
            {
                Chef.PreparandoSobremesa();
            }
        }
    }
}
