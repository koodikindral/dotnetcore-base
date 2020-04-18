namespace DAL
{
    public interface IUserNameProvider
    {
        string CurrentUserName { get; }
    }
}