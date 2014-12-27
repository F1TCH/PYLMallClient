using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;
using EWDTWebServiceApp.Models;
using EWDTApp;
using EWDTApp.Class;

namespace EWDTWebServiceApp.Models
{
    public class RentDBManager
    {
        public static bool Login(string input_username, string input_password)
        {
            bool successful = false;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.
                    ConnectionStrings["EWDTdbConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM UserAccount  WHERE username=@username and password=@password";
                comm.Parameters.AddWithValue("@username", input_username);
                comm.Parameters.AddWithValue("@password", input_password);
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read()) //dr.Read() will return true if there is at least one row
                {
                    successful = true;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }

            return successful;
        }

        public static int Register(UserAccount u)
        {
            int rowsinserted = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["EWDTdbConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO UserAccount(username, password, email)" +
                    " VALUES (@username, @password, @email)";
                comm.Parameters.AddWithValue("@username", u.username);
                comm.Parameters.AddWithValue("@password", u.password);
                comm.Parameters.AddWithValue("@email", u.email);
                rowsinserted = comm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsinserted;
        }

        public static int UpdateEmail(UserAccount u)
        {

            int rowsinserted = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["EWDTdbConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE UserAccount SET email=@email where username = @username";
                comm.Parameters.AddWithValue("@email", u.email);
                comm.Parameters.AddWithValue("@username", u.username);
                rowsinserted = comm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsinserted;
        }

        public static int UpdatePassword(UserAccount u)
        {

            int rowsinserted = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["EWDTdbConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE UserAccount SET password=@password where username = @username";
                comm.Parameters.AddWithValue("@password", u.password);
                comm.Parameters.AddWithValue("@username", u.username);
                rowsinserted = comm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsinserted;
        }

        public static string GetPassword(UserAccount u)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["EWDTdbConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT password FROM UserAccount where username = @username";
                comm.Parameters.AddWithValue("@username", u.username);
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    return dr.GetString(0);
                }
                dr.Close();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return "";
        }

        //public static int CreateBid(BidClass c)
        //{
        //    int rowsinserted = 0;

        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["EWDTdb"].ConnectionString;
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "INSERT INTO Bidding(BiddingAmt,Time,Date)" +
        //            " VALUES (@BiddingAmt,@Time,@Date)";
        //        comm.Parameters.AddWithValue("@BiddingAmt", c.BiddingAmt);
        //        comm.Parameters.AddWithValue("@Time", c.Time);
        //        comm.Parameters.AddWithValue("@Date", c.Date);
        //        rowsinserted = comm.ExecuteNonQuery();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //    return rowsinserted;
        //}

        //public static int RetrieveBid(BidClass r)
        //{
        //    int rowsinserted = 0;

        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["EWDTdb"].ConnectionString;
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "SELECT * FROM Bidding";

        //        comm.Parameters.AddWithValue("@BiddingAmt", r.BiddingAmt);
        //        comm.Parameters.AddWithValue("@Time", r.Time);
        //        comm.Parameters.AddWithValue("@Date", r.Date);
        //        rowsinserted = comm.ExecuteNonQuery();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //    return rowsinserted;
        //}

        //public static int UpdateBid(BidClass u)
        //{

        //    int rowsinserted = 0;

        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["EWDTdb"].ConnectionString;
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "UPDATE Bidding SET BiddingAmt=@BiddingAmt,Time=@Time,Date=@Date where BiddingAmt = '4468'";

        //        comm.Parameters.AddWithValue("@BiddingAmt", u.BiddingAmt);
        //        comm.Parameters.AddWithValue("@Time", u.Time);
        //        comm.Parameters.AddWithValue("@Date", u.Date);
        //        rowsinserted = comm.ExecuteNonQuery();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //    return rowsinserted;
        //}

        //public static int DeleteBid(double biddingamt)
        //{
        //    int rowsdeleted = 0;

        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["EWDTdb"].ConnectionString;
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "DELETE * FROM bidding where BiddingAmt=@BiddingAmt";
        //        comm.Parameters.AddWithValue("@BiddingAmt", biddingamt);
        //        rowsdeleted = comm.ExecuteNonQuery();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //    return rowsdeleted;
        //}


        //public static int CreateFloor(FloorPlanClass c)
        //{
        //    int rowsinserted = 0;

        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["EWDTdb"].ConnectionString;
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "INSERT INTO FloorPlan(Unit,UnitLevel,Name,Price,Condition,Imagefile)" +
        //            " VALUES (@Unit,@UnitLevel,@Name,@Price,@Condition,@Imagefile)";
        //        comm.Parameters.AddWithValue("@Unit", c.Unit);
        //        comm.Parameters.AddWithValue("@UnitLevel", c.UnitLevel);
        //        comm.Parameters.AddWithValue("@Name", c.Name);
        //        comm.Parameters.AddWithValue("@Price", c.Price);
        //        comm.Parameters.AddWithValue("@Condition", c.Condition);
        //        comm.Parameters.AddWithValue("@Imagefile", c.Imagefile);
        //        rowsinserted = comm.ExecuteNonQuery();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //    return rowsinserted;
        //}

        //public static int RetrieveFloor(FloorPlanClass r)
        //{
        //    int rowsinserted = 0;

        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["EWDTdb"].ConnectionString;
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "SELECT * FROM FloorPlan";

        //        comm.Parameters.AddWithValue("@Unit", r.Unit);
        //        comm.Parameters.AddWithValue("@UnitLevel", r.UnitLevel);
        //        comm.Parameters.AddWithValue("@Name", r.Name);
        //        comm.Parameters.AddWithValue("@Price", r.Price);
        //        comm.Parameters.AddWithValue("@Condition", r.Condition);
        //        comm.Parameters.AddWithValue("@Imagefile", r.Imagefile);
        //        rowsinserted = comm.ExecuteNonQuery();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //    return rowsinserted;
        //}

        //public static int UpdateFloor(FloorPlanClass u)
        //{

        //    int rowsinserted = 0;

        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["EWDTdb"].ConnectionString;
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "UPDATE FloorPlan SET Unit=@Unit,UnitLevel=@UnitLevel,Name=@Name,Price=@Price,Condition=@Condition,Imagefile=@Imagefile";

        //        comm.Parameters.AddWithValue("@Unit", u.Unit);
        //        comm.Parameters.AddWithValue("@UnitLevel", u.UnitLevel);
        //        comm.Parameters.AddWithValue("@Name", u.Name);
        //        comm.Parameters.AddWithValue("@Price", u.Price);
        //        comm.Parameters.AddWithValue("@Condition", u.Condition);
        //        comm.Parameters.AddWithValue("@Imagefile", u.Imagefile);
        //        rowsinserted = comm.ExecuteNonQuery();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //    return rowsinserted;
        //}

        //public static int DeleteFloor(string unit)
        //{
        //    int rowsdeleted = 0;

        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["EWDTdb"].ConnectionString;
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "DELETE * FROM Floorplan where Unit=@Unit";
        //        comm.Parameters.AddWithValue("@Unit", unit);
        //        rowsdeleted = comm.ExecuteNonQuery();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //    return rowsdeleted;
        //}




        //public static ArrayList GetAllBid()
        //{
        //    ArrayList result = new ArrayList();
        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["EWDTdbConnectionString"].ConnectionString;
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "SELECT * from Bidding";
        //        SqlDataReader dr = comm.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            BidClass b = new BidClass();
        //            b.BiddingAmt = (double)dr["BiddingAmt"];
        //            b.Date = (string)dr["Date"];
        //            b.Time = (string)dr["Time"];
        //            result.Add(b);
        //        }
        //        dr.Close();
        //        conn.Close();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //    return result;
        //}

        //public static BidClass GetBidBy(int id)
        //{
        //    Class m = null;
        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["MusicDBConnectionString"].ConnectionString;
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "SELECT * FROM music WHERE Musicid=@musicid";
        //        comm.Parameters.AddWithValue("@musicid", id);
        //        SqlDataReader dr = comm.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            m = new Class();
        //            m.Musicid = (int)dr["Musicid"];
        //            m.Title = (string)dr["Title"];
        //            m.Genre = (string)dr["Genre"];
        //            m.Imagefile = (string)dr["Imagefile"];
        //            m.Price = Convert.ToDouble((decimal)dr["Price"]);
        //            m.Username = (string)dr["Username"];
        //        }
        //        dr.Close();
        //        conn.Close();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }

        //    return m;

        //}

        //public static ArrayList GetMusicByGenre(string genre)
        //{
        //    ArrayList result = new ArrayList();
        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["MusicDBConnectionString"].ConnectionString;
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "SELECT * FROM music WHERE genre=@genre";
        //        comm.Parameters.AddWithValue("@genre", genre);
        //        //comm.Parameters.AddWithValue("@username", username);
        //        SqlDataReader dr = comm.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            Class m = new Class();
        //            m.Musicid = (int)dr["Musicid"];
        //            m.Title = (string)dr["Title"];
        //            m.Genre = (string)dr["Genre"];
        //            m.Imagefile = (string)dr["Imagefile"];
        //            m.Price = Convert.ToDouble((decimal)dr["Price"]);
        //            m.Username = (string)dr["Username"];
        //            result.Add(m);
        //        }

        //        dr.Close();
        //        conn.Close();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }

        //    return result;
        //}

        //public static ArrayList GetMusicByUser(string username)
        //{
        //    ArrayList result = new ArrayList();
        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["MusicDBConnectionString"].ConnectionString;
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "SELECT * FROM music WHERE username=@username";
        //        //comm.Parameters.AddWithValue("@genre", genre);
        //        comm.Parameters.AddWithValue("@username", username);
        //        SqlDataReader dr = comm.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            Class m = new Class();
        //            m.Musicid = (int)dr["Musicid"];
        //            m.Title = (string)dr["Title"];
        //            m.Genre = (string)dr["Genre"];
        //            m.Imagefile = (string)dr["Imagefile"];
        //            m.Price = Convert.ToDouble((decimal)dr["Price"]);
        //            result.Add(m);
        //        }

        //        dr.Close();
        //        conn.Close();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }

        //    return result;
        //}

        //public static int InsertMusic(Class m)
        //{
        //    int rowsinserted = 0;

        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["MusicDBConnectionString"].ConnectionString;
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "INSERT INTO music(title,genre,imagefile,price,username)" +
        //            " VALUES (@title,@genre,@imagefile,@price,@username)";
        //        comm.Parameters.AddWithValue("@title", m.Title);
        //        comm.Parameters.AddWithValue("@genre", m.Genre);
        //        comm.Parameters.AddWithValue("@imagefile", m.Imagefile);
        //        comm.Parameters.AddWithValue("@price", m.Price);
        //        comm.Parameters.AddWithValue("@username", m.Username);
        //        rowsinserted = comm.ExecuteNonQuery();
        //        conn.Close();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //    return rowsinserted;
        //}
        //public static int UpdateMusic(Class m)
        //{
        //    int rowsupdated = 0;

        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["MusicDBConnectionString"].ConnectionString;
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "UPDATE music SET Title=@title,Genre=@genre,Price=@price,Imagefile=@imagefile,Username=@username where Musicid=@musicid";
        //        comm.Parameters.AddWithValue("@title", m.Title);
        //        comm.Parameters.AddWithValue("@genre", m.Genre);
        //        comm.Parameters.AddWithValue("@price", m.Price);
        //        comm.Parameters.AddWithValue("@imagefile", m.Imagefile);
        //        comm.Parameters.AddWithValue("@username", m.Username);
        //        comm.Parameters.AddWithValue("@musicid", m.Musicid);
        //        rowsupdated = comm.ExecuteNonQuery();
        //        conn.Close();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //    return rowsupdated;
        //}

        //public static int DeleteMusic(int musicid)
        //{
        //    int rowsdeleted = 0;

        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = ConfigurationManager.ConnectionStrings["MusicDBConnectionString"].ConnectionString;
        //        conn.Open();
        //        SqlCommand comm = new SqlCommand();
        //        comm.Connection = conn;
        //        comm.CommandText = "Delete from Music where musicid=@musicid";
        //        comm.Parameters.AddWithValue("@musicid", musicid);
        //        rowsdeleted = comm.ExecuteNonQuery();
        //    }
        //    catch (SqlException e)
        //    {
        //        throw e;
        //    }
        //    return rowsdeleted;
        //}
    }
}