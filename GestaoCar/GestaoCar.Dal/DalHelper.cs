using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoCar.Model;
using Microsoft.Data.Sqlite;

namespace GestaoCar.Dal
{
    public class DalHelper
    {
        private static SqliteConnection sqliteConnection;
        private static string stBanco = @"C:/Minha Mecanica/mecanicaVeicular.sqlite3";

        private static SqliteConnection DbConnection()
        {
            try
            {
                sqliteConnection = new SqliteConnection(string.Concat("Data Source=", stBanco, "; Version=3;"));
                sqliteConnection.Open();
            }
            catch (Exception ex)
            {
                HelperLog.GravaLog(string.Concat("Erro DbConnection: ", ex.Message));
            }

            return sqliteConnection;
        }


        #region CLIENTE
        public static bool AdicionarCliente(Cliente cliente)
        {
            bool sucesso = false;
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    var query = @"INSERT INTO Cliente (NomeCliente, PlacaVeiculo, DescricaoVeiculo, Mecanico, Diagnostico)
                                VALUES(@NOMECLIENTE, @PLACAVEICULO, @DESCRICAOVEICULO, @MECANICO, @DIAGNOSTICO);";

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@NOMECLIENTE", cliente.NomeCliente);
                    cmd.Parameters.AddWithValue("@PLACAVEICULO", cliente.PlacaVeiculo);
                    cmd.Parameters.AddWithValue("@DESCRICAOVEICULO", cliente.DescricaoVeiculo);
                    cmd.Parameters.AddWithValue("@MECANICO", cliente.NomeMecanico);
                    cmd.Parameters.AddWithValue("@DIAGNOSTICO", cliente.Diagnostico);

                    cmd.ExecuteNonQuery();

                    sucesso = true;
                }

                return sucesso;
            }
            catch (Exception ex)
            {
                HelperLog.GravaLog(string.Concat("Erro método AdicionarCliente( ", cliente.NomeCliente, ")", " -- " , ex.Message));
                return sucesso;
            }
        }

        public static List<Cliente> GetCliente(Cliente cliente=null)
        {
            try
            {
                var query = @"SELECT codigoCliente, NomeCliente, PlacaVeiculo, DescricaoVeiculo, Mecanico, Diagnostico FROM Cliente C
                    WHERE 1 = 1 ";

                if (cliente.CodigoCliente > 0)
                    query += " AND C.CODIGOCLIENTE = @CODIGOCLIENTE";
                if (string.IsNullOrEmpty(cliente.NomeCliente))
                    query += " AND C.NomeCliente = @NOMECLIENTE";
                if (string.IsNullOrEmpty(cliente.PlacaVeiculo))
                    query += " AND C.PlacaVeiculo = @PLACAVEICULO";

                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = query;

                    if (cliente.CodigoCliente > 0)
                        cmd.Parameters.AddWithValue("@CODIGOCLIENTE", cliente.CodigoCliente);
                    if (string.IsNullOrEmpty(cliente.NomeCliente))
                        cmd.Parameters.AddWithValue("@NOMECLIENTE", cliente.NomeCliente);
                    if (string.IsNullOrEmpty(cliente.PlacaVeiculo))
                        cmd.Parameters.AddWithValue("@PLACAVEICULO", cliente.PlacaVeiculo);


                    SqliteDataReader reader = cmd.ExecuteReader();

                    return PreencheClienteReader(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region DETALHES
        public static bool AdicionarDetalhe(DetalheOrcamento detalhe)
        {
            bool sucesso = false;
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    var query = @"INSERT INTO DETALHEORCAMENTO (ORDEMSERVICO, PECAEXECUTADA, NOMEPECA, QUANTIDADE, VALORUNITARIO, VALORTOTAL)
                            VALUES (@ORDEMSERVICO, @PECAEXECUTADA, @NOMEPECA, @QUANTIDADE, @VALORUNITARIO, @VALORTOTAL);";

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ORDEMSERVICO", detalhe.OrdemServico);
                    cmd.Parameters.AddWithValue("@PECAEXECUTADA", detalhe.PecaExecutada);
                    cmd.Parameters.AddWithValue("@NOMEPECA", detalhe.NomePeca);
                    cmd.Parameters.AddWithValue("@QUANTIDADE", detalhe.Quantidade);
                    cmd.Parameters.AddWithValue("@VALORUNITARIO", detalhe.ValorUnitario);
                    cmd.Parameters.AddWithValue("@VALORTOTAL", detalhe.ValorTotal);

                    cmd.ExecuteNonQuery();

                    sucesso = true;
                }

                return sucesso;
            }
            catch (Exception ex)
            {
                HelperLog.GravaLog(string.Concat("Erro método AdicionarCliente( ", detalhe.CodigoCliente, ")", " -- ", ex.Message));
                return sucesso;
            }
        }

        public static List<DetalheOrcamento> GetDetalheOrcamento(DetalheOrcamento detalhe)
        {
            try
            {
                var query = @"SELECT ORDEMSERVICO, CODIGOCLIENTE, PECAEXECUTADA, NOMEPECA, QUANTIDADE, VALORUNITARIO, VALORTOTAL
                                FROM DETALHEORCAMENTO WHERE 1 = 1 AND ORDEMSERVICO = @ORDEMSERVICO AND CODIGOCLIENTE = @CODIGOCLIENTE;";

                  using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = query;

                   cmd.Parameters.AddWithValue("@ORDEMSERVICO", detalhe.OrdemServico);
                   cmd.Parameters.AddWithValue("@CODIGOCLIENTE", detalhe.CodigoCliente);

                    SqliteDataReader reader = cmd.ExecuteReader();

                    return PreencheDetalheReader(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region ANEXOS
        public static bool AdicionarAnexo(Anexo anexo)
        {
            bool sucesso = false;
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    var query = @"INSERT INTO ANEXOS (CODIGOCLIENTE, ORDEMSERVICO, ANEXO) VALUES (@CODIGOCLIENTE, @ORDEMSERVICO, @ANEXO);";

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@CODIGOCLIENTE", anexo.CodigoCliente);
                    cmd.Parameters.AddWithValue("@ORDEMSERVICO", anexo.OrdemServico);
                    cmd.Parameters.AddWithValue("@ANEXO", anexo.Arquivo);

                    cmd.ExecuteNonQuery();

                    sucesso = true;
                }

                return sucesso;
            }
            catch (Exception ex)
            {
                HelperLog.GravaLog(string.Concat("Erro método AdicionarAnexo( ", anexo.CodigoCliente, ")", " -- ", ex.Message));
                return sucesso;
            }
        }

        public static List<Anexo> GetAnexosOrcamento(Anexo anexo)
        {
            try
            {
                var query = @"SELECT CODIGOANEXO, CODIGOCLIENTE, ORDEMSERVICO, ANEXO FROM ANEXOS WHERE CODIGOCLIENTE = @CODIGOCLIENTE AND  ORDEMSERVICO =  @ORDEMSERVICO;";

                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@ORDEMSERVICO", anexo.OrdemServico);
                    cmd.Parameters.AddWithValue("@CODIGOCLIENTE", anexo.CodigoCliente);

                    SqliteDataReader reader = cmd.ExecuteReader();

                    return PreencheAnexoReader(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region PREENCHE OBJETOS CLIENTE
        private static List<Cliente> PreencheClienteReader(SqliteDataReader reader)
        {
            List<Cliente> clientes = new List<Cliente>();

            while (reader.Read())
            {
                Cliente cliente = new Cliente()
                {
                    CodigoCliente = int.Parse(reader.IsDBNull(0) ? "" : reader.GetString(0)),
                    NomeCliente = reader.IsDBNull(1) ? "" : reader.GetString(1),
                    PlacaVeiculo = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    DescricaoVeiculo = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    NomeMecanico = reader.IsDBNull(4) ? "" : reader.GetString(4),
                    Diagnostico = reader.IsDBNull(5) ? "" : reader.GetString(5)
                };
                clientes.Add(cliente);
            }
            return clientes;
        }
        #endregion

        #region PREENCHE OBJETOS DETALHE
        private static List<DetalheOrcamento> PreencheDetalheReader(SqliteDataReader reader)
        {
            List<DetalheOrcamento> detalhes = new List<DetalheOrcamento>();

            while (reader.Read())
            {
                DetalheOrcamento detalhe = new DetalheOrcamento()
                { 
                    OrdemServico = int.Parse(reader.IsDBNull(0) ? "0" : reader.GetString(0)),
                    CodigoCliente = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                    PecaExecutada = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    NomePeca = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    Quantidade = int.Parse(reader.IsDBNull(4) ? "0" : reader.GetString(4)),
                    ValorUnitario = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5),
                    ValorTotal = reader.IsDBNull(5) ? 0 : reader.GetDecimal(6)
                };
                detalhes.Add(detalhe);
            }
            return detalhes;
        }
        #endregion

        #region PREENCHE OBJETOS ANEXO
        private static List<Anexo> PreencheAnexoReader(SqliteDataReader reader)
        {
            List<Anexo> anexos = new List<Anexo>();

            while (reader.Read())
            {
                Anexo anexo = new Anexo()
                {  
                    CodigoAnexo = int.Parse(reader.IsDBNull(0) ? "0" : reader.GetString(0)),
                    CodigoCliente = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                    OrdemServico = int.Parse(reader.IsDBNull(2) ? "0" : reader.GetString(2)),
                    Arquivo = reader.IsDBNull(3) ? "0" : reader.GetString(3),
                };
                anexos.Add(anexo);
            }
            return anexos;
        }
        #endregion
    }
}
