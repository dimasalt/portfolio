namespace Portfolio.Data_Access
{
    public interface IReadJson
    {
        public T ReadJsonFile<T>(T ReturnDtoObject, string JsonFilePath);
    }
}
