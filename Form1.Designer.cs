namespace WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewFursonas = new DataGridView();
            fursonaTypeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fursonaTypeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fursonaTypeBindingSource = new BindingSource(components);
            dataGridViewSpecies = new DataGridView();
            speciesIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            speciesNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            speciessBindingSource = new BindingSource(components);
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFursonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fursonaTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpecies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)speciessBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFursonas
            // 
            dataGridViewFursonas.AutoGenerateColumns = false;
            dataGridViewFursonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFursonas.Columns.AddRange(new DataGridViewColumn[] { fursonaTypeIdDataGridViewTextBoxColumn, fursonaTypeNameDataGridViewTextBoxColumn });
            dataGridViewFursonas.DataSource = fursonaTypeBindingSource;
            dataGridViewFursonas.Location = new Point(12, 12);
            dataGridViewFursonas.Name = "dataGridViewFursonas";
            dataGridViewFursonas.RowTemplate.Height = 25;
            dataGridViewFursonas.Size = new Size(297, 391);
            dataGridViewFursonas.TabIndex = 0;
            dataGridViewFursonas.SelectionChanged += dataGridViewFursonas_SelectionChanged;
            // 
            // fursonaTypeIdDataGridViewTextBoxColumn
            // 
            fursonaTypeIdDataGridViewTextBoxColumn.DataPropertyName = "FursonaTypeId";
            fursonaTypeIdDataGridViewTextBoxColumn.HeaderText = "FursonaTypeId";
            fursonaTypeIdDataGridViewTextBoxColumn.Name = "fursonaTypeIdDataGridViewTextBoxColumn";
            fursonaTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fursonaTypeNameDataGridViewTextBoxColumn
            // 
            fursonaTypeNameDataGridViewTextBoxColumn.DataPropertyName = "FursonaTypeName";
            fursonaTypeNameDataGridViewTextBoxColumn.HeaderText = "Fursona Type";
            fursonaTypeNameDataGridViewTextBoxColumn.Name = "fursonaTypeNameDataGridViewTextBoxColumn";
            // 
            // fursonaTypeBindingSource
            // 
            fursonaTypeBindingSource.DataSource = typeof(FursonaType);
            // 
            // dataGridViewSpecies
            // 
            dataGridViewSpecies.AutoGenerateColumns = false;
            dataGridViewSpecies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSpecies.Columns.AddRange(new DataGridViewColumn[] { speciesIdDataGridViewTextBoxColumn, speciesNameDataGridViewTextBoxColumn });
            dataGridViewSpecies.DataSource = speciessBindingSource;
            dataGridViewSpecies.Location = new Point(315, 8);
            dataGridViewSpecies.Name = "dataGridViewSpecies";
            dataGridViewSpecies.RowTemplate.Height = 25;
            dataGridViewSpecies.Size = new Size(473, 395);
            dataGridViewSpecies.TabIndex = 1;
            // 
            // speciesIdDataGridViewTextBoxColumn
            // 
            speciesIdDataGridViewTextBoxColumn.DataPropertyName = "SpeciesId";
            speciesIdDataGridViewTextBoxColumn.HeaderText = "SpeciesId";
            speciesIdDataGridViewTextBoxColumn.Name = "speciesIdDataGridViewTextBoxColumn";
            speciesIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speciesNameDataGridViewTextBoxColumn
            // 
            speciesNameDataGridViewTextBoxColumn.DataPropertyName = "SpeciesName";
            speciesNameDataGridViewTextBoxColumn.HeaderText = "SpeciesName";
            speciesNameDataGridViewTextBoxColumn.Name = "speciesNameDataGridViewTextBoxColumn";
            // 
            // speciessBindingSource
            // 
            speciessBindingSource.DataMember = "Speciess";
            speciessBindingSource.DataSource = fursonaTypeBindingSource;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(713, 415);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewSpecies);
            Controls.Add(dataGridViewFursonas);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFursonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)fursonaTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpecies).EndInit();
            ((System.ComponentModel.ISupportInitialize)speciessBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewFursonas;
        private DataGridView dataGridViewSpecies;
        private Button buttonSave;
        private BindingSource fursonaTypeBindingSource;
        private BindingSource speciessBindingSource;
        private DataGridViewTextBoxColumn fursonaTypeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fursonaTypeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn speciesIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn speciesNameDataGridViewTextBoxColumn;
    }
}
