using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tAsk
{
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "סוג: בוחן\nקורס: מעגלים דיגיטליים ספרתיים\nמתי?: 05/12/2013 08:30\n\nהערות:\nהבוחן אמו" +
    "ר להיות קשה מאד ואני\nממליץ לעצמי לסדר כמה ימים שקטים\nללמוד אליו, בנוסף שמעתי שחל" +
    "ק מהשאלות נמצאות ב....\n";
        }
    }
}
