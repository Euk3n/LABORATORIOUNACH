using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

public class LoginService:ILogin
{
//     public async Task<bool> IniciarSesion(User user)
//     {
        
//    bool Resultado=false;

//     using (var sqlConnection=new SqlConnection())
//      {
//      try
//      {
//      var Comando=new SqlCommand();
//      Comando.Connection=sqlConnection;
//      Comando.CommandText="[dbo].[Autentificar]";
//      Comando.CommandType=System.Data.CommandType.StoredProcedure;
//      Comando.Parameters.AddWithValue("@Usuario",user.Correo);
//      Comando.Parameters.AddWithValue("@Password",user.PassWord);

//     await sqlConnection.OpenAsync();
//     var lectura=await Comando.ExecuteReaderAsync();
//     if(lectura.HasRows)
//     {
//      if(lectura.Read())
//      {
//     Resultado=true;

//         }
//      }else{
//         Resultado=false;
//      }


//      }
//      catch (System.Exception ex)
//       {
//     Resultado=false;


//      } 
//      }

//      return Resultado;
//      return true;
//     }
    public async Task<bool> IniciarSesion(User user)
    {
        using (var conexion=new LabDBContex())
        {
            var consulta= await (from c in conexion.Docente 
            where c.Correo==user.Correo
            && c.PassWord==user.PassWord
            select c).FirstOrDefaultAsync();
            if(consulta!=null) 
            {
                return true;
            }else{
                return false;
            }
            
        }
    }
}