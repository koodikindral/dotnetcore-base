namespace BLL.Mappers
{
    public class IdentityMapper<TInObject, TOutObject> : IBaseBLLMapper<TInObject, TOutObject>
        where TInObject : class, new()
        where TOutObject : class, new()
    {
        public TOutObject Map<TInObject, TOutObject>(TInObject inObject)
            where TInObject : class, new()
            where TOutObject : class, new()
        {
            return inObject as TOutObject;
        }
    }
}