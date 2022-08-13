using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ödev___Araç_Sınıfının_Tanımlanması
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleModels VehicleModelsAccess = new VehicleModels();
            for (; ; )
            {
                Console.WriteLine("1.Ilan Ver");
                Console.WriteLine("2.Fiyat Listesi");
                Console.WriteLine("3.Cixis");
                Console.Write("Seciniz : ");
                int SelectValue = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (SelectValue)
                {
                    case 1:

                        Console.Write("Model : ");
                        string Model = Console.ReadLine();

                        Console.Write("Marka : ");
                        string Marka = Console.ReadLine();

                        int ModelYear = VehicleModelsAccess.ModelYearsOversight();

                        Console.Write("Kilometre : ");
                        double Km = Convert.ToDouble(Console.ReadLine());

                        VehicleModelsAccess = new VehicleModels(Model, Marka, ModelYear, Km);

                        VehicleModelsAccess.FuelTypeOversight();

                        Console.Write("Vites Tipi //Otomatik => true || Vites => false : ");
                        bool _GearType = Convert.ToBoolean(Console.ReadLine().ToLower());
                        VehicleModelsAccess.GearOversight(_GearType);

                        Console.Write("Alis Fiyati : ");
                        VehicleModelsAccess.PurchasePrice = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Satis Fiyati : ");
                        VehicleModelsAccess.SalePrice = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Max Indirim Tutari : ");
                        VehicleModelsAccess.MaxDiscountAmount = Convert.ToInt32(Console.ReadLine());

                        VehicleModelsAccess.PriceOversight();

                        Console.Clear();
                        continue;

                    case 2:
                        Console.Clear();
                        VehicleModelsAccess.ViewInformation();
                        Thread.Sleep(3000);
                        Console.Clear();
                        continue;

                    case 3:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Yanlis Secim");
                        Thread.Sleep(2000);
                        Console.WriteLine("Yeniden Seciniz");
                        Thread.Sleep(2000);
                        Console.Clear();
                        continue;
                }
                break;
            }
        }
    }
}

