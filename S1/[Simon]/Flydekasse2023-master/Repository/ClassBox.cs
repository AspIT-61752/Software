namespace Repository
{
    public class ClassBox : ClassNotify
    {
        private double _boxHeight;
        private double _boxDepth;
        private double _boxWide;
        private double _boxVolume;
        private double _boxBuoyancy;
        private double _boxWeight;
        private double _materialDim;
        private double _boxInnerVolumen;
        private string _boxHeightStr;
        private string _boxWideStr;
        private string _materialDimStr;
        private string _boxDepthStr;
        private string _warningDim;

        private ClassMaterial _boxMaterial;

        public ClassBox()
        {
            boxMaterial = new ClassMaterial();
            boxDepthStr = "0";
            boxHeightStr = "0";
            boxWideStr = "0";
            boxVolume = 0D;
            boxBuoyancy = 0D;
            boxWeight = 0D;
            boxInnerVolumen = 0D;
            materialDimStr = "0";
            warningDim = "Hidden";
        }

        public ClassBox(ClassBox inBox)
        {
            boxMaterial = new ClassMaterial(inBox.boxMaterial);
            boxDepthStr = inBox.boxDepthStr;
            boxHeightStr = inBox.boxHeightStr;
            boxWideStr = inBox.boxWideStr;
            boxVolume = inBox.boxVolume;
            boxBuoyancy = inBox.boxBuoyancy;
            boxWeight = inBox.boxWeight;
            boxInnerVolumen = inBox.boxInnerVolumen;
            materialDimStr = inBox.materialDimStr;
            warningDim = inBox.warningDim;
        }


        public string warningDim
        {
            get { return _warningDim; }
            set
            {
                if (_warningDim != value)
                {
                    _warningDim = value;
                }
                Notify("warningDim");
            }
        }


        public ClassMaterial boxMaterial
        {
            get { return _boxMaterial; }
            set
            {
                if (_boxMaterial != value)
                {
                    _boxMaterial = value;
                }
                Notify("boxMaterial");
            }
        }


        public string boxDepthStr
        {
            get { return _boxDepthStr; }
            set
            {
                if (_boxDepthStr != value)
                {
                    if (double.TryParse(value, out double X))
                    {
                        _boxDepthStr = value;
                        boxDepth = X;
                        CalculateAll();
                    }
                }
                Notify("boxDepthStr");
            }
        }


        public string materialDimStr
        {
            get { return _materialDimStr; }
            set
            {
                if (_materialDimStr != value)
                {
                    if (double.TryParse(value, out double X))
                    {
                        _materialDimStr = value;
                        materialDim = X;
                        CalculateAll();
                    }

                }
                Notify("materialDimStr");
            }
        }


        public string boxWideStr
        {
            get { return _boxWideStr; }
            set
            {
                if (_boxWideStr != value)
                {
                    if (double.TryParse(value, out double X))
                    {
                        _boxWideStr = value;
                        boxWide = X;
                        CalculateAll();
                    }
                }
                Notify("boxWideStr");
            }
        }


        public string boxHeightStr
        {
            get { return _boxHeightStr; }
            set
            {
                if (_boxHeightStr != value)
                {
                    if (double.TryParse(value, out double X))
                    {
                        _boxHeightStr = value;
                        boxHeight = X;
                        CalculateAll();
                    }
                }
                Notify("boxHeightStr");
            }
        }


        public double boxInnerVolumen
        {
            get { return _boxInnerVolumen; }
            set
            {
                if (_boxInnerVolumen != value)
                {
                    _boxInnerVolumen = value;
                }
                Notify("boxInnerVolumen");
            }
        }


        public double materialDim
        {
            get { return _materialDim; }
            set
            {
                if (_materialDim != value)
                {
                    _materialDim = value;
                }
                Notify("materialDim");
            }
        }


        public double boxWeight
        {
            get { return _boxWeight; }
            set
            {
                if (_boxWeight != value)
                {
                    _boxWeight = value;
                }
                Notify("boxWeight");
            }
        }


        public double boxBuoyancy
        {
            get { return _boxBuoyancy; }
            set
            {
                if (_boxBuoyancy != value)
                {
                    _boxBuoyancy = value;
                }
                Notify("boxBuoyancy");
            }
        }


        public double boxVolume
        {
            get { return _boxVolume; }
            set
            {
                if (_boxVolume != value)
                {
                    _boxVolume = value;
                }
                Notify("boxVolume");
            }
        }


        public double boxWide
        {
            get { return _boxWide; }
            set
            {
                if (_boxWide != value)
                {
                    _boxWide = value;
                }
                Notify("boxWide");
            }
        }


        public double boxDepth
        {
            get { return _boxDepth; }
            set
            {
                if (_boxDepth != value)
                {
                    _boxDepth = value;
                }
                Notify("boxDepth");
            }
        }


        public double boxHeight
        {
            get { return _boxHeight; }
            set
            {
                if (_boxHeight != value)
                {
                    _boxHeight = value;
                }
                Notify("boxHeight");
            }
        }

        private void CalculateAll()
        {
            CheckDim();
            CalculateMaterial();
            double height = boxHeight / 100D;
            double wide = boxWide / 100D;
            double depth = boxDepth / 100D;

            boxBuoyancy = ((height * wide * depth) * 1000D) - boxWeight;
            boxVolume = height * wide * depth;
        }

        private void CheckDim()
        {
            if (boxHeight > 0 && boxWide > 0 && boxDepth > 0)
            {
                double temp = (materialDim * 2D) / 1000D;
                double height = boxHeight / 100D;
                double wide = boxWide / 100D;
                double depth = boxDepth / 100D;

                if (temp >= height || temp >= wide || temp >= depth)
                {
                    warningDim = "Visible";
                }
                else
                {
                    warningDim = "Hidden";
                }
            }
        }

        private void CalculateMaterial()
        {
            if (boxHeight > 0 && boxWide > 0 && boxDepth > 0 && materialDim > 0)
            {
                double height = boxHeight / 100D;
                double wide = boxWide / 100D;
                double depth = boxDepth / 100D;

                double matWeight = boxMaterial.materialWeight * 1000D;
                double matDim = (materialDim / 1000D) * 2D;

                double tempMaterialWeight1 = 0;
                double tempMaterialWeight2 = 0;

                tempMaterialWeight1 = (height * wide * depth) * matWeight;
                tempMaterialWeight2 = ((height - matDim) * (wide - matDim) * (depth - matDim)) * matWeight;

                boxInnerVolumen = (height - matDim) * (wide - matDim) * (depth - matDim);

                boxWeight = (tempMaterialWeight1 - tempMaterialWeight2);
            }
        }
    }
}
