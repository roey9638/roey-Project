using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_WindowsForm
{
    public class Person
    {

        public string name;

        #region Events HM Qst 01
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnNameEnter();

            }
        }

        protected void OnNameEnter()
        {
            if (name.Length > 10)
            {
                if (delegateLongName != null)
                {
                    delegateLongName();
                }
            }
        }

        public event DelegateLongName delegateLongName;

        public override string ToString()
        {
            return string.Format(Name);
        }

        #endregion

        #region Events HM Qst 02

        public event DelegateLuckyNum delegateLuckyNum;

        public int num;

        public int Num
        {
            get
            { 
                return num;
            }
            set 
            {
                num = value;
                GetNumQst02();
            }
        }


        public void GetNumQst02()
        {          
            if(num == 999)
            {
                if(delegateLuckyNum != null)
                {
                    delegateLuckyNum();
                }
            }
        }

        #endregion

        #region HM Qst 03
        //Answer is in the Student Class in the Event Project.
        #endregion
    }

    public class client : Person
    {

    }


}





