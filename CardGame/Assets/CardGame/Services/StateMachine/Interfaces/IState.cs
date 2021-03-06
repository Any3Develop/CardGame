using CardGame.Services.StorageService;

namespace CardGame.Services.StateMachine
{
    public interface IState : IStorageItem
    {
        void OnEnter(params object[] args);
        void OnExit();
    }
}