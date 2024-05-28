
namespace Portfolio.Data_Access
{
    public interface IReadJson
    {
        T ReadJsonFile<T>(T ReturnDtoObject, string JsonFilePath);
    }
}

