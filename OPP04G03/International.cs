using System;
using System.Collections.Generic;
using System.Text;

namespace OPP04G03
{
    internal class International : Shipment
    {
        public International(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        public override decimal estimatedCost
        {
            get
            {
                return Weight * 5 + DeliveryFee;
            }
        }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered";
        }
        public decimal CalculateInsurance()
        {
            return estimatedCost * 0.12m;
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"International - Tracking Code: {TrackingCode}, Description: {Description}, Weight: {Weight} kg, Delivery Fee: ${DeliveryFee}, Destination: {Destination.GetFullAddress()}");

        }
    }
}
