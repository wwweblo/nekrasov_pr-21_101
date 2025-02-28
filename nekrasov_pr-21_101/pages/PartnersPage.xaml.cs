using nekrasov_pr_21_101.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для PartnersPage.xaml
    /// </summary>
    public partial class PartnersPage : Page
    {
        public PartnersPage()
        {
            InitializeComponent();
            LoadPartners();
        }

        private Model1 db = new Model1();

        private void LoadPartners()
        {
            var request = db.Partners
                .Select(r => new
                {
                    r.id,
                    Type = db.PartnerType
                                    .Where(n => n.id == r.Тип_партнера)
                                    .Select(n => n.Тип_партнера)
                                    .FirstOrDefault() ?? "Тип",
                    r.Наименование_партнера,
                    Name = db.Name
                                    .Where(n => n.id == r.name)
                                    .Select(n => n.Name1)
                                    .FirstOrDefault() ?? "Имя",
                    Surname = db.Surname
                                    .Where(s => s.id == r.surname)
                                    .Select(n => n.Name)
                                    .FirstOrDefault() ?? "Фамилия",
                    Middlename = db.Middlename
                                    .Where(m => m.id == r.middlename)
                                    .Select(n => n.MiddleName1)
                                    .FirstOrDefault() ?? "Отчество",
                    r.Электронная_почта_партнера,
                    r.Телефон_партнера,
                    r.Юридический_адрес_партнера,
                    r.ИНН,
                    r.Рейтинг

                })
                .ToList();

            PartnersGrid.ItemsSource = request;
        }

        private void PartnersGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PartnersGrid.SelectedItem != null)
            {
                var selectedRow = (dynamic)PartnersGrid.SelectedItem;
                string partnerid = Convert.ToInt64(selectedRow.id);

                NavigationService.Navigate(new PartnerPage(partnerid));

            }
        }
    }
}
