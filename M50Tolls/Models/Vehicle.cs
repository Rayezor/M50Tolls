namespace M50Tolls.Models
{
    public class Vehicle
    {
        const double CarTollCharge = 2.00;
        const double PSVTollCharge = 2.80;
        const double BusTollCharge = 2.00;

        const double GoodsTollCharge = 4.10;

        const double DiscountPercentage = 0.2;

        public static String[] VehicleTypes
        {
            get
            {
                return new String[] { "Car", "PSV", "Bus", "Goods" };
            }
        }

        public String VehicleType { get; set; }
        public bool HasETag { get; set; }
        public double Charge
        {
            get
            {
                double toll = 0;
                if (VehicleType == "Car")
                {
                    toll = CarTollCharge;
                }
                else if (VehicleType == "PSV")
                {
                    toll = PSVTollCharge;
                }
                else if(VehicleType == "Bus")
                {
                    toll = BusTollCharge;
                }
                else if(VehicleType == "Goods")
                {
                    toll = GoodsTollCharge;
                }

                if (HasETag)
                {
                    toll *= (1.0 - DiscountPercentage);
                }
                return toll;
            }
        }
    }
}
