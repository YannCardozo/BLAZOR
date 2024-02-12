namespace Justo.Data
{
    public class SqlConnectionConfiguration
    {
        public string ConnectionString { get; }

        // O construtor da classe deve ser declarado como "public SqlConnectionConfiguration"
        public SqlConnectionConfiguration(string stringConexao) => this.ConnectionString = stringConexao;
    }

}
