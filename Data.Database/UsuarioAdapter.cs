using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Data.Database
{
    public class UsuarioAdapter:Adapter
    {
       

        public List<Usuario> GetAll()
        {
            
            List<Usuario> usuarios = new List<Usuario>();
            this.OpenConnection();
            SqlCommand cmdUsuario = new SqlCommand("Select * from usuarios", SqlConn);
            SqlDataReader drUsuarios = cmdUsuario.ExecuteReader();
            while (drUsuarios.Read())
            {
                Usuario usr = new Usuario();
                usr.ID = (int)drUsuarios["id_usuario"];
                usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                usr.Clave = (string)drUsuarios["clave"];
                usr.Habilitado = (bool)drUsuarios["habilitado"];
                usr.Nombre = (string)drUsuarios["nombre"];
                usr.Apellido = (string)drUsuarios["apellido"];
                usr.Email = (string)drUsuarios["email"];
                usuarios.Add(usr);
            }
            //cerramos el dataReader 
            drUsuarios.Close();
            //cerramos la connexion
            this.CloseConnection();

            return usuarios;
        }

        public Business.Entities.Usuario GetOne(int ID)
        {

            //return Usuarios.Find(delegate(Usuario u) { return u.ID == ID; });
            Usuario usr = new Usuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("select * from usuarios where id_usuario = @id",SqlConn);
                cmdUsuario.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();
                if (drUsuario.Read())
                {
                    usr.ID = (int)drUsuario["id_usuario"];
                    usr.NombreUsuario = (string)drUsuario["nombre_usuario"];
                    usr.Clave = (string)drUsuario["clave"];
                    usr.Habilitado = (bool)drUsuario["habilitado"];
                    usr.Nombre = (string)drUsuario["nombre"];
                    usr.Apellido = (string)drUsuario["apellido"];
                    usr.Email = (string)drUsuario["email"];
                    
                }
                drUsuario.Close();
            }
            catch (Exception ex )
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los datos del usuario", ex); 

                throw ExcepcionManejada ;
            }
            finally
            {
                this.CloseConnection();
            }
            return usr; 
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete  from usuarios where id_usuario = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Usuario borrado con exito :)");
               
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el  usuario", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Usuario usuario) {

            try 
            {

                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand("insert into usuarios (nombre_usuario, clave, habilitado, nombre, apellido, email)"+
                    "values (@nombre_usuario, @clave, @habilitado, @nombre, @apellido, @email)" + 
                    "select @@identity",    //esta lanea es para recuperar el ID que asigna el sql automaticamente 
                    SqlConn);
                cmdSave.Parameters .Add( "@nombre_usuario", SqlDbType. VarChar, 50) . Value = usuario. NombreUsuario;
                cmdSave . Parameters. Add ( "@clave", SqlDbType. VarChar, 50) .Value = usuario. Clave;
                cmdSave . Parameters. Add ("@habilitado", SqlDbType.Bit) .Value = usuario. Habilitado;
                cmdSave. Parameters. Add ( "@nombre", SqlDbType. VarChar, 50) .Value = usuario. Nombre;
                cmdSave. Parameters. Add ("@apellido", SqlDbType.VarChar, 50) .Value = usuario. Apellido;
                cmdSave. Parameters. Add ("@email", SqlDbType.VarChar, 50) .Value = usuario.Email;
                usuario. ID = Decimal.ToInt32( (decimal)cmdSave.ExecuteScalar());
                MessageBox.Show("Usuario agregado con exito :)");
                //asi se obtiene el ID que asigna al BD automaticamente
            }
            catch (Exception Ex) {

                Exception Excepcionalejada = new Exception("Error al crear usuario", Ex); throw Excepcionalejada;
            }

            finally {

                this.CloseConnection();
            }

            }
        protected void Update(Usuario usuario)
        {

            try
            {

                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(

                "UPDATE usuarios SET nombre_usuario = @nombre_usuario, clave = @clave, " +
                "habilitado = @habilitado, nombre = @nombre, apellido = @apellido, email = @email " +
                "WHERE id_usuario=@id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = usuario.ID;
                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave; 
                cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido; 
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
                cmdSave.ExecuteNonQuery();
                MessageBox.Show("Usuario actualizado con exito :)");
            }
            catch (Exception Ex)
            {

                Exception Excepcionalejada = new Exception("Error al actualizar el usuario", Ex); throw Excepcionalejada;
            }

            finally
            {

                this.CloseConnection();
            }

        }

        public void Save(Usuario usuario)
        {

            if(usuario.State == BusinessEntity.States.Delete)
            {
                this.Delete(usuario.ID);

            }else if( usuario.State == BusinessEntity.States.New)
            {
                this.Insert(usuario);

            }else if( usuario.State == BusinessEntity.States.Modified)
            {
                this.Update(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified; 

        }
        public Usuario LogIn(string username , string password)
        {
            Usuario usr = null  ;
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("select usr.id_usuario , usr.nombre_usuario , per.tipo_persona from usuarios usr inner join personas per on usr.id_persona = per.id_persona where usr.nombre_usuario = @nombre_usuario AND usr.clave = @clave", SqlConn);
                cmdUsuario.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = password;
                cmdUsuario.Parameters.Add("@nombre_usuario", SqlDbType.VarChar,50).Value = username;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();
                if (drUsuario.Read())
                {
                    usr = new Usuario();
                    usr.ID = (int)drUsuario["id_usuario"];
                    usr.NombreUsuario = (string)drUsuario["nombre_usuario"];
                    //usr.Clave = (string)drUsuario["clave"];
                    //usr.Habilitado = (bool)drUsuario["habilitado"];
                    //usr.Nombre = (string)drUsuario["nombre"];
                    //usr.Apellido = (string)drUsuario["apellido"];
                    //usr.Email = (string)drUsuario["email"];
                    usr.TipoPersona = (int)drUsuario["tipo_persona"];

                }
                drUsuario.Close();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar los datos del usuario", ex);

                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return usr;
        }
    }
}
