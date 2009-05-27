using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowchartToASCII
{
    [Serializable]
    public class Model
        //:List<BaseType>
    {
        public List<BaseType> bList = new List<BaseType>();

        public List<BaseType> GetList
        {
            get { return bList; }
            set { bList = value; }
        }

        public void Add(BaseType b)
        {
            bList.Add(b);
        }

        public void Remove(BaseType b)
        {
            bList.Remove(b);
        }
    }
}
