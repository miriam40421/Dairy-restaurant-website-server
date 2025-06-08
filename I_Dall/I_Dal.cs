namespace I_Dall
{
    public interface IDalRepository<T>
    {
        public Task<List<T>> SelectAllAsync();
    }
}

