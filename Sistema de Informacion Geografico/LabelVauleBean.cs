using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Informacion_Geografico
{
    public class LabelVauleBean
    {
        private int id;
        private string label;
        private Boolean selected;

        public LabelVauleBean()
        {
        }

        public LabelVauleBean(int id, string label, Boolean selected)
        {
            this.Id = id;
            this.Label = label;
            this.Selected = selected;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Label
        {
            get { return label; }
            set { label = value; }
        }

        public Boolean Selected
        {
            get { return selected; }
            set { selected = value; }
        }
    }
}
