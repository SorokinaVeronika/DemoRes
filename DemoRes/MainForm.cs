using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DemoRes
{
    public partial class MainForm : Form
    {
        SqlConnection _connection;
        string _connectionString;

        Populate populate = new Populate();
        Functional functional = new Functional();


        public MainForm()
        {
            InitializeComponent();

            _connectionString = ConfigurationManager.ConnectionStrings["DemoRes.Properties.Settings.ResConnectionString"].ConnectionString;
        }

        //--------------------------------------------------------------------------------------

        private void MainForm_Load(object sender, EventArgs e)
        {
            populate.PopulateRecipes(_connection, _connectionString, listRecipes);
            populate.PopulateAllIngredients(_connection, _connectionString, listAllIngredients);
        }
        
        //--------------------------------------------------------------------------------------

        private void listRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate.PopulateIgredients(_connection, _connectionString, listIngredients, listRecipes);
            populate.PopulateInstructions(_connection, _connectionString, Insrtuction, listRecipes);
        }

        //--------------------------------------------------------------------------------------

        private void btnAddRecipe_Click_1(object sender, EventArgs e)
        {

            functional.InsertRecipe(_connection, _connectionString, addInstruction, RecipeName);
            populate.PopulateRecipes(_connection, _connectionString, listRecipes);
        }

        //--------------------------------------------------------------------------------------

        private void btnUpdateRecipeName_Click(object sender, EventArgs e)
        {
            functional.UpdateRecipeName(_connection, _connectionString, updateName, listRecipes);
            populate.PopulateRecipes(_connection, _connectionString, listRecipes);
        }

        //--------------------------------------------------------------------------------------

        private void btnAddToRecipe_Click(object sender, EventArgs e)
        {
            functional.AddToRecipe(_connection, _connectionString, listRecipes, listAllIngredients);
            populate.PopulateRecipes(_connection, _connectionString, listRecipes);
        }

        //-----------------------------------------------------------------------------------

        private void btnDeleteDish_Click(object sender, EventArgs e)
        {
            functional.DeleteDish(_connection, _connectionString, listRecipes);
            populate.PopulateRecipes(_connection, _connectionString, listRecipes);
        }
    }
}
