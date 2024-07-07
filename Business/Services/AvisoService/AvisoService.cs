namespace Plamove.Business.Services.AvisoService
{
    public class AvisoService : IAvisoService
    {
        private List<string> _notificacoes;

        public AvisoService()
        {
            _notificacoes = new List<string>();
        }

        public void Adicionar(string notificacao, params object[] dados)
        {
            _notificacoes.Add(notificacao);
        }

        public List<string> ObtersAvisos()
        {
            return _notificacoes.ToList();
        }

        public bool PossuiAvisos()
        {
            return _notificacoes.Any();
        }
    }
}
