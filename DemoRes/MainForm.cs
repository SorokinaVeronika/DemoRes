using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DemoRes
{
    public partial class MainForm : Form
    {
        string _connectionString;

        Populate populate;
        Functional functional;
        
        public MainForm()
        {
            InitializeComponent();

            _connectionString = ConfigurationManager.ConnectionStrings["DemoRes.Properties.Settings.ResConnectionString"].ConnectionString;
            functional = new Functional( _connectionString, listRecipes);
            populate = new Populate( _connectionString);
        }

        //--------------------------------------------------------------------------------------

        private void MainForm_Load(object sender, EventArgs e)
        {
            populate.PopulateRecipes(listRecipes);
            populate.PopulateAllIngredients(listAllIngredients);
        }
        
        //--------------------------------------------------------------------------------------

        private void listRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate.PopulateIgredients(listIngredients, listRecipes);
            populate.PopulateInstructions(Insrtuction, listRecipes);
        }

        //--------------------------------------------------------------------------------------

        private void btnAddRecipe_Click_1(object sender, EventArgs e)
        {

            functional.InsertRecipe(addInstruction, RecipeName);

        }

        //--------------------------------------------------------------------------------------

        private void btnUpdateRecipeName_Click(object sender, EventArgs e)
        {
            functional.UpdateRecipeName(updateName, listRecipes);
        }

        //--------------------------------------------------------------------------------------

        private void btnAddToRecipe_Click(object sender, EventArgs e)
        {
            functional.AddToRecipe(listRecipes, listAllIngredients);

        }

        //-----------------------------------------------------------------------------------

        private void btnDeleteDish_Click(object sender, EventArgs e)
        {
            functional.DeleteDish(listRecipes);

        }

        private void AddIngred_Click(object sender, EventArgs e)
        {
            functional.InsertIngredient(addIngredients);

        }
    }
}
