using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Yaji.Common;


namespace Yaji.DB
{
    public class DevalayaDB
    {

        public IList<DevalayaSummary> GetNewListings(int count)
        {
            
            SqlCommand command = new SqlCommand();
            command.CommandText = DBObjects.GET_NEW_DEVALAYA_LISTING;
            command.Parameters.AddWithValue("@count",count);

            IList<DevalayaSummary> listingSummary = new List<DevalayaSummary>();

            SqlDataReader  reader = DBHelper.ExecuteReader(command);

            while(reader.Read()){
                DevalayaSummary summary = new DevalayaSummary();
                summary.ID = Guid.Parse(reader["TempleID"].ToString());
                summary.Name = reader["Name"].ToString();
                summary.ShortDescription = reader["ShortDesciption"].ToString();
                summary.ThumbNailImage = reader["ThumbNailImage"].ToString();
                summary.NoOfFollowers = Convert.ToInt32(reader["NoOfFollowers"].ToString());
                listingSummary.Add(summary);
            }

            DBHelper.CloseConnection(command);
            return listingSummary;
        }

        public DevalayaDetails GetDetails(Guid Id)
        {

            SqlCommand command = new SqlCommand();
            command.CommandText = DBObjects.GET_DEVALAYA_DETAILS + " '" + Id.ToString() + "'"; //needs to change later
            //command.Parameters.AddWithValue("@Id", Id);

            DevalayaDetails dvDetails = new DevalayaDetails(); 
            SqlDataReader reader = DBHelper.ExecuteReader(command);

            while (reader.Read())
            {

                dvDetails.ID = Guid.Parse(reader["TempleID"].ToString());
                dvDetails.Name = reader["Name"].ToString();
                dvDetails.ShortDescription = reader["ShortDesciption"].ToString();
                dvDetails.Description = reader["Description"].ToString();
                dvDetails.ThumbnailImg = reader["ThumbNailImage"].ToString();
                dvDetails.NoOfFollowers = Convert.ToInt32(reader["NoOfFollowers"].ToString());
                dvDetails.SevaDetails = reader["SevaDetails"].ToString();
                dvDetails.SpecialOccasions = reader["SpecialOccassions"].ToString();
                dvDetails.TimingDetails = reader["TimingDetails"].ToString();
                dvDetails.MapLocation = reader["MapLocation"].ToString();
                dvDetails.HowToreach = reader["Howtoreach"].ToString();
                dvDetails.Contact = reader["ContactDetails"].ToString();
            }

            DBHelper.CloseConnection(command);
            return dvDetails;
        }
    }
}
