

using System.ComponentModel;
using System.Data.SqlClient;

namespace LH_PETS___Fabi
{
    public class Banco
    {
        private List<Clientes> lista = new List<Clientes>();

        public List<Clientes> GetLista() 
        return Lista;
        }
        
        public string GetListaString() {
           string enviar = "<!DOCTYPE html>\n<html>\n<head>\n<meta charset='utf-8'/>\n" +
                           "<title>Cadastro de Clientes</title>\n" +
                           "<style>table{border-spacing: 0; border-collapse: collapse;} th, td{border: 1px solid black; padding: 0 10px;} tbody tr:nth-child(even){background: #ccc} 
                           "</head>\n<body>" +
                           "<h1>Lista de Cliente</h1>" +
                           "<table><thead><tr>" +
                              "<th>CPF/CNPJ</th>" +
                              "<th>Nome/th>" +
                              "<th>Endereço</th>" +
                              "<th>RG/IE</th>" +
                              "<th>Tipo</th>" +
                              "<th>Valor</th>" +
                              "<th>valor Imposto</th>" +
                              "<t>Total</th>" +
                            "</thead><tbody>";

            foreach (Clientes cli in GetLista()); {

            enviar += "<tr>" +
                         $"<td> {cli.cpf_cnpj}</td>" +
                         $"<td> {cli.nome}</td>" +
                         $"<td> {cli.endereco}</td>" +
                         $"<td> {cli.rg_ie}</td>" +
                         $"<td> {cli.tipo}</td>" +
                         $"<td> {cli.valor.ToString("C")}</td>" +
                         $"<td> {cli.valor_imposto.ToString("C")}</td>" +
                         $"<td> {cli.total.ToString("C")}</td>" +
                         "</tr>";

        }

        enviar += "</tbody><table><body></html>";
        return enviar:

    }

    public banco() {
        try {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder (
                "User ID=sa;Password=1234;" +
                "Server=Localhost\\SQLEXPRESS2;" +
                "Database=vendas;" +
                "Trusted_Connection=false;" +
            );

        }
          catch (Exception ex) {
                 Console.WriteLine(ex.ToString());
          }

    }

}