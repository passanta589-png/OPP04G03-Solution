using System;
using System.Collections.Generic;
using System.Text;

namespace OPP04G03
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
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
        public string GetTrackingstatus()
        {
            return $"Shipment{TrackingCode} is Ready .";
        }
        public decimal CalculateInsurance()
        {
            return estimatedCost * 0.05m;
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"Standard Shipment - Tracking Code: {TrackingCode}, Description: {Description}, Weight: {Weight} kg, Delivery Fee: ${DeliveryFee}");
        }
    }
}
