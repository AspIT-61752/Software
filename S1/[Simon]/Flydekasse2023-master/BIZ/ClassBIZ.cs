using Repository;
using System.Collections.Generic;


namespace BIZ
{
    public class ClassBIZ : ClassNotify
    {

        public ClassBIZ()
        {
            listMaterial = new List<ClassMaterial>();
            box = new ClassBox();
            tube = new ClassTube();
            matDim = "0";
            selectedMaterial = new ClassMaterial();
            SetUpMaterialList();
        }

        private List<ClassMaterial> _listMaterial;
        private ClassBox _box;
        private string _matDim;
        private ClassMaterial _selectedMaterial;
        private ClassTube _tube;

        public ClassTube tube
        {
            get { return _tube; }
            set
            {
                if (_tube != value)
                {
                    _tube = value;
                }
                Notify("tube");
            }
        }


        public ClassMaterial selectedMaterial
        {
            get { return _selectedMaterial; }
            set
            {
                if (_selectedMaterial != value)
                {
                    _selectedMaterial = value;
                    box.boxMaterial = value;
                    tube.tubeMaterial = value;
                }


            }
        }


        public string matDim
        {
            get { return _matDim; }
            set
            {
                if (double.TryParse(value, out double x))
                {
                    _matDim = value;
                    box.materialDimStr = value;
                    tube.tubeMaterialDim = x;
                }
            }
        }


        public ClassBox box
        {
            get { return _box; }
            set { _box = value; }
        }



        public List<ClassMaterial> listMaterial
        {
            get { return _listMaterial; }
            set
            {
                if (_listMaterial != value)
                {
                    _listMaterial = value;
                }
                Notify("listMaterial");
            }
        }



        private void SetUpMaterialList()
        {
            listMaterial.Add(new ClassMaterial("Træ", 0.987));
            listMaterial.Add(new ClassMaterial("Plast", 3.378));
            listMaterial.Add(new ClassMaterial("Jern", 25.477));
            listMaterial.Add(new ClassMaterial("Glas", 14.251));
        }

    }
}
