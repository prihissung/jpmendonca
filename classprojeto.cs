using classcourse;
using Projetcts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Projeto
{
    public class Course : ICourse
    {
        string connectionString = @"Data Source=PRIHISSUNG;Initial Catalog=CadastroDB;Integrated Security=True;";
        public IEnumerable<Course> GetAllProjects()
        {
            List<Course> lstcourse = new List<Course>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT CourseId, Course, Nome from Projects", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Course course = new Course();
                    course.CourseId = Convert.ToInt32(rdr["CourseId"]);
                    course.Course = rdr["Course"].ToString();
                    course.Nome = rdr["Nome"].ToString();
                    lstfuncionario.Add(funcionario);
                }
                con.Close();
            }
            return lstcourse;
        }

        public void UpdateCourse(Course course)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comandoSQL = "Update Projects set Nome = @Nome, Course = @Course where CourseId = @CourseId";
                SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CourseId", course.CourseId);
                cmd.Parameters.AddWithValue("@Course", course.Course);
                cmd.Parameters.AddWithValue("@Nome", course.Nome);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteCourse(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string comandoSQL = "Delete from Projects where CourseId = @CourseId";
                SqlCommand cmd = new SqlCommand(comandoSQL, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CourseId", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }


    public void Create(Project projeto)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            cstring comandoSQL ="INSERT INTO Projects VALUES (@course, @nome)";
            SqlCommand cmd = new SqlCommand(comandoSQL, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@course", projeto.Course);
            cmd.Parameters.AddWithValue("@nome", projeto.Nome);

            cmd.ExecuteNonQuery();

            return Course;
        }
    }
}
//teste