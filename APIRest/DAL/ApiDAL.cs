using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace APIRest.DAL
{
    public class ApiDAL
    {
        string ConString = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["DefaultConnection"].ToString();

        public ResponseData PostPromocionDAL(Promociones Promocion)
        {
            ResponseData response = new ResponseData();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PostPromocion";
                    command.Parameters.AddWithValue("@Descripcion", Promocion.Descripcion);
                    command.Parameters.AddWithValue("@Restricciones", Promocion.Restricciones);
                    command.Parameters.AddWithValue("@FechaInicioVigencia", Promocion.FechaInicioVigencia);
                    command.Parameters.AddWithValue("@FechaFinVigencia", Promocion.FechaFinVigencia);

                    SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                    DataTable dtResponse = new DataTable();
                    connection.Open();
                    sqlDA.Fill(dtResponse);
                    connection.Close();
                    response.Message = dtResponse.Rows[0]["Message"].ToString() ?? "";
                    response.ResponseCode = Convert.ToInt32(dtResponse.Rows[0]["ResponseCode"]);
                }
            }
            catch (Exception e)
            {

                response.Message = "Un Error ha ocurrio: " + e.Message.ToString();
                response.ResponseCode = 0;
            }

            return response;

        }
        public ResponseData PutPromocionDAL(Promociones Promocion)
        {
            ResponseData response = new ResponseData();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PutPromocion";
                    command.Parameters.AddWithValue("@Id", Promocion.Id);
                    command.Parameters.AddWithValue("@Descripcion", Promocion.Descripcion);
                    command.Parameters.AddWithValue("@Restricciones", Promocion.Restricciones);
                    command.Parameters.AddWithValue("@FechaInicioVigencia", Promocion.FechaInicioVigencia);
                    command.Parameters.AddWithValue("@FechaFinVigencia", Promocion.FechaFinVigencia);

                    SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                    DataTable dtResponse = new DataTable();
                    connection.Open();
                    sqlDA.Fill(dtResponse);
                    connection.Close();
                    response.Message = dtResponse.Rows[0]["Message"].ToString() ?? "";
                    response.ResponseCode = Convert.ToInt32(dtResponse.Rows[0]["ResponseCode"]);
                }
            }
            catch (Exception e)
            {

                response.Message = "Un Error ha ocurrio: " + e.Message.ToString();
                response.ResponseCode = 0;
            }

            return response;

        }
        public Promociones GetPromocionDAL(long Id)
        {
            Promociones response = new Promociones();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GetPromocion";
                    command.Parameters.AddWithValue("@Id", Id);

                    SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                    DataTable dtResponse = new DataTable();
                    connection.Open();
                    sqlDA.Fill(dtResponse);
                    connection.Close(); 
                    response.Id = Convert.ToInt64(dtResponse.Rows[0]["Id"]);
                    response.Descripcion = dtResponse.Rows[0]["Descripcion"].ToString() ?? "";
                    response.Restricciones = dtResponse.Rows[0]["Restricciones"].ToString() ?? "";
                    response.FechaInicioVigencia = dtResponse.Rows[0]["FechaInicioVigencia"].ToString() ?? "";
                    response.FechaFinVigencia = dtResponse.Rows[0]["FechaFinVigencia"].ToString() ?? "";
                }
            }
            catch (Exception e)
            {

                
            }

            return response;

        }
        public ResponseData DeletePromocionDAL(long Id)
        {
            ResponseData response = new ResponseData();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "DeletePromocion";
                    command.Parameters.AddWithValue("@Id", Id);

                    SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                    DataTable dtResponse = new DataTable();
                    connection.Open();
                    sqlDA.Fill(dtResponse);
                    connection.Close();
                    response.Message = dtResponse.Rows[0]["Message"].ToString() ?? "";
                    response.ResponseCode = Convert.ToInt32(dtResponse.Rows[0]["ResponseCode"]);
                }
            }
            catch (Exception e)
            {

                response.Message = "Un Error ha ocurrio: " + e.Message.ToString();
                response.ResponseCode = 0;
            }

            return response;

        }
    }
}
