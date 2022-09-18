using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Drugs
    {
        private int _drugID;
        private string _drugName;
        private string _drugType;
        private int _dosage;
        private int _interval;

        public int DrugID
        {
            get { return _drugID; }
        }

        public string DrugName
        {
            get { return _drugName; }
            set { _drugName = value; }
        }

        public string DrugType
        {
            get { return _drugType; }
            set { _drugType = value; }
        }

        public int Dosage
        {
            get { return _dosage; }
            set { _dosage = value; }
        }

        public int Interval
        {
            get { return _interval; }
            set { _interval = value; }
        }


        public void getDrugInfo(int drugID)
        {
             
        }

        public void updateDrug(int drugID)
        {

        }

        public void deleteDrug(int drugID)
        {

        }

        public void createDrug()
        {

        }
    }
}
