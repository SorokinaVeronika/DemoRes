using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DemoRes
{
    class Populate
    {

        public void PopulateRecipes(SqlConnection connection, string connStr, ListBox list )
        {
            using (connection = new SqlConnection(connStr))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from Recipe", connStr))
            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

                list.DisplayMember = "Name";
                list.ValueMember = "Id";
                list.DataSource = recipeTable;
            }
        }

        //------------------------------------------------------------------------------------

        public void PopulateAllIngredients(SqlConnection connection, string connStr, ListBox list)
        {
            using (connection = new SqlConnection(connStr))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from Ingredient", connection))
            {
                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                list.DisplayMember = "Name";
                list.ValueMember = "Id";
                list.DataSource = ingredientTable;
            }
        }

        //--------------------------------------------------------------------------------------

        public void PopulateIgredients(SqlConnection connection, string connStr, ListBox list, ListBox listRecipes)
        {
            string query = "SELECT a.Name FROM Ingredient a " +
                "INNER JOIN Recipe_Ingredient b ON a.Id = b.Id_Ingredient " +
                "WHERE b.Id_Recipe = @Id_Recipe";

            using (connection = new SqlConnection(connStr))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Id_Recipe", listRecipes.SelectedValue);

                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                list.DisplayMember = "Name";
                list.ValueMember = "Id";
                list.DataSource = ingredientTable;
            }
        }

        //-------------------------------------------------------------------------------------

        public void PopulateInstructions(SqlConnection connection, string connStr, ListBox list, ListBox listRecipes)
        {
            string query = "SELECT Instructions FROM Recipe WHERE Id = @Id_Recipe";

            using (connection = new SqlConnection(connStr))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Id_Recipe", listRecipes.SelectedValue);

                DataTable instructionTable = new DataTable();
                adapter.Fill(instructionTable);

                list.DisplayMember = "Instructions";
                list.ValueMember = "Name";
                list.DataSource = instructionTable;
            }
        }


    }
}