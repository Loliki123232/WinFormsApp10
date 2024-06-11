using System.Security.Policy;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool fg = false;
        private List<int> nums = new List<int>() { 1, 3, 4, 5, 6, 7, 9 };
        private void Form1_Load(object sender, EventArgs e)
        {
            int count = 0;
            for(; fg == false || count==100;)
            {

                addElement();
                count++;
            }
            MessageBox.Show(count.ToString());
            int rnd = new Random().Next(10);
            MessageBox.Show(string.Join(", ", nums));
        }
        private void addElement()
        {
            fg= true;   
            int rnd = new Random().Next(10);

            for (int i = 0; i < nums.Count; i++)
            {
                if (rnd == nums[i])
                {

                    fg = false;
                }
            }
            if (fg != false)
            {
                nums.Add(rnd);
               
            }
        }

    }

}
        
        
        
    




