namespace DemoRes
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.resDataSet = new DemoRes.ResDataSet();
            this.IdRecipe = new System.Windows.Forms.Label();
            this.listRecipes = new System.Windows.Forms.ListBox();
            this.listIngredients = new System.Windows.Forms.ListBox();
            this.lbIngredients = new System.Windows.Forms.Label();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.RecipeName = new System.Windows.Forms.TextBox();
            this.btnUpdateRecipeName = new System.Windows.Forms.Button();
            this.listAllIngredients = new System.Windows.Forms.ListBox();
            this.lbAllIngredients = new System.Windows.Forms.Label();
            this.btnAddToRecipe = new System.Windows.Forms.Button();
            this.Insrtuction = new System.Windows.Forms.ListBox();
            this.lbInstruction = new System.Windows.Forms.Label();
            this.lbNewRecipeAndUpdate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addInstruction = new System.Windows.Forms.TextBox();
            this.btnDeleteDish = new System.Windows.Forms.Button();
            this.updateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addIngredient = new System.Windows.Forms.Label();
            this.addIngredients = new System.Windows.Forms.TextBox();
            this.AddIngred = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // resDataSet
            // 
            this.resDataSet.DataSetName = "ResDataSet";
            this.resDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IdRecipe
            // 
            this.IdRecipe.AutoSize = true;
            this.IdRecipe.Location = new System.Drawing.Point(186, 13);
            this.IdRecipe.Name = "IdRecipe";
            this.IdRecipe.Size = new System.Drawing.Size(39, 13);
            this.IdRecipe.TabIndex = 0;
            this.IdRecipe.Text = "Dishes";
            // 
            // listRecipes
            // 
            this.listRecipes.FormattingEnabled = true;
            this.listRecipes.Location = new System.Drawing.Point(157, 39);
            this.listRecipes.Name = "listRecipes";
            this.listRecipes.Size = new System.Drawing.Size(120, 121);
            this.listRecipes.TabIndex = 1;
            this.listRecipes.SelectedIndexChanged += new System.EventHandler(this.listRecipes_SelectedIndexChanged);
            // 
            // listIngredients
            // 
            this.listIngredients.FormattingEnabled = true;
            this.listIngredients.Location = new System.Drawing.Point(15, 39);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.Size = new System.Drawing.Size(120, 95);
            this.listIngredients.TabIndex = 3;
            // 
            // lbIngredients
            // 
            this.lbIngredients.AutoSize = true;
            this.lbIngredients.Location = new System.Drawing.Point(12, 13);
            this.lbIngredients.Name = "lbIngredients";
            this.lbIngredients.Size = new System.Drawing.Size(59, 13);
            this.lbIngredients.TabIndex = 2;
            this.lbIngredients.Text = "Ingredients";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(633, 149);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(75, 23);
            this.btnAddRecipe.TabIndex = 4;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click_1);
            // 
            // RecipeName
            // 
            this.RecipeName.Location = new System.Drawing.Point(436, 63);
            this.RecipeName.Name = "RecipeName";
            this.RecipeName.Size = new System.Drawing.Size(272, 20);
            this.RecipeName.TabIndex = 5;
            // 
            // btnUpdateRecipeName
            // 
            this.btnUpdateRecipeName.Location = new System.Drawing.Point(159, 262);
            this.btnUpdateRecipeName.Name = "btnUpdateRecipeName";
            this.btnUpdateRecipeName.Size = new System.Drawing.Size(110, 23);
            this.btnUpdateRecipeName.TabIndex = 6;
            this.btnUpdateRecipeName.Text = "Update Name Recipe";
            this.btnUpdateRecipeName.UseVisualStyleBackColor = true;
            this.btnUpdateRecipeName.Click += new System.EventHandler(this.btnUpdateRecipeName_Click);
            // 
            // listAllIngredients
            // 
            this.listAllIngredients.FormattingEnabled = true;
            this.listAllIngredients.HorizontalScrollbar = true;
            this.listAllIngredients.Location = new System.Drawing.Point(436, 236);
            this.listAllIngredients.Name = "listAllIngredients";
            this.listAllIngredients.Size = new System.Drawing.Size(120, 95);
            this.listAllIngredients.TabIndex = 8;
            // 
            // lbAllIngredients
            // 
            this.lbAllIngredients.AutoSize = true;
            this.lbAllIngredients.Location = new System.Drawing.Point(433, 210);
            this.lbAllIngredients.Name = "lbAllIngredients";
            this.lbAllIngredients.Size = new System.Drawing.Size(73, 13);
            this.lbAllIngredients.TabIndex = 7;
            this.lbAllIngredients.Text = "All Ingredients";
            // 
            // btnAddToRecipe
            // 
            this.btnAddToRecipe.Location = new System.Drawing.Point(436, 340);
            this.btnAddToRecipe.Name = "btnAddToRecipe";
            this.btnAddToRecipe.Size = new System.Drawing.Size(120, 23);
            this.btnAddToRecipe.TabIndex = 9;
            this.btnAddToRecipe.Text = "Add To Recipe";
            this.btnAddToRecipe.UseVisualStyleBackColor = true;
            this.btnAddToRecipe.Click += new System.EventHandler(this.btnAddToRecipe_Click);
            // 
            // Insrtuction
            // 
            this.Insrtuction.FormattingEnabled = true;
            this.Insrtuction.Location = new System.Drawing.Point(12, 177);
            this.Insrtuction.Name = "Insrtuction";
            this.Insrtuction.Size = new System.Drawing.Size(123, 173);
            this.Insrtuction.TabIndex = 11;
            // 
            // lbInstruction
            // 
            this.lbInstruction.AutoSize = true;
            this.lbInstruction.Location = new System.Drawing.Point(12, 153);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(56, 13);
            this.lbInstruction.TabIndex = 10;
            this.lbInstruction.Text = "Instruction";
            // 
            // lbNewRecipeAndUpdate
            // 
            this.lbNewRecipeAndUpdate.AutoSize = true;
            this.lbNewRecipeAndUpdate.Location = new System.Drawing.Point(433, 37);
            this.lbNewRecipeAndUpdate.Name = "lbNewRecipeAndUpdate";
            this.lbNewRecipeAndUpdate.Size = new System.Drawing.Size(118, 13);
            this.lbNewRecipeAndUpdate.TabIndex = 13;
            this.lbNewRecipeAndUpdate.Text = "Enter a new dish name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter instructions:";
            // 
            // addInstruction
            // 
            this.addInstruction.Location = new System.Drawing.Point(436, 123);
            this.addInstruction.Multiline = true;
            this.addInstruction.Name = "addInstruction";
            this.addInstruction.Size = new System.Drawing.Size(272, 20);
            this.addInstruction.TabIndex = 17;
            // 
            // btnDeleteDish
            // 
            this.btnDeleteDish.Location = new System.Drawing.Point(157, 166);
            this.btnDeleteDish.Name = "btnDeleteDish";
            this.btnDeleteDish.Size = new System.Drawing.Size(75, 20);
            this.btnDeleteDish.TabIndex = 18;
            this.btnDeleteDish.Text = "Delete Dish";
            this.btnDeleteDish.UseVisualStyleBackColor = true;
            this.btnDeleteDish.Click += new System.EventHandler(this.btnDeleteDish_Click);
            // 
            // updateName
            // 
            this.updateName.Location = new System.Drawing.Point(157, 236);
            this.updateName.Name = "updateName";
            this.updateName.Size = new System.Drawing.Size(112, 20);
            this.updateName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Select a name for the update";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "and enter a new name:";
            // 
            // addIngredient
            // 
            this.addIngredient.AutoSize = true;
            this.addIngredient.Location = new System.Drawing.Point(620, 210);
            this.addIngredient.Name = "addIngredient";
            this.addIngredient.Size = new System.Drawing.Size(99, 13);
            this.addIngredient.TabIndex = 22;
            this.addIngredient.Text = "Add new Ingredient";
            // 
            // addIngredients
            // 
            this.addIngredients.Location = new System.Drawing.Point(623, 235);
            this.addIngredients.Name = "addIngredients";
            this.addIngredients.Size = new System.Drawing.Size(143, 20);
            this.addIngredients.TabIndex = 23;
            // 
            // AddIngred
            // 
            this.AddIngred.Location = new System.Drawing.Point(655, 262);
            this.AddIngred.Name = "AddIngred";
            this.AddIngred.Size = new System.Drawing.Size(111, 23);
            this.AddIngred.TabIndex = 24;
            this.AddIngred.Text = "Add Ingredient";
            this.AddIngred.UseVisualStyleBackColor = true;
            this.AddIngred.Click += new System.EventHandler(this.AddIngred_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.AddIngred);
            this.Controls.Add(this.addIngredients);
            this.Controls.Add(this.addIngredient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateName);
            this.Controls.Add(this.btnDeleteDish);
            this.Controls.Add(this.addInstruction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNewRecipeAndUpdate);
            this.Controls.Add(this.Insrtuction);
            this.Controls.Add(this.lbInstruction);
            this.Controls.Add(this.btnAddToRecipe);
            this.Controls.Add(this.listAllIngredients);
            this.Controls.Add(this.lbAllIngredients);
            this.Controls.Add(this.btnUpdateRecipeName);
            this.Controls.Add(this.RecipeName);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.listIngredients);
            this.Controls.Add(this.lbIngredients);
            this.Controls.Add(this.listRecipes);
            this.Controls.Add(this.IdRecipe);
            this.Name = "MainForm";
            this.Text = "CookBook";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ResDataSet resDataSet;
        private System.Windows.Forms.Label IdRecipe;
        private System.Windows.Forms.ListBox listRecipes;
        private System.Windows.Forms.ListBox listIngredients;
        private System.Windows.Forms.Label lbIngredients;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.TextBox RecipeName;
        private System.Windows.Forms.Button btnUpdateRecipeName;
        private System.Windows.Forms.ListBox listAllIngredients;
        private System.Windows.Forms.Label lbAllIngredients;
        private System.Windows.Forms.Button btnAddToRecipe;
        private System.Windows.Forms.ListBox Insrtuction;
        private System.Windows.Forms.Label lbInstruction;
        private System.Windows.Forms.Label lbNewRecipeAndUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addInstruction;
        private System.Windows.Forms.Button btnDeleteDish;
        private System.Windows.Forms.TextBox updateName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label addIngredient;
        private System.Windows.Forms.TextBox addIngredients;
        private System.Windows.Forms.Button AddIngred;
    }
}

