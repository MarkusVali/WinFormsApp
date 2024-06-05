using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private SpeciesContext? dbContext;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new SpeciesContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.FursonaTypes.Load();

            this.fursonaTypeBindingSource.DataSource = dbContext.FursonaTypes.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void dataGridViewFursonas_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var fursonaType = (FursonaType)this.dataGridViewFursonas.CurrentRow.DataBoundItem;

                if (fursonaType != null)
                {
                    this.dbContext.Entry(fursonaType).Collection(e => e.Speciess).Load();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.dataGridViewFursonas.Refresh();
            this.dataGridViewSpecies.Refresh();
        }
    }
}
