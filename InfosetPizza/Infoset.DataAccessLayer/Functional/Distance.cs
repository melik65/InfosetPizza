using System;

namespace Infoset.DataAccessLayer.Functional
{

    public class Distance
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Distance(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        // converting from radian to degree
        private double RadToDeg(double rad)
        {
            return rad / Math.PI * 180.0;
        }
        // converting from degree to radian
        private double DegToRad(double deg)
        {
            return deg * Math.PI / 180.0;
        }

        //calculating distance by latitude and longitude
        public double CalcDistance(double latitude, double longitude)
        {
            double TetaVal = Longitude - longitude;
            double mil = Math.Sin(DegToRad(Latitude)) * Math.Sin(DegToRad(latitude)) +
            Math.Cos(DegToRad(Latitude)) * Math.Cos(DegToRad(latitude)) * Math.Cos(DegToRad(TetaVal));
            mil = Math.Acos(mil);
            mil = RadToDeg(mil);
            mil = mil * 60 * 1.1515;
            double kilometer = mil * 1.609344;
            return kilometer;

        }

    }
}


