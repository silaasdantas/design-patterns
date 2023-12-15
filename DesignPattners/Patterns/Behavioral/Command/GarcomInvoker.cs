namespace DesignPatterns.Patterns.Behavioral.Command
{
    //Invoker
    public class GarcomInvoker
    {
        public PedidoCommand _pedido;
        public GarcomInvoker(PedidoCommand pedido)
        {
            _pedido = pedido;
        }
        public void Executar()
        {
            _pedido.Execute();
        }
    }
}
