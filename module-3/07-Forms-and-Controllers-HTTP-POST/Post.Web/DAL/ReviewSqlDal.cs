using Post.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.DAL
{
    public class ReviewSqlDal : IReviewDAL
    {
        private readonly string connectionString;
        private const string SQL_Get_All_Reviews = "SELECT * FROM reviews;";
        private const string SQL_Save_Review = "INSERT INTO reviews (username, rating, review_title, review_text, review_date) VALUES(@username, @rating, @title, @text, GETDATE()); SELECT CAST(SCOPE_IDENTITY() AS int);";

        public ReviewSqlDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all reviews
        /// </summary>
        /// <returns></returns>
        public IList<Review> GetAllReviews()
        {
            IList<Review> reviewList = new List<Review>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(SQL_Get_All_Reviews, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Review review = new Review();

                    review.Username = Convert.ToString(reader["username"]);
                    review.Rating = Convert.ToInt32(reader["rating"]);
                    review.Title = Convert.ToString(reader["review_title"]);
                    review.Text = Convert.ToString(reader["review_text"]);
                    review.Date = Convert.ToDateTime(reader["review_date"]);

                    reviewList.Add(review);
                }
            }

            return reviewList;
        }

        /// <summary>
        /// Saves a new review to the system.
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns></returns>
        public int SaveReview(Review newReview)
        {

            int newReviewID;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(SQL_Save_Review, conn);
                cmd.Parameters.AddWithValue("@username", newReview.Username);
                cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                cmd.Parameters.AddWithValue("@title", newReview.Title);
                cmd.Parameters.AddWithValue("@text", newReview.Text);

                newReviewID = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return newReviewID;
        }
    }
}
