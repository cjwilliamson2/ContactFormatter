namespace ContactFormatter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string emailAddress = txtEmailAddress.Text.Trim();
            string username = "";
            string domain = "";
            string[] strings;

            if(!emailAddress.Contains("@"))
            {
                MessageBox.Show("Must be a valid email address", "Error");
            } else
            {
                strings = emailAddress.Split('@');

                MessageBox.Show("Username: " + strings[0] +
                    "\n" + "Domain: " + strings[1], "Parse Email Address");
            }

            /*
            int index = emailAddress.IndexOf("@");

            if (index == -1)
            {
                MessageBox.Show("Must be a valid email address", "Error");
            } else
            {
                username = emailAddress.Substring(0, index);
                domain = emailAddress.Substring(index + 1);

                MessageBox.Show("Username: " + username +
                    "\n" + "Domain: " + domain, "Parse Email Address");
            }
            */
        }
    }
}