namespace Repository
{
    public class ClassMaterial : ClassNotify
    {
        private string _materialName;
        private double _materialWeight;

        public ClassMaterial()
        {
            materialName = "";
            materialWeight = 0D;
        }

        public ClassMaterial(ClassMaterial inMaterial)
        {
            materialName = inMaterial.materialName;
            materialWeight = inMaterial.materialWeight;
        }

        public ClassMaterial(string inName, double inWeight)
        {
            materialName = inName;
            materialWeight = inWeight;
        }


        public double materialWeight
        {
            get { return _materialWeight; }
            set
            {
                if (_materialWeight != value)
                {
                    _materialWeight = value;
                }
                Notify("materialWeight");
            }
        }


        public string materialName
        {
            get { return _materialName; }
            set
            {
                if (_materialName != value)
                {
                    _materialName = value;
                }
                Notify("materialName");
            }
        }

        public string matShow
        {
            get { return $"{_materialName} - {_materialWeight} kg. pr. dm3"; }
        }

        public override string ToString()
        {
            return $"{_materialName} - {_materialWeight} kg. pr. dm3";
        }
    }
}
