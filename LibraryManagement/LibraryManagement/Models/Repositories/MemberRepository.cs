using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManagement.Models
{
    internal class MemberRepository
    {
        public List<Member> members = new List<Member>();
        public DataTable GetAllMembers()
        {
            var data = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.connectionString))
                {
                    connection.Open();
                    var query = "SELECT * FROM Members ORDER BY MembershipDate DESC";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader()) data.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching members from database: {ex.Message}");
            }

            return data;
        }
        public bool RegisterMember(string name, string contactInfo)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Program.connectionString))
                {
                    connection.Open();
                    var query = @"INSERT INTO Members (Name, ContactInfo, MembershipDate) 
VALUES (@Name, @ContactInfo, @MembershipDate)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@ContactInfo", contactInfo);
                        cmd.Parameters.AddWithValue("@MembershipDate", DateTime.Now);

                        var rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering member: {ex.Message}");
                return false;
            }
        }
    }
}