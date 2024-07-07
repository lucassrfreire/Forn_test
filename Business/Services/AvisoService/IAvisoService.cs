namespace Plamove.Business.Services.AvisoService
{
    public interface IAvisoService
    {
        public void Adicionar(string notificacao, params object[] dados);
        public List<string> ObtersAvisos();
        public bool PossuiAvisos();
    }
}
