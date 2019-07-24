using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace EmailSender
{
    class BusinessLogic : Member
    {


        public IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

        public List<Member> SaMembers()
        {

            return this.db.Query<Member>("SELECT * FROM Members").ToList();


        }

        public List<Member> LesothoMembers()
        {

            return this.db.Query<Member>("SELECT * FROM Members").ToList();


        }

        public List<Member> TanzaniaMembers()
        {

            return this.db.Query<Member>("SELECT * FROM Members").ToList();


        }




    }
}
