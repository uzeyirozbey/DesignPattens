
namespace AbstractFactoryDesign
{
    public class MySqlDatabse : DatabaseFactory
    {
        //deneme tfs
        public override Command CreateCommand() => new MySqlCommand();
        public override Connection CreateConnection() => new MySqlConnection();
    }
}
