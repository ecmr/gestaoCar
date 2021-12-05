using GestaoCar.Dal;
using GestaoCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCar.Bus
{
    public class ServiceBus
    {
        public bool AdicionarCliente(Cliente cliente)
        {
            return DalHelper.AdicionarCliente(cliente);
        }
        public bool AdicionarDetalheOrcamento(DetalheOrcamento detalhe)
        {
            return DalHelper.AdicionarDetalhe(detalhe);
        }
        public bool AdicionarAnexo(Anexo anexo)
        {
            return DalHelper.AdicionarAnexo(anexo);
        }

        public List<Cliente> ListarCliente(Cliente cliente)
        {
            return DalHelper.GetCliente(cliente);
        }
        public List<DetalheOrcamento> ListarDetalheOrcamento(DetalheOrcamento detalhe)
        {
            return DalHelper.GetDetalheOrcamento(detalhe);
        }
        public List<Anexo> ListarAnexo(Anexo anexo)
        {
            return DalHelper.GetAnexosOrcamento(anexo);
        }
    }
}
