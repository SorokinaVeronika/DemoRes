using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoRes
{
    class Functional
    {
        public void InsertRecipe(SqlConnection connection, string connStr, TextBox addInstruction, TextBox RecipeName)
        {
            string query = "INSERT INTO Recipe VALUES(@RecipeName, @RecipeInstruction)";

            using (connection = new SqlConnection(connStr))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RecipeInstruction", addInstruction.Text);
                command.Parameters.AddWithValue("@RecipeName", RecipeName.Text);

                command.ExecuteNonQuery();
            }
        }

        //-------------------------------------------------------------------------------------

        public void UpdateRecipeName(SqlConnection connection, string connStr, TextBox updateName, ListBox listRecipes)
        {
            string query = "UPDATE Recipe SET Name = @RecipeName WHERE Id = @RecipeId";

            using (connection = new SqlConnection(connStr))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RecipeName", updateName.Text);
                command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);

                command.ExecuteNonQuery();
            }

        }

        //----------------------------------------------------------------------------------------------

        public void AddToRecipe(SqlConnection connection, string connStr, ListBox listRecipes, ListBox listAllIngredients)
        {
            string query = "INSERT INTO Recipe_Ingredient VALUES(@RecipeId,@IngredientId)";

            using (connection = new SqlConnection(connStr))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);
                command.Parameters.AddWithValue("@IngredientId", listAllIngredients.SelectedValue);

                command.ExecuteNonQuery();
            }
        }

        //------------------------------------------------------------------------------------------

        public void DeleteDish(SqlConnection connection, string connStr, ListBox listRecipes)
        {
            string query = "DELETE FROM Recipe_Ingredient WHERE Id_Recipe = @RecipeId; " +
                "DELETE FROM Recipe WHERE Id = @RecipeId";

            using (connection = new SqlConnection(connStr))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);

                command.ExecuteNonQuery();
            }
        }
    }
}