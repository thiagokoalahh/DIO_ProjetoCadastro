namespace DIO.Series.Interfaces
{
    // Seguindo a mesma ideia de IRepositorio, essa interface deverá ser implementada em todos os serviços,
    // inclusive no caso de novos serviços.
    public interface IService
    {
        void Excluir();
        void Visualizar();
        void Atualizar();
        void Listar();
        void Inserir();
        string ObterOpcaoUsuario();
    }
}
