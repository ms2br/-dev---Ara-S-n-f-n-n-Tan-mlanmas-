using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ödev___Araç_Sınıfının_Tanımlanması
{
    class VehicleModels
    {
        public string Model;
        public string Marka;
        public int ModelYears;
        public double Km;
        public string FuelType;
        public string GearType;
        public int PurchasePrice;
        public int SalePrice;
        public int MaxDiscountAmount;
        public int Price;

        public VehicleModels()
        {

        }
        public VehicleModels(string _Model, string _Marka)
        {
            Model = _Model;
            Marka = _Marka;
        }
        public VehicleModels(string _Model, string _Marka, int _ModelYears)
        {
            Model = _Model;
            Marka = _Marka;
            ModelYears = _ModelYears;
        }

        public VehicleModels(string _Model, string _Marka, int _ModelYears, double _Km)
        {
            this.Model = _Model;
            this.Marka = _Marka;
            this.ModelYears = _ModelYears;
            this.Km = _Km;
        }

        public void ViewInformation()
        {
            Console.WriteLine("Model : {0}", Model);
            Console.WriteLine("Marka : {0}", Marka);
            Console.WriteLine("Model Yili : {0}", ModelYears);
            Console.WriteLine("Kilometre : {0}", Km);
            Console.WriteLine("Yakit Tipi : {0}", FuelType);
            Console.WriteLine("Vites Tipi : {0}", GearType);
            Console.WriteLine("Alis Fiyati : {0}", PurchasePrice);
            Console.WriteLine("Satis Fiyati : {0}", SalePrice);
            Console.WriteLine("Max Indirim Tutari : {0}", MaxDiscountAmount);
            Console.WriteLine("Son Fiyat : {0}", Price);
        }

        public void PriceOversight()
        {
            bool Oversight = false;
            for (; Oversight == false;)
            {
                Console.Write("Son Fiyat : ");
                Price = Convert.ToInt32(Console.ReadLine());
                if (SalePrice - MaxDiscountAmount <= Price && Price <= SalePrice)
                {
                    Oversight = true;
                    continue;
                }
                else
                {
                    Console.WriteLine("Girdiginiz Son Fitat Satis Fiyatindan Buyuk ve ya Indirm Fiyatini  Indirim Fiyatini Gectiniz");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("Yendiden Son Fiyati Giriniz");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }

        public bool GearOversight(bool _GearType)
        {

            switch (_GearType)
            {
                case true:
                    GearType = "Otomatik";
                    break;
                case false:
                    GearType = "Vites";
                    break;
            }
            return false;
        }

        public int ModelYearsOversight()
        {
            int _ModelYear = 0;
            bool YearsOversight = false;
            for (; YearsOversight == false;)
            {
                Console.Write("Model Yili : ");
                _ModelYear = Convert.ToInt32(Console.ReadLine());
                if (_ModelYear <= DateTime.Now.Year)
                {
                    YearsOversight = true;
                }
                else
                {
                    Console.Clear();
                    Console.Write("Girdigin Yil Cok Onde");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
            return _ModelYear;
        }

        public void FuelTypeOversight()
        {
            Console.WriteLine("1.Dizel");
            Console.WriteLine("2.Benzin");
            Console.WriteLine("3.LPG ");
            Console.WriteLine("4.Elektrik ");
            while (true)
            {
                Console.Write("Yakit Tipi : ");
                int _FuelType = Convert.ToInt32(Console.ReadLine());
                switch (_FuelType)
                {
                    case 1:
                        FuelType = "Dizel";
                        break;
                    case 2:
                        FuelType = "Benzin";
                        break;
                    case 3:
                        FuelType = "LPG";
                        break;
                    case 4:
                        FuelType = "Elektrik";
                        break;
                    default:
                        Console.WriteLine("Yanlis");
                        continue;
                }
                break;
            }
        }
    }
}
