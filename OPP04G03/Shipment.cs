using System;
using System.Collections.Generic;
using System.Text;

namespace OPP04G03
{
    internal abstract class Shipment
    {
        private string _Trackingcode;
        private string _Description;
        private decimal _Weight;
        private decimal _DeliveryFee;

        public string TrackingCode
        {
            get { return _Trackingcode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _Trackingcode = value;
                }
            }
        }
        public string Description

        {
            get { return _Description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Description = value;
                }
            }

        }
        public decimal Weight
        {
            get => _Weight;
            set
            {
                if (value > 0) _Weight = value;
            }
        }
        public decimal DeliveryFee
        {
            get { return DeliveryFee; }

            private set
            {
                if (value >= 0)
                {
                    DeliveryFee = value;
                }
            }

        }
        internal DeliveryAddress Destination { get; set; }

        public abstract decimal estimatedCost { get; }

        internal Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }
        public void updateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }

        }
        public void updateWeightAndDeliveryFee(decimal newWeight, double extrapackingweight)
        {
            if (newWeight > 0 && extrapackingweight >= 0)
            {
                Weight = newWeight + (decimal)extrapackingweight;
            }
        }
        public abstract void PrintShipment();
    }
}
