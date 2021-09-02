using System;

namespace Finde.Core.Domain
{
    public class Node
    {
        public string Address { get; protected set; }
        public double Latitude { get; protected set; }
        public double Longitude { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }

        protected Node()
        {
        }

        public Node(string address, double latitude, double longitude)
        {
            SetAddress(address);
            SetLatitude(latitude);
            SetLongitude(longitude);
        }

        public void SetAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                throw new Exception("Address can not be empty.");
            }

            Address = address;
            UpdatedAt = DateTime.UtcNow;
        }

        private void SetLatitude(double latitude)
        {
            if(double.IsNaN(latitude))
            {
                throw new Exception("Latitude must be a number.");
            }    
            if(Latitude == latitude)
            {
                return;
            }

            Latitude = latitude;
            UpdatedAt = DateTime.UtcNow;
        }

        private void SetLongitude(double longitude)
        {
            if(Longitude == longitude)
            {
                throw new Exception("Longitude must be a number.");
            }
            if(Longitude == longitude)
            {
                return;
            }

            Longitude = longitude;
            UpdatedAt = DateTime.UtcNow;
        }

        public static Node Create(string address, double latitude, double longitude)
            => new Node(address, latitude, longitude);
    }
}
