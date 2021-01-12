using System;
using System.Collections.Generic;
using System.IO;
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

namespace ExamenApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //// Импорт клиентов.
            //var clientsData = File.ReadAllLines(@"D:\Work\ДЭ\2020-2021\День 1\Клиенты.txt");
            //for (int i = 0; i < clientsData.Count(); i++)
            //{
            //    var currentClient = clientsData[i].Split('\t');

            //    var clientForDB = new Client
            //    {
            //        LastName = currentClient[0],
            //        FirstName = currentClient[1],
            //        Patronymic = currentClient[2],
            //        GenderCode = currentClient[3],
            //        Phone = currentClient[4],
            //        Birthday = DateTime.Parse(currentClient[5]),
            //        Email = currentClient[6],
            //        RegistrationDate = DateTime.Parse(currentClient[7])
            //    };

            //    AppData.Context.Clients.Add(clientForDB);
            //    AppData.Context.SaveChanges();
            //}


            // Импорт услуг.
            var servicesData = File.ReadAllLines(@"D:\Work\ДЭ\2020-2021\День 1\Услуги.txt");
            for (int i = 0; i < servicesData.Count(); i++)
            {
                var currentService = servicesData[i].Split('\t');

                var serviceForDB = new Service
                {
                    Title = currentService[0].Trim(),
                    MainImage = File.ReadAllBytes(@"D:\Work\ДЭ\2020-2021\День 1\" 
                        + currentService[1].Trim()),
                    DurationInSeconds = Int32.Parse(currentService[2]),
                    Cost = Decimal.Parse(currentService[3]),
                    Discount = Double.Parse(currentService[4])
                };

                AppData.Context.Services.Add(serviceForDB);
                AppData.Context.SaveChanges();
            }






            //// Импорт услуг клиентов.
            //var clientServicesData = File.ReadAllLines(@"D:\Work\ДЭ\2020-2021\День 1\Услуги Клиента.txt");
            //for (int i = 0; i < clientServicesData.Count(); i++)
            //{
            //    var currentClientService = clientServicesData[i].Split('\t');

            //    var clientServiceForDB = new ClientService
            //    {
            //        ServiceID = AppData.Context.Services.ToList()
            //            .FirstOrDefault(p => p.Title == currentClientService[0]).ID,
            //        StartTime = DateTime.Parse(currentClientService[1]),
            //        ClientID = AppData.Context.Clients.ToList()
            //            .FirstOrDefault(p => p.LastName == currentClientService[2]).ID
            //    };

            //    AppData.Context.ClientServices.Add(clientServiceForDB);
            //    AppData.Context.SaveChanges();
            //}

        }
    }
}
