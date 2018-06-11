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
        SqlConnection _connection;
        string _connStr;
        ListBox _listRecipe;
        Populate _populate;

        public Functional(string connStr, ListBox listRecipe)
        {
            _connStr = connStr;
            _listRecipe = listRecipe;
        }

        public void InsertRecipe(TextBox addInstruction, TextBox RecipeName)
        {
            string query = "INSERT INTO Recipe VALUES(@RecipeName, @RecipeInstruction)";

            using (_connection = new SqlConnection(_connStr))
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                _connection.Open();

                command.Parameters.AddWithValue("@RecipeInstruction", addInstruction.Text);
                command.Parameters.AddWithValue("@RecipeName", RecipeName.Text);

                command.ExecuteNonQuery();
            }
            addInstruction.Text = "";
            RecipeName.Text = "";
            _populate = new Populate(_connStr);
            _populate.PopulateRecipes(_listRecipe);
        }

        //-------------------------------------------------------------------------------------

        public void UpdateRecipeName(TextBox updateName, ListBox listRecipes)
        {
            string query = "UPDATE Recipe SET Name = @RecipeName WHERE Id = @RecipeId";

            using (_connection = new SqlConnection(_connStr))
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                _connection.Open();

                command.Parameters.AddWithValue("@RecipeName", updateName.Text);
                command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);

                command.ExecuteNonQuery();
            }
            updateName.Text = "";
            _populate = new Populate(_connStr);
            _populate.PopulateRecipes(_listRecipe);

        }

        //----------------------------------------------------------------------------------------------

        public void AddToRecipe(ListBox listRecipes, ListBox listAllIngredients)
        {
            string query = "INSERT INTO Recipe_Ingredient VALUES(@RecipeId,@IngredientId)";

            using (_connection = new SqlConnection(_connStr))
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                _connection.Open();

                command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);
                command.Parameters.AddWithValue("@IngredientId", listAllIngredients.SelectedValue);

                command.ExecuteNonQuery();
            }
            _populate = new Populate(_connStr);
            _populate.PopulateRecipes(_listRecipe);
        }

        //------------------------------------------------------------------------------------------

        public void DeleteDish( ListBox listRecipes)
        {
            string query = "DELETE FROM Recipe_Ingredient WHERE Id_Recipe = @RecipeId; " +
                "DELETE FROM Recipe WHERE Id = @RecipeId";

            using (_connection = new SqlConnection(_connStr))
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                _connection.Open();

                command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);

                command.ExecuteNonQuery();
            }
            _populate = new Populate(_connStr);
            _populate.PopulateRecipes(_listRecipe);
        }

        //-----------------------------------------------------------------------------------------------

        public void InsertIngredient(TextBox addIngredient)
        {
            string query = "INSERT INTO Ingredient VALUES(@addIngredient)";

            using (_connection = new SqlConnection(_connStr))
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                _connection.Open();

                command.Parameters.AddWithValue("@addIngredient", addIngredient.Text);

                command.ExecuteNonQuery();
            }
            addIngredient.Text = "";
            _populate = new Populate(_connStr);
            _populate.PopulateRecipes(_listRecipe);
        }
    }
}