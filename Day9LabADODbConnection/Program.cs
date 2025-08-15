//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;



namespace Day9LabADODbConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ ADO .Net -----------");
            #region Session Part 1
            //CRUD Operation ADO.Net
            //Connection SQL DB

            ////1- Create SQL Connection  
            //SqlConnection conn = new SqlConnection();
            ////2- connection string 
            //conn.ConnectionString = "Data Source=SAYEDHAWAS\\DEPI2025R3;Initial Catalog=ADOTest;Integrated Security=True";
            ////3- Open Connection 
            //conn.Open();

            ////4- Sql Command 
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = conn;
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = "Select * from Students";
            //SqlDataReader dr = cmd.ExecuteReader();

            //if (dr.HasRows)
            //{
            //    while (dr.Read())
            //    {
            //        Console.WriteLine($"ID: {dr[0]} Name : {dr[1]} Mark : {dr[2]}");
            //    }
            //}
            //conn.Close();

            const string ConnectionString = "Data Source=SAYEDHAWAS\\DEPI2025R3;Initial Catalog=ADOTest;Integrated Security=True;Trust Server Certificate=True";


            Console.WriteLine("-------------   Student Tables -----------");
            //1- Create SQL Connection  
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmdCounter = new SqlCommand("Select count(*) from Students", conn);
                int RowCounter = (int)cmdCounter.ExecuteScalar();
                Console.WriteLine($" Student Rows No:. {RowCounter}");
                Console.WriteLine("------------------------------------------------");
                SqlCommand cmdmax = new SqlCommand("Select max(mark) from Students", conn);
                int MaxMark = (int)cmdmax.ExecuteScalar();
                Console.WriteLine($" Student Max Mark:. {MaxMark}");
                Console.WriteLine("------------------------------------------------");
                SqlCommand cmd = new SqlCommand("Select * from Students", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine($"ID: {dr[0]} Name : {dr[1]} Mark : {dr[2]}");
                    }
                }


            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Insert Data : ");
            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your Mark : ");
            int mark;
            int.TryParse(Console.ReadLine(), out mark);

            string strInsert = $"Insert Into Students (name , mark)values ('{name}',{mark})";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmdInsert = new SqlCommand(strInsert, conn);
                int Row = cmdInsert.ExecuteNonQuery();
                Console.WriteLine($"Insert {Row} Row ... ");

                Console.WriteLine("------------------------------------------------");
                SqlCommand cmd = new SqlCommand("Select * from Students", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine($"ID: {dr[0]} Name : {dr[1]} Mark : {dr[2]}");
                    }
                }
            }


            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Update Data : ");
            Console.Write("Enter your Id : ");
            int id;
            int.TryParse(Console.ReadLine(), out id);

            Console.Write("Enter your Name : ");
            string name2 = Console.ReadLine();
            Console.Write("Enter your Mark : ");
            int mark2;
            int.TryParse(Console.ReadLine(), out mark2);

            string strUpdate = $"Update Students set name = '{name2}' , mark = {mark2} Where Id = {id}";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmdInsert = new SqlCommand(strUpdate, conn);
                int Row = cmdInsert.ExecuteNonQuery();
                Console.WriteLine($"update {Row} Row ... ");

                Console.WriteLine("------------------------------------------------");
                SqlCommand cmd = new SqlCommand("Select * from Students", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine($"ID: {dr[0]} Name : {dr[1]} Mark : {dr[2]}");
                    }
                }
            }


            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Delete Data : ");
            Console.Write("Enter your Id : ");
            int idDelete;
            int.TryParse(Console.ReadLine(), out idDelete);

            string strDelete = $"Delete from  Students Where Id = {idDelete}";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmdInsert = new SqlCommand(strDelete, conn);
                int Row = cmdInsert.ExecuteNonQuery();
                Console.WriteLine($"Delete {Row} Row ... ");

                Console.WriteLine("------------------------------------------------");
                SqlCommand cmd = new SqlCommand("Select * from Students", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine($"ID: {dr[0]} Name : {dr[1]} Mark : {dr[2]}");
                    }
                }
            }

            Console.ReadLine();
            #endregion
        }
    }
}
