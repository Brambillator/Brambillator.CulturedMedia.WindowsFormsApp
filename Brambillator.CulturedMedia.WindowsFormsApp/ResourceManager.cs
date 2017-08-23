using Brambillator.CulturedMedia.Domain.Models;
using Brambillator.CulturedMedia.Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace Brambillator.CulturedMedia.WindowsFormsApp
{
    public partial class ResourceManager : Form
    {
        ICulturedMediaUnitOfWork unitOfWork;
        Service.ResourceService resourceService;

        public ResourceManager()
        {
            InitializeComponent();

            string connectionStr = @"Server=(localdb)\MSSQLLocalDB;Database=CulturedMedia;Trusted_Connection=True;";

            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlServer(connectionStr);

            unitOfWork = new Repositories.EF.EFCulturedMediaUnitOfWork(optionsBuilder.Options);
            resourceService = new Service.ResourceService(unitOfWork);


            using (Service.CultureService cultureService = new Service.CultureService())
            {
                CultureModel[] cultures = cultureService.GetValidCultures();
                cboCultureNames.DataSource = cultures;
                cboCultureNames.DisplayMember = "CultureName";
            }
        }

        private void btnAddTextResource_Click(object sender, EventArgs e)
        {
            try
            {
                btnAddTextResource.Enabled = false;

                resourceService.AddTextResource(cboCultureNames.Text, txtKey.Text, txtTitle.Text, txtText.Text);
                unitOfWork.Commit();

                if (txtKey.Text.Equals(txtSearchKey.Text))
                {
                    searchForKey(txtSearchKey.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnAddTextResource.Enabled = true;
            }
        }

        private void btnListResources_Click(object sender, EventArgs e)
        {
            searchForKey(txtSearchKey.Text);
        }

        private void searchForKey(string key)
        {
            mainResourceGrid.DataSource = resourceService.GetResourceForAllCultures(key);
        }
    }
}
