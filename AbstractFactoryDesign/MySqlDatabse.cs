
namespace AbstractFactoryDesign
{
    public class MySqlDatabse : DatabaseFactory
    {
        public override Command CreateCommand() => new MySqlCommand();
        public override Connection CreateConnection() => new MySqlConnection();
    }
}
