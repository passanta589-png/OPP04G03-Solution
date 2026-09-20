using System;
using System.Collections.Generic;
using System.Text;

namespace OPP04G03
{
    internal class DeliveryCenter
    {
        private Shipment[] _shipments;
        private int _count;
        private int _Index;
        public DriveType driver { get; set; }

        public DeliveryCenter()
        {
            _shipments = new Shipment[10];
            _count = 0;
        }
        public Shipment this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }
                return _shipments[index];
            }
            set
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }
                _shipments[index] = value;
            }

        }
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < _count; i++)
                {
                    if (_shipments[i].TrackingCode == trackingCode)
                    {
                        return _shipments[i];


                    }
                }
                throw new KeyNotFoundException("Shipment with the specified tracking code not found.");
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            if (_count >= _shipments.Length)
            {
                Array.Resize(ref _shipments, _shipments.Length * 2);

                _shipments[_count] = shipment;
                _count++;
                return true;
            }
            return false;
        }
        public void PrintTrackingstatus()
        {
            foreach (Shipment Shipment in _shipments)
            {
                if (Shipment is ITrackable trackable)
                {
                    Console.WriteLine(trackable.GetTrackingStatus());
                }
            }
        }
        public void PrintAllShipments()
        {
            for (int i = 0; i < _count; i++)
            {
                _shipments[i].PrintShipment();
                Console.WriteLine();
            }
        }
    }
}
