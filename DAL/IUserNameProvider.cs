namespace DotnetCore.Base.DAL
{
    public interface IUserNameProvider
    {
        string CurrentUserName { get; }
    }
}