using Microsoft.Extensions.Configuration;

namespace FirstCoreApp
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }
    public class Greeter : IGreeter
    {
        IConfiguration _config;
        public Greeter(IConfiguration config)
        {
            _config = config;
        }
        public string GetMessageOfTheDay()
        {
            return _config["Greetings"];
        }
    }
}
