
namespace WinAppDB2022
{
    partial class frmPers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label persIdLabel;
            System.Windows.Forms.Label naamLabel;
            System.Windows.Forms.Label voornaamLabel;
            System.Windows.Forms.Label straatLabel;
            System.Windows.Forms.Label nrLabel;
            System.Windows.Forms.Label geboortedateumLabel;
            System.Windows.Forms.Label postIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPers));
            System.Windows.Forms.Label postIdLabel1;
            System.Windows.Forms.Label postcodeLabel;
            System.Windows.Forms.Label gemeenteLabel;
            this.personeelsAdministratieDataSet = new WinAppDB2022.PersoneelsAdministratieDataSet();
            this.tablePersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablePersTableAdapter = new WinAppDB2022.PersoneelsAdministratieDataSetTableAdapters.TablePersTableAdapter();
            this.tableAdapterManager = new WinAppDB2022.PersoneelsAdministratieDataSetTableAdapters.TableAdapterManager();
            this.tablePersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tablePersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.persIdLabel1 = new System.Windows.Forms.Label();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.voornaamTextBox = new System.Windows.Forms.TextBox();
            this.straatTextBox = new System.Windows.Forms.TextBox();
            this.nrTextBox = new System.Windows.Forms.TextBox();
            this.geboortedateumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.postIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tablePostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablePostTableAdapter = new WinAppDB2022.PersoneelsAdministratieDataSetTableAdapters.TablePostTableAdapter();
            this.postIdLabel2 = new System.Windows.Forms.Label();
            this.postcodeLabel1 = new System.Windows.Forms.Label();
            this.gemeenteLabel1 = new System.Windows.Forms.Label();
            persIdLabel = new System.Windows.Forms.Label();
            naamLabel = new System.Windows.Forms.Label();
            voornaamLabel = new System.Windows.Forms.Label();
            straatLabel = new System.Windows.Forms.Label();
            nrLabel = new System.Windows.Forms.Label();
            geboortedateumLabel = new System.Windows.Forms.Label();
            postIdLabel = new System.Windows.Forms.Label();
            postIdLabel1 = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            gemeenteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personeelsAdministratieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersBindingNavigator)).BeginInit();
            this.tablePersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // persIdLabel
            // 
            persIdLabel.AutoSize = true;
            persIdLabel.Location = new System.Drawing.Point(43, 55);
            persIdLabel.Name = "persIdLabel";
            persIdLabel.Size = new System.Drawing.Size(56, 17);
            persIdLabel.TabIndex = 1;
            persIdLabel.Text = "Pers Id:";
            // 
            // naamLabel
            // 
            naamLabel.AutoSize = true;
            naamLabel.Location = new System.Drawing.Point(43, 84);
            naamLabel.Name = "naamLabel";
            naamLabel.Size = new System.Drawing.Size(49, 17);
            naamLabel.TabIndex = 3;
            naamLabel.Text = "Naam:";
            // 
            // voornaamLabel
            // 
            voornaamLabel.AutoSize = true;
            voornaamLabel.Location = new System.Drawing.Point(428, 86);
            voornaamLabel.Name = "voornaamLabel";
            voornaamLabel.Size = new System.Drawing.Size(77, 17);
            voornaamLabel.TabIndex = 5;
            voornaamLabel.Text = "Voornaam:";
            // 
            // straatLabel
            // 
            straatLabel.AutoSize = true;
            straatLabel.Location = new System.Drawing.Point(43, 140);
            straatLabel.Name = "straatLabel";
            straatLabel.Size = new System.Drawing.Size(50, 17);
            straatLabel.TabIndex = 7;
            straatLabel.Text = "Straat:";
            // 
            // nrLabel
            // 
            nrLabel.AutoSize = true;
            nrLabel.Location = new System.Drawing.Point(428, 142);
            nrLabel.Name = "nrLabel";
            nrLabel.Size = new System.Drawing.Size(27, 17);
            nrLabel.TabIndex = 9;
            nrLabel.Text = "Nr:";
            // 
            // geboortedateumLabel
            // 
            geboortedateumLabel.AutoSize = true;
            geboortedateumLabel.Location = new System.Drawing.Point(43, 197);
            geboortedateumLabel.Name = "geboortedateumLabel";
            geboortedateumLabel.Size = new System.Drawing.Size(119, 17);
            geboortedateumLabel.TabIndex = 11;
            geboortedateumLabel.Text = "Geboortedateum:";
            // 
            // postIdLabel
            // 
            postIdLabel.AutoSize = true;
            postIdLabel.Location = new System.Drawing.Point(43, 249);
            postIdLabel.Name = "postIdLabel";
            postIdLabel.Size = new System.Drawing.Size(55, 17);
            postIdLabel.TabIndex = 13;
            postIdLabel.Text = "Post Id:";
            // 
            // personeelsAdministratieDataSet
            // 
            this.personeelsAdministratieDataSet.DataSetName = "PersoneelsAdministratieDataSet";
            this.personeelsAdministratieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablePersBindingSource
            // 
            this.tablePersBindingSource.DataMember = "TablePers";
            this.tablePersBindingSource.DataSource = this.personeelsAdministratieDataSet;
            // 
            // tablePersTableAdapter
            // 
            this.tablePersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TablePersTableAdapter = this.tablePersTableAdapter;
            this.tableAdapterManager.TablePostTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WinAppDB2022.PersoneelsAdministratieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tablePersBindingNavigator
            // 
            this.tablePersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tablePersBindingNavigator.BindingSource = this.tablePersBindingSource;
            this.tablePersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tablePersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tablePersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tablePersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tablePersBindingNavigatorSaveItem});
            this.tablePersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tablePersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tablePersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tablePersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tablePersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tablePersBindingNavigator.Name = "tablePersBindingNavigator";
            this.tablePersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tablePersBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.tablePersBindingNavigator.TabIndex = 0;
            this.tablePersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tablePersBindingNavigatorSaveItem
            // 
            this.tablePersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tablePersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tablePersBindingNavigatorSaveItem.Image")));
            this.tablePersBindingNavigatorSaveItem.Name = "tablePersBindingNavigatorSaveItem";
            this.tablePersBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tablePersBindingNavigatorSaveItem.Text = "Save Data";
            this.tablePersBindingNavigatorSaveItem.Click += new System.EventHandler(this.tablePersBindingNavigatorSaveItem_Click);
            // 
            // persIdLabel1
            // 
            this.persIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePersBindingSource, "PersId", true));
            this.persIdLabel1.Location = new System.Drawing.Point(168, 55);
            this.persIdLabel1.Name = "persIdLabel1";
            this.persIdLabel1.Size = new System.Drawing.Size(200, 23);
            this.persIdLabel1.TabIndex = 2;
            this.persIdLabel1.Text = "label1";
            // 
            // naamTextBox
            // 
            this.naamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePersBindingSource, "Naam", true));
            this.naamTextBox.Location = new System.Drawing.Point(168, 81);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(200, 22);
            this.naamTextBox.TabIndex = 4;
            // 
            // voornaamTextBox
            // 
            this.voornaamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePersBindingSource, "Voornaam", true));
            this.voornaamTextBox.Location = new System.Drawing.Point(553, 83);
            this.voornaamTextBox.Name = "voornaamTextBox";
            this.voornaamTextBox.Size = new System.Drawing.Size(200, 22);
            this.voornaamTextBox.TabIndex = 6;
            // 
            // straatTextBox
            // 
            this.straatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePersBindingSource, "Straat", true));
            this.straatTextBox.Location = new System.Drawing.Point(168, 137);
            this.straatTextBox.Name = "straatTextBox";
            this.straatTextBox.Size = new System.Drawing.Size(200, 22);
            this.straatTextBox.TabIndex = 8;
            // 
            // nrTextBox
            // 
            this.nrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePersBindingSource, "Nr", true));
            this.nrTextBox.Location = new System.Drawing.Point(553, 139);
            this.nrTextBox.Name = "nrTextBox";
            this.nrTextBox.Size = new System.Drawing.Size(200, 22);
            this.nrTextBox.TabIndex = 10;
            // 
            // geboortedateumDateTimePicker
            // 
            this.geboortedateumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tablePersBindingSource, "Geboortedateum", true));
            this.geboortedateumDateTimePicker.Location = new System.Drawing.Point(168, 193);
            this.geboortedateumDateTimePicker.Name = "geboortedateumDateTimePicker";
            this.geboortedateumDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.geboortedateumDateTimePicker.TabIndex = 12;
            // 
            // postIdNumericUpDown
            // 
            this.postIdNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tablePersBindingSource, "PostId", true));
            this.postIdNumericUpDown.Location = new System.Drawing.Point(168, 249);
            this.postIdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.postIdNumericUpDown.Name = "postIdNumericUpDown";
            this.postIdNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.postIdNumericUpDown.TabIndex = 14;
            this.postIdNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.postIdNumericUpDown.ValueChanged += new System.EventHandler(this.postIdNumericUpDown_ValueChanged);
            // 
            // tablePostBindingSource
            // 
            this.tablePostBindingSource.DataMember = "TablePost";
            this.tablePostBindingSource.DataSource = this.personeelsAdministratieDataSet;
            // 
            // tablePostTableAdapter
            // 
            this.tablePostTableAdapter.ClearBeforeFill = true;
            // 
            // postIdLabel1
            // 
            postIdLabel1.AutoSize = true;
            postIdLabel1.Location = new System.Drawing.Point(428, 249);
            postIdLabel1.Name = "postIdLabel1";
            postIdLabel1.Size = new System.Drawing.Size(55, 17);
            postIdLabel1.TabIndex = 15;
            postIdLabel1.Text = "Post Id:";
            // 
            // postIdLabel2
            // 
            this.postIdLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePostBindingSource, "PostId", true));
            this.postIdLabel2.Location = new System.Drawing.Point(550, 251);
            this.postIdLabel2.Name = "postIdLabel2";
            this.postIdLabel2.Size = new System.Drawing.Size(100, 23);
            this.postIdLabel2.TabIndex = 16;
            this.postIdLabel2.Text = "label1";
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Location = new System.Drawing.Point(43, 288);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(71, 17);
            postcodeLabel.TabIndex = 17;
            postcodeLabel.Text = "Postcode:";
            // 
            // postcodeLabel1
            // 
            this.postcodeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePostBindingSource, "Postcode", true));
            this.postcodeLabel1.Location = new System.Drawing.Point(168, 288);
            this.postcodeLabel1.Name = "postcodeLabel1";
            this.postcodeLabel1.Size = new System.Drawing.Size(100, 23);
            this.postcodeLabel1.TabIndex = 18;
            this.postcodeLabel1.Text = "label1";
            // 
            // gemeenteLabel
            // 
            gemeenteLabel.AutoSize = true;
            gemeenteLabel.Location = new System.Drawing.Point(428, 288);
            gemeenteLabel.Name = "gemeenteLabel";
            gemeenteLabel.Size = new System.Drawing.Size(78, 17);
            gemeenteLabel.TabIndex = 19;
            gemeenteLabel.Text = "Gemeente:";
            // 
            // gemeenteLabel1
            // 
            this.gemeenteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablePostBindingSource, "Gemeente", true));
            this.gemeenteLabel1.Location = new System.Drawing.Point(550, 288);
            this.gemeenteLabel1.Name = "gemeenteLabel1";
            this.gemeenteLabel1.Size = new System.Drawing.Size(100, 23);
            this.gemeenteLabel1.TabIndex = 20;
            this.gemeenteLabel1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(postIdLabel1);
            this.Controls.Add(this.postIdLabel2);
            this.Controls.Add(postcodeLabel);
            this.Controls.Add(this.postcodeLabel1);
            this.Controls.Add(gemeenteLabel);
            this.Controls.Add(this.gemeenteLabel1);
            this.Controls.Add(persIdLabel);
            this.Controls.Add(this.persIdLabel1);
            this.Controls.Add(naamLabel);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(voornaamLabel);
            this.Controls.Add(this.voornaamTextBox);
            this.Controls.Add(straatLabel);
            this.Controls.Add(this.straatTextBox);
            this.Controls.Add(nrLabel);
            this.Controls.Add(this.nrTextBox);
            this.Controls.Add(geboortedateumLabel);
            this.Controls.Add(this.geboortedateumDateTimePicker);
            this.Controls.Add(postIdLabel);
            this.Controls.Add(this.postIdNumericUpDown);
            this.Controls.Add(this.tablePersBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personeelsAdministratieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersBindingNavigator)).EndInit();
            this.tablePersBindingNavigator.ResumeLayout(false);
            this.tablePersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePostBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PersoneelsAdministratieDataSet personeelsAdministratieDataSet;
        private System.Windows.Forms.BindingSource tablePersBindingSource;
        private PersoneelsAdministratieDataSetTableAdapters.TablePersTableAdapter tablePersTableAdapter;
        private PersoneelsAdministratieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tablePersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tablePersBindingNavigatorSaveItem;
        private System.Windows.Forms.Label persIdLabel1;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.TextBox voornaamTextBox;
        private System.Windows.Forms.TextBox straatTextBox;
        private System.Windows.Forms.TextBox nrTextBox;
        private System.Windows.Forms.DateTimePicker geboortedateumDateTimePicker;
        private System.Windows.Forms.NumericUpDown postIdNumericUpDown;
        private System.Windows.Forms.BindingSource tablePostBindingSource;
        private PersoneelsAdministratieDataSetTableAdapters.TablePostTableAdapter tablePostTableAdapter;
        private System.Windows.Forms.Label postIdLabel2;
        private System.Windows.Forms.Label postcodeLabel1;
        private System.Windows.Forms.Label gemeenteLabel1;
    }
}

