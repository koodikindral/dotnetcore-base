namespace DotnetCore.Base.DAL.Interface
{
    public interface IUserNameProvider
    {
        string CurrentUserName { get; }
    }
}