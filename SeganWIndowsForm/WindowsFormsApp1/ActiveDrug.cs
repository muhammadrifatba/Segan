using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ActiveDrug
    {
        private int _activeDrugID;
        private int _userID;
        private int _drugID;
        private DateTime _activeTime;
        private Boolean _status;

        public int ActiveDrugID
        {
            get { return _activeDrugID; }
        }

        public DateTime ActiveTime
        {
            get { return _activeTime; }
            set { _activeTime = value; }
        }

        public Boolean Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public void updateStatus (int activeDrugID)
        {

        }

        public void addActiveDrug()
        {

        }

        public void updateActiveDrug(int activeDrugID)
        {

        }

        public void deleteActiveDrug(int activeDrug)
        {

        }

        public void readActiveDrug(int userID)
        {

        }
    }
}
