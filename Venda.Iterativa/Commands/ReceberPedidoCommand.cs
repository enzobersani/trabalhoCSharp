using System;
using System.Windows;
using Venda.Iterativa.Classes;
using Venda.Iterativa.UserControls;
using Venda.Iterativa.ViewModel;

namespace Venda.Iterativa.Commands
{
    internal sealed class ReceberPedidoCommand : AbstractCommand
    {
        public override void Execute(object? parameter)
        {
            try
            {
                var vm = parameter as ListarProdutosViewModel;

                if (vm.Pedido.Produtos.Count == 0)
                {
                    MessageBox.Show("É preciso realizar a seleção de um produto para adiciona-lo");
                    return;
                }

                vm.Pedido = ucReceber.Exibir(vm.MainUserControl, vm.Pedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }
    }
}