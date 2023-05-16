using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Ludgero
{
    internal class Desk
    {
        // Structure variables
        // Oi
        private double _width;
        private double _depth;
        private int _drawers;
        public double _surfaceArea;

        // Material variables
        public enum SurfaceMaterial
        {
            Laminate = 100,
            Oak = 200,
            Rosewood = 300,
            Veneer = 125,
            Pine = 50
        };
        private SurfaceMaterial _material;

        // Pricing variables
        private double _structurePrice;
        // private double _surfaceMaterialPrice;
        private double _drawersPrice;

        public Desk(double width, double depth, int drawers, SurfaceMaterial chosenMaterial)
        {
            _width = width;
            _depth = depth;
            _drawers = drawers;
            _material = chosenMaterial;
        }


        public double CalculateStructure()
        {
            // Princing the surface area
            double baseDeskPrice = 200;
            double surfaceArea = GetSurfaceArea();
            double pricePerInch = 1;
            if (surfaceArea > 1000)
            {
                baseDeskPrice = surfaceArea * pricePerInch;
            }

            // Pricing the drawers
            if (_drawers > 0)
            {
                _drawersPrice = _drawers * 50;
            }

            // Princing the surface material
            /* 
            switch (_material)
            {
                case (SurfaceMaterial.Laminate):
                    _surfaceMaterialPrice = 100;
                    break;
                case (SurfaceMaterial.Oak):
                    _surfaceMaterialPrice = 200;
                    break;
                case (SurfaceMaterial.Pine):
                    _surfaceMaterialPrice = 50;
                    break;
                case (SurfaceMaterial.Rosewood):
                    _surfaceMaterialPrice = 300;
                    break;
                case (SurfaceMaterial.Veneer):
                    _surfaceMaterialPrice = 125;
                    break;
            } 
            */

            // Test of Surface Price
            double surfaceValue = (double)_material;

            // Total Structure Price
            if (_drawers == 0)
            {
                _structurePrice = baseDeskPrice + surfaceValue;
            }
            else
                _structurePrice = baseDeskPrice + surfaceValue + _drawersPrice;

            return _structurePrice;
        }

        public double GetSurfaceArea()
        {
            return _surfaceArea = _width * _depth;
        }
    }
}
