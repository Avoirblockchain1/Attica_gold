using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using attica_gold.Helpers;

namespace attica_gold.Models
{
    public class LoginViewModels
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }


        // <summary>
        /// Checks if user with given password exists in the database
        /// </summary>
        /// <param name="_username">User name</param>
        /// <param name="_password">User password</param>
        /// <returns>True if user exist and password is correct</returns>
        public LogIndetailsResp GetLoginDetails(string _username, string _password)
        {
            LogIndetailsResp resp = new LogIndetailsResp();
            var conStr = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString();

            try
            {
                using (var cn = new SqlConnection(conStr))
                {
                    var cmd = new SqlCommand();

                    cmd.Connection = cn;

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters
                        .Add(new SqlParameter("@userid", SqlDbType.NVarChar))
                        .Value = _username;
                    cmd.Parameters
                        .Add(new SqlParameter("@password", SqlDbType.NVarChar))
                        .Value = Helpers.SHA1.Encode(_password);
                    cn.Open();
                    var reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        resp.UserName = Convert.ToString(reader[0]);
                        resp.Role = Convert.ToString(reader[1]);
                        resp.IsUserActive = Convert.ToString(reader[2]);
                        resp.IsUserExists = Convert.ToString(reader[3]);
                        resp.IsUserIdPasswordmatched = Convert.ToString(reader[4]);

                        reader.Dispose();
                        cmd.Dispose();
                        return true;
                    }
                    else
                    {
                        reader.Dispose();
                        cmd.Dispose();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return resp;
        }
    }
}