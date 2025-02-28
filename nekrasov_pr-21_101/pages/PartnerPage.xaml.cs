using nekrasov_pr_21_101.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace nekrasov_pr_21_101.pages
{
    /// <summary>
    /// Логика взаимодействия для PartnerPage.xaml
    /// </summary>
    public partial class PartnerPage : Page
    {

        private float partnerId;
        private Model1 db = new Model1();
        public PartnerPage(float partnerId)
        {
            InitializeComponent();
            this.partnerId = partnerId;
            LoadPartner(this.partnerId);
        }

        private void LoadPartner(float partnerId)
        {
            var request = db.Partners
                .Where(r => r.id == partnerId)
                .FirstOrDefault();

            TypeBox.Text = request.Тип_партнера.ToString();
            NameBox.Text = request.Наименование_партнера.ToString();
            DirectorNameBox.Text = request.name.ToString();
            DirectorSurnameBox.Text = request.surname.ToString();
            DirectorMiddlenameBox.Text = request.surname.ToString();


        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var partner = db.Partners.Where(p => p.id == partnerId).FirstOrDefault();
            db.Partners.Remove(partner);
        }


    }
}
