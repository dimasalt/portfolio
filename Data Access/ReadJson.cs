using Newtonsoft.Json;

namespace Portfolio.Data_Access;

public class ReadJson : IReadJson 
{ 
    private readonly IConfiguration _config;

    public ReadJson(IConfiguration config){
        _config = config;
    }

    public T ReadJsonFile<T>(T returnDtoObject, string jsonFileName)
    {
        string jsonFolder = _config.GetValue<string>("JsonFilePath") ?? string.Empty;
        string jsonPath = Directory.GetCurrentDirectory() + "\\" + jsonFolder + "\\" + jsonFileName;

        using (StreamReader reader = new StreamReader(jsonPath))
        {
            var json = reader.ReadToEnd();
            var result = JsonConvert.DeserializeObject<T>(json);

            reader.Close();
            reader.Dispose();

            //sending data or an empty object
            return result ?? returnDtoObject;
        }
    }
}
